using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BR300walkietalkie.Controls.ComboBox
{
    public partial class XqComboBox : System.Windows.Forms.ComboBox
    {
        public XqComboBox()
        {
            InitializeComponent();            
           
            this.DrawItem += XqComboBox_DrawItem;
        }

        private void XqComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            if (e.Index>=0)
            {
                string s = this.Items[e.Index].ToString();
                // 计算字符串尺寸（以像素为单位）
                SizeF ss = e.Graphics.MeasureString(s, e.Font);
                // 水平居中
                float left = (float)(e.Bounds.Width - ss.Width) / 2;
                if (left < 0) left = 0f;
                float top = (float)(e.Bounds.Height - ss.Height) / 2;
                // 垂直居中
                if (top < 0) top = 0f;
                top = top + this.ItemHeight * e.Index;
                // 输出
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(
                    s,
                    e.Font,
                    new SolidBrush(e.ForeColor),
                    left, top);
            }
            
        }
    }
}
