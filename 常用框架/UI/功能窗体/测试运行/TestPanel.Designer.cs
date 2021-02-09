namespace UI
{
    partial class TestPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label34 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label_NowTotal = new System.Windows.Forms.Label();
            this.label_NowOKnum = new System.Windows.Forms.Label();
            this.label_DayTotal = new System.Windows.Forms.Label();
            this.label_DayPassRate = new System.Windows.Forms.Label();
            this.label_NowNGnum = new System.Windows.Forms.Label();
            this.label_DayOKnum = new System.Windows.Forms.Label();
            this.label_NowPassRate = new System.Windows.Forms.Label();
            this.label_DayNGnum = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lab相机 = new System.Windows.Forms.Label();
            this.lab运动控制器 = new System.Windows.Forms.Label();
            this.comboBox_ModelSelect = new CCWin.SkinControl.SkinComboBox();
            this.Btn_LoadModel = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.Btn_检测控制 = new CCWin.SkinControl.SkinButton();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.Location = new System.Drawing.Point(30, 124);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(74, 25);
            this.label34.TabIndex = 51;
            this.label34.Text = "合格率:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(21, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 25);
            this.label12.TabIndex = 51;
            this.label12.Text = "本次总数:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(32, 47);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 25);
            this.label23.TabIndex = 51;
            this.label23.Text = "OK数:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(31, 85);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 25);
            this.label24.TabIndex = 51;
            this.label24.Text = "NG数:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(183, 8);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(93, 25);
            this.label27.TabIndex = 54;
            this.label27.Text = "今日总数:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(200, 47);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(63, 25);
            this.label26.TabIndex = 53;
            this.label26.Text = "OK数:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(199, 85);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 25);
            this.label25.TabIndex = 52;
            this.label25.Text = "NG数:";
            // 
            // label_NowTotal
            // 
            this.label_NowTotal.AutoSize = true;
            this.label_NowTotal.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_NowTotal.Location = new System.Drawing.Point(112, 8);
            this.label_NowTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NowTotal.Name = "label_NowTotal";
            this.label_NowTotal.Size = new System.Drawing.Size(23, 25);
            this.label_NowTotal.TabIndex = 55;
            this.label_NowTotal.Text = "0";
            // 
            // label_NowOKnum
            // 
            this.label_NowOKnum.AutoSize = true;
            this.label_NowOKnum.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_NowOKnum.Location = new System.Drawing.Point(112, 47);
            this.label_NowOKnum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NowOKnum.Name = "label_NowOKnum";
            this.label_NowOKnum.Size = new System.Drawing.Size(23, 25);
            this.label_NowOKnum.TabIndex = 56;
            this.label_NowOKnum.Text = "0";
            // 
            // label_DayTotal
            // 
            this.label_DayTotal.AutoSize = true;
            this.label_DayTotal.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_DayTotal.Location = new System.Drawing.Point(275, 9);
            this.label_DayTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DayTotal.Name = "label_DayTotal";
            this.label_DayTotal.Size = new System.Drawing.Size(23, 25);
            this.label_DayTotal.TabIndex = 55;
            this.label_DayTotal.Text = "0";
            // 
            // label_DayPassRate
            // 
            this.label_DayPassRate.AutoSize = true;
            this.label_DayPassRate.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_DayPassRate.Location = new System.Drawing.Point(275, 125);
            this.label_DayPassRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DayPassRate.Name = "label_DayPassRate";
            this.label_DayPassRate.Size = new System.Drawing.Size(23, 25);
            this.label_DayPassRate.TabIndex = 59;
            this.label_DayPassRate.Text = "0";
            // 
            // label_NowNGnum
            // 
            this.label_NowNGnum.AutoSize = true;
            this.label_NowNGnum.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_NowNGnum.Location = new System.Drawing.Point(112, 85);
            this.label_NowNGnum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NowNGnum.Name = "label_NowNGnum";
            this.label_NowNGnum.Size = new System.Drawing.Size(23, 25);
            this.label_NowNGnum.TabIndex = 56;
            this.label_NowNGnum.Text = "0";
            // 
            // label_DayOKnum
            // 
            this.label_DayOKnum.AutoSize = true;
            this.label_DayOKnum.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_DayOKnum.Location = new System.Drawing.Point(275, 48);
            this.label_DayOKnum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DayOKnum.Name = "label_DayOKnum";
            this.label_DayOKnum.Size = new System.Drawing.Size(23, 25);
            this.label_DayOKnum.TabIndex = 56;
            this.label_DayOKnum.Text = "0";
            // 
            // label_NowPassRate
            // 
            this.label_NowPassRate.AutoSize = true;
            this.label_NowPassRate.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_NowPassRate.Location = new System.Drawing.Point(112, 124);
            this.label_NowPassRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NowPassRate.Name = "label_NowPassRate";
            this.label_NowPassRate.Size = new System.Drawing.Size(23, 25);
            this.label_NowPassRate.TabIndex = 58;
            this.label_NowPassRate.Text = "0";
            // 
            // label_DayNGnum
            // 
            this.label_DayNGnum.AutoSize = true;
            this.label_DayNGnum.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_DayNGnum.Location = new System.Drawing.Point(275, 86);
            this.label_DayNGnum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DayNGnum.Name = "label_DayNGnum";
            this.label_DayNGnum.Size = new System.Drawing.Size(23, 25);
            this.label_DayNGnum.TabIndex = 56;
            this.label_DayNGnum.Text = "0";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.Location = new System.Drawing.Point(195, 124);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(74, 25);
            this.label35.TabIndex = 57;
            this.label35.Text = "合格率:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label34);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.label_NowTotal);
            this.panel5.Controls.Add(this.label_NowOKnum);
            this.panel5.Controls.Add(this.label_DayTotal);
            this.panel5.Controls.Add(this.label_DayPassRate);
            this.panel5.Controls.Add(this.label_NowNGnum);
            this.panel5.Controls.Add(this.label_DayOKnum);
            this.panel5.Controls.Add(this.label_NowPassRate);
            this.panel5.Controls.Add(this.label_DayNGnum);
            this.panel5.Controls.Add(this.label35);
            this.panel5.Location = new System.Drawing.Point(1124, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 158);
            this.panel5.TabIndex = 72;
            // 
            // lab相机
            // 
            this.lab相机.AutoSize = true;
            this.lab相机.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab相机.Image = global::UI.Properties.Resources.错误;
            this.lab相机.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lab相机.Location = new System.Drawing.Point(1326, 21);
            this.lab相机.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab相机.Name = "lab相机";
            this.lab相机.Size = new System.Drawing.Size(74, 25);
            this.lab相机.TabIndex = 71;
            this.lab相机.Text = "相机    ";
            this.lab相机.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab运动控制器
            // 
            this.lab运动控制器.AutoSize = true;
            this.lab运动控制器.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab运动控制器.Image = global::UI.Properties.Resources.错误;
            this.lab运动控制器.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lab运动控制器.Location = new System.Drawing.Point(1133, 21);
            this.lab运动控制器.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab运动控制器.Name = "lab运动控制器";
            this.lab运动控制器.Size = new System.Drawing.Size(131, 25);
            this.lab运动控制器.TabIndex = 70;
            this.lab运动控制器.Text = "运动控制器    ";
            this.lab运动控制器.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_ModelSelect
            // 
            this.comboBox_ModelSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_ModelSelect.Font = new System.Drawing.Font("微软雅黑", 17F);
            this.comboBox_ModelSelect.FormattingEnabled = true;
            this.comboBox_ModelSelect.Location = new System.Drawing.Point(1272, 405);
            this.comboBox_ModelSelect.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_ModelSelect.MouseColor = System.Drawing.Color.DodgerBlue;
            this.comboBox_ModelSelect.MouseGradientColor = System.Drawing.Color.DodgerBlue;
            this.comboBox_ModelSelect.Name = "comboBox_ModelSelect";
            this.comboBox_ModelSelect.Size = new System.Drawing.Size(182, 38);
            this.comboBox_ModelSelect.TabIndex = 69;
            this.comboBox_ModelSelect.WaterText = "";
            // 
            // Btn_LoadModel
            // 
            this.Btn_LoadModel.BackColor = System.Drawing.Color.Transparent;
            this.Btn_LoadModel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_LoadModel.DownBack = null;
            this.Btn_LoadModel.FadeGlow = false;
            this.Btn_LoadModel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_LoadModel.ForeColor = System.Drawing.Color.White;
            this.Btn_LoadModel.IsDrawBorder = false;
            this.Btn_LoadModel.IsDrawGlass = false;
            this.Btn_LoadModel.Location = new System.Drawing.Point(1124, 403);
            this.Btn_LoadModel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_LoadModel.MouseBack = null;
            this.Btn_LoadModel.Name = "Btn_LoadModel";
            this.Btn_LoadModel.NormlBack = null;
            this.Btn_LoadModel.Size = new System.Drawing.Size(140, 42);
            this.Btn_LoadModel.TabIndex = 68;
            this.Btn_LoadModel.Text = "载入机型";
            this.Btn_LoadModel.UseVisualStyleBackColor = false;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.FadeGlow = false;
            this.skinButton1.Font = new System.Drawing.Font("微软雅黑", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.ForeColor = System.Drawing.Color.White;
            this.skinButton1.IsDrawBorder = false;
            this.skinButton1.IsDrawGlass = false;
            this.skinButton1.Location = new System.Drawing.Point(1124, 476);
            this.skinButton1.Margin = new System.Windows.Forms.Padding(4);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(330, 76);
            this.skinButton1.TabIndex = 67;
            this.skinButton1.Text = "设备复位";
            this.skinButton1.UseVisualStyleBackColor = false;
            // 
            // Btn_检测控制
            // 
            this.Btn_检测控制.BackColor = System.Drawing.Color.Transparent;
            this.Btn_检测控制.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_检测控制.DownBack = null;
            this.Btn_检测控制.FadeGlow = false;
            this.Btn_检测控制.Font = new System.Drawing.Font("微软雅黑", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_检测控制.ForeColor = System.Drawing.Color.White;
            this.Btn_检测控制.IsDrawBorder = false;
            this.Btn_检测控制.IsDrawGlass = false;
            this.Btn_检测控制.Location = new System.Drawing.Point(1124, 584);
            this.Btn_检测控制.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_检测控制.MouseBack = null;
            this.Btn_检测控制.Name = "Btn_检测控制";
            this.Btn_检测控制.NormlBack = null;
            this.Btn_检测控制.Size = new System.Drawing.Size(330, 76);
            this.Btn_检测控制.TabIndex = 66;
            this.Btn_检测控制.Text = "▶ 开始检测";
            this.Btn_检测控制.UseVisualStyleBackColor = false;
            // 
            // TestPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lab相机);
            this.Controls.Add(this.lab运动控制器);
            this.Controls.Add(this.comboBox_ModelSelect);
            this.Controls.Add(this.Btn_LoadModel);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.Btn_检测控制);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TestPanel";
            this.Size = new System.Drawing.Size(1472, 681);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label_NowTotal;
        private System.Windows.Forms.Label label_NowOKnum;
        private System.Windows.Forms.Label label_DayTotal;
        private System.Windows.Forms.Label label_DayPassRate;
        private System.Windows.Forms.Label label_NowNGnum;
        private System.Windows.Forms.Label label_DayOKnum;
        private System.Windows.Forms.Label label_NowPassRate;
        private System.Windows.Forms.Label label_DayNGnum;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lab相机;
        private System.Windows.Forms.Label lab运动控制器;
        private CCWin.SkinControl.SkinComboBox comboBox_ModelSelect;
        private CCWin.SkinControl.SkinButton Btn_LoadModel;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton Btn_检测控制;
    }
}
