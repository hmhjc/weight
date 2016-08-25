namespace mynotepadwidget
{
    partial class Form1
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
            this.fontsetting1 = new ClassLibrary1.Fontsetting();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontcolourwidget1 = new ClassLibrary1.fontcolourwidget();
            this.SuspendLayout();
            // 
            // fontsetting1
            // 
            this.fontsetting1.Location = new System.Drawing.Point(13, 13);
            this.fontsetting1.Name = "fontsetting1";
            this.fontsetting1.Rtb = null;
            this.fontsetting1.Size = new System.Drawing.Size(78, 25);
            this.fontsetting1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(284, 261);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // fontcolourwidget1
            // 
            this.fontcolourwidget1.Location = new System.Drawing.Point(163, 81);
            this.fontcolourwidget1.Name = "fontcolourwidget1";
            this.fontcolourwidget1.Rtb = null;
            this.fontcolourwidget1.SelectedColor = System.Drawing.Color.Empty;
            this.fontcolourwidget1.Size = new System.Drawing.Size(101, 26);
            this.fontcolourwidget1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.fontcolourwidget1);
            this.Controls.Add(this.fontsetting1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary1.Fontsetting fontsetting1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private ClassLibrary1.fontcolourwidget fontcolourwidget1;
    }
}

