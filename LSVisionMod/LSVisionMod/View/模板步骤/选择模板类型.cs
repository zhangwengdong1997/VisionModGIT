using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LSVisionMod.Common.模板步骤;
using LSVisionMod.Model;
using LSVisionMod.Common;
using System.Text.RegularExpressions;
using System.IO;

namespace LSVisionMod.View.模板步骤
{
    public partial class 选择模板类型 : UserControl
    {
        public 选择模板类型()
        {
            InitializeComponent();
        }

        private void 选择模板类型_Load(object sender, EventArgs e)
        {
            btn模板名确认.Enabled = false;
            grp常用检测流程.Enabled = false;
            grp模板检测流程.Enabled = false;
            grp编辑检测流程.Enabled = false;
            btn添加相机.Enabled = false;
            btn添加匹配定位.Enabled = false;
            btn添加检测项.Enabled = false;
            btn删除.Enabled = false;
            btn保存模板.Enabled = false;
            lab模板名称提示.Text = "请输入模板名称";

        }

        public void SetModelName(string ModelName)
        {
            txt模板名称.Text = ModelName;
            
        }

        private void txt模板名称_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(?!((^(con)$)|(^(prn)$)|(^(aux)$)|(^(nul)$)|(^(com)[1-9]$)|(^(lpt)[1-9]$))|^\\s+|.*\\s$)(^[^\\\\\\/\\:\\*\\?\\\&;\\\\|]{1,255}$)");
            if (!regex.IsMatch(txt模板名称.Text))
            {
                lab模板名称提示.Text = "模板名非法";
                btn模板名确认.Enabled = false;
            }
            else
            {
                lab模板名称提示.Text = "";
                btn模板名确认.Enabled = true;
            }
        }

        private void btn模板名确认_Click(object sender, EventArgs e)
        {
            string modelName = txt模板名称.Text;
            //这里判断是否已经有同名模板存在
            MyRun.GetProductModelNameList(out List<string> modelNameList);
            if (modelNameList.Contains(modelName))
            {
                lab模板名称提示.Text = "模板" + modelName + "已存在";
                
                Init(modelName);
            }
            else
            {
                Directory.CreateDirectory(MyRun.appPath + "\\model\\" + modelName);
            }
            MyRun.model.modelName = modelName;

            grp常用检测流程.Enabled = true;
            grp模板检测流程.Enabled = true;
            grp编辑检测流程.Enabled = true;
            btn添加相机.Enabled = true;
            btn保存模板.Enabled = true;

            
        }


        public bool Init(string modelName)
        {
            MyRun.model = MyRun.ReadModelJS(modelName);
            int Level0 = 0;
            foreach (var step in MyRun.model.ModelSteps.Steps)
            {

                TreeNode node = new TreeNode(step.Type + ":" + step.Name);
                switch (step.Level)
                {
                    case 0:
                        tvwSteps.Nodes.Add(node);
                        Level0 = step.Index;
                        break;
                    case 1:
                        tvwSteps.Nodes[step.ParentIndex].Nodes.Add(node);
                        break;
                    case 2:
                        tvwSteps.Nodes[Level0].Nodes[step.ParentIndex].Nodes.Add(node);
                        break;
                }
            }
            tvwSteps.ExpandAll();
            grp常用检测流程.Enabled = true;
            grp模板检测流程.Enabled = true;
            grp编辑检测流程.Enabled = true;
            btn添加相机.Enabled = true;
            btn保存模板.Enabled = true;
            lab模板名称提示.Text = "";
            return true;
        }

        #region 常用检测流程
        private void btn默认_Click(object sender, EventArgs e)
        {
            //TreeNode node = new TreeNode("添加相机");
            //tvwSteps.Nodes.Add(node);
            //tvwSteps.SelectedNode = node;
            //tvwSteps.SelectedNode.Nodes.Add("添加检测项");

        }
        #endregion


        #region 模板检测流程

        private void tvwSteps_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string NodeType = e.Node.Text.Split(':')[0];
            switch (NodeType)
            {
                case "相机":
                    btn添加匹配定位.Enabled = true;
                    btn添加检测项.Enabled = true;
                    btn添加相机.Enabled = true;
                    btn删除.Enabled = true;
                    break;
                case "匹配定位":
                    btn添加匹配定位.Enabled = false;
                    btn添加检测项.Enabled = true;
                    btn添加相机.Enabled = true;
                    btn删除.Enabled = true;
                    break;
                case "检测项":
                    btn添加匹配定位.Enabled = false;
                    btn添加检测项.Enabled = false;
                    btn添加相机.Enabled = true;
                    btn删除.Enabled = true;
                    break;
            }
        }

        private void tvwSteps_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string NodeType = e.Node.Text.Split(':')[0];
            switch (NodeType)
            {
                case "相机":
                    string camName = e.Node.Text.Substring(3);
                    
                    MyRun.CreateModelWindow.SelectCamSetWindow();
                    MyRun.CreateModelWindow.InitCamSetWindow(camName);
                    break;

                case "匹配定位":
                    string matchName = e.Node.Text.Substring(5);
                    
                    MyRun.CreateModelWindow.SelectMatchingWindow();
                    MyRun.CreateModelWindow.InitMatchingWindow(matchName);           
                    break;
                case "检测项":
                    string testItemName = e.Node.Text.Substring(4);
                    MyRun.CreateModelWindow.SelectTestItemAddWindow();
                    MyRun.CreateModelWindow.InitTestItemAddWindow(testItemName);                    
                    break;
            }
        }

        public void AddCamNode(string camName)
        {
            TreeNode node = new TreeNode("相机:" + camName);
            tvwSteps.Nodes.Add(node);
            tvwSteps.SelectedNode = node;
        }

        public void AddMatchingNode(string matchName)
        {
            TreeNode node = new TreeNode("匹配定位:" + matchName);
            tvwSteps.SelectedNode.Nodes.Add(node);
            tvwSteps.SelectedNode = node;
            tvwSteps.SelectedNode.ExpandAll();
        }

        public void AddTestItemNode(string itemName)
        {
            tvwSteps.SelectedNode.Nodes.Add("检测项:" + itemName);
            tvwSteps.SelectedNode.ExpandAll();
        }
        #endregion

        #region 编辑检测流程



        private void btn添加相机_Click(object sender, EventArgs e)
        {
            MyRun.CreateModelWindow.SelectCamSetWindow();
        }

        private void btn添加匹配定位_Click(object sender, EventArgs e)
        {
            if (tvwSteps.SelectedNode == null)
            {
                MessageBox.Show("请选择添加匹配定位的位置");
                return;
            }
            string NodeType = tvwSteps.SelectedNode.Text.Split(':')[0];

            switch (NodeType)
            {
                case "相机":
                    MyRun.nowModel.CamName = tvwSteps.SelectedNode.Text.Substring(3);
                    break;
                case "匹配定位":
                    tvwSteps.SelectedNode = tvwSteps.SelectedNode.Parent;
                    break;
                case "检测项":
                    MessageBox.Show("检测项步骤暂不支持添加匹配定位步骤");
                    return;
            }
            MyRun.CreateModelWindow.SelectMatchingWindow();
        }

        private void btn添加检测项_Click(object sender, EventArgs e)
        {
            if (tvwSteps.SelectedNode == null)
            {
                MessageBox.Show("请选择添加检测项的位置");
                return;
            }
            string NodeType = tvwSteps.SelectedNode.Text.Split(':')[0];

            switch (NodeType)
            {
                case "相机":
                    MyRun.nowModel.CamName = tvwSteps.SelectedNode.Text.Substring(3);
                    MyRun.nowModel.MatchName = "无模板定位";
                    break;
                case "匹配定位":
                    MyRun.nowModel.MatchName = tvwSteps.SelectedNode.Text.Substring(5);
                    MyRun.nowModel.CamName = tvwSteps.SelectedNode.Parent.Text.Substring(3);
                    break;
                case "检测项":
                    tvwSteps.SelectedNode = tvwSteps.SelectedNode.Parent;
                    break;
            }
            MyRun.CreateModelWindow.SelectTestItemAddWindow();

        }

        private void btn撤销_Click(object sender, EventArgs e)
        {
            if (tvwSteps.SelectedNode == null)
            {
                MessageBox.Show("请选择要删除的步骤");
                return;
            }
            string NodeType = tvwSteps.SelectedNode.Text.Split(':')[0];

            switch (NodeType)
            {
                case "相机":
                    string camName = tvwSteps.SelectedNode.Text.Substring(3);
                    MyRun.model.cams.Remove(MyRun.model.cams.Find(x => x.CamName == camName));
                    MyRun.model.matchings.Remove(MyRun.model.matchings.Find(x => x.CamName == camName));
                    MyRun.model.testItems.Remove(MyRun.model.testItems.Find(x => x.CamName == camName));
                    break;

                case "匹配定位":
                    string matchName = tvwSteps.SelectedNode.Text.Substring(5);
                    MyRun.model.matchings.Remove(MyRun.model.matchings.Find(x => x.Name == matchName));
                    MyRun.model.testItems.Remove(MyRun.model.testItems.Find(x => x.MatchName == matchName));
                    break;
                case "检测项":
                    string testItemName = tvwSteps.SelectedNode.Text.Substring(4);
                    MyRun.model.testItems.Remove(MyRun.model.testItems.Find(x => x.Name == testItemName));
                    break;
            }
            tvwSteps.SelectedNode.Remove();
        }

        #endregion


        private void SaveModelSteps(ref ModelSteps modelSteps, int parentIndex, TreeNodeCollection treeNodes)
        {
            foreach (TreeNode Node in treeNodes)
            {
                Step item = new Step()
                {
                    Index = Node.Index,
                    ParentIndex = parentIndex,
                    Type = Node.Text.Split(':')[0],
                    Name = Node.Text.Substring(Node.Text.IndexOf(':') + 1),
                    Level = Node.Level
                };
                modelSteps.Steps.Add(item);
                if (Node.Nodes.Count > 0)
                {
                    SaveModelSteps(ref modelSteps, Node.Index, Node.Nodes);
                }
            }
        }

        private void btn保存模板_Click(object sender, EventArgs e)
        {
            string modelName = txt模板名称.Text;
            ModelSteps modelSteps = new ModelSteps();

            SaveModelSteps(ref modelSteps, -1, tvwSteps.Nodes);
            
            ProductModelStep.AddModel(modelName, modelSteps, ref MyRun.model);

            //这里判断是否已经有同名模板存在
            MyRun.GetProductModelNameList(out List<string> modelNameList);
            if (modelNameList.Contains(modelName))
            {
                if (MessageBox.Show("模板" + modelName + "已存在\n是否覆盖", "存在同名模板", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MyRun.WriteModelJS(MyRun.model);
                    MyRun.ModelNumber++;
                    MyRun.CreateModelWindow.Close();
                }
            }
            else
            {
                if (MessageBox.Show("是否保存模板", "保存模板", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MyRun.WriteModelJS(MyRun.model);
                    MyRun.ModelNumber++;
                    MyRun.CreateModelWindow.Close();
                }
            }
        }
    }
}
