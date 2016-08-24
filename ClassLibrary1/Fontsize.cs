using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class Fontsize : UserControl
    {
        public Fontsize()
        {
            InitializeComponent();
        }
        RichTextBox rtb;
        public RichTextBox Rtb
        {
            get
            {
                return rtb;
            }

            set
            {
                rtb = value;
            }
        }

        private void changertbtextstyle(string fontName, RichTextBox curRichTextBox)
        {
            RichTextBox tempRichTextBox = new RichTextBox();  //用于保存被选中文本的副本  
            //curRichTextBox是当前文本，即原型  
            int curRtbStart = curRichTextBox.SelectionStart;
            int len = curRichTextBox.SelectionLength;
            int tempRtbStart = 0;

            Font font = curRichTextBox.SelectionFont;
            if (len <= 1 && null != font)
            {
                curRichTextBox.SelectionFont = new Font(fontName, font.Size, font.Style);
                return;
            }

            tempRichTextBox.Rtf = curRichTextBox.SelectedRtf;
            for (int i = 0; i < len; i++)  //逐个设置字体种类  
            {
                tempRichTextBox.Select(tempRtbStart + i, 1);
                tempRichTextBox.SelectionFont =
                    new Font(fontName, tempRichTextBox.SelectionFont.Size,
                             tempRichTextBox.SelectionFont.Style);
            }

            //将副本内容插入到到原型中  
            tempRichTextBox.Select(tempRtbStart, len);
            curRichTextBox.SelectedRtf = tempRichTextBox.SelectedRtf;
            curRichTextBox.Select(curRtbStart, len);
            curRichTextBox.Focus();
        }

        private void changertbtextsize(float fontSize, RichTextBox rtb)
        {
            RichTextBox tempRichTextBox = new RichTextBox();
            int curRtbStart = rtb.SelectionStart;
            int len = rtb.SelectionLength;
            int tempRtbStart = 0;

            Font font = rtb.SelectionFont;
            if (len <= 1 && null != font)
            {
                rtb.SelectionFont = new Font(font.Name, fontSize, font.Style);
                return;
            }

            tempRichTextBox.Rtf = rtb.SelectedRtf;
            for (int i = 0; i < len; i++)
            {
                tempRichTextBox.Select(tempRtbStart + i, 1);
                tempRichTextBox.SelectionFont =
                    new Font(tempRichTextBox.SelectionFont.Name,
                             fontSize, tempRichTextBox.SelectionFont.Style);
            }

            tempRichTextBox.Select(tempRtbStart, len);
            rtb.SelectedRtf = tempRichTextBox.SelectedRtf;
            rtb.Select(curRtbStart, len);
            rtb.Focus();
        }


        private void 宋体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changertbtextstyle("宋体", this.rtb);
        }

        private void 黑体ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            changertbtextstyle("黑体", this.rtb);
        }

        private void 楷书ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            changertbtextstyle("楷体", this.rtb);
        }

        private void 幼圆ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            changertbtextstyle("幼圆", this.rtb);
        }

        private void arialToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            changertbtextstyle("Arial", this.rtb);
        }

        private void timesNewRomanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            changertbtextstyle("Times New Roman", this.rtb);
        }

        private void verdanaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            changertbtextstyle("Verdana", this.rtb);
        }

        private void 小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changertbtextsize(9, this.rtb);
        }

        private void 中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changertbtextsize(12, this.rtb);
        }

        private void 大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changertbtextsize(15, this.rtb);
        }

        private void 较大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changertbtextsize(18, this.rtb);
        }

        private void 最大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changertbtextsize(21, this.rtb);
        }
    }
}
