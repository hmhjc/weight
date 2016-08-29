namespace ClassLibrary1
{
    partial class Fontsize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fontsize));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tssbtn_font = new System.Windows.Forms.ToolStripSplitButton();
            this.宋体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.楷书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.幼圆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesNewRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssbtn_size = new System.Windows.Forms.ToolStripSplitButton();
            this.小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.较大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtn_sizeadd = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_sizesubtract = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbtn_font,
            this.tssbtn_size,
            this.tsbtn_sizeadd,
            this.tsbtn_sizesubtract});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(111, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "字体";
            // 
            // tssbtn_font
            // 
            this.tssbtn_font.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbtn_font.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.宋体ToolStripMenuItem,
            this.黑体ToolStripMenuItem,
            this.楷书ToolStripMenuItem,
            this.幼圆ToolStripMenuItem,
            this.arialToolStripMenuItem,
            this.timesNewRomanToolStripMenuItem,
            this.verdanaToolStripMenuItem});
            this.tssbtn_font.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tssbtn_font.Image = ((System.Drawing.Image)(resources.GetObject("tssbtn_font.Image")));
            this.tssbtn_font.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbtn_font.Name = "tssbtn_font";
            this.tssbtn_font.Size = new System.Drawing.Size(32, 22);
            this.tssbtn_font.Text = "字体";
            // 
            // 宋体ToolStripMenuItem
            // 
            this.宋体ToolStripMenuItem.Checked = true;
            this.宋体ToolStripMenuItem.CheckOnClick = true;
            this.宋体ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.宋体ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.宋体ToolStripMenuItem.Name = "宋体ToolStripMenuItem";
            this.宋体ToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.宋体ToolStripMenuItem.Text = "宋体";
            this.宋体ToolStripMenuItem.Click += new System.EventHandler(this.宋体ToolStripMenuItem_Click);
            // 
            // 黑体ToolStripMenuItem
            // 
            this.黑体ToolStripMenuItem.CheckOnClick = true;
            this.黑体ToolStripMenuItem.Name = "黑体ToolStripMenuItem";
            this.黑体ToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.黑体ToolStripMenuItem.Text = "黑体";
            this.黑体ToolStripMenuItem.Click += new System.EventHandler(this.黑体ToolStripMenuItem_Click_1);
            // 
            // 楷书ToolStripMenuItem
            // 
            this.楷书ToolStripMenuItem.CheckOnClick = true;
            this.楷书ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.楷书ToolStripMenuItem.Name = "楷书ToolStripMenuItem";
            this.楷书ToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.楷书ToolStripMenuItem.Text = "楷书";
            this.楷书ToolStripMenuItem.Click += new System.EventHandler(this.楷书ToolStripMenuItem_Click_1);
            // 
            // 幼圆ToolStripMenuItem
            // 
            this.幼圆ToolStripMenuItem.CheckOnClick = true;
            this.幼圆ToolStripMenuItem.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.幼圆ToolStripMenuItem.Name = "幼圆ToolStripMenuItem";
            this.幼圆ToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.幼圆ToolStripMenuItem.Text = "幼圆";
            this.幼圆ToolStripMenuItem.Click += new System.EventHandler(this.幼圆ToolStripMenuItem_Click_1);
            // 
            // arialToolStripMenuItem
            // 
            this.arialToolStripMenuItem.CheckOnClick = true;
            this.arialToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arialToolStripMenuItem.Name = "arialToolStripMenuItem";
            this.arialToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.arialToolStripMenuItem.Text = "Arial";
            this.arialToolStripMenuItem.Click += new System.EventHandler(this.arialToolStripMenuItem_Click_1);
            // 
            // timesNewRomanToolStripMenuItem
            // 
            this.timesNewRomanToolStripMenuItem.CheckOnClick = true;
            this.timesNewRomanToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            this.timesNewRomanToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            this.timesNewRomanToolStripMenuItem.Click += new System.EventHandler(this.timesNewRomanToolStripMenuItem_Click_1);
            // 
            // verdanaToolStripMenuItem
            // 
            this.verdanaToolStripMenuItem.CheckOnClick = true;
            this.verdanaToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verdanaToolStripMenuItem.Name = "verdanaToolStripMenuItem";
            this.verdanaToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.verdanaToolStripMenuItem.Text = "Verdana";
            this.verdanaToolStripMenuItem.Click += new System.EventHandler(this.verdanaToolStripMenuItem_Click_1);
            // 
            // tssbtn_size
            // 
            this.tssbtn_size.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbtn_size.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.小ToolStripMenuItem,
            this.中ToolStripMenuItem,
            this.大ToolStripMenuItem,
            this.较大ToolStripMenuItem,
            this.最大ToolStripMenuItem});
            this.tssbtn_size.Image = ((System.Drawing.Image)(resources.GetObject("tssbtn_size.Image")));
            this.tssbtn_size.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbtn_size.Name = "tssbtn_size";
            this.tssbtn_size.Size = new System.Drawing.Size(32, 22);
            this.tssbtn_size.Text = "字号";
            // 
            // 小ToolStripMenuItem
            // 
            this.小ToolStripMenuItem.Checked = true;
            this.小ToolStripMenuItem.CheckOnClick = true;
            this.小ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.小ToolStripMenuItem.Name = "小ToolStripMenuItem";
            this.小ToolStripMenuItem.Size = new System.Drawing.Size(152, 40);
            this.小ToolStripMenuItem.Text = "小";
            this.小ToolStripMenuItem.Click += new System.EventHandler(this.小ToolStripMenuItem_Click);
            // 
            // 中ToolStripMenuItem
            // 
            this.中ToolStripMenuItem.CheckOnClick = true;
            this.中ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.中ToolStripMenuItem.Name = "中ToolStripMenuItem";
            this.中ToolStripMenuItem.Size = new System.Drawing.Size(152, 40);
            this.中ToolStripMenuItem.Text = "中";
            this.中ToolStripMenuItem.Click += new System.EventHandler(this.中ToolStripMenuItem_Click);
            // 
            // 大ToolStripMenuItem
            // 
            this.大ToolStripMenuItem.CheckOnClick = true;
            this.大ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.大ToolStripMenuItem.Name = "大ToolStripMenuItem";
            this.大ToolStripMenuItem.Size = new System.Drawing.Size(152, 40);
            this.大ToolStripMenuItem.Text = "大";
            this.大ToolStripMenuItem.Click += new System.EventHandler(this.大ToolStripMenuItem_Click);
            // 
            // 较大ToolStripMenuItem
            // 
            this.较大ToolStripMenuItem.CheckOnClick = true;
            this.较大ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.较大ToolStripMenuItem.Name = "较大ToolStripMenuItem";
            this.较大ToolStripMenuItem.Size = new System.Drawing.Size(152, 40);
            this.较大ToolStripMenuItem.Text = "较大";
            this.较大ToolStripMenuItem.Click += new System.EventHandler(this.较大ToolStripMenuItem_Click);
            // 
            // 最大ToolStripMenuItem
            // 
            this.最大ToolStripMenuItem.CheckOnClick = true;
            this.最大ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 21F);
            this.最大ToolStripMenuItem.Name = "最大ToolStripMenuItem";
            this.最大ToolStripMenuItem.Size = new System.Drawing.Size(152, 40);
            this.最大ToolStripMenuItem.Text = "最大";
            this.最大ToolStripMenuItem.Click += new System.EventHandler(this.最大ToolStripMenuItem_Click);
            // 
            // tsbtn_sizeadd
            // 
            this.tsbtn_sizeadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_sizeadd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_sizeadd.Image")));
            this.tsbtn_sizeadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_sizeadd.Name = "tsbtn_sizeadd";
            this.tsbtn_sizeadd.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_sizeadd.Text = "增大字体";
            this.tsbtn_sizeadd.Click += new System.EventHandler(this.tsbtn_sizeadd_Click);
            // 
            // tsbtn_sizesubtract
            // 
            this.tsbtn_sizesubtract.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_sizesubtract.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_sizesubtract.Image")));
            this.tsbtn_sizesubtract.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_sizesubtract.Name = "tsbtn_sizesubtract";
            this.tsbtn_sizesubtract.Size = new System.Drawing.Size(23, 20);
            this.tsbtn_sizesubtract.Text = "减小字体";
            this.tsbtn_sizesubtract.Click += new System.EventHandler(this.tsbtn_sizesubtract_Click);
            // 
            // Fontsize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Name = "Fontsize";
            this.Size = new System.Drawing.Size(111, 25);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton tssbtn_font;
        private System.Windows.Forms.ToolStripMenuItem 宋体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黑体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 楷书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 幼圆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton tssbtn_size;
        private System.Windows.Forms.ToolStripMenuItem 小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 较大ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最大ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtn_sizeadd;
        private System.Windows.Forms.ToolStripButton tsbtn_sizesubtract;
    }
}
