namespace LSVisionMod.View.模板步骤
{
    partial class 匹配定位
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo多边形区域 = new System.Windows.Forms.RadioButton();
            this.rdo圆形区域 = new System.Windows.Forms.RadioButton();
            this.rdo矩形区域 = new System.Windows.Forms.RadioButton();
            this.cmb定位模板类型 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn新建区域 = new System.Windows.Forms.Button();
            this.btn添加区域 = new System.Windows.Forms.Button();
            this.btn减少区域 = new System.Windows.Forms.Button();
            this.btn创建模板 = new System.Windows.Forms.Button();
            this.btn撤销上一步 = new System.Windows.Forms.Button();
            this.btn测试模板 = new System.Windows.Forms.Button();
            this.lab模板匹配率 = new System.Windows.Forms.Label();
            this.btn保存设置 = new System.Windows.Forms.Button();
            this.lab关联图片数量 = new System.Windows.Forms.Label();
            this.txt定位模板名称 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lab当前相机 = new System.Windows.Forms.Label();
            this.btn返回 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn获取相机图片 = new System.Windows.Forms.Button();
            this.btn获取本地图片 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo多边形区域);
            this.groupBox1.Controls.Add(this.rdo圆形区域);
            this.groupBox1.Controls.Add(this.rdo矩形区域);
            this.groupBox1.Controls.Add(this.btn新建区域);
            this.groupBox1.Controls.Add(this.btn撤销上一步);
            this.groupBox1.Controls.Add(this.btn添加区域);
            this.groupBox1.Controls.Add(this.btn减少区域);
            this.groupBox1.Font = new System.Drawing.Font("华文楷体", 12F);
            this.groupBox1.Location = new System.Drawing.Point(815, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 126);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择定位区域";
            // 
            // rdo多边形区域
            // 
            this.rdo多边形区域.AutoSize = true;
            this.rdo多边形区域.Location = new System.Drawing.Point(324, 35);
            this.rdo多边形区域.Name = "rdo多边形区域";
            this.rdo多边形区域.Size = new System.Drawing.Size(106, 22);
            this.rdo多边形区域.TabIndex = 2;
            this.rdo多边形区域.Text = "多边形区域";
            this.rdo多边形区域.UseVisualStyleBackColor = true;
            // 
            // rdo圆形区域
            // 
            this.rdo圆形区域.AutoSize = true;
            this.rdo圆形区域.Location = new System.Drawing.Point(180, 35);
            this.rdo圆形区域.Name = "rdo圆形区域";
            this.rdo圆形区域.Size = new System.Drawing.Size(90, 22);
            this.rdo圆形区域.TabIndex = 1;
            this.rdo圆形区域.Text = "圆形区域";
            this.rdo圆形区域.UseVisualStyleBackColor = true;
            // 
            // rdo矩形区域
            // 
            this.rdo矩形区域.AutoSize = true;
            this.rdo矩形区域.Checked = true;
            this.rdo矩形区域.Location = new System.Drawing.Point(36, 35);
            this.rdo矩形区域.Name = "rdo矩形区域";
            this.rdo矩形区域.Size = new System.Drawing.Size(90, 22);
            this.rdo矩形区域.TabIndex = 0;
            this.rdo矩形区域.TabStop = true;
            this.rdo矩形区域.Text = "矩形区域";
            this.rdo矩形区域.UseVisualStyleBackColor = true;
            // 
            // cmb定位模板类型
            // 
            this.cmb定位模板类型.Font = new System.Drawing.Font("华文楷体", 12F);
            this.cmb定位模板类型.FormattingEnabled = true;
            this.cmb定位模板类型.Location = new System.Drawing.Point(195, 76);
            this.cmb定位模板类型.Name = "cmb定位模板类型";
            this.cmb定位模板类型.Size = new System.Drawing.Size(223, 26);
            this.cmb定位模板类型.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 12F);
            this.label1.Location = new System.Drawing.Point(74, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "定位模板类型";
            // 
            // btn新建区域
            // 
            this.btn新建区域.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn新建区域.Location = new System.Drawing.Point(36, 68);
            this.btn新建区域.Name = "btn新建区域";
            this.btn新建区域.Size = new System.Drawing.Size(100, 40);
            this.btn新建区域.TabIndex = 74;
            this.btn新建区域.Text = "新建区域";
            this.btn新建区域.UseVisualStyleBackColor = true;
            this.btn新建区域.Click += new System.EventHandler(this.btn新建区域_Click);
            // 
            // btn添加区域
            // 
            this.btn添加区域.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn添加区域.Location = new System.Drawing.Point(169, 68);
            this.btn添加区域.Name = "btn添加区域";
            this.btn添加区域.Size = new System.Drawing.Size(100, 40);
            this.btn添加区域.TabIndex = 75;
            this.btn添加区域.Text = "添加区域";
            this.btn添加区域.UseVisualStyleBackColor = true;
            this.btn添加区域.Click += new System.EventHandler(this.btn添加区域_Click);
            // 
            // btn减少区域
            // 
            this.btn减少区域.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn减少区域.Location = new System.Drawing.Point(302, 68);
            this.btn减少区域.Name = "btn减少区域";
            this.btn减少区域.Size = new System.Drawing.Size(100, 40);
            this.btn减少区域.TabIndex = 76;
            this.btn减少区域.Text = "减少区域";
            this.btn减少区域.UseVisualStyleBackColor = true;
            this.btn减少区域.Click += new System.EventHandler(this.btn减少区域_Click);
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
            // btn撤销上一步
            // 
            this.btn撤销上一步.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn撤销上一步.Location = new System.Drawing.Point(435, 68);
            this.btn撤销上一步.Name = "btn撤销上一步";
            this.btn撤销上一步.Size = new System.Drawing.Size(100, 40);
            this.btn撤销上一步.TabIndex = 77;
            this.btn撤销上一步.Text = "撤销上一步";
            this.btn撤销上一步.UseVisualStyleBackColor = true;
            this.btn撤销上一步.Click += new System.EventHandler(this.btn撤销上一步_Click);
            // 
            // btn测试模板
            // 
            this.btn测试模板.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn测试模板.Location = new System.Drawing.Point(20, 35);
            this.btn测试模板.Name = "btn测试模板";
            this.btn测试模板.Size = new System.Drawing.Size(138, 40);
            this.btn测试模板.TabIndex = 79;
            this.btn测试模板.Text = "测试模板";
            this.btn测试模板.UseVisualStyleBackColor = true;
            this.btn测试模板.Click += new System.EventHandler(this.btn测试模板_Click);
            // 
            // lab模板匹配率
            // 
            this.lab模板匹配率.AutoSize = true;
            this.lab模板匹配率.Font = new System.Drawing.Font("华文楷体", 12F);
            this.lab模板匹配率.Location = new System.Drawing.Point(179, 46);
            this.lab模板匹配率.Name = "lab模板匹配率";
            this.lab模板匹配率.Size = new System.Drawing.Size(88, 18);
            this.lab模板匹配率.TabIndex = 82;
            this.lab模板匹配率.Text = "模板匹配率";
            // 
            // btn保存设置
            // 
            this.btn保存设置.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn保存设置.Location = new System.Drawing.Point(1253, 683);
            this.btn保存设置.Name = "btn保存设置";
            this.btn保存设置.Size = new System.Drawing.Size(138, 40);
            this.btn保存设置.TabIndex = 85;
            this.btn保存设置.Text = "保存设置";
            this.btn保存设置.UseVisualStyleBackColor = true;
            this.btn保存设置.Click += new System.EventHandler(this.btn保存设置_Click);
            // 
            // lab关联图片数量
            // 
            this.lab关联图片数量.AutoSize = true;
            this.lab关联图片数量.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab关联图片数量.Location = new System.Drawing.Point(33, 87);
            this.lab关联图片数量.Name = "lab关联图片数量";
            this.lab关联图片数量.Size = new System.Drawing.Size(104, 18);
            this.lab关联图片数量.TabIndex = 86;
            this.lab关联图片数量.Text = "关联图片数量";
            // 
            // txt定位模板名称
            // 
            this.txt定位模板名称.Font = new System.Drawing.Font("华文楷体", 12F);
            this.txt定位模板名称.Location = new System.Drawing.Point(195, 27);
            this.txt定位模板名称.Name = "txt定位模板名称";
            this.txt定位模板名称.Size = new System.Drawing.Size(223, 28);
            this.txt定位模板名称.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文楷体", 12F);
            this.label3.Location = new System.Drawing.Point(74, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 87;
            this.label3.Text = "定位模板名称";
            // 
            // lab当前相机
            // 
            this.lab当前相机.AutoSize = true;
            this.lab当前相机.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab当前相机.Location = new System.Drawing.Point(33, 32);
            this.lab当前相机.Name = "lab当前相机";
            this.lab当前相机.Size = new System.Drawing.Size(72, 18);
            this.lab当前相机.TabIndex = 89;
            this.lab当前相机.Text = "当前相机";
            // 
            // btn返回
            // 
            this.btn返回.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn返回.Location = new System.Drawing.Point(815, 683);
            this.btn返回.Name = "btn返回";
            this.btn返回.Size = new System.Drawing.Size(138, 40);
            this.btn返回.TabIndex = 90;
            this.btn返回.Text = "返回";
            this.btn返回.UseVisualStyleBackColor = true;
            this.btn返回.Click += new System.EventHandler(this.btn返回_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt定位模板名称);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmb定位模板类型);
            this.groupBox2.Font = new System.Drawing.Font("华文楷体", 12F);
            this.groupBox2.Location = new System.Drawing.Point(815, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 125);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "定位模板初始化";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn获取相机图片);
            this.groupBox3.Controls.Add(this.btn获取本地图片);
            this.groupBox3.Controls.Add(this.lab当前相机);
            this.groupBox3.Controls.Add(this.lab关联图片数量);
            this.groupBox3.Font = new System.Drawing.Font("华文楷体", 12F);
            this.groupBox3.Location = new System.Drawing.Point(815, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 132);
            this.groupBox3.TabIndex = 92;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "图片获取";
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
            // btn获取本地图片
            // 
            this.btn获取本地图片.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn获取本地图片.Location = new System.Drawing.Point(373, 76);
            this.btn获取本地图片.Name = "btn获取本地图片";
            this.btn获取本地图片.Size = new System.Drawing.Size(138, 40);
            this.btn获取本地图片.TabIndex = 70;
            this.btn获取本地图片.Text = "获取本地图片";
            this.btn获取本地图片.UseVisualStyleBackColor = true;
            this.btn获取本地图片.Click += new System.EventHandler(this.btn获取本地图片_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn创建模板);
            this.groupBox4.Font = new System.Drawing.Font("华文楷体", 12F);
            this.groupBox4.Location = new System.Drawing.Point(815, 439);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(209, 100);
            this.groupBox4.TabIndex = 93;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "定位模板创建";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn测试模板);
            this.groupBox5.Controls.Add(this.lab模板匹配率);
            this.groupBox5.Font = new System.Drawing.Font("华文楷体", 12F);
            this.groupBox5.Location = new System.Drawing.Point(1046, 439);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(345, 100);
            this.groupBox5.TabIndex = 94;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "定位模板测试";
            // 
            // 匹配定位
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn返回);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn保存设置);
            this.Controls.Add(this.groupBox1);
            this.Name = "匹配定位";
            this.Size = new System.Drawing.Size(1456, 741);
            this.Load += new System.EventHandler(this.匹配定位_Load);
            this.Enter += new System.EventHandler(this.匹配定位_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo多边形区域;
        private System.Windows.Forms.RadioButton rdo圆形区域;
        private System.Windows.Forms.RadioButton rdo矩形区域;
        private System.Windows.Forms.ComboBox cmb定位模板类型;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn新建区域;
        private System.Windows.Forms.Button btn添加区域;
        private System.Windows.Forms.Button btn减少区域;
        private System.Windows.Forms.Button btn创建模板;
        private System.Windows.Forms.Button btn撤销上一步;
        private System.Windows.Forms.Button btn测试模板;
        private System.Windows.Forms.Label lab模板匹配率;
        private System.Windows.Forms.Button btn保存设置;
        private System.Windows.Forms.Label lab关联图片数量;
        private System.Windows.Forms.TextBox txt定位模板名称;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab当前相机;
        private System.Windows.Forms.Button btn返回;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn获取相机图片;
        private System.Windows.Forms.Button btn获取本地图片;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}
