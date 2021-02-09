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
using HalconDotNet;

namespace LSVisionMod.View.模板步骤
{
    public partial class 相机拼接 : UserControl
    {
        HalconFun halconFun = new HalconFun();
        List<string> camNames = new List<string>();
        public 相机拼接()
        {
            InitializeComponent();
        }

        private void 相机拼接_Load(object sender, EventArgs e)
        {
            //关联Halcon窗口
            halconFun.SetWindowHandle(pictureBox1);

            foreach(var cam in MyRun.model.cams)
            {
                camNames.Add(cam.CamName);
            }
            cmb相机列表1.DataSource = camNames;
            cmb相机列表2.DataSource = camNames;
        }

        private void btn创建模板_Click(object sender, EventArgs e)
        {
            MyRun.TriggerCamera(cmb相机列表1.Text, out HObject ho_Image1);
            MyRun.TriggerCamera(cmb相机列表2.Text, out HObject ho_Image2);
            HTuple SigmaGrad = double.Parse(txt高斯平滑值.Text);
            HTuple ThreshInhom = double.Parse(txt区域分割.Text);
            HTuple ThreshShape = double.Parse(txt点分割.Text);
            HTuple MatchThreshold = double.Parse(txt匹配灰度差.Text);
            SplicingStep.SplicingImage(ho_Image1, ho_Image2, SigmaGrad, ThreshInhom,
            ThreshShape, MatchThreshold, out HObject ho_outImage, out HTuple hv_HomMat2D, out HTuple hv_Kappa);

            halconFun.ShowImage(ho_outImage);

            //SplicingStep.CreateSplicingModel(ho_Image1, ho_Image2, SigmaGrad, ThreshInhom,
            //ThreshShape, MatchThreshold, out HalconDotNet.HTuple hv_HomMat2D, out HalconDotNet.HTuple hv_Kappa);

        }

        private void btn返回_Click(object sender, EventArgs e)
        {
            MyRun.CreateModelWindow.SelectChooseModelTypeWindow();
        }

        private void btn保存设置_Click(object sender, EventArgs e)
        {

        }
    }
}
