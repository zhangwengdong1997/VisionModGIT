using CameraModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamTest1
{
    public partial class OneCamForm : Form
    {
        readonly CameraControl cameraControl = new CameraControl();
        string camName;
        public OneCamForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb相机品牌.Items.Add(CameraBrand.Basler);
            cmb相机品牌.Items.Add(CameraBrand.HikVision);
            lab当前相机.Parent = picMain;
            lab当前相机.Dock = DockStyle.Top;
            cameraControl.EventOnBitmap += new DelegateOnBitmap(OnGetBitmap);

            grp连接相机.Enabled = false;
            grp拍照.Enabled = false;
        }

        private void OnGetBitmap(object camName, Bitmap bitmap)
        {
            picMain.Image = bitmap;
        }

        private void Btn加载模块_Click(object sender, EventArgs e)
        {
            cameraControl.LoadCameraDLL((CameraBrand)cmb相机品牌.SelectedItem);
            cmb相机名.DataSource = cameraControl.CameraNames;
            grp连接相机.Enabled = true;
        }

        private void Btn连接相机_Click(object sender, EventArgs e)
        {
            camName = cmb相机名.Text;

            if (cameraControl.OpenOneCamera(camName))
            {
                lab当前相机.Text = "当前相机: " + camName;
                grp拍照.Enabled = true;
            }
        }

        private void Btn断开连接_Click(object sender, EventArgs e)
        {
            cameraControl.CloseOneCamera(camName);
            grp拍照.Enabled = false;
        }

        private void Btn触发一次_Click(object sender, EventArgs e)
        {
            cameraControl.SoftwareMode(camName);
            cameraControl.OpenOneStream(camName);
            cameraControl.TriggerSoftware(camName);
        }

        private void Btn实时拍照_Click(object sender, EventArgs e)
        {
            cameraControl.ContinuesMode(camName);
            cameraControl.OpenOneStream(camName);
        }

        private void OneCamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cameraControl.CloseAllCamera();
        }
    }
}
