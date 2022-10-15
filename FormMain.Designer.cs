namespace YuanChuang10._15
{
    partial class FormMain
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
            this.groupBox_showpic = new System.Windows.Forms.GroupBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox_startgrabber = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_paraset = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripMenuItem_drawroi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_cadselect = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_systemmessage = new System.Windows.Forms.TextBox();
            this.groupBox_systemmessage = new System.Windows.Forms.GroupBox();
            this.menuStrip.SuspendLayout();
            this.groupBox_systemmessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_showpic
            // 
            this.groupBox_showpic.Location = new System.Drawing.Point(12, 45);
            this.groupBox_showpic.Name = "groupBox_showpic";
            this.groupBox_showpic.Size = new System.Drawing.Size(388, 632);
            this.groupBox_showpic.TabIndex = 1;
            this.groupBox_showpic.TabStop = false;
            this.groupBox_showpic.Text = "实时图像显示";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox_startgrabber,
            this.toolStripMenuItem_paraset,
            this.toolStripMenuItem_drawroi,
            this.toolStripMenuItem_cadselect});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1208, 25);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripTextBox_startgrabber
            // 
            this.toolStripTextBox_startgrabber.Name = "toolStripTextBox_startgrabber";
            this.toolStripTextBox_startgrabber.Size = new System.Drawing.Size(68, 21);
            this.toolStripTextBox_startgrabber.Text = "开始采集";
            this.toolStripTextBox_startgrabber.Click += new System.EventHandler(this.toolStripTextBox_startgrabber_Click);
            // 
            // toolStripMenuItem_paraset
            // 
            this.toolStripMenuItem_paraset.Name = "toolStripMenuItem_paraset";
            this.toolStripMenuItem_paraset.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem_paraset.Text = "参数设置";
            this.toolStripMenuItem_paraset.Click += new System.EventHandler(this.toolStripMenuItem_paraset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(406, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 632);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "废料识别";
            // 
            // toolStripMenuItem_drawroi
            // 
            this.toolStripMenuItem_drawroi.Name = "toolStripMenuItem_drawroi";
            this.toolStripMenuItem_drawroi.Size = new System.Drawing.Size(66, 21);
            this.toolStripMenuItem_drawroi.Text = "ROI绘制";
            // 
            // toolStripMenuItem_cadselect
            // 
            this.toolStripMenuItem_cadselect.Name = "toolStripMenuItem_cadselect";
            this.toolStripMenuItem_cadselect.Size = new System.Drawing.Size(69, 21);
            this.toolStripMenuItem_cadselect.Text = "CAD选择";
            // 
            // textBox_systemmessage
            // 
            this.textBox_systemmessage.Location = new System.Drawing.Point(6, 20);
            this.textBox_systemmessage.Multiline = true;
            this.textBox_systemmessage.Name = "textBox_systemmessage";
            this.textBox_systemmessage.Size = new System.Drawing.Size(376, 252);
            this.textBox_systemmessage.TabIndex = 4;
            // 
            // groupBox_systemmessage
            // 
            this.groupBox_systemmessage.Controls.Add(this.textBox_systemmessage);
            this.groupBox_systemmessage.Location = new System.Drawing.Point(800, 46);
            this.groupBox_systemmessage.Name = "groupBox_systemmessage";
            this.groupBox_systemmessage.Size = new System.Drawing.Size(388, 281);
            this.groupBox_systemmessage.TabIndex = 5;
            this.groupBox_systemmessage.TabStop = false;
            this.groupBox_systemmessage.Text = "系统消息";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 690);
            this.Controls.Add(this.groupBox_systemmessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_showpic);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "YuanChuang";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox_systemmessage.ResumeLayout(false);
            this.groupBox_systemmessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_showpic;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox_startgrabber;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_paraset;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_drawroi;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_cadselect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_systemmessage;
        private System.Windows.Forms.GroupBox groupBox_systemmessage;
    }
}

