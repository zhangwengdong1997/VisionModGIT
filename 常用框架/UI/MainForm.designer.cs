namespace UI
{
    partial class MainForm
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
            this.mainPanel = new CCWin.SkinControl.SkinPanel();
            this.label_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_User = new System.Windows.Forms.Label();
            this.Btn_Test = new CCWin.SkinControl.SkinButton();
            this.Btn_Model = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.Btn_Data = new CCWin.SkinControl.SkinButton();
            this.Btn_Dev = new CCWin.SkinControl.SkinButton();
            this.Btn_User = new CCWin.SkinControl.SkinButton();
            this.Btn_LogOut = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.mainPanel.DownBack = null;
            this.mainPanel.Location = new System.Drawing.Point(-1, 130);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.MouseBack = null;
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.NormlBack = null;
            this.mainPanel.Size = new System.Drawing.Size(1472, 699);
            this.mainPanel.TabIndex = 9;
            this.mainPanel.Resize += new System.EventHandler(this.mainPanel_Resize);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("微软雅黑", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_time.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_time.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_time.Location = new System.Drawing.Point(1282, 103);
            this.label_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(179, 23);
            this.label_time.TabIndex = 46;
            this.label_time.Text = "2020/10/24/11:01:54";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Font = new System.Drawing.Font("微软雅黑", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_User.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_User.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_User.Location = new System.Drawing.Point(3, 103);
            this.label_User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(82, 23);
            this.label_User.TabIndex = 46;
            this.label_User.Text = "当前用户:";
            // 
            // Btn_Test
            // 
            this.Btn_Test.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Test.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Btn_Test.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Test.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_Test.DownBack = null;
            this.Btn_Test.FadeGlow = false;
            this.Btn_Test.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Test.ForeColor = System.Drawing.Color.White;
            this.Btn_Test.Image = global::UI.Properties.Resources.检测;
            this.Btn_Test.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Test.ImageSize = new System.Drawing.Size(50, 50);
            this.Btn_Test.InnerBorderColor = System.Drawing.Color.Transparent;
            this.Btn_Test.IsDrawGlass = false;
            this.Btn_Test.Location = new System.Drawing.Point(459, 2);
            this.Btn_Test.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Test.MouseBack = null;
            this.Btn_Test.Name = "Btn_Test";
            this.Btn_Test.NormlBack = null;
            this.Btn_Test.RoundStyle = CCWin.SkinClass.RoundStyle.Bottom;
            this.Btn_Test.Size = new System.Drawing.Size(108, 81);
            this.Btn_Test.TabIndex = 48;
            this.Btn_Test.Text = "测试运行";
            this.Btn_Test.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Test.UseVisualStyleBackColor = false;
            this.Btn_Test.Click += new System.EventHandler(this.Btn_Test_Click);
            // 
            // Btn_Set
            // 
            this.Btn_Model.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Model.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Btn_Model.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Model.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_Model.DownBack = null;
            this.Btn_Model.FadeGlow = false;
            this.Btn_Model.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Model.ForeColor = System.Drawing.Color.White;
            this.Btn_Model.Image = global::UI.Properties.Resources.文件夹_实色;
            this.Btn_Model.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Model.ImageSize = new System.Drawing.Size(55, 55);
            this.Btn_Model.InnerBorderColor = System.Drawing.Color.Transparent;
            this.Btn_Model.IsDrawGlass = false;
            this.Btn_Model.Location = new System.Drawing.Point(568, 2);
            this.Btn_Model.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Model.MouseBack = null;
            this.Btn_Model.Name = "Btn_Set";
            this.Btn_Model.NormlBack = null;
            this.Btn_Model.RoundStyle = CCWin.SkinClass.RoundStyle.Bottom;
            this.Btn_Model.Size = new System.Drawing.Size(108, 81);
            this.Btn_Model.TabIndex = 4;
            this.Btn_Model.Text = "机型配置";
            this.Btn_Model.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Model.UseVisualStyleBackColor = false;
            this.Btn_Model.Click += new System.EventHandler(this.Btn_Set_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton2.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton2.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton2.Image = global::UI.Properties.Resources.力视科技;
            this.skinButton2.ImageSize = new System.Drawing.Size(170, 40);
            this.skinButton2.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton2.Location = new System.Drawing.Point(1287, 60);
            this.skinButton2.MouseBack = null;
            this.skinButton2.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(173, 44);
            this.skinButton2.TabIndex = 49;
            this.skinButton2.UseVisualStyleBackColor = false;
            // 
            // Btn_Data
            // 
            this.Btn_Data.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Data.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Btn_Data.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Data.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_Data.DownBack = null;
            this.Btn_Data.FadeGlow = false;
            this.Btn_Data.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Data.ForeColor = System.Drawing.Color.White;
            this.Btn_Data.Image = global::UI.Properties.Resources.云;
            this.Btn_Data.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Data.ImageSize = new System.Drawing.Size(50, 40);
            this.Btn_Data.InnerBorderColor = System.Drawing.Color.Transparent;
            this.Btn_Data.IsDrawGlass = false;
            this.Btn_Data.Location = new System.Drawing.Point(677, 2);
            this.Btn_Data.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Data.MouseBack = null;
            this.Btn_Data.Name = "Btn_Data";
            this.Btn_Data.NormlBack = null;
            this.Btn_Data.RoundStyle = CCWin.SkinClass.RoundStyle.Bottom;
            this.Btn_Data.Size = new System.Drawing.Size(108, 81);
            this.Btn_Data.TabIndex = 5;
            this.Btn_Data.Text = "数据管理";
            this.Btn_Data.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Data.UseVisualStyleBackColor = false;
            this.Btn_Data.Click += new System.EventHandler(this.Btn_Data_Click);
            // 
            // Btn_Dev
            // 
            this.Btn_Dev.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Dev.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Btn_Dev.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Dev.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_Dev.DownBack = null;
            this.Btn_Dev.FadeGlow = false;
            this.Btn_Dev.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Dev.ForeColor = System.Drawing.Color.White;
            this.Btn_Dev.Image = global::UI.Properties.Resources.设_置;
            this.Btn_Dev.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Dev.ImageSize = new System.Drawing.Size(50, 50);
            this.Btn_Dev.InnerBorderColor = System.Drawing.Color.Transparent;
            this.Btn_Dev.IsDrawGlass = false;
            this.Btn_Dev.Location = new System.Drawing.Point(895, 2);
            this.Btn_Dev.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Dev.MouseBack = null;
            this.Btn_Dev.Name = "Btn_Dev";
            this.Btn_Dev.NormlBack = null;
            this.Btn_Dev.RoundStyle = CCWin.SkinClass.RoundStyle.Bottom;
            this.Btn_Dev.Size = new System.Drawing.Size(108, 81);
            this.Btn_Dev.TabIndex = 7;
            this.Btn_Dev.Text = "设备管理";
            this.Btn_Dev.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Dev.UseVisualStyleBackColor = false;
            this.Btn_Dev.Click += new System.EventHandler(this.Btn_Dev_Click);
            // 
            // Btn_User
            // 
            this.Btn_User.BackColor = System.Drawing.Color.Transparent;
            this.Btn_User.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Btn_User.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_User.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_User.DownBack = null;
            this.Btn_User.FadeGlow = false;
            this.Btn_User.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_User.ForeColor = System.Drawing.Color.White;
            this.Btn_User.Image = global::UI.Properties.Resources.用户_灰;
            this.Btn_User.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_User.ImageSize = new System.Drawing.Size(50, 50);
            this.Btn_User.InnerBorderColor = System.Drawing.Color.Transparent;
            this.Btn_User.IsDrawGlass = false;
            this.Btn_User.Location = new System.Drawing.Point(786, 2);
            this.Btn_User.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_User.MouseBack = null;
            this.Btn_User.Name = "Btn_User";
            this.Btn_User.NormlBack = null;
            this.Btn_User.RoundStyle = CCWin.SkinClass.RoundStyle.Bottom;
            this.Btn_User.Size = new System.Drawing.Size(108, 81);
            this.Btn_User.TabIndex = 8;
            this.Btn_User.Text = "用户管理";
            this.Btn_User.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_User.UseVisualStyleBackColor = false;
            this.Btn_User.Click += new System.EventHandler(this.Btn_User_Click);
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.BackColor = System.Drawing.Color.Transparent;
            this.Btn_LogOut.BaseColor = System.Drawing.Color.Transparent;
            this.Btn_LogOut.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_LogOut.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_LogOut.DownBack = null;
            this.Btn_LogOut.DownBaseColor = System.Drawing.Color.Transparent;
            this.Btn_LogOut.FadeGlow = false;
            this.Btn_LogOut.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_LogOut.ForeColor = System.Drawing.Color.Black;
            this.Btn_LogOut.Image = global::UI.Properties.Resources.退出;
            this.Btn_LogOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_LogOut.ImageSize = new System.Drawing.Size(50, 50);
            this.Btn_LogOut.InnerBorderColor = System.Drawing.Color.Transparent;
            this.Btn_LogOut.IsDrawGlass = false;
            this.Btn_LogOut.Location = new System.Drawing.Point(0, 6);
            this.Btn_LogOut.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_LogOut.MouseBack = null;
            this.Btn_LogOut.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.NormlBack = null;
            this.Btn_LogOut.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_LogOut.Size = new System.Drawing.Size(59, 79);
            this.Btn_LogOut.TabIndex = 10;
            this.Btn_LogOut.Text = "登出";
            this.Btn_LogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_LogOut.UseVisualStyleBackColor = false;
            this.Btn_LogOut.Click += new System.EventHandler(this.Btn_LogOut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1470, 827);
            this.Controls.Add(this.Btn_Test);
            this.Controls.Add(this.Btn_Model);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.Btn_Data);
            this.Controls.Add(this.label_User);
            this.Controls.Add(this.Btn_Dev);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.Btn_User);
            this.Controls.Add(this.Btn_LogOut);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(25, 75, 25, 25);
            this.Resizable = false;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinButton Btn_Model;
        private CCWin.SkinControl.SkinButton Btn_Data;
        private CCWin.SkinControl.SkinButton Btn_Dev;
        private CCWin.SkinControl.SkinButton Btn_User;
        private CCWin.SkinControl.SkinPanel mainPanel;
        private CCWin.SkinControl.SkinButton Btn_LogOut;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinButton Btn_Test;
        private System.Windows.Forms.Label label_User;
        private CCWin.SkinControl.SkinButton skinButton2;
    }
}

