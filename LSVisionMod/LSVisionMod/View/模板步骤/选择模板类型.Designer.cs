namespace LSVisionMod.View.模板步骤
{
    partial class 选择模板类型
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
            this.btn默认 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn删除 = new System.Windows.Forms.Button();
            this.btn添加检测项 = new System.Windows.Forms.Button();
            this.btn添加相机 = new System.Windows.Forms.Button();
            this.btn保存模板 = new System.Windows.Forms.Button();
            this.tvwSteps = new System.Windows.Forms.TreeView();
            this.btn添加匹配定位 = new System.Windows.Forms.Button();
            this.grp模板检测流程 = new System.Windows.Forms.GroupBox();
            this.grp常用检测流程 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grp编辑检测流程 = new System.Windows.Forms.GroupBox();
            this.txt模板名称 = new System.Windows.Forms.TextBox();
            this.btn模板名确认 = new System.Windows.Forms.Button();
            this.lab模板名称提示 = new System.Windows.Forms.Label();
            this.grp模板检测流程.SuspendLayout();
            this.grp常用检测流程.SuspendLayout();
            this.grp编辑检测流程.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn默认
            // 
            this.btn默认.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn默认.Location = new System.Drawing.Point(26, 50);
            this.btn默认.Name = "btn默认";
            this.btn默认.Size = new System.Drawing.Size(276, 47);
            this.btn默认.TabIndex = 0;
            this.btn默认.Text = "机型1";
            this.btn默认.UseVisualStyleBackColor = true;
            this.btn默认.Click += new System.EventHandler(this.btn默认_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文楷体", 22F);
            this.label4.Location = new System.Drawing.Point(434, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 34);
            this.label4.TabIndex = 40;
            this.label4.Text = "模板名称";
            // 
            // btn删除
            // 
            this.btn删除.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn删除.Location = new System.Drawing.Point(73, 297);
            this.btn删除.Name = "btn删除";
            this.btn删除.Size = new System.Drawing.Size(195, 42);
            this.btn删除.TabIndex = 50;
            this.btn删除.Text = "删除";
            this.btn删除.UseVisualStyleBackColor = true;
            this.btn删除.Click += new System.EventHandler(this.btn撤销_Click);
            // 
            // btn添加检测项
            // 
            this.btn添加检测项.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn添加检测项.Location = new System.Drawing.Point(73, 213);
            this.btn添加检测项.Name = "btn添加检测项";
            this.btn添加检测项.Size = new System.Drawing.Size(195, 42);
            this.btn添加检测项.TabIndex = 49;
            this.btn添加检测项.Text = "添加检测项";
            this.btn添加检测项.UseVisualStyleBackColor = true;
            this.btn添加检测项.Click += new System.EventHandler(this.btn添加检测项_Click);
            // 
            // btn添加相机
            // 
            this.btn添加相机.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn添加相机.Location = new System.Drawing.Point(73, 45);
            this.btn添加相机.Name = "btn添加相机";
            this.btn添加相机.Size = new System.Drawing.Size(195, 42);
            this.btn添加相机.TabIndex = 46;
            this.btn添加相机.Text = "添加相机";
            this.btn添加相机.UseVisualStyleBackColor = true;
            this.btn添加相机.Click += new System.EventHandler(this.btn添加相机_Click);
            // 
            // btn保存模板
            // 
            this.btn保存模板.Font = new System.Drawing.Font("华文楷体", 22F);
            this.btn保存模板.Location = new System.Drawing.Point(1110, 620);
            this.btn保存模板.Name = "btn保存模板";
            this.btn保存模板.Size = new System.Drawing.Size(270, 71);
            this.btn保存模板.TabIndex = 51;
            this.btn保存模板.Text = "保存模板";
            this.btn保存模板.UseVisualStyleBackColor = true;
            this.btn保存模板.Click += new System.EventHandler(this.btn保存模板_Click);
            // 
            // tvwSteps
            // 
            this.tvwSteps.AllowDrop = true;
            this.tvwSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwSteps.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvwSteps.Location = new System.Drawing.Point(3, 24);
            this.tvwSteps.Name = "tvwSteps";
            this.tvwSteps.ShowLines = false;
            this.tvwSteps.Size = new System.Drawing.Size(624, 582);
            this.tvwSteps.TabIndex = 52;
            this.tvwSteps.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwSteps_AfterSelect);
            this.tvwSteps.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwSteps_NodeMouseDoubleClick);
            // 
            // btn添加匹配定位
            // 
            this.btn添加匹配定位.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn添加匹配定位.Location = new System.Drawing.Point(73, 129);
            this.btn添加匹配定位.Name = "btn添加匹配定位";
            this.btn添加匹配定位.Size = new System.Drawing.Size(195, 42);
            this.btn添加匹配定位.TabIndex = 53;
            this.btn添加匹配定位.Text = "添加匹配定位";
            this.btn添加匹配定位.UseVisualStyleBackColor = true;
            this.btn添加匹配定位.Click += new System.EventHandler(this.btn添加匹配定位_Click);
            // 
            // grp模板检测流程
            // 
            this.grp模板检测流程.Controls.Add(this.tvwSteps);
            this.grp模板检测流程.Font = new System.Drawing.Font("华文楷体", 12F);
            this.grp模板检测流程.Location = new System.Drawing.Point(411, 107);
            this.grp模板检测流程.Name = "grp模板检测流程";
            this.grp模板检测流程.Size = new System.Drawing.Size(630, 609);
            this.grp模板检测流程.TabIndex = 54;
            this.grp模板检测流程.TabStop = false;
            this.grp模板检测流程.Text = "模板检测流程";
            // 
            // grp常用检测流程
            // 
            this.grp常用检测流程.Controls.Add(this.button2);
            this.grp常用检测流程.Controls.Add(this.button1);
            this.grp常用检测流程.Controls.Add(this.btn默认);
            this.grp常用检测流程.Font = new System.Drawing.Font("华文楷体", 12F);
            this.grp常用检测流程.Location = new System.Drawing.Point(48, 108);
            this.grp常用检测流程.Name = "grp常用检测流程";
            this.grp常用检测流程.Size = new System.Drawing.Size(334, 605);
            this.grp常用检测流程.TabIndex = 55;
            this.grp常用检测流程.TabStop = false;
            this.grp常用检测流程.Text = "常用检测流程";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("华文楷体", 12F);
            this.button2.Location = new System.Drawing.Point(26, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "机型3";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("华文楷体", 12F);
            this.button1.Location = new System.Drawing.Point(26, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "机型2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grp编辑检测流程
            // 
            this.grp编辑检测流程.Controls.Add(this.btn添加检测项);
            this.grp编辑检测流程.Controls.Add(this.btn添加相机);
            this.grp编辑检测流程.Controls.Add(this.btn删除);
            this.grp编辑检测流程.Controls.Add(this.btn添加匹配定位);
            this.grp编辑检测流程.Font = new System.Drawing.Font("华文楷体", 12F);
            this.grp编辑检测流程.Location = new System.Drawing.Point(1073, 108);
            this.grp编辑检测流程.Name = "grp编辑检测流程";
            this.grp编辑检测流程.Size = new System.Drawing.Size(328, 381);
            this.grp编辑检测流程.TabIndex = 56;
            this.grp编辑检测流程.TabStop = false;
            this.grp编辑检测流程.Text = "编辑检测流程";
            // 
            // txt模板名称
            // 
            this.txt模板名称.Font = new System.Drawing.Font("微软雅黑", 17F);
            this.txt模板名称.Location = new System.Drawing.Point(601, 43);
            this.txt模板名称.Name = "txt模板名称";
            this.txt模板名称.Size = new System.Drawing.Size(389, 37);
            this.txt模板名称.TabIndex = 41;
            this.txt模板名称.TextChanged += new System.EventHandler(this.txt模板名称_TextChanged);
            // 
            // btn模板名确认
            // 
            this.btn模板名确认.Font = new System.Drawing.Font("华文楷体", 12F);
            this.btn模板名确认.Location = new System.Drawing.Point(1030, 44);
            this.btn模板名确认.Name = "btn模板名确认";
            this.btn模板名确认.Size = new System.Drawing.Size(134, 36);
            this.btn模板名确认.TabIndex = 54;
            this.btn模板名确认.Text = "确认";
            this.btn模板名确认.UseVisualStyleBackColor = true;
            this.btn模板名确认.Click += new System.EventHandler(this.btn模板名确认_Click);
            // 
            // lab模板名称提示
            // 
            this.lab模板名称提示.AutoSize = true;
            this.lab模板名称提示.Font = new System.Drawing.Font("华文楷体", 12F);
            this.lab模板名称提示.Location = new System.Drawing.Point(1183, 53);
            this.lab模板名称提示.Name = "lab模板名称提示";
            this.lab模板名称提示.Size = new System.Drawing.Size(104, 18);
            this.lab模板名称提示.TabIndex = 57;
            this.lab模板名称提示.Text = "模板名称提示";
            // 
            // 选择模板类型
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lab模板名称提示);
            this.Controls.Add(this.btn模板名确认);
            this.Controls.Add(this.txt模板名称);
            this.Controls.Add(this.grp编辑检测流程);
            this.Controls.Add(this.grp常用检测流程);
            this.Controls.Add(this.grp模板检测流程);
            this.Controls.Add(this.btn保存模板);
            this.Controls.Add(this.label4);
            this.Name = "选择模板类型";
            this.Size = new System.Drawing.Size(1456, 741);
            this.Load += new System.EventHandler(this.选择模板类型_Load);
            this.grp模板检测流程.ResumeLayout(false);
            this.grp常用检测流程.ResumeLayout(false);
            this.grp编辑检测流程.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn默认;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn删除;
        private System.Windows.Forms.Button btn添加检测项;
        private System.Windows.Forms.Button btn添加相机;
        private System.Windows.Forms.Button btn保存模板;
        private System.Windows.Forms.TreeView tvwSteps;
        private System.Windows.Forms.Button btn添加匹配定位;
        private System.Windows.Forms.GroupBox grp模板检测流程;
        private System.Windows.Forms.GroupBox grp常用检测流程;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grp编辑检测流程;
        private System.Windows.Forms.TextBox txt模板名称;
        private System.Windows.Forms.Button btn模板名确认;
        private System.Windows.Forms.Label lab模板名称提示;
    }
}
