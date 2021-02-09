using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LSVisionMod.Common;
using LSVisionMod.Common.模板步骤;
using LSVisionMod.View.检测功能;
using System.IO;
using LSVisionMod.Model;

namespace LSVisionMod.View.模板步骤
{
    public partial class 检测项添加 : UserControl
    {
        I检测参数设置 ParameterSetControl;
        string camName;
        string localImagePath;
        string[] ImagesPath;
        int count = 0;
        HalconFun halconFun = new HalconFun();
        string matchName;
        MatchingFun matchingfun;
        public 检测项添加()
        {
            InitializeComponent();
            
        }

        private void 检测项添加_Load(object sender, EventArgs e)
        {
            //关联Halcon窗口
            halconFun.SetWindowHandle(pictureBox1);
            halconFun.SetLineWidth(3);
            //获取可用的检测功能
            TestItemStep.GetTestItemTypeList(out List<string> testItemTypes);
            cmb选择检测项.DataSource = testItemTypes;

        }

        private void RelateCam()
        {
            if (MyRun.nowModel.CamName is null)
            {
                return;
            }
            else
            {
                //获取该相机关联图片的路径，如无此路径则创建文件夹用于保存相机关联图片
                localImagePath = MyRun.appPath + "\\model\\" + MyRun.model.modelName + "\\" + MyRun.nowModel.CamName;
                ImagesPath = GetImagesPath(localImagePath);
                count = 0;
                //获取关联图片数量
                lab关联图片数量.Text = "关联图片数量:" + ImagesPath.Length.ToString();
                lab当前相机.Text = "当前相机:" + MyRun.nowModel.CamName;
                camName = MyRun.nowModel.CamName;
            }
        }

        private void RelateMatch()
        {
            if(MyRun.nowModel.MatchName is null)
            {
                return;
            }
            if (MyRun.nowModel.MatchName.Equals("无模板定位"))
            {
                lab当前匹配模板.Text = "当前匹配模板:" + MyRun.nowModel.MatchName;
                matchName = MyRun.nowModel.MatchName;
            }
            else if(matchName != MyRun.nowModel.MatchName)
            {
                Matching nowMatching = MyRun.model.matchings.Find(x => x.Name == MyRun.nowModel.MatchName);
                matchingfun = MyRun.GetMatchingFun(nowMatching.Type);
                matchingfun.Read(MyRun.appPath + "\\model\\" + MyRun.model.modelName, nowMatching);
                
                lab当前匹配模板.Text = "当前匹配模板:" + MyRun.nowModel.MatchName;
                matchName = MyRun.nowModel.MatchName;
            }
        }

        public static string[] GetImagesPath(string path)
        {
            Directory.CreateDirectory(path);
            string[] jpgPaths = Directory.GetFiles(path, "*.jpg");
            string[] bmpPaths = Directory.GetFiles(path, "*.bmp");
            string[] imagePaths = new string[jpgPaths.Length + bmpPaths.Length];

            jpgPaths.CopyTo(imagePaths, 0);
            bmpPaths.CopyTo(imagePaths, jpgPaths.Length);
            return imagePaths;
        }
        private void cmb选择检测项_SelectedIndexChanged(object sender, EventArgs e)
        {
            string testItemType = cmb选择检测项.Text;
            TestItemStep.GetParameterSettingControl(testItemType, out ParameterSetControl);
            pnl参数设置.Controls.Clear();
            pnl参数设置.Controls.Add((Control)ParameterSetControl);
            ParameterSetControl.SetHalconWindow(halconFun.m_hvWindowHandle);
        }

        private void btn获取图片_Click(object sender, EventArgs e)
        {
            string ImagePath = ImagesPath[count++];
            halconFun.ReadImage(ImagePath);
            if (!matchName.Equals("无模板定位"))
            {
                matchingfun.Find(halconFun.m_hoImage, out halconFun.m_hoImage);
            }
            halconFun.ShowImage();
            ParameterSetControl.SetHalconImage(halconFun.m_hoImage);
            count %= ImagesPath.Length;
        }

       



        private void btn测试_Click(object sender, EventArgs e)
        {
            string outMessage;
            List<Parameter> parameters = ParameterSetControl.initParameterList();
            ParameterSetControl.Save(ref parameters);
            if (!ParameterSetControl.HaveSet())
            {
                return;
            }
            ParameterSetControl.Find(halconFun.m_hoImage, parameters, out outMessage);
            halconFun.ShowImage();
            halconFun.SetRegionFillMode(HalconFun.RegionFillMode.Margin);
            
            if (ParameterSetControl.isOK)
            {
                halconFun.ShowRegion(ParameterSetControl.hROI, Color.Green);
            }else
            {
                halconFun.ShowRegion(ParameterSetControl.hROI, Color.Red);
            }
            
            txt检测结果.Text = outMessage;
        }

        private void btn保存设置_Click(object sender, EventArgs e)
        {
            if(txt检测项名称.Text == "")
            {
                MessageBox.Show("请输入检测项名称");
                return;
            }

            if(!ParameterSetControl.HaveSet())
            {
                return;
            }

            string testItemName = txt检测项名称.Text;
            string testItemType = cmb选择检测项.Text;
            TestItem testItem = MyRun.model.testItems.Find(x => x.Name == testItemName);
            if (testItem != null)
            {
                if (MessageBox.Show("检测项" + testItemName + "已存在\n是否覆盖", "存在同名检测项", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
            }
            List<Parameter> parameters = ParameterSetControl.initParameterList();
            ParameterSetControl.Save(ref parameters);
            ParameterSetControl.WriteSample(MyRun.appPath + "\\model\\" + MyRun.model.modelName, testItemName + ".bmp");
            if (TestItemStep.AddTestItem(testItemName, testItemType, parameters, MyRun.nowModel, ref MyRun.model))
            {
                MyRun.CreateModelWindow.AddTestItemNode(testItemName);
            }
            MyRun.nowModel.TestItemName = testItemName;
            MyRun.CreateModelWindow.SelectChooseModelTypeWindow();
        }

        private void btn返回_Click(object sender, EventArgs e)
        {
            MyRun.CreateModelWindow.SelectChooseModelTypeWindow();
        }

        public void Init(string itemName)
        {
            TestItem testItem = MyRun.model.testItems.Find(x => x.Name == itemName);
            
            TestItemStep.GetParameterSettingControl(testItem.Type, out ParameterSetControl);
            txt检测项名称.Text = itemName;
            pnl参数设置.Controls.Clear();
            pnl参数设置.Controls.Add((Control)ParameterSetControl);
            ParameterSetControl.SetHalconWindow(halconFun.m_hvWindowHandle);
            ParameterSetControl.Initial(testItem.Parameters);
            MyRun.nowModel.CamName = testItem.CamName;
            MyRun.nowModel.MatchName = testItem.MatchName;
            RelateCam();
            RelateMatch();
        }

        private void btn获取相机图片_Click(object sender, EventArgs e)
        {
            MyRun.TriggerCamera(MyRun.nowModel.CamName, out HalconDotNet.HObject ho_Image);

            if (ho_Image is null)
            {
                MessageBox.Show("图片获取失败");
                return;
            }
            if (!matchName.Equals("无模板定位"))
            {
                matchingfun.Find(ho_Image, out halconFun.m_hoImage);
            }
            halconFun.ShowImage(ho_Image);
            ParameterSetControl.SetHalconImage(ho_Image);
            ho_Image.Dispose();
        }

        private void txt检测项名称_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txt检测项名称.Text == "")
            {
                grp图片获取.Enabled = false;
                grp检测项参数配置.Enabled = false;
                grp测试结果.Enabled = false;
                btn测试.Enabled = false;
                btn保存设置.Enabled = false;
            }
            else
            {
                grp图片获取.Enabled = true;
                if (halconFun.m_hoImage is null)
                {
                    grp检测项参数配置.Enabled = false;
                }
                else
                {
                    grp检测项参数配置.Enabled = true;
                    
                }
                if (!ParameterSetControl.HaveSet())
                {
                    grp测试结果.Enabled = false;
                    btn保存设置.Enabled = false;
                }
                else
                {
                    grp测试结果.Enabled = true;
                    btn测试.Enabled = true;
                    btn保存设置.Enabled = true;
                }
            }
        }

        private void 检测项添加_Enter(object sender, EventArgs e)
        {
            RelateCam();
            RelateMatch();
            timer1.Start();
        }
        private void 检测项添加_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        
    }
}
