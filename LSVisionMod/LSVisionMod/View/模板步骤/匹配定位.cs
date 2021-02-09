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
using System.IO;
using LSVisionMod.Model;

namespace LSVisionMod.View.模板步骤
{
    public partial class 匹配定位 : UserControl
    {
        List<string> matchTypes;
        string camName;
        string localImagePath;
        string[] ImagesPath;
        /// <summary>
        /// 循环遍历本地关联图片使用
        /// </summary>
        int count = 0;

        HalconFun halconFun = new HalconFun();

        MatchingFun matchingfun;

        public 匹配定位()
        {
            InitializeComponent();
        }

        private void 匹配定位_Load(object sender, EventArgs e)
        {
            //关联Halcon窗口
            halconFun.SetWindowHandle(pictureBox1);
            halconFun.SetLineWidth(3);
            halconFun.InitHistoryRegions();
            MatchingStep.GetMatchingTypeList(out matchTypes);
            cmb定位模板类型.DataSource = matchTypes;
        }

        private void btn新建区域_Click(object sender, EventArgs e)
        {
            ButtonEnabled(this.Controls, false);
            halconFun.AddHistoryRegions();
            halconFun.SetRegionColor(Color.Green);
            this.Focus();
            if (rdo矩形区域.Checked)
                halconFun.DrawRegion(halconFun.DrawRectangle1, HalconFun.Operation.New);
            if (rdo圆形区域.Checked)
                halconFun.DrawRegion(halconFun.DrawCircle, HalconFun.Operation.New);
            if (rdo多边形区域.Checked)
                halconFun.DrawRegion(halconFun.DrawPolygon, HalconFun.Operation.New);
            halconFun.HWindowRefresh(Color.Red, HalconFun.RegionFillMode.Margin);
            ButtonEnabled(this.Controls, true);
        }
        private void ButtonEnabled(ControlCollection collection, bool enabled)
        {
            foreach (Control control in collection)
            {
                if (control.GetType().Equals(typeof(Button)))
                {
                    control.Enabled = enabled;
                }
                if(control.Controls.Count > 0)
                {
                    ButtonEnabled(control.Controls, enabled);
                }
            }

        }

        private void btn添加区域_Click(object sender, EventArgs e)
        {
            ButtonEnabled(this.Controls, false);
            halconFun.AddHistoryRegions();
            halconFun.SetRegionColor(Color.Green);
            this.Focus();
            if (rdo矩形区域.Checked)
                halconFun.DrawRegion(halconFun.DrawRectangle1, HalconFun.Operation.Add);
            if (rdo圆形区域.Checked)
                halconFun.DrawRegion(halconFun.DrawCircle, HalconFun.Operation.Add);
            if (rdo多边形区域.Checked)
                halconFun.DrawRegion(halconFun.DrawPolygon, HalconFun.Operation.Add);
            halconFun.HWindowRefresh(Color.Red, HalconFun.RegionFillMode.Margin);
            ButtonEnabled(this.Controls, true);
        }

        private void btn减少区域_Click(object sender, EventArgs e)
        {
            ButtonEnabled(this.Controls, false);
            halconFun.AddHistoryRegions();
            halconFun.SetRegionColor(Color.Green);
            this.Focus();
            if (rdo矩形区域.Checked)
                halconFun.DrawRegion(halconFun.DrawRectangle1, HalconFun.Operation.Cut);
            if (rdo圆形区域.Checked)
                halconFun.DrawRegion(halconFun.DrawCircle, HalconFun.Operation.Cut);
            if (rdo多边形区域.Checked)
                halconFun.DrawRegion(halconFun.DrawPolygon, HalconFun.Operation.Cut);
            halconFun.HWindowRefresh(Color.Red, HalconFun.RegionFillMode.Margin);
            ButtonEnabled(this.Controls, true);
        }

        private void btn撤销上一步_Click(object sender, EventArgs e)
        {
            halconFun.BreakHistoryRegion();
            halconFun.HWindowRefresh(Color.Red, HalconFun.RegionFillMode.Margin);
        }

        private void btn创建模板_Click(object sender, EventArgs e)
        {
            matchingfun = MyRun.GetMatchingFun(cmb定位模板类型.Text);
            if (halconFun.m_hoRegion == null)
            {
                MessageBox.Show("请先新建区域");
                return;
            }
            matchingfun.Create(halconFun.m_hoImage, halconFun.m_hoRegion);
            halconFun.ShowRegion(matchingfun.outContour, Color.Red);
        }

        private void btn测试模板_Click(object sender, EventArgs e)
        {
            if (matchingfun is null)
            {
                MessageBox.Show("请创建定位模板");
                return;
            }
            double score;
            matchingfun.Find(halconFun.m_hoImage, out halconFun.m_hoImage, out score);
            halconFun.HWindowRefresh(Color.Red, HalconFun.RegionFillMode.Margin);
            halconFun.ShowRegion(matchingfun.outContour, Color.Red);
            lab模板匹配率.Text = "模板匹配率:" + score.ToString("P3");
        }

        private void RelateCam()
        {
            if(MyRun.nowModel.CamName is null)
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

        public bool Init(string matchName)
        {
            Matching matching = MyRun.model.matchings.Find(x => x.Name == matchName);
            txt定位模板名称.Text = matchName;
            cmb定位模板类型.Text = matching.Type;
            matchingfun = MyRun.GetMatchingFun(matching.Type);

            matchingfun.Read(MyRun.appPath + "\\model\\" + MyRun.model.modelName, matching);

            MyRun.nowModel.CamName = matching.CamName;
            MyRun.nowModel.MatchName = matchName;
            RelateCam();
            return true;
        }

        private void btn保存设置_Click(object sender, EventArgs e)
        {
            if (txt定位模板名称.Text == "")
            {
                MessageBox.Show("请输入定位模板名称");
                return;
            }
            if(matchingfun is null)
            {
                MessageBox.Show("请创建定位模板");
                return;
            }
            string matchName = txt定位模板名称.Text;
            string matchType = cmb定位模板类型.Text;
            string camName = MyRun.nowModel.CamName;

            Matching matching = MyRun.model.matchings.Find(x => x.Name == matchName);
            if (matching != null)
            {
                if (MessageBox.Show("定位模板" + matchName + "已存在\n是否覆盖", "存在同名定位模板", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
            }
            matchingfun.Write(MyRun.appPath + "\\model\\" + MyRun.model.modelName, matchName);
            if (MatchingStep.AddMatching(matchName, matchType, camName, ref MyRun.model))
            {
                MyRun.CreateModelWindow.AddMatchingNode(matchName);
            }
            MyRun.nowModel.MatchName = matchName;
            MyRun.CreateModelWindow.SelectChooseModelTypeWindow();
        }



        private void btn返回_Click(object sender, EventArgs e)
        {
            MyRun.CreateModelWindow.SelectChooseModelTypeWindow();
        }

        private void btn获取相机图片_Click(object sender, EventArgs e)
        {
            if (MyRun.TriggerCamera(MyRun.nowModel.CamName, out HalconDotNet.HObject ho_Image))
            {
                halconFun.ShowImage(ho_Image);
                ho_Image.Dispose();
                if (matchingfun.inRegion != null)
                {
                    halconFun.SetRegion(matchingfun.inRegion);
                }
                halconFun.SetRegionFillMode(HalconFun.RegionFillMode.Margin);
                halconFun.ShowRegion(Color.Red);
            }
            else
            {
                MessageBox.Show(MyRun.StrErrorMsg);
            }
        }

        private void btn获取本地图片_Click(object sender, EventArgs e)
        {
            if(ImagesPath.Length > 0)
            {
                string ImagePath = ImagesPath[count++];
                halconFun.ReadImage(ImagePath);
                halconFun.ShowImage();
                if (matchingfun != null && matchingfun.inRegion != null)
                {
                    halconFun.SetRegion(matchingfun.inRegion);
                }
                halconFun.SetRegionFillMode(HalconFun.RegionFillMode.Margin);
                halconFun.ShowRegion(Color.Red);
                count %= ImagesPath.Length;
            }
        }

        private void txt定位模板名称_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txt定位模板名称.Text == "")
            {
                grp图片获取.Enabled = false;
                grp选择定位区域.Enabled = false;
                grp选择定位区域.Enabled = false;
                grp定位模板创建.Enabled = false;
                grp定位模板测试.Enabled = false;
                btn保存设置.Enabled = false;
            }
            else
            {
                grp图片获取.Enabled = true;

                if (halconFun.m_hoImage is null)
                {
                    grp选择定位区域.Enabled = false;
                }
                else
                {
                    grp选择定位区域.Enabled = true;
                }
                if (halconFun.m_hoRegion is null)
                {
                    grp定位模板创建.Enabled = false;
                }
                else
                {
                    grp定位模板创建.Enabled = true;
                }


                if (matchingfun is null)
                {
                    grp定位模板测试.Enabled = false;
                    btn保存设置.Enabled = false;
                }
                else
                {
                    grp定位模板测试.Enabled = true;
                    btn保存设置.Enabled = true;
                }
            }
            
        }
        private void 匹配定位_Enter(object sender, EventArgs e)
        {
            RelateCam();
            timer1.Start();
        }
        private void 匹配定位_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
