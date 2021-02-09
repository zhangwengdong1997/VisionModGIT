namespace UI
{
    partial class LogInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbox_Permission = new System.Windows.Forms.TextBox();
            this.cbox_UserName = new System.Windows.Forms.ComboBox();
            this.tbox_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.gifBox1 = new CCWin.SkinControl.GifBox();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.label_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbox_Permission
            // 
            this.tbox_Permission.Location = new System.Drawing.Point(144, 311);
            this.tbox_Permission.Name = "tbox_Permission";
            this.tbox_Permission.Size = new System.Drawing.Size(161, 21);
            this.tbox_Permission.TabIndex = 45;
            this.tbox_Permission.TextChanged += new System.EventHandler(this.tbox_Password_TextChanged);
            // 
            // cbox_UserName
            // 
            this.cbox_UserName.AutoCompleteCustomSource.AddRange(new string[] {
            "操作员",
            "技术员",
            "工程师"});
            this.cbox_UserName.FormattingEnabled = true;
            this.cbox_UserName.Location = new System.Drawing.Point(144, 235);
            this.cbox_UserName.Name = "cbox_UserName";
            this.cbox_UserName.Size = new System.Drawing.Size(162, 20);
            this.cbox_UserName.TabIndex = 44;
            this.cbox_UserName.SelectedIndexChanged += new System.EventHandler(this.cbox_UserName_SelectedIndexChanged);
            this.cbox_UserName.TextChanged += new System.EventHandler(this.cbox_UserName_TextChanged);
            // 
            // tbox_Password
            // 
            this.tbox_Password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbox_Password.Location = new System.Drawing.Point(144, 272);
            this.tbox_Password.Name = "tbox_Password";
            this.tbox_Password.Size = new System.Drawing.Size(161, 21);
            this.tbox_Password.TabIndex = 43;
            this.tbox_Password.Enter += new System.EventHandler(this.tbox_Password_Enter);
            this.tbox_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_Password_KeyDown);
            this.tbox_Password.Leave += new System.EventHandler(this.tbox_Password_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(53, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 42;
            this.label3.Text = "权    限";
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.btn_LogIn.FlatAppearance.BorderSize = 0;
            this.btn_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogIn.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_LogIn.Location = new System.Drawing.Point(75, 376);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(230, 54);
            this.btn_LogIn.TabIndex = 41;
            this.btn_LogIn.Text = "登录";
            this.btn_LogIn.UseVisualStyleBackColor = false;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(53, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "密    码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "用户名";
            // 
            // toolTip2
            // 
            this.toolTip2.Active = false;
            this.toolTip2.AutomaticDelay = 1000;
            // 
            // gifBox1
            // 
            this.gifBox1.BorderColor = System.Drawing.Color.Transparent;
            this.gifBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gifBox1.Image = global::UI.Properties.Resources.正在登陆;
            this.gifBox1.Location = new System.Drawing.Point(90, 51);
            this.gifBox1.Name = "gifBox1";
            this.gifBox1.Size = new System.Drawing.Size(181, 146);
            this.gifBox1.TabIndex = 47;
            this.gifBox1.Visible = false;
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton2.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton2.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton2.Image = global::UI.Properties.Resources.力视科技;
            this.skinButton2.ImageSize = new System.Drawing.Size(100, 25);
            this.skinButton2.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton2.Location = new System.Drawing.Point(-5, 514);
            this.skinButton2.MouseBack = null;
            this.skinButton2.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(118, 35);
            this.skinButton2.TabIndex = 46;
            this.skinButton2.UseVisualStyleBackColor = false;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton1.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton1.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton1.Image = global::UI.Properties.Resources.方块蓝色;
            this.skinButton1.ImageSize = new System.Drawing.Size(130, 130);
            this.skinButton1.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton1.Location = new System.Drawing.Point(116, 51);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(133, 137);
            this.skinButton1.TabIndex = 46;
            this.skinButton1.UseVisualStyleBackColor = false;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.White;
            this.label_login.Font = new System.Drawing.Font("微软雅黑", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(208)))));
            this.label_login.Location = new System.Drawing.Point(132, 24);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(98, 23);
            this.label_login.TabIndex = 39;
            this.label_login.Text = "正在登陆.....";
            this.label_login.Visible = false;
            // 
            // LogInForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(363, 544);
            this.Controls.Add(this.gifBox1);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.tbox_Permission);
            this.Controls.Add(this.cbox_UserName);
            this.Controls.Add(this.tbox_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbox_Permission;
        private System.Windows.Forms.ComboBox cbox_UserName;
        private System.Windows.Forms.TextBox tbox_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.GifBox gifBox1;
        private System.Windows.Forms.Label label_login;
    }
}