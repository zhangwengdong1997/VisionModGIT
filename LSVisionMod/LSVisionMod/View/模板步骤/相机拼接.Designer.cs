namespace LSVisionMod.View.模板步骤
{
    partial class 相机拼接
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
            this.grp相机源选择 = new System.Windows.Forms.GroupBox();
            this.txt定位模板名称 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn获取相机图片 = new System.Windows.Forms.Button();
            this.cmb相机列表2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lablab选择相机提示1 = new System.Windows.Forms.Label();
            this.cmb相机列表1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab选择相机提示1 = new System.Windows.Forms.Label();
            this.grp拼接参数设置 = new System.Windows.Forms.GroupBox();
            this.txt匹配灰度差 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lab匹配灰度差提示 = new System.Windows.Forms.Label();
            this.txt点分割 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lab点分割提示 = new System.Windows.Forms.Label();
            this.txt区域分割 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lab区域分割提示 = new System.Windows.Forms.Label();
            this.txt高斯平滑值 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lab高斯平滑值提示 = new System.Windows.Forms.Label();
            this.btn返回 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn保存设置 = new System.Windows.Forms.Button();
            this.btn测试拼接 = new System.Windows.Forms.Button();
            this.grp定位模板测试 = new System.Windows.Forms.GroupBox();
            this.lab拼接匹配率 = new System.Windows.Forms.Label();
            this.grp拼接模板创建 = new System.Windows.Forms.GroupBox();
            this.btn创建模板 = new System.Windows.Forms.Button();
            this.grp相机源选择.SuspendLayout();
            this.grp拼接参数设置.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grp定位模板测试.SuspendLayout();
            this.grp拼接模板创建.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp相机源选择
            // 
            this.grp相机源选择.Controls.Add(this.txt定位模板名称);
            this.grp相机源选择.Controls.Add(this.label5);
            this.grp相机源选择.Controls.Add(this.btn获取相机图片);
            this.grp相机源选择.Controls.Add(this.cmb相机列表2);
            this.grp相机源选择.Controls.Add(this.label4);
            this.grp相机源选择.Controls.Add(this.lablab选择相机提示1);
            this.grp相机源选择.Controls.Add(this.cmb相机列表1);
            this.grp相机源选择.Controls.Add(this.label1);
            this.grp相机源选择.Controls.Add(this.lab选择相机提示1);
            this.grp相机源选择.Font = new System.Drawing.Font("华文楷体", 12F);
            this.grp相机源选择.Location = new System.Drawing.Point(838, 19);
            this.grp相机源选择.Name = "grp相机源选择";
            this.grp相机源选择.Size = new System.Drawing.Size(576, 241);
            this.grp相机源选择.TabIndex = 73;
            this.grp相机源选择.TabStop = false;
            this.grp相机源选择.Text = "拼接模板初始化";
            // 
            // txt定位模板名称
            // 
            this.txt定位模板名称.Font = new System.Drawing.Font("华文楷体", 12F);
            this.txt定位模板名称.Location = new System.Drawing.Point(163, 44);
            this.txt定位模板名称.Name = "txt定位模板名称";
            this.txt定位模板名称.Size = new System.Drawing.Size(223, 28);
            this.txt定位模板名称.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文楷体", 12F);
            this.label5.Location = new System.Drawing.Point(42, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 89;
            this.label5.Text = "拼接模板名称";
            // 
            // btn获取相机图片
            // 
            this.btn获取相机图片.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn获取相机图片.Location = new System.Drawing.Point(392, 172);
            this.btn获取相机图片.Name = "btn获取相机图片";
            this.btn获取相机图片.Size = new System.Drawing.Size(138, 40);
            this.btn获取相机图片.TabIndex = 68;
            this.btn获取相机图片.Text = "获取相机图片";
            this.btn获取相机图片.UseVisualStyleBackColor = true;
            // 
            // cmb相机列表2
            // 
            this.cmb相机列表2.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb相机列表2.FormattingEnabled = true;
            this.cmb相机列表2.Location = new System.Drawing.Point(163, 133);
            this.cmb相机列表2.Name = "cmb相机列表2";
            this.cmb相机列表2.Size = new System.Drawing.Size(223, 26);
            this.cmb相机列表2.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(87, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "相机2";
            // 
            // lablab选择相机提示1
            // 
            this.lablab选择相机提示1.AutoSize = true;
            this.lablab选择相机提示1.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lablab选择相机提示1.Location = new System.Drawing.Point(410, 136);
            this.lablab选择相机提示1.Name = "lablab选择相机提示1";
            this.lablab选择相机提示1.Size = new System.Drawing.Size(104, 18);
            this.lablab选择相机提示1.TabIndex = 62;
            this.lablab选择相机提示1.Text = "选择相机提示";
            // 
            // cmb相机列表1
            // 
            this.cmb相机列表1.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb相机列表1.FormattingEnabled = true;
            this.cmb相机列表1.Location = new System.Drawing.Point(163, 88);
            this.cmb相机列表1.Name = "cmb相机列表1";
            this.cmb相机列表1.Size = new System.Drawing.Size(223, 26);
            this.cmb相机列表1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(87, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "相机1";
            // 
            // lab选择相机提示1
            // 
            this.lab选择相机提示1.AutoSize = true;
            this.lab选择相机提示1.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab选择相机提示1.Location = new System.Drawing.Point(410, 91);
            this.lab选择相机提示1.Name = "lab选择相机提示1";
            this.lab选择相机提示1.Size = new System.Drawing.Size(104, 18);
            this.lab选择相机提示1.TabIndex = 59;
            this.lab选择相机提示1.Text = "选择相机提示";
            // 
            // grp拼接参数设置
            // 
            this.grp拼接参数设置.Controls.Add(this.txt匹配灰度差);
            this.grp拼接参数设置.Controls.Add(this.label8);
            this.grp拼接参数设置.Controls.Add(this.lab匹配灰度差提示);
            this.grp拼接参数设置.Controls.Add(this.txt点分割);
            this.grp拼接参数设置.Controls.Add(this.label6);
            this.grp拼接参数设置.Controls.Add(this.lab点分割提示);
            this.grp拼接参数设置.Controls.Add(this.txt区域分割);
            this.grp拼接参数设置.Controls.Add(this.label3);
            this.grp拼接参数设置.Controls.Add(this.lab区域分割提示);
            this.grp拼接参数设置.Controls.Add(this.txt高斯平滑值);
            this.grp拼接参数设置.Controls.Add(this.label2);
            this.grp拼接参数设置.Controls.Add(this.lab高斯平滑值提示);
            this.grp拼接参数设置.Font = new System.Drawing.Font("华文楷体", 12F);
            this.grp拼接参数设置.Location = new System.Drawing.Point(838, 286);
            this.grp拼接参数设置.Name = "grp拼接参数设置";
            this.grp拼接参数设置.Size = new System.Drawing.Size(576, 222);
            this.grp拼接参数设置.TabIndex = 72;
            this.grp拼接参数设置.TabStop = false;
            this.grp拼接参数设置.Text = "拼接参数设置";
            // 
            // txt匹配灰度差
            // 
            this.txt匹配灰度差.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt匹配灰度差.Location = new System.Drawing.Point(134, 169);
            this.txt匹配灰度差.Name = "txt匹配灰度差";
            this.txt匹配灰度差.Size = new System.Drawing.Size(252, 28);
            this.txt匹配灰度差.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(18, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 68;
            this.label8.Text = "匹配灰度差";
            // 
            // lab匹配灰度差提示
            // 
            this.lab匹配灰度差提示.AutoSize = true;
            this.lab匹配灰度差提示.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab匹配灰度差提示.Location = new System.Drawing.Point(410, 172);
            this.lab匹配灰度差提示.Name = "lab匹配灰度差提示";
            this.lab匹配灰度差提示.Size = new System.Drawing.Size(120, 18);
            this.lab匹配灰度差提示.TabIndex = 70;
            this.lab匹配灰度差提示.Text = "匹配灰度差提示";
            // 
            // txt点分割
            // 
            this.txt点分割.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt点分割.Location = new System.Drawing.Point(134, 126);
            this.txt点分割.Name = "txt点分割";
            this.txt点分割.Size = new System.Drawing.Size(252, 28);
            this.txt点分割.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(50, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 65;
            this.label6.Text = "点分割";
            // 
            // lab点分割提示
            // 
            this.lab点分割提示.AutoSize = true;
            this.lab点分割提示.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab点分割提示.Location = new System.Drawing.Point(410, 129);
            this.lab点分割提示.Name = "lab点分割提示";
            this.lab点分割提示.Size = new System.Drawing.Size(88, 18);
            this.lab点分割提示.TabIndex = 67;
            this.lab点分割提示.Text = "点分割提示";
            // 
            // txt区域分割
            // 
            this.txt区域分割.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt区域分割.Location = new System.Drawing.Point(134, 83);
            this.txt区域分割.Name = "txt区域分割";
            this.txt区域分割.Size = new System.Drawing.Size(252, 28);
            this.txt区域分割.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(34, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 62;
            this.label3.Text = "区域分割";
            // 
            // lab区域分割提示
            // 
            this.lab区域分割提示.AutoSize = true;
            this.lab区域分割提示.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab区域分割提示.Location = new System.Drawing.Point(410, 86);
            this.lab区域分割提示.Name = "lab区域分割提示";
            this.lab区域分割提示.Size = new System.Drawing.Size(104, 18);
            this.lab区域分割提示.TabIndex = 64;
            this.lab区域分割提示.Text = "区域分割提示";
            // 
            // txt高斯平滑值
            // 
            this.txt高斯平滑值.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt高斯平滑值.Location = new System.Drawing.Point(134, 40);
            this.txt高斯平滑值.Name = "txt高斯平滑值";
            this.txt高斯平滑值.Size = new System.Drawing.Size(252, 28);
            this.txt高斯平滑值.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(34, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 59;
            this.label2.Text = "高斯平滑";
            // 
            // lab高斯平滑值提示
            // 
            this.lab高斯平滑值提示.AutoSize = true;
            this.lab高斯平滑值提示.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab高斯平滑值提示.Location = new System.Drawing.Point(410, 43);
            this.lab高斯平滑值提示.Name = "lab高斯平滑值提示";
            this.lab高斯平滑值提示.Size = new System.Drawing.Size(120, 18);
            this.lab高斯平滑值提示.TabIndex = 61;
            this.lab高斯平滑值提示.Text = "高斯平滑值提示";
            // 
            // btn返回
            // 
            this.btn返回.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn返回.Location = new System.Drawing.Point(838, 682);
            this.btn返回.Name = "btn返回";
            this.btn返回.Size = new System.Drawing.Size(138, 40);
            this.btn返回.TabIndex = 70;
            this.btn返回.Text = "返回";
            this.btn返回.UseVisualStyleBackColor = true;
            this.btn返回.Click += new System.EventHandler(this.btn返回_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 703);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // btn保存设置
            // 
            this.btn保存设置.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn保存设置.Location = new System.Drawing.Point(1276, 682);
            this.btn保存设置.Name = "btn保存设置";
            this.btn保存设置.Size = new System.Drawing.Size(138, 40);
            this.btn保存设置.TabIndex = 69;
            this.btn保存设置.Text = "保存设置";
            this.btn保存设置.UseVisualStyleBackColor = true;
            this.btn保存设置.Click += new System.EventHandler(this.btn保存设置_Click);
            // 
            // btn测试拼接
            // 
            this.btn测试拼接.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn测试拼接.Location = new System.Drawing.Point(17, 39);
            this.btn测试拼接.Name = "btn测试拼接";
            this.btn测试拼接.Size = new System.Drawing.Size(138, 40);
            this.btn测试拼接.TabIndex = 72;
            this.btn测试拼接.Text = "测试拼接";
            this.btn测试拼接.UseVisualStyleBackColor = true;
            // 
            // grp定位模板测试
            // 
            this.grp定位模板测试.Controls.Add(this.lab拼接匹配率);
            this.grp定位模板测试.Controls.Add(this.btn测试拼接);
            this.grp定位模板测试.Font = new System.Drawing.Font("华文楷体", 12F);
            this.grp定位模板测试.Location = new System.Drawing.Point(1069, 536);
            this.grp定位模板测试.Name = "grp定位模板测试";
            this.grp定位模板测试.Size = new System.Drawing.Size(345, 100);
            this.grp定位模板测试.TabIndex = 96;
            this.grp定位模板测试.TabStop = false;
            this.grp定位模板测试.Text = "拼接模板测试";
            // 
            // lab拼接匹配率
            // 
            this.lab拼接匹配率.AutoSize = true;
            this.lab拼接匹配率.Font = new System.Drawing.Font("华文楷体", 12F);
            this.lab拼接匹配率.Location = new System.Drawing.Point(179, 50);
            this.lab拼接匹配率.Name = "lab拼接匹配率";
            this.lab拼接匹配率.Size = new System.Drawing.Size(88, 18);
            this.lab拼接匹配率.TabIndex = 82;
            this.lab拼接匹配率.Text = "拼接匹配率";
            // 
            // grp拼接模板创建
            // 
            this.grp拼接模板创建.Controls.Add(this.btn创建模板);
            this.grp拼接模板创建.Font = new System.Drawing.Font("华文楷体", 12F);
            this.grp拼接模板创建.Location = new System.Drawing.Point(838, 536);
            this.grp拼接模板创建.Name = "grp拼接模板创建";
            this.grp拼接模板创建.Size = new System.Drawing.Size(209, 100);
            this.grp拼接模板创建.TabIndex = 95;
            this.grp拼接模板创建.TabStop = false;
            this.grp拼接模板创建.Text = "拼接模板创建";
            // 
            // btn创建模板
            // 
            this.btn创建模板.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn创建模板.Location = new System.Drawing.Point(35, 39);
            this.btn创建模板.Name = "btn创建模板";
            this.btn创建模板.Size = new System.Drawing.Size(138, 40);
            this.btn创建模板.TabIndex = 78;
            this.btn创建模板.Text = "创建模板";
            this.btn创建模板.UseVisualStyleBackColor = true;
            this.btn创建模板.Click += new System.EventHandler(this.btn创建模板_Click);
            // 
            // 相机拼接
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grp定位模板测试);
            this.Controls.Add(this.grp拼接模板创建);
            this.Controls.Add(this.grp相机源选择);
            this.Controls.Add(this.grp拼接参数设置);
            this.Controls.Add(this.btn返回);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn保存设置);
            this.Name = "相机拼接";
            this.Size = new System.Drawing.Size(1456, 741);
            this.Load += new System.EventHandler(this.相机拼接_Load);
            this.grp相机源选择.ResumeLayout(false);
            this.grp相机源选择.PerformLayout();
            this.grp拼接参数设置.ResumeLayout(false);
            this.grp拼接参数设置.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grp定位模板测试.ResumeLayout(false);
            this.grp定位模板测试.PerformLayout();
            this.grp拼接模板创建.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp相机源选择;
        private System.Windows.Forms.ComboBox cmb相机列表2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lablab选择相机提示1;
        private System.Windows.Forms.ComboBox cmb相机列表1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab选择相机提示1;
        private System.Windows.Forms.GroupBox grp拼接参数设置;
        private System.Windows.Forms.Button btn返回;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn保存设置;
        private System.Windows.Forms.Button btn获取相机图片;
        private System.Windows.Forms.TextBox txt高斯平滑值;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab高斯平滑值提示;
        private System.Windows.Forms.TextBox txt区域分割;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab区域分割提示;
        private System.Windows.Forms.TextBox txt匹配灰度差;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab匹配灰度差提示;
        private System.Windows.Forms.TextBox txt点分割;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab点分割提示;
        private System.Windows.Forms.Button btn测试拼接;
        private System.Windows.Forms.GroupBox grp定位模板测试;
        private System.Windows.Forms.Label lab拼接匹配率;
        private System.Windows.Forms.GroupBox grp拼接模板创建;
        private System.Windows.Forms.Button btn创建模板;
        private System.Windows.Forms.TextBox txt定位模板名称;
        private System.Windows.Forms.Label label5;
    }
}
