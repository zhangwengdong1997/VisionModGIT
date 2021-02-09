using CCWin;
using CCWin.SkinControl;
using MetroFramework.Forms;
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
using System.IO;
using System.Reflection;

namespace UI
{
    public partial class MainForm : MetroForm
    {
        /// <summary>
        /// 界面选择控件被选中时和未选中时的高度
        /// </summary>
        private int bh_sel, bh_unsel;
        private string m_userName;
        /// <summary>
        /// 当前登入用户的权限
        /// </summary>
        private string m_userPermission;

        private Button[] m_PageButtons = new Button[5];
        /// <summary>
        /// 用户登出的委托
        /// </summary>
        public delegate void LogoutHandler();
        /// <summary>
        /// 用户登出的事件
        /// </summary>
        public event LogoutHandler ReturnLogin;


        TestPanel testPanel               = new TestPanel();
        ModelPanel modelPanel             = new ModelPanel();
        DataPanel dataPanel               = new DataPanel();
        UsersManagePanel usersManagePanel = new UsersManagePanel();
        DevicesPanel devicesPanel         = new DevicesPanel();
        

        public MainForm(string userName, string userPermission)
        {
            InitializeComponent();
            x = this.Width;
            y = this.Height;
            //modelPanel.CreatDone += new ModelPanel.CreateModelHandler(testPanel.LoadModelList);
            bh_unsel        = Btn_Dev.Height;
            bh_sel          = bh_unsel * 6 / 5;
            m_userPermission = userPermission;
            m_userName       = userName;

            m_PageButtons[0] = Btn_Test;
            m_PageButtons[1] = Btn_Model;
            m_PageButtons[2] = Btn_Data;
            m_PageButtons[3] = Btn_User;
            m_PageButtons[4] = Btn_Dev;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Btn_Test.Height = bh_sel;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(testPanel);

            //根据权限限制功能
            if (m_userPermission == "工程师")
            {
                Btn_User.Enabled = false;
            }
            else if (m_userPermission == "操作员")
            {
                Btn_Model.Enabled = false;
                Btn_Data.Enabled = false;
                Btn_User.Enabled = false;
                Btn_Dev.Enabled = false;
            }
            label_User.Text = "当前用户: " + m_userName + "  " + m_userPermission;
        }


        /// <summary>
        /// 防止窗体闪烁
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #region 工作界面选择
        private void Btn_Test_Click(object sender, EventArgs e)
        {
            ChangeButtonHeight(0);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(testPanel);
        }
        private void Btn_Set_Click(object sender, EventArgs e)
        {
            ChangeButtonHeight(1);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(modelPanel);
        }
        private void Btn_Data_Click(object sender, EventArgs e)
        {
            ChangeButtonHeight(2);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(dataPanel);
        }
        private void Btn_User_Click(object sender, EventArgs e)
        {
            ChangeButtonHeight(3);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(usersManagePanel);
        }
        private void Btn_Dev_Click(object sender, EventArgs e)
        {
            ChangeButtonHeight(4);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(devicesPanel);
        }
        private void ChangeButtonHeight(int currentNum)
        {
            int otherNum;
            if (currentNum == 0)
                otherNum = 4;
            else
                otherNum = currentNum - 1;

            // 若当前选择的按钮高度大于其他按钮高度，则认为当前按钮已处于被选中状态，就不修改按钮高度
            if (m_PageButtons[currentNum].Height > m_PageButtons[otherNum].Height)
                return;

            bh_unsel = m_PageButtons[currentNum].Height;
            bh_sel = bh_unsel * 6 / 5;
            for (int i = 0; i < m_PageButtons.Length; i++)
            {
                if (i == currentNum)
                    m_PageButtons[currentNum].Height = bh_sel;
                else
                    m_PageButtons[i].Height = bh_unsel;
            }
        }
        #endregion

        /// <summary>
        /// 用户登出，返回登录界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            testPanel.Dispose();
            modelPanel.Dispose();
            usersManagePanel.Dispose();
            devicesPanel.Dispose();
            dataPanel.Dispose();
            ReturnLogin();
        }

        /// <summary>
        /// 右上角时间显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_time.Text = System.DateTime.Now.ToString();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit(e);
        }


        #region 控件大小随窗体大小等比例缩放或者移动位置
        private float x;//定义当前窗体的宽度
        private float y;//定义当前窗体的高度
        /// <summary>
        /// 改变主面板大小
        /// </summary>
        /// <param name="newx"></param>
        /// <param name="newy"></param>
        private void ChangControlsSize(float newx, float newy)
        {
            //根据窗体缩放的比例确定控件的值
            mainPanel.Width = Convert.ToInt32(System.Convert.ToSingle(mainPanel.Width) * newx);//宽度
            mainPanel.Height = Convert.ToInt32(System.Convert.ToSingle(mainPanel.Height) * newy);//高度
            mainPanel.Left = Convert.ToInt32(System.Convert.ToSingle(mainPanel.Left) * newx);//左边距
            mainPanel.Top = Convert.ToInt32(System.Convert.ToSingle(mainPanel.Top) * newy);//顶边距

            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in this.Controls)
            {
                if (con is Label)
                {
                    Single currentSize = System.Convert.ToSingle(con.Font.Size) * newy;//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    con.Left = Convert.ToInt32(System.Convert.ToSingle(con.Left) * newx);//左边距
                    con.Top = Convert.ToInt32(System.Convert.ToSingle(con.Top) * newy);//顶边距
                }
                else if (con is SkinButton)
                {
                    if (con.Text == "")
                        continue;
                    SkinButton temp = (SkinButton)con;
                    temp.Width = Convert.ToInt32(System.Convert.ToSingle(temp.Width) * newx);//宽度
                    temp.Height = Convert.ToInt32(System.Convert.ToSingle(temp.Height) * newy);//高度
                    Size tempSize = new Size();
                    tempSize.Width = Convert.ToInt32(System.Convert.ToSingle(temp.ImageSize.Width) * newy);
                    tempSize.Height = Convert.ToInt32(System.Convert.ToSingle(temp.ImageSize.Height) * newy);
                    temp.ImageSize = tempSize;
                    Single currentSize = System.Convert.ToSingle(temp.Font.Size) * newy;//字体大小
                    temp.Font = new Font(temp.Font.Name, currentSize, temp.Font.Style, temp.Font.Unit);
                    temp.Left = Convert.ToInt32(System.Convert.ToSingle(temp.Left) * newx);//左边距
                    temp.Top = Convert.ToInt32(System.Convert.ToSingle(temp.Top) * newy);//顶边距
                }
            }
        }

        private void mainPanel_Resize(object sender, EventArgs e)
        {
            int width = mainPanel.Width;
            int height = mainPanel.Height;
            testPanel.Width = width;
            testPanel.Height = height;
            modelPanel.Width = width;
            modelPanel.Height = height;
            dataPanel.Width = width;
            dataPanel.Height = height;
            usersManagePanel.Width = width;
            usersManagePanel.Height = height;
            devicesPanel.Width = width;
            devicesPanel.Height = height;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                return;
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            float dx = Width - x;
            x = this.Width;
            y = this.Height;
            //setControls(newx, newy, this);
            ChangControlsSize(newx, newy);
        }
        #endregion

    }
}
