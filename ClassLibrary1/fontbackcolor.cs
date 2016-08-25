using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class fontbackcolor : UserControl
    {
        private RichTextBox rtb;
        private Color _SelectedColor;
        public Color SelectedColor
        {
            get
            {
                return _SelectedColor;
            }

            set
            {
                _SelectedColor = value;
            }
        }

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
        public fontbackcolor()
        {
            InitializeComponent();
            AddComponent();
        }
        private void AddComponent()

        {

            this.comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            //设定ComboBox的高度
            this.comboBox1.ItemHeight = 18;
            this.comboBox1.BeginUpdate();
            this.comboBox1.Items.Clear();
            //加载系统所有的颜色
            Array colors = System.Enum.GetValues(typeof(KnownColor));
            for (int i = colors.GetLength(0) - 1; i >= 0; i--)
            {
                this.comboBox1.Items.Add(colors.GetValue(i).ToString());
            }
            this.comboBox1.EndUpdate();
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;
            Rectangle rect = e.Bounds;  //获取Item矩形框
            //获取对应项记录的颜色值
            string colorName = comboBox1.Items[e.Index].ToString();
            //新建单一色刷子，颜色为对应项记录的值
            SolidBrush brush = new SolidBrush(Color.FromName(colorName));
            SelectedColor = brush.Color;
            //为美观，可缩小选定项区域1个像素
            rect.Inflate(-1, -1);
            // 填充颜色
            e.Graphics.FillRectangle(brush, rect);
            // 用黑色绘制颜色边框
            e.Graphics.DrawRectangle(Pens.Black, rect);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //修改颜色
            fontcolor(this.comboBox1.Text, Rtb);
        }

        private void fontcolor(string color, RichTextBox rtb)
        {
            //修改文字颜色
            //rtb.SelectionColor = Color.FromName(color);
            //修改背景颜色
            rtb.SelectionBackColor = Color.FromName(color);
        }
    }
}
