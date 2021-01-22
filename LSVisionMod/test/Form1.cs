using LSVisionMod;
using LSVisionMod.Common;
using LSVisionMod.Model;
using LSVisionMod.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisionMod.AddProductModel();
            VisionMod.GetProductModelList(out List<ProductModel> productModels);
            int a = productModels.Count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VisionMod.Connect();

            Thread.Sleep(1000);
            //VisionMod.HardMode();
            VisionMod.GetProductModelList(out List<ProductModel> productModels);
            //VisionMod.GetAllTemplateImage("123", out List<Bitmap> templateImages);
            VisionMod.ErrorEvent += VisionMod_ErrorEvent;

        }

        private void VisionMod_ErrorEvent(object sender, string e)
        {
            //MessageBox.Show(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VisionMod.PrepareModel("1234");
            VisionMod.TriggerDetection();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VisionMod.WaitDetectionResult(out List<OutResult> outResults,10000);
            pictureBox1.Image = outResults[0].EffectImage.BmpImage;
            pictureBox2.Image = outResults[1].EffectImage.BmpImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VisionMod.EditProductModel("1234");
        }
    }
}
