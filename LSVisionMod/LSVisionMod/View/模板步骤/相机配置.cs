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
using System.IO;
using LSVisionMod.Common.模板步骤;
using LSVisionMod.Model;
using System.Threading;
using System.Diagnostics;

namespace LSVisionMod.View.模板步骤
{
    public partial class 相机配置 : UserControl
    {
        string camName;
        List<string> CamNames;
        string localImagePath;
        string[] ImagesPath;
        float exposureTime = -1;
        /// <summary>
        /// 循环遍历本地关联图片使用
        /// </summary>
        int count = 0;
        HalconFun halconFun = new HalconFun();
        public 相机配置()
        {
            InitializeComponent();
           
        }

        private void 相机配置_Load(object sender, EventArgs e)
        {
            //关联Halcon窗口
            halconFun.SetWindowHandle(pictureBox1);
            //获取连接的相机名，供选择
            CamStep.GetCameraNameList(out CamNames);
            cmb相机列表.DataSource = CamNames;
            if (CamNames.Count == 0)
            {
                cmb相机列表.Text = "noCam";
                camName = "noCam";
                lab选择相机提示.Text = "无相机连接";
                lab相机曝光值提示.Text = "";
                InitImagesPaths();
            }
            else
            {
                lab选择相机提示.Text = "";
                lab相机曝光值提示.Text = "";
            }
            CamStep.ReconnectCamEvent += CamStep_ReconnectCamEvent;
        }

        private void cmb相机列表_SelectedIndexChanged(object sender, EventArgs e)
        {
            camName = cmb相机列表.SelectedItem.ToString();
            //获取相机当前曝光值
            CamStep.GetCameraExposureTime(camName, out float exposureTime, out _, out _);
            txt相机曝光值.Text = exposureTime.ToString();
            InitImagesPaths();
        }


        private void cmb相机列表_TextChanged(object sender, EventArgs e)
        {
            camName = cmb相机列表.Text;
            var cam = MyRun.model.cams.Find(x => x.CamName == camName);
            if (cam != null)
            {
                lab选择相机提示.Text = "相机" + camName + "已存在";
            }
            
        }

        private void InitImagesPaths()
        {
            //获取该相机关联图片的路径，如无此路径则创建文件夹用于保存相机关联图片
            localImagePath = MyRun.appPath + "\\model\\" + MyRun.model.modelName + "\\" + camName;
            txt样本图片保存路径.Text = localImagePath;
            ImagesPath = GetImagesPath(localImagePath);
            
            //获取关联图片数量
            lab关联图片数量.Text = "关联图片数量:" + ImagesPath.Length.ToString();
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

        private void txt相机曝光值_TextChanged(object sender, EventArgs e)
        {
            
            //设置相机曝光值
            if (float.TryParse(txt相机曝光值.Text, out exposureTime))
            {
                if (!CamNames.Contains(camName))
                {
                    return;
                }
                float lower, upper;
                CamStep.GetCameraExposureTime(camName, out _, out lower, out upper);
                if (exposureTime < lower || exposureTime > upper)
                {
                    lab相机曝光值提示.Text = string.Format("相机曝光值范围{0}至{1}", lower, upper);
                }
                else
                {
                    lab相机曝光值提示.Text = "";
                    if (camName != null)
                        CamStep.SetCameraExposureTime(camName, exposureTime);
                }
            }
            else
            {
                lab相机曝光值提示.Text = "请输入相机曝光值";
                txt相机曝光值.Text = "";
            }
        }

        private void btn添加本地图片关联相机_Click(object sender, EventArgs e)
        {
            InitImagesPaths();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG文件|*.jpg*|BMP文件|*.bmp*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = true;


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                {
                    string imagePath = openFileDialog.FileNames[i];
                    File.Copy(imagePath, localImagePath + "\\" + openFileDialog.SafeFileNames[i], true);
                }
            }
            InitImagesPaths();
        }

        private void btn添加当前图片关联相机_Click(object sender, EventArgs e)
        {
            InitImagesPaths();
            halconFun.WriteImage(localImagePath, DateTime.Now.ToString("HH-mm-ss") + ".jpg");
            ImagesPath = GetImagesPath(localImagePath);
            lab关联图片数量.Text = ImagesPath.Length.ToString();
            InitImagesPaths();
        }

        private void btn获取图片_Click(object sender, EventArgs e)
        {
            if (MyRun.TriggerCamera(camName, out HalconDotNet.HObject ho_Image))
            {
                halconFun.ShowImage(ho_Image);
                ho_Image.Dispose();
            }
            else
            {
                MessageBox.Show(MyRun.StrErrorMsg);
                btn刷新相机连接.Visible = true;
            }
        }

        private void btn保存设置_Click(object sender, EventArgs e)
        {
            if(CamStep.AddCam(camName, exposureTime, ref MyRun.model))
            {
                MyRun.CreateModelWindow.AddCamNode(camName);
            }
            MyRun.nowModel.CamName = camName;
            MyRun.CreateModelWindow.SelectChooseModelTypeWindow();
        }

        private void btn返回_Click(object sender, EventArgs e)
        {
            MyRun.CreateModelWindow.SelectChooseModelTypeWindow();
        }

        public bool Init(string camName)
        {
            CamStep.GetCameraNameList(out CamNames);
            
            if (camName.Equals("noCam"))
            {
                cmb相机列表.Text = "noCam";
                MyRun.nowModel.CamName = camName;
                return true;
            }
            if (CamNames.Contains(camName))
            {
                cmb相机列表.SelectedItem = camName;
                MyRun.nowModel.CamName = camName;
                return true;
            }
            else
            {
                lab选择相机提示.Text = "相机" + camName + "未连接";
                btn刷新相机连接.Visible = true;
                return false;
            }
            
        }

        private void btn显示样本图片_Click(object sender, EventArgs e)
        {
            InitImagesPaths();
            if (ImagesPath.Length > 0)
            {
                count %= ImagesPath.Length;
                string ImagePath = ImagesPath[count++];
                halconFun.ReadImage(ImagePath);
                halconFun.ShowImage();
                count %= ImagesPath.Length;
            }
            
        }

        private void btn刷新相机连接_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                CamStep.ReconnectCam();

            })
            { IsBackground = true }.Start();
            Spinner等待重连.Visible = true;
        }

        private void CamStep_ReconnectCamEvent(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
           {
               Spinner等待重连.Visible = false;
                //获取连接的相机名，供选择
                CamStep.GetCameraNameList(out CamNames);
               cmb相机列表.DataSource = CamNames;
               if (CamNames.Count == 0)
               {
                   cmb相机列表.Text = "noCam";
                   camName = "noCam";
                   lab选择相机提示.Text = "无相机连接";
                   InitImagesPaths();
                   btn刷新相机连接.Visible = true;
               }
               else
               {
                   lab选择相机提示.Text = "";
                   
               }
           }));
            
        }

        private void chk实时拍照显示_CheckedChanged(object sender, EventArgs e)
        {
            if (chk实时拍照显示.Checked)
            {
                new Thread(() =>
                {
                    while (chk实时拍照显示.Checked)
                    {
                        if (MyRun.TriggerCamera(camName, out HalconDotNet.HObject ho_Image))
                        {
                            halconFun.ShowImage(ho_Image);
                            ho_Image.Dispose();
                        }
                        else
                        {
                            MessageBox.Show(MyRun.StrErrorMsg);
                            break;
                        }
                    }
                })
                { IsBackground = true }.Start();
                
            }
        }

        private void txt样本图片保存路径_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start(txt样本图片保存路径.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(cmb相机列表.Text == "" || cmb相机列表.Text == "noCam")
            {
                btn获取相机图片.Enabled = false;
            }
            else
            {
                btn获取相机图片.Enabled = true;
            }

            if(cmb相机列表.Text == "")
            {
                btn保存设置.Enabled = false;
            }
            else
            {
                btn保存设置.Enabled = true;
            }
            if(ImagesPath.Length == 0)
            {
                btn显示样本图片.Enabled = false;
            }
            else
            {
                btn显示样本图片.Enabled = true;
            }

        }
        private void 相机配置_Enter(object sender, EventArgs e)
        {
            InitImagesPaths();
            timer1.Start();
        }

        private void 相机配置_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }

}
