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
    public partial class alignment : UserControl
    {
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

        public alignment()
        {
            InitializeComponent();
        }


        private void tsbtn_left_Click(object sender, EventArgs e)
        {
            this.Rtb.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void tsbtn_center_Click(object sender, EventArgs e)
        {
            this.Rtb.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void tsbtn_right_Click(object sender, EventArgs e)
        {
            this.Rtb.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}
