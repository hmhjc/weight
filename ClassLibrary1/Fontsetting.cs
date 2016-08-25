using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class Fontsetting : UserControl
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

        public Fontsetting()
        {
            InitializeComponent();
        }

        private void tsbtn_bold_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Bold,Rtb);
            Font font = Rtb.SelectionFont;
            if (font.Bold)
            {
                tsbtn_bold.BackColor = Color.FromArgb(255, 255, 233, 120);
            }
            else
            {
                tsbtn_bold.BackColor = Color.Transparent;
            }
        }
        private void tsbtn_Italic_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Italic, Rtb);
            Font font = Rtb.SelectionFont;
            if (font.Italic)
            {
                tsbtn_Italic.BackColor = Color.FromArgb(255, 255, 233, 120);
            }
            else
            {
                tsbtn_Italic.BackColor = Color.Transparent;
            }
        }
        private void tsbtn_Underline_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Underline, Rtb);
            Font font = Rtb.SelectionFont;
            if (font.Underline)
            {
                tsbtn_Underline.BackColor = Color.FromArgb(255, 255, 233, 120);
            }
            else
            {
                tsbtn_Underline.BackColor = Color.Transparent;
            }
        }

        #region ChangeFontStyle(FontStyle style, RichTextBox curRichTextBox) :: setfontstyle;设置字体格式：粗体、斜体、下划线 
        ///<summary>  
        ///设置字体格式：粗体、斜体、下划线  
        ///</summary>  
        /// <param name="style">事件触发后传参：字体格式类型</param>  
        private void ChangeFontStyle(FontStyle style, RichTextBox curRichTextBox)
        {
            if (style != FontStyle.Bold && style != FontStyle.Italic &&
                style != FontStyle.Underline)
                throw new System.InvalidProgramException("字体格式错误");
            RichTextBox tempRichTextBox = new RichTextBox();  //将要存放被选中文本的副本  
            int curRtbStart = curRichTextBox.SelectionStart;
            int len = curRichTextBox.SelectionLength;
            int tempRtbStart = 0;
            Font font = curRichTextBox.SelectionFont;
            if (len <= 1 && font != null) //与上边的那段代码类似，功能相同  
            {
                if (style == FontStyle.Bold && font.Bold ||
                    style == FontStyle.Italic && font.Italic ||
                    style == FontStyle.Underline && font.Underline)
                {
                    curRichTextBox.SelectionFont = new Font(font, font.Style ^ style);
                }
                else if (style == FontStyle.Bold && !font.Bold ||
                         style == FontStyle.Italic && !font.Italic ||
                         style == FontStyle.Underline && !font.Underline)
                {
                    curRichTextBox.SelectionFont = new Font(font, font.Style | style);
                }
                return;
            }
            tempRichTextBox.Rtf = curRichTextBox.SelectedRtf;
            tempRichTextBox.Select(len - 1, 1); //选中副本中的最后一个文字  
                                                //克隆被选中的文字Font，这个tempFont主要是用来判断  
                                                //最终被选中的文字是否要加粗、去粗、斜体、去斜、下划线、去下划线  
            Font tempFont = (Font)tempRichTextBox.SelectionFont.Clone();

            //清空2和3  
            for (int i = 0; i < len; i++)
            {
                tempRichTextBox.Select(tempRtbStart + i, 1);  //每次选中一个，逐个进行加粗或去粗  
                if (style == FontStyle.Bold && tempFont.Bold ||
                    style == FontStyle.Italic && tempFont.Italic ||
                    style == FontStyle.Underline && tempFont.Underline)
                {
                    tempRichTextBox.SelectionFont =
                        new Font(tempRichTextBox.SelectionFont,
                                 tempRichTextBox.SelectionFont.Style ^ style);
                }
                else if (style == FontStyle.Bold && !tempFont.Bold ||
                         style == FontStyle.Italic && !tempFont.Italic ||
                         style == FontStyle.Underline && !tempFont.Underline)
                {
                    tempRichTextBox.SelectionFont =
                        new Font(tempRichTextBox.SelectionFont,
                                 tempRichTextBox.SelectionFont.Style | style);
                }
            }
            tempRichTextBox.Select(tempRtbStart, len);
            curRichTextBox.SelectedRtf = tempRichTextBox.SelectedRtf; //将设置格式后的副本拷贝给原型  
            curRichTextBox.Select(curRtbStart, len);
        }
        #endregion

        //#region 之前写的不成熟的方法
        //private void changetextfont(string fontstyle, RichTextBox rtb)
        //{
        //    switch (fontstyle)
        //    {
        //        case "Bold":
        //            if (isBold)
        //            {
        //                //加粗状态下,取消加粗
        //                isBold = false;
        //                tsbtn_bold.BackColor = Color.Transparent;
        //                if (isItalic)
        //                {
        //                    //倾斜的时候
        //                    if (isUnderline)
        //                    {
        //                        //加粗倾斜且有下划线,此时设置倾斜+下划线
        //                        rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Italic | FontStyle.Underline);
        //                    }
        //                    else
        //                    {
        //                        //加粗倾斜且没有下划线,此时设置倾斜
        //                        rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Italic);
        //                    }
        //                }
        //                else
        //                if (isUnderline)
        //                {
        //                    //加粗且有下划线,此时设置下划线
        //                    rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Underline);
        //                }
        //                else
        //                {
        //                    rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Regular);
        //                }
        //            }
        //            else
        //            {
        //                //不是加粗的情况下,加粗
        //                isBold = true;
        //                tsbtn_bold.BackColor = Color.Orange;
        //                if (isItalic)
        //                {
        //                    //倾斜的时候
        //                    if (isUnderline)
        //                    {
        //                        //加粗倾斜且有下划线,此时设置加粗+倾斜+下划线
        //                        rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
        //                    }
        //                    else
        //                    {
        //                        //加粗倾斜且没有下划线,此时设置加粗+倾斜
        //                        rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Bold | FontStyle.Italic);
        //                    }
        //                }
        //                else
        //                if (isUnderline)
        //                {
        //                    //加粗且有下划线,此时设置加粗+下划线
        //                    rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Bold | FontStyle.Underline);
        //                }
        //                else
        //                {
        //                    rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Bold);
        //                }
        //            }
        //            break;
        //        case "Italic":
        //            if (isItalic)
        //            {
        //                //倾斜状态下,取消倾斜
        //                isItalic = false;
        //                tsbtn_Italic.BackColor = Color.Transparent;
        //                if (isBold)
        //                {
        //                    //加粗的时候
        //                    if (isUnderline)
        //                    {
        //                        //加粗倾斜且有下划线,此时设置加粗+下划线
        //                        rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Bold | FontStyle.Underline);
        //                    }
        //                    else
        //                    {
        //                        //加粗倾斜且没有下划线,此时设置加粗
        //                        rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Bold);
        //                    }
        //                }
        //                else
        //                if (isUnderline)
        //                {
        //                    //倾斜且有下划线,此时设置下划线
        //                    rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Underline);
        //                }
        //                else
        //                {
        //                    rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Regular);
        //                }
        //            }
        //            else
        //            {
        //                //不是倾斜的情况下,倾斜
        //                isItalic = true;
        //                tsbtn_Italic.BackColor = Color.Orange;
        //                if (isBold)
        //                {
        //                    //加粗的时候
        //                    if (isUnderline)
        //                    {
        //                        //加粗+下划线,此时设置加粗+倾斜+下划线
        //                        rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
        //                    }
        //                    else
        //                    {
        //                        //加粗倾斜且没有下划线,此时设置加粗+倾斜
        //                        rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Bold | FontStyle.Italic);
        //                    }
        //                }
        //                else
        //                if (isUnderline)
        //                {
        //                    //下划线,此时设置倾斜+下划线
        //                    rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Italic | FontStyle.Underline);
        //                }
        //                else
        //                {
        //                    rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Italic);
        //                }
        //            }
        //            break;
        //        case "Underline":
        //            if (isUnderline)
        //            {
        //                //下划线状态下,取消下划线
        //                isUnderline = false;
        //                tsbtn_Underline.BackColor = Color.Transparent;
        //                if (isItalic)
        //                {
        //                    //倾斜的时候
        //                    if (isBold)
        //                    {
        //                        //加粗+倾斜+下划线,此时设置加粗+倾斜
        //                        rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Bold | FontStyle.Italic);
        //                    }
        //                    else
        //                    {
        //                        //倾斜+下划线,此时设置下划线
        //                        rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Italic);
        //                    }
        //                }
        //                //下面考虑是否加粗
        //                if (isBold)
        //                {
        //                    //加粗且有下划线,此时设置加粗
        //                    rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Bold);
        //                }
        //                else
        //                {
        //                    rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Regular);
        //                }
        //            }
        //            else
        //            {
        //                //不是下划线的情况下,设置下划线
        //                isUnderline = true;
        //                tsbtn_Underline.BackColor = Color.Orange;
        //                if (isItalic)
        //                {
        //                    //加粗的时候
        //                    if (isBold)
        //                    {
        //                        //加粗+倾斜,此时设置加粗+倾斜+下划线
        //                        rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
        //                    }
        //                    else
        //                    {
        //                        //倾斜,此时设置倾斜+下划线
        //                        rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Underline | FontStyle.Italic);
        //                    }
        //                }
        //                else
        //                if (isBold)
        //                {
        //                    //加粗,此时设置加粗+下划线
        //                    rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Bold | FontStyle.Underline);
        //                }
        //                else
        //                {
        //                    rtb.SelectionFont = new Font(Font.Name, Font.Size, FontStyle.Underline);
        //                }
        //            }
        //            break;
        //    }
        //} 
        //#endregion
    }
}
