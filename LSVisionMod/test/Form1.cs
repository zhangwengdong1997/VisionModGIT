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
        VisionMod visionMod = new VisionMod();
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

            VisionMod.GetProductModelList(out List<ProductModel> productModels);
            for (int i = 0; i < productModels.Count; i++)
                comboBox1.Items.Add(productModels[i].modelName);

            VisionMod.ErrorEvent += VisionMod_ErrorEvent;

        }

        private void VisionMod_ErrorEvent(object sender, string e)
        {
            //MessageBox.Show(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            visionMod.PrepareModel("1234");
            visionMod.TriggerDetection();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            visionMod.WaitDetectionResult(out List<OutResult> outResults,10000);
            pictureBox1.Image = outResults[0].EffectImage.BmpImage;
            pictureBox2.Image = outResults[1].EffectImage.BmpImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string modelName = comboBox1.Text;
            VisionMod.EditProductModel(modelName);
        }
    }
}
