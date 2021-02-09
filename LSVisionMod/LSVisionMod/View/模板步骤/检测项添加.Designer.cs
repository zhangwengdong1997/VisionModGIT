namespace LSVisionMod.View.模板步骤
{
    partial class 检测项添加
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb选择检测项 = new System.Windows.Forms.ComboBox();
            this.pnl参数设置 = new System.Windows.Forms.Panel();
            this.btn保存设置 = new System.Windows.Forms.Button();
            this.lab关联图片数量 = new System.Windows.Forms.Label();
            this.lab当前相机 = new System.Windows.Forms.Label();
            this.btn获取本地图片 = new System.Windows.Forms.Button();
            this.txt检测结果 = new System.Windows.Forms.TextBox();
            this.btn测试 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt检测项名称 = new System.Windows.Forms.TextBox();
            this.btn返回 = new System.Windows.Forms.Button();
            this.lab当前匹配模板 = new System.Windows.Forms.Label();
            this.btn获取相机图片 = new System.Windows.Forms.Button();
            this.grp检测项初始化 = new System.Windows.Forms.GroupBox();
            this.lab检测项名称提示 = new System.Windows.Forms.Label();
            this.grp图片获取 = new System.Windows.Forms.GroupBox();
            this.grp检测项参数配置 = new System.Windows.Forms.GroupBox();
            this.grp测试结果 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grp检测项初始化.SuspendLayout();
            this.grp图片获取.SuspendLayout();
            this.grp检测项参数配置.SuspendLayout();
            this.grp测试结果.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 703);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 12F);
            this.label1.Location = new System.Drawing.Point(87, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "检测项功能";
            // 
            // cmb选择检测项
            // 
            this.cmb选择检测项.Font = new System.Drawing.Font("华文楷体", 12F);
            this.cmb选择检测项.FormattingEnabled = true;
            this.cmb选择检测项.Location = new System.Drawing.Point(195, 76);
            this.cmb选择检测项.Name = "cmb选择检测项";
            this.cmb选择检测项.Size = new System.Drawing.Size(223, 26);
            this.cmb选择检测项.TabIndex = 53;
            this.cmb选择检测项.SelectedIndexChanged += new System.EventHandler(this.cmb选择检测项_SelectedIndexChanged);
            // 
            // pnl参数设置
            // 
            this.pnl参数设置.Font = new System.Drawing.Font("宋体", 9F);
            this.pnl参数设置.Location = new System.Drawing.Point(4, 29);
            this.pnl参数设置.Name = "pnl参数设置";
            this.pnl参数设置.Size = new System.Drawing.Size(572, 165);
            this.pnl参数设置.TabIndex = 60;
            // 
            // btn保存设置
            // 
            this.btn保存设置.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn保存设置.Location = new System.Drawing.Point(1253, 683);
            this.btn保存设置.Name = "btn保存设置";
            this.btn保存设置.Size = new System.Drawing.Size(138, 40);
            this.btn保存设置.TabIndex = 75;
            this.btn保存设置.Text = "保存设置";
            this.btn保存设置.UseVisualStyleBackColor = true;
            this.btn保存设置.Click += new System.EventHandler(this.btn保存设置_Click);
            // 
            // lab关联图片数量
            // 
            this.lab关联图片数量.AutoSize = true;
            this.lab关联图片数量.Font = new System.Drawing.Font("华文楷体", 12F);
            this.lab关联图片数量.Location = new System.Drawing.Point(17, 96);
            this.lab关联图片数量.Name = "lab关联图片数量";
            this.lab关联图片数量.Size = new System.Drawing.Size(104, 18);
            this.lab关联图片数量.TabIndex = 74;
            this.lab关联图片数量.Text = "关联图片数量";
            // 
            // lab当前相机
            // 
            this.lab当前相机.AutoSize = true;
            this.lab当前相机.Font = new System.Drawing.Font("华文楷体", 12F);
            this.lab当前相机.Location = new System.Drawing.Point(17, 30);
            this.lab当前相机.Name = "lab当前相机";
            this.lab当前相机.Size = new System.Drawing.Size(72, 18);
            this.lab当前相机.TabIndex = 73;
            this.lab当前相机.Text = "当前相机";
            // 
            // btn获取本地图片
            // 
            this.btn获取本地图片.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn获取本地图片.Location = new System.Drawing.Point(373, 76);
            this.btn获取本地图片.Name = "btn获取本地图片";
            this.btn获取本地图片.Size = new System.Drawing.Size(138, 40);
            this.btn获取本地图片.TabIndex = 70;
            this.btn获取本地图片.Text = "获取本地图片";
            this.btn获取本地图片.UseVisualStyleBackColor = true;
            this.btn获取本地图片.Click += new System.EventHandler(this.btn获取图片_Click);
            // 
            // txt检测结果
            // 
            this.txt检测结果.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt检测结果.Font = new System.Drawing.Font("华文楷体", 12F);
            this.txt检测结果.Location = new System.Drawing.Point(3, 24);
            this.txt检测结果.Multiline = true;
            this.txt检测结果.Name = "txt检测结果";
            this.txt检测结果.Size = new System.Drawing.Size(411, 103);
            this.txt检测结果.TabIndex = 69;
            // 
            // btn测试
            // 
            this.btn测试.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn测试.Location = new System.Drawing.Point(1250, 540);
            this.btn测试.Name = "btn测试";
            this.btn测试.Size = new System.Drawing.Size(138, 40);
            this.btn测试.TabIndex = 67;
            this.btn测试.Text = "测试";
            this.btn测试.UseVisualStyleBackColor = true;
            this.btn测试.Click += new System.EventHandler(this.btn测试_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文楷体", 12F);
            this.label3.Location = new System.Drawing.Point(87, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 76;
            this.label3.Text = "检测项名称";
            // 
            // txt检测项名称
            // 
            this.txt检测项名称.Font = new System.Drawing.Font("华文楷体", 12F);
            this.txt检测项名称.Location = new System.Drawing.Point(195, 27);
            this.txt检测项名称.Name = "txt检测项名称";
            this.txt检测项名称.Size = new System.Drawing.Size(223, 28);
            this.txt检测项名称.TabIndex = 77;
            this.txt检测项名称.TextChanged += new System.EventHandler(this.txt检测项名称_TextChanged);
            // 
            // btn返回
            // 
            this.btn返回.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn返回.Location = new System.Drawing.Point(815, 683);
            this.btn返回.Name = "btn返回";
            this.btn返回.Size = new System.Drawing.Size(138, 40);
            this.btn返回.TabIndex = 78;
            this.btn返回.Text = "返回";
            this.btn返回.UseVisualStyleBackColor = true;
            this.btn返回.Click += new System.EventHandler(this.btn返回_Click);
            // 
            // lab当前匹配模板
            // 
            this.lab当前匹配模板.AutoSize = true;
            this.lab当前匹配模板.Font = new System.Drawing.Font("华文楷体", 12F);
            this.lab当前匹配模板.Location = new System.Drawing.Point(17, 62);
            this.lab当前匹配模板.Name = "lab当前匹配模板";
            this.lab当前匹配模板.Size = new System.Drawing.Size(104, 18);
            this.lab当前匹配模板.TabIndex = 79;
            this.lab当前匹配模板.Text = "当前匹配模板";
            // 
            // btn获取相机图片
            // 
            this.btn获取相机图片.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn获取相机图片.Location = new System.Drawing.Point(373, 21);
            this.btn获取相机图片.Name = "btn获取相机图片";
            this.btn获取相机图片.Size = new System.Drawing.Size(138, 40);
            this.btn获取相机图片.TabIndex = 80;
            this.btn获取相机图片.Text = "获取相机图片";
            this.btn获取相机图片.UseVisualStyleBackColor = true;
            this.btn获取相机图片.Click += new System.EventHandler(this.btn获取相机图片_Click);
            // 
            // grp检测项初始化
            // 
            this.grp检测项初始化.Controls.Add(this.lab检测项名称提示);
            this.grp检测项初始化.Controls.Add(this.cmb选择检测项);
            this.grp检测项初始化.Controls.Add(this.label3);
            this.grp检测项初始化.Controls.Add(this.txt检测项名称);
            this.grp检测项初始化.Controls.Add(this.label1);
            this.grp检测项初始化.Font = new System.Drawing.Font("华文楷体", 12F);
            this.grp检测项初始化.Location = new System.Drawing.Point(815, 20);
            this.grp检测项初始化.Name = "grp检测项初始化";
            this.grp检测项初始化.Size = new System.Drawing.Size(576, 125);
            this.grp检测项初始化.TabIndex = 81;
            this.grp检测项初始化.TabStop = false;
            this.grp检测项初始化.Text = "检测项初始化";
            // 
            // lab检测项名称提示
            // 
            this.lab检测项名称提示.AutoSize = true;
            this.lab检测项名称提示.Font = new System.Drawing.Font("华文楷体", 12F);
            this.lab检测项名称提示.Location = new System.Drawing.Point(435, 30);
            this.lab检测项名称提示.Name = "lab检测项名称提示";
            this.lab检测项名称提示.Size = new System.Drawing.Size(120, 18);
            this.lab检测项名称提示.TabIndex = 78;
            this.lab检测项名称提示.Text = "检测项名称提示";
            // 
            // grp图片获取
            // 
            this.grp图片获取.Controls.Add(this.btn获取相机图片);
            this.grp图片获取.Controls.Add(this.lab关联图片数量);
            this.grp图片获取.Controls.Add(this.btn获取本地图片);
            this.grp图片获取.Controls.Add(this.lab当前匹配模板);
            this.grp图片获取.Controls.Add(this.lab当前相机);
            this.grp图片获取.Font = new System.Drawing.Font("华文楷体", 12F);
            this.grp图片获取.Location = new System.Drawing.Point(815, 158);
            this.grp图片获取.Name = "grp图片获取";
            this.grp图片获取.Size = new System.Drawing.Size(576, 132);
            this.grp图片获取.TabIndex = 82;
            this.grp图片获取.TabStop = false;
            this.grp图片获取.Text = "图片获取";
            // 
            // grp检测项参数配置
            // 
            this.grp检测项参数配置.Controls.Add(this.pnl参数设置);
            this.grp检测项参数配置.Font = new System.Drawing.Font("华文楷体", 12F);
            this.grp检测项参数配置.Location = new System.Drawing.Point(815, 312);
            this.grp检测项参数配置.Name = "grp检测项参数配置";
            this.grp检测项参数配置.Size = new System.Drawing.Size(576, 198);
            this.grp检测项参数配置.TabIndex = 83;
            this.grp检测项参数配置.TabStop = false;
            this.grp检测项参数配置.Text = "检测项参数配置";
            // 
            // grp测试结果
            // 
            this.grp测试结果.Controls.Add(this.txt检测结果);
            this.grp测试结果.Font = new System.Drawing.Font("华文楷体", 12F);
            this.grp测试结果.Location = new System.Drawing.Point(815, 524);
            this.grp测试结果.Name = "grp测试结果";
            this.grp测试结果.Size = new System.Drawing.Size(417, 130);
            this.grp测试结果.TabIndex = 84;
            this.grp测试结果.TabStop = false;
            this.grp测试结果.Text = "测试结果";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 检测项添加
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn测试);
            this.Controls.Add(this.grp测试结果);
            this.Controls.Add(this.grp检测项参数配置);
            this.Controls.Add(this.grp图片获取);
            this.Controls.Add(this.grp检测项初始化);
            this.Controls.Add(this.btn返回);
            this.Controls.Add(this.btn保存设置);
            this.Controls.Add(this.pictureBox1);
            this.Name = "检测项添加";
            this.Size = new System.Drawing.Size(1456, 741);
            this.Load += new System.EventHandler(this.检测项添加_Load);
            this.Enter += new System.EventHandler(this.检测项添加_Enter);
            this.Leave += new System.EventHandler(this.检测项添加_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grp检测项初始化.ResumeLayout(false);
            this.grp检测项初始化.PerformLayout();
            this.grp图片获取.ResumeLayout(false);
            this.grp图片获取.PerformLayout();
            this.grp检测项参数配置.ResumeLayout(false);
            this.grp测试结果.ResumeLayout(false);
            this.grp测试结果.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb选择检测项;
        private System.Windows.Forms.Panel pnl参数设置;
        private System.Windows.Forms.Button btn保存设置;
        private System.Windows.Forms.Label lab关联图片数量;
        private System.Windows.Forms.Label lab当前相机;
        private System.Windows.Forms.Button btn获取本地图片;
        private System.Windows.Forms.TextBox txt检测结果;
        private System.Windows.Forms.Button btn测试;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt检测项名称;
        private System.Windows.Forms.Button btn返回;
        private System.Windows.Forms.Label lab当前匹配模板;
        private System.Windows.Forms.Button btn获取相机图片;
        private System.Windows.Forms.GroupBox grp检测项初始化;
        private System.Windows.Forms.GroupBox grp图片获取;
        private System.Windows.Forms.GroupBox grp检测项参数配置;
        private System.Windows.Forms.Label lab检测项名称提示;
        private System.Windows.Forms.GroupBox grp测试结果;
        private System.Windows.Forms.Timer timer1;
    }
}
