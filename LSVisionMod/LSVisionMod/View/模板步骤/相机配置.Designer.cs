namespace LSVisionMod.View.模板步骤
{
    partial class 相机配置
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
            this.btn添加当前图片关联相机 = new System.Windows.Forms.Button();
            this.lab相机曝光值提示 = new System.Windows.Forms.Label();
            this.lab关联图片数量 = new System.Windows.Forms.Label();
            this.btn添加本地图片关联相机 = new System.Windows.Forms.Button();
            this.btn获取图片 = new System.Windows.Forms.Button();
            this.txt相机曝光值 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn保存设置 = new System.Windows.Forms.Button();
            this.btn返回 = new System.Windows.Forms.Button();
            this.chk实时拍照显示 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt样本图片保存路径 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn显示样本图片 = new System.Windows.Forms.Button();
            this.lab选择相机提示 = new System.Windows.Forms.Label();
            this.cmb相机列表 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn刷新相机连接 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Spinner等待重连 = new MetroFramework.Controls.MetroProgressSpinner();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn添加当前图片关联相机
            // 
            this.btn添加当前图片关联相机.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn添加当前图片关联相机.Location = new System.Drawing.Point(200, 77);
            this.btn添加当前图片关联相机.Name = "btn添加当前图片关联相机";
            this.btn添加当前图片关联相机.Size = new System.Drawing.Size(138, 40);
            this.btn添加当前图片关联相机.TabIndex = 60;
            this.btn添加当前图片关联相机.Text = "保存当前图片";
            this.btn添加当前图片关联相机.UseVisualStyleBackColor = true;
            this.btn添加当前图片关联相机.Click += new System.EventHandler(this.btn添加当前图片关联相机_Click);
            // 
            // lab相机曝光值提示
            // 
            this.lab相机曝光值提示.AutoSize = true;
            this.lab相机曝光值提示.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab相机曝光值提示.Location = new System.Drawing.Point(354, 45);
            this.lab相机曝光值提示.Name = "lab相机曝光值提示";
            this.lab相机曝光值提示.Size = new System.Drawing.Size(120, 18);
            this.lab相机曝光值提示.TabIndex = 58;
            this.lab相机曝光值提示.Text = "相机曝光值提示";
            // 
            // lab关联图片数量
            // 
            this.lab关联图片数量.AutoSize = true;
            this.lab关联图片数量.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab关联图片数量.Location = new System.Drawing.Point(40, 88);
            this.lab关联图片数量.Name = "lab关联图片数量";
            this.lab关联图片数量.Size = new System.Drawing.Size(104, 18);
            this.lab关联图片数量.TabIndex = 55;
            this.lab关联图片数量.Text = "样本图片数量";
            // 
            // btn添加本地图片关联相机
            // 
            this.btn添加本地图片关联相机.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn添加本地图片关联相机.Location = new System.Drawing.Point(390, 77);
            this.btn添加本地图片关联相机.Name = "btn添加本地图片关联相机";
            this.btn添加本地图片关联相机.Size = new System.Drawing.Size(138, 40);
            this.btn添加本地图片关联相机.TabIndex = 54;
            this.btn添加本地图片关联相机.Text = "加载本地图片";
            this.btn添加本地图片关联相机.UseVisualStyleBackColor = true;
            this.btn添加本地图片关联相机.Click += new System.EventHandler(this.btn添加本地图片关联相机_Click);
            // 
            // btn获取图片
            // 
            this.btn获取图片.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn获取图片.Location = new System.Drawing.Point(43, 81);
            this.btn获取图片.Name = "btn获取图片";
            this.btn获取图片.Size = new System.Drawing.Size(138, 40);
            this.btn获取图片.TabIndex = 53;
            this.btn获取图片.Text = "显示相机图片";
            this.btn获取图片.UseVisualStyleBackColor = true;
            this.btn获取图片.Click += new System.EventHandler(this.btn获取图片_Click);
            // 
            // txt相机曝光值
            // 
            this.txt相机曝光值.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt相机曝光值.Location = new System.Drawing.Point(144, 42);
            this.txt相机曝光值.Name = "txt相机曝光值";
            this.txt相机曝光值.Size = new System.Drawing.Size(204, 28);
            this.txt相机曝光值.TabIndex = 52;
            this.txt相机曝光值.TextChanged += new System.EventHandler(this.txt相机曝光值_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(50, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "相机曝光值";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 703);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // btn保存设置
            // 
            this.btn保存设置.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn保存设置.Location = new System.Drawing.Point(1253, 683);
            this.btn保存设置.Name = "btn保存设置";
            this.btn保存设置.Size = new System.Drawing.Size(138, 40);
            this.btn保存设置.TabIndex = 61;
            this.btn保存设置.Text = "保存设置";
            this.btn保存设置.UseVisualStyleBackColor = true;
            this.btn保存设置.Click += new System.EventHandler(this.btn保存设置_Click);
            // 
            // btn返回
            // 
            this.btn返回.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn返回.Location = new System.Drawing.Point(815, 683);
            this.btn返回.Name = "btn返回";
            this.btn返回.Size = new System.Drawing.Size(138, 40);
            this.btn返回.TabIndex = 62;
            this.btn返回.Text = "返回";
            this.btn返回.UseVisualStyleBackColor = true;
            this.btn返回.Click += new System.EventHandler(this.btn返回_Click);
            // 
            // chk实时拍照显示
            // 
            this.chk实时拍照显示.AutoSize = true;
            this.chk实时拍照显示.Font = new System.Drawing.Font("华文楷体", 12F);
            this.chk实时拍照显示.Location = new System.Drawing.Point(234, 91);
            this.chk实时拍照显示.Name = "chk实时拍照显示";
            this.chk实时拍照显示.Size = new System.Drawing.Size(123, 22);
            this.chk实时拍照显示.TabIndex = 63;
            this.chk实时拍照显示.Text = "实时拍照显示";
            this.chk实时拍照显示.UseVisualStyleBackColor = true;
            this.chk实时拍照显示.CheckedChanged += new System.EventHandler(this.chk实时拍照显示_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt样本图片保存路径);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn显示样本图片);
            this.groupBox1.Controls.Add(this.btn添加当前图片关联相机);
            this.groupBox1.Controls.Add(this.lab关联图片数量);
            this.groupBox1.Controls.Add(this.btn添加本地图片关联相机);
            this.groupBox1.Font = new System.Drawing.Font("华文楷体", 12F);
            this.groupBox1.Location = new System.Drawing.Point(815, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 216);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "样本图片管理";
            // 
            // txt样本图片保存路径
            // 
            this.txt样本图片保存路径.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt样本图片保存路径.Location = new System.Drawing.Point(200, 40);
            this.txt样本图片保存路径.Name = "txt样本图片保存路径";
            this.txt样本图片保存路径.ReadOnly = true;
            this.txt样本图片保存路径.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt样本图片保存路径.Size = new System.Drawing.Size(328, 28);
            this.txt样本图片保存路径.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(40, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "样本图片保存路径";
            // 
            // btn显示样本图片
            // 
            this.btn显示样本图片.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn显示样本图片.Location = new System.Drawing.Point(43, 146);
            this.btn显示样本图片.Name = "btn显示样本图片";
            this.btn显示样本图片.Size = new System.Drawing.Size(138, 40);
            this.btn显示样本图片.TabIndex = 64;
            this.btn显示样本图片.Text = "显示样本图片";
            this.btn显示样本图片.UseVisualStyleBackColor = true;
            this.btn显示样本图片.Click += new System.EventHandler(this.btn显示样本图片_Click);
            // 
            // lab选择相机提示
            // 
            this.lab选择相机提示.AutoSize = true;
            this.lab选择相机提示.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab选择相机提示.Location = new System.Drawing.Point(344, 33);
            this.lab选择相机提示.Name = "lab选择相机提示";
            this.lab选择相机提示.Size = new System.Drawing.Size(104, 18);
            this.lab选择相机提示.TabIndex = 59;
            this.lab选择相机提示.Text = "选择相机提示";
            // 
            // cmb相机列表
            // 
            this.cmb相机列表.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb相机列表.FormattingEnabled = true;
            this.cmb相机列表.Location = new System.Drawing.Point(134, 30);
            this.cmb相机列表.Name = "cmb相机列表";
            this.cmb相机列表.Size = new System.Drawing.Size(204, 26);
            this.cmb相机列表.TabIndex = 48;
            this.cmb相机列表.SelectedIndexChanged += new System.EventHandler(this.cmb相机列表_SelectedIndexChanged);
            this.cmb相机列表.TextChanged += new System.EventHandler(this.cmb相机列表_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "相机名";
            // 
            // btn刷新相机连接
            // 
            this.btn刷新相机连接.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn刷新相机连接.Location = new System.Drawing.Point(390, 81);
            this.btn刷新相机连接.Name = "btn刷新相机连接";
            this.btn刷新相机连接.Size = new System.Drawing.Size(138, 40);
            this.btn刷新相机连接.TabIndex = 66;
            this.btn刷新相机连接.Text = "刷新相机连接";
            this.btn刷新相机连接.UseVisualStyleBackColor = true;
            this.btn刷新相机连接.Visible = false;
            this.btn刷新相机连接.Click += new System.EventHandler(this.btn刷新相机连接_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Spinner等待重连);
            this.groupBox3.Controls.Add(this.cmb相机列表);
            this.groupBox3.Controls.Add(this.chk实时拍照显示);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btn刷新相机连接);
            this.groupBox3.Controls.Add(this.btn获取图片);
            this.groupBox3.Controls.Add(this.lab选择相机提示);
            this.groupBox3.Font = new System.Drawing.Font("华文楷体", 12F);
            this.groupBox3.Location = new System.Drawing.Point(815, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 158);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "相机源选择";
            // 
            // Spinner等待重连
            // 
            this.Spinner等待重连.Location = new System.Drawing.Point(531, 81);
            this.Spinner等待重连.Maximum = 100;
            this.Spinner等待重连.Name = "Spinner等待重连";
            this.Spinner等待重连.Size = new System.Drawing.Size(40, 40);
            this.Spinner等待重连.TabIndex = 67;
            this.Spinner等待重连.UseSelectable = true;
            this.Spinner等待重连.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt相机曝光值);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lab相机曝光值提示);
            this.groupBox2.Font = new System.Drawing.Font("华文楷体", 12F);
            this.groupBox2.Location = new System.Drawing.Point(815, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 153);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "相机参数设置";
            // 
            // 相机配置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn返回);
            this.Controls.Add(this.btn保存设置);
            this.Controls.Add(this.pictureBox1);
            this.Name = "相机配置";
            this.Size = new System.Drawing.Size(1456, 741);
            this.Load += new System.EventHandler(this.相机配置_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn添加当前图片关联相机;
        private System.Windows.Forms.Label lab相机曝光值提示;
        private System.Windows.Forms.Label lab关联图片数量;
        private System.Windows.Forms.Button btn添加本地图片关联相机;
        private System.Windows.Forms.Button btn获取图片;
        private System.Windows.Forms.TextBox txt相机曝光值;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn保存设置;
        private System.Windows.Forms.Button btn返回;
        private System.Windows.Forms.CheckBox chk实时拍照显示;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn显示样本图片;
        private System.Windows.Forms.Label lab选择相机提示;
        private System.Windows.Forms.ComboBox cmb相机列表;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn刷新相机连接;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt样本图片保存路径;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroProgressSpinner Spinner等待重连;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
