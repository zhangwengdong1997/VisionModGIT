using LSVisionMod.Common;
using LSVisionMod.View.模板步骤;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSVisionMod.View
{
    public partial class 模板配置 : MetroForm
    {
        选择模板类型 ChooseModelTypeWindow = new 选择模板类型();
        相机配置 CamSetWindow = new 相机配置();
        匹配定位 MatchingWindow = new 匹配定位();
        检测项添加 TestItemAddWindow = new 检测项添加();

        相机拼接 SplicingWindow = new 相机拼接();
        public 模板配置()
        {
            InitializeComponent();
        }
        public void SetModelName(string ModelName)
        {
            ChooseModelTypeWindow.SetModelName(ModelName);
        }
        private void 新建模板_Load(object sender, EventArgs e)
        {
            MyRun.CreateModelWindow = this;
            MyRun.model = new Model.ProductModel();
            pnlMain.Controls.Add(ChooseModelTypeWindow);
            ChooseModelTypeWindow.Focus();
        }

        public void SelectCamSetWindow()
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(CamSetWindow);
            CamSetWindow.Focus();
        }

        public void SelectMatchingWindow()
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(MatchingWindow);
            MatchingWindow.Focus();
        }
        public void SelectTestItemAddWindow()
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(TestItemAddWindow);
            TestItemAddWindow.Focus();
        }

        public void SelectChooseModelTypeWindow()
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ChooseModelTypeWindow);
            ChooseModelTypeWindow.Focus();
        }

        public void SelectSplicingWindow()
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(SplicingWindow);
            SplicingWindow.Focus();
        }

        public void AddCamNode(string camName)
        {
            ChooseModelTypeWindow.AddCamNode(camName);
        }

        public void AddMatchingNode(string matchName)
        {
            ChooseModelTypeWindow.AddMatchingNode(matchName);
        }

        public void AddTestItemNode(string camName)
        {
            ChooseModelTypeWindow.AddTestItemNode(camName);
        }
        
        public void InitChooseModelTypeWindow(string modelName)
        {
            ChooseModelTypeWindow.Init(modelName);
            Text = "当前模板：" + modelName;
        }
        public void InitCamSetWindow(string camName)
        {
            CamSetWindow.Init(camName);
        }

        public void InitMatchingWindow(string matchName)
        {
            MatchingWindow.Init(matchName);
        }

        public void InitTestItemAddWindow(string itemName)
        {
            TestItemAddWindow.Init(itemName);
        }
    }
}
