namespace ClassLibrary1
{
    partial class alignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alignment));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_left = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_center = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_right = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_left,
            this.tsbtn_center,
            this.tsbtn_right});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(70, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_left
            // 
            this.tsbtn_left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_left.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_left.Image")));
            this.tsbtn_left.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_left.Name = "tsbtn_left";
            this.tsbtn_left.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_left.Text = "左对齐";
            this.tsbtn_left.Click += new System.EventHandler(this.tsbtn_left_Click);
            // 
            // tsbtn_center
            // 
            this.tsbtn_center.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_center.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_center.Image")));
            this.tsbtn_center.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_center.Name = "tsbtn_center";
            this.tsbtn_center.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_center.Text = "居中";
            this.tsbtn_center.Click += new System.EventHandler(this.tsbtn_center_Click);
            // 
            // tsbtn_right
            // 
            this.tsbtn_right.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_right.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_right.Image")));
            this.tsbtn_right.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_right.Name = "tsbtn_right";
            this.tsbtn_right.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_right.Text = "右对齐";
            this.tsbtn_right.Click += new System.EventHandler(this.tsbtn_right_Click);
            // 
            // alignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Name = "alignment";
            this.Size = new System.Drawing.Size(70, 25);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn_left;
        private System.Windows.Forms.ToolStripButton tsbtn_center;
        private System.Windows.Forms.ToolStripButton tsbtn_right;
    }
}
