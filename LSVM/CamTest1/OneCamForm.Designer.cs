namespace CamTest1
{
    partial class OneCamForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picMain = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn加载模块 = new System.Windows.Forms.Button();
            this.cmb相机品牌 = new System.Windows.Forms.ComboBox();
            this.grp连接相机 = new System.Windows.Forms.GroupBox();
            this.btn断开连接 = new System.Windows.Forms.Button();
            this.btn连接相机 = new System.Windows.Forms.Button();
            this.cmb相机名 = new System.Windows.Forms.ComboBox();
            this.lab当前相机 = new System.Windows.Forms.Label();
            this.btn触发一次 = new System.Windows.Forms.Button();
            this.grp拍照 = new System.Windows.Forms.GroupBox();
            this.btn实时拍照 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grp连接相机.SuspendLayout();
            this.grp拍照.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.Location = new System.Drawing.Point(12, 12);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(600, 600);
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn加载模块);
            this.groupBox1.Controls.Add(this.cmb相机品牌);
            this.groupBox1.Location = new System.Drawing.Point(640, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择相机品牌";
            // 
            // btn加载模块
            // 
            this.btn加载模块.Location = new System.Drawing.Point(28, 69);
            this.btn加载模块.Name = "btn加载模块";
            this.btn加载模块.Size = new System.Drawing.Size(254, 37);
            this.btn加载模块.TabIndex = 1;
            this.btn加载模块.Text = "加载模块";
            this.btn加载模块.UseVisualStyleBackColor = true;
            this.btn加载模块.Click += new System.EventHandler(this.Btn加载模块_Click);
            // 
            // cmb相机品牌
            // 
            this.cmb相机品牌.FormattingEnabled = true;
            this.cmb相机品牌.Location = new System.Drawing.Point(28, 32);
            this.cmb相机品牌.Name = "cmb相机品牌";
            this.cmb相机品牌.Size = new System.Drawing.Size(254, 20);
            this.cmb相机品牌.TabIndex = 0;
            // 
            // grp连接相机
            // 
            this.grp连接相机.Controls.Add(this.btn断开连接);
            this.grp连接相机.Controls.Add(this.btn连接相机);
            this.grp连接相机.Controls.Add(this.cmb相机名);
            this.grp连接相机.Location = new System.Drawing.Point(640, 161);
            this.grp连接相机.Name = "grp连接相机";
            this.grp连接相机.Size = new System.Drawing.Size(303, 182);
            this.grp连接相机.TabIndex = 2;
            this.grp连接相机.TabStop = false;
            this.grp连接相机.Text = "连接相机";
            // 
            // btn断开连接
            // 
            this.btn断开连接.Location = new System.Drawing.Point(28, 125);
            this.btn断开连接.Name = "btn断开连接";
            this.btn断开连接.Size = new System.Drawing.Size(254, 37);
            this.btn断开连接.TabIndex = 4;
            this.btn断开连接.Text = "断开连接";
            this.btn断开连接.UseVisualStyleBackColor = true;
            this.btn断开连接.Click += new System.EventHandler(this.Btn断开连接_Click);
            // 
            // btn连接相机
            // 
            this.btn连接相机.Location = new System.Drawing.Point(28, 73);
            this.btn连接相机.Name = "btn连接相机";
            this.btn连接相机.Size = new System.Drawing.Size(254, 37);
            this.btn连接相机.TabIndex = 2;
            this.btn连接相机.Text = "连接相机";
            this.btn连接相机.UseVisualStyleBackColor = true;
            this.btn连接相机.Click += new System.EventHandler(this.Btn连接相机_Click);
            // 
            // cmb相机名
            // 
            this.cmb相机名.FormattingEnabled = true;
            this.cmb相机名.Location = new System.Drawing.Point(28, 34);
            this.cmb相机名.Name = "cmb相机名";
            this.cmb相机名.Size = new System.Drawing.Size(254, 20);
            this.cmb相机名.TabIndex = 1;
            // 
            // lab当前相机
            // 
            this.lab当前相机.AutoSize = true;
            this.lab当前相机.BackColor = System.Drawing.Color.Transparent;
            this.lab当前相机.Location = new System.Drawing.Point(12, 12);
            this.lab当前相机.Name = "lab当前相机";
            this.lab当前相机.Size = new System.Drawing.Size(53, 12);
            this.lab当前相机.TabIndex = 3;
            this.lab当前相机.Text = "当前相机";
            // 
            // btn触发一次
            // 
            this.btn触发一次.Location = new System.Drawing.Point(28, 37);
            this.btn触发一次.Name = "btn触发一次";
            this.btn触发一次.Size = new System.Drawing.Size(254, 37);
            this.btn触发一次.TabIndex = 3;
            this.btn触发一次.Text = "触发一次";
            this.btn触发一次.UseVisualStyleBackColor = true;
            this.btn触发一次.Click += new System.EventHandler(this.Btn触发一次_Click);
            // 
            // grp拍照
            // 
            this.grp拍照.Controls.Add(this.btn实时拍照);
            this.grp拍照.Controls.Add(this.btn触发一次);
            this.grp拍照.Location = new System.Drawing.Point(640, 367);
            this.grp拍照.Name = "grp拍照";
            this.grp拍照.Size = new System.Drawing.Size(303, 160);
            this.grp拍照.TabIndex = 4;
            this.grp拍照.TabStop = false;
            this.grp拍照.Text = "拍照";
            // 
            // btn实时拍照
            // 
            this.btn实时拍照.Location = new System.Drawing.Point(28, 93);
            this.btn实时拍照.Name = "btn实时拍照";
            this.btn实时拍照.Size = new System.Drawing.Size(254, 37);
            this.btn实时拍照.TabIndex = 4;
            this.btn实时拍照.Text = "实时拍照";
            this.btn实时拍照.UseVisualStyleBackColor = true;
            this.btn实时拍照.Click += new System.EventHandler(this.Btn实时拍照_Click);
            // 
            // OneCamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 620);
            this.Controls.Add(this.grp拍照);
            this.Controls.Add(this.lab当前相机);
            this.Controls.Add(this.grp连接相机);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picMain);
            this.Name = "OneCamForm";
            this.Text = "相机模块测试（单相机）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OneCamForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grp连接相机.ResumeLayout(false);
            this.grp拍照.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb相机品牌;
        private System.Windows.Forms.Button btn加载模块;
        private System.Windows.Forms.GroupBox grp连接相机;
        private System.Windows.Forms.ComboBox cmb相机名;
        private System.Windows.Forms.Button btn连接相机;
        private System.Windows.Forms.Label lab当前相机;
        private System.Windows.Forms.Button btn触发一次;
        private System.Windows.Forms.Button btn断开连接;
        private System.Windows.Forms.GroupBox grp拍照;
        private System.Windows.Forms.Button btn实时拍照;
    }
}

