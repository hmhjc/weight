namespace ClassLibrary1
{
    partial class Test
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fontsetting1 = new ClassLibrary1.Fontsetting();
            this.fontsize1 = new ClassLibrary1.Fontsize();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fontsize1);
            this.panel1.Controls.Add(this.fontsetting1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 25);
            this.panel1.TabIndex = 0;
            // 
            // fontsetting1
            // 
            this.fontsetting1.Dock = System.Windows.Forms.DockStyle.Left;
            this.fontsetting1.Location = new System.Drawing.Point(0, 0);
            this.fontsetting1.Name = "fontsetting1";
            this.fontsetting1.Rtb = null;
            this.fontsetting1.Size = new System.Drawing.Size(88, 25);
            this.fontsetting1.TabIndex = 0;
            // 
            // fontsize1
            // 
            this.fontsize1.Dock = System.Windows.Forms.DockStyle.Left;
            this.fontsize1.Location = new System.Drawing.Point(88, 0);
            this.fontsize1.Name = "fontsize1";
            this.fontsize1.Rtb = null;
            this.fontsize1.Size = new System.Drawing.Size(109, 25);
            this.fontsize1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(571, 445);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 470);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Fontsize fontsize1;
        private Fontsetting fontsetting1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}