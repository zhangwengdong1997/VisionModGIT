
using MetroFramework.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using UI.Properties;

namespace UI
{
    public partial class LogInForm : MetroForm
    {
        MainForm mainForm = null;
        /// <summary>
        /// 存放所有用户名称
        /// </summary>
        List<string> _allUsersName;
        /// <summary>
        /// 存放所有用户对应的权限
        /// </summary>
        List<string> _allUsersPermission;

        public LogInForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 登录判断
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            Model.UserInfo userInfo = new Model.UserInfo();
            userInfo.UserName = cbox_UserName.Text.ToString().Replace(" ", "");
            userInfo.PassWord = tbox_Password.Text.ToString().Replace(" ", "");
            userInfo.Permission = tbox_Permission.Text.ToString();
            BLL.UserManager userManager = new BLL.UserManager();

            userManager.UserLogIn(userInfo,out int res);
            if (res == 0)  //登陆成功
            {
                Settings.Default.上次登录用户 = cbox_UserName.Text;
                Settings.Default.Save();

                //利用构造函数传入权限
                mainForm = new MainForm(userInfo.UserName, userInfo.Permission);
                mainForm.ReturnLogin += new MainForm.LogoutHandler(ReturnLoginForm);
                mainForm.Show();
                this.Hide();
            }
            else if (res == 1)  //用户不存在
            {
                toolTip2.Active = true;
                toolTip2.Show("用户名不存在", cbox_UserName, new Point(0, 20));
                cbox_UserName.Text = "";
            }
            else if (res == 2)  //密码错误
            {
                toolTip2.Active = true;
                toolTip2.Show("密码错误", tbox_Password, new Point(0, 20));
                tbox_Password.Clear();
            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            // 获取所有用户名及权限
            _allUsersPermission = null;

            BLL.UserManager userManager = new BLL.UserManager();
            //获取用户名列表与权限列表

            userManager.GetAllUsersNameList(out _allUsersName);

            userManager.GetAllUsersPermissionList(out _allUsersPermission);

            // 所有用户名加入下拉菜单
            cbox_UserName.DataSource = _allUsersName;
            // 权限只读
            tbox_Permission.ReadOnly = true;
            // 焦点顺序
            cbox_UserName.TabIndex = 0;
            tbox_Password.TabIndex = 1;
            tbox_Permission.TabIndex = 2;
            btn_LogIn.TabIndex = 3;
            // 回车登录
            this.AcceptButton = btn_LogIn;
            cbox_UserName.Text = Settings.Default.上次登录用户;
            btn_LogIn.Focus();

            //测试用*********************************************
            cbox_UserName.Text = "Administrator";
            tbox_Password.Text = "1";
            //***************************************************

        }

        /// <summary>
        /// 权限根据用户名实时显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbox_UserName_TextChanged(object sender, EventArgs e)
        {
            toolTip2.Active = false;
            if (_allUsersName == null)
                return;
            for (int i = 0; i < _allUsersName.Count(); i++)
            {
                if (cbox_UserName.Text == _allUsersName[i])   //如果用户名存在显示对应权限
                {
                    tbox_Permission.Text = _allUsersPermission[i];
                }
            }
        }

        /// <summary>
        /// 当主窗体登出时，返回登录窗体
        /// </summary>
        private void ReturnLoginForm()
        {
            mainForm.Dispose();
            //mainForm.Close();
            skinButton1.Visible = true;
            label_login.Visible = false;
            gifBox1.Visible = false;
            this.Show();
        }

        #region 输入密码大写提示
        private void tbox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            toolTip2.Active = false;
            //Point point = new Point(0, 20);
            if (e.KeyCode == Keys.CapsLock && Console.CapsLock == true)
            {
                e.Handled = true;
                toolTip1.Active = true;
                toolTip1.Show("大写锁定已打开", tbox_Password, new Point(0, 20));
            }
            else if (e.KeyCode == Keys.CapsLock && Console.CapsLock == false)
            {
                toolTip1.Active = false;
            }
        }

        private void tbox_Password_Enter(object sender, EventArgs e)
        {
            //Point point = new Point(0, 20);
            if (Console.CapsLock == true)
            {
                toolTip1.Active = true;
                toolTip1.Show("大写锁定已打开", tbox_Password, new Point(0, 20));
            }
        }

        private void tbox_Password_Leave(object sender, EventArgs e)
        {
            toolTip1.Active = false;
        }
        #endregion

        //输入密码时加密
        private void tbox_Password_TextChanged(object sender, EventArgs e)
        {
            tbox_Password.PasswordChar = '*';
        }

        private void cbox_UserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_LogIn.Focus();
        }

    }
}
