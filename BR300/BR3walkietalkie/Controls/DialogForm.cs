using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BR300walkietalkie.Controls
{
    public partial class DialogForm : BaseForm
    {

      
        public DialogForm(string text, string caption, MsgBoxButtons buttons)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            SetText(text);
            SetCaption(caption);
            SetButton(buttons);
        }
        private void SetText(string text)
        {
            

            int width = this.pnlText.Width / 2;
            int height = this.pnlText.Height;         
            Label lbl = new Label();
            lbl.Text = text;
            if (text.Length<100)
            {
                lbl.Size = new Size(text.Length*6+5,12);
                if (lbl.Width > (width-20))
                {
                    this.Width = (lbl.Width + 20);
                    lbl.Location = new Point(10, 20);
                }
                else
                {
                    lbl.Location = new Point((width-lbl.Width)/2,20);
                }
                
            }
            pnlText.Controls.Add(lbl);
            lbl.Show(); 
        }
        private void SetCaption(string caption)
        {
            this.Text = caption;
        }
        private void SetButton(MsgBoxButtons buttons)
        {
            this.pnlButtonContainer.Width = this.Width - 10;
            int width = this.pnlButtonContainer.Width / 2;
            int height = this.pnlButtonContainer.Height;
            int x = 0, y = 0;
            switch (buttons)
            {
                case MsgBoxButtons.OK:
                    {

                        x = width - 37;
                        y = height - 30;
                        //“确认”按钮
                        Button btn1 = new Button();
                        btn1.Size = new Size(75, 23);
                        btn1.Font = new Font("宋体", 9);
                        btn1.Location = new Point(x, y);
                        btn1.Name = "btnOK";
                        btn1.Text = MsgBoxButtonText.OK;
                        btn1.Click += btnOK_Click;
                        pnlButtonContainer.Controls.Add(btn1);

                    }
                    break;
                case MsgBoxButtons.OKCancel:
                    {
                        x = width - 80;
                        y = height - 30;
                        //“确认”按钮
                        Button btn1 = new Button();
                        btn1.Size = new Size(75, 23);
                        btn1.Font = new Font("宋体", 9);
                        btn1.Location = new Point(x, y);
                        btn1.Name = "btnOK";
                        btn1.Text = MsgBoxButtonText.OK;
                        btn1.Click += btnOK_Click;
                        pnlButtonContainer.Controls.Add(btn1);


                        x = width + 5;
                        y = height - 30;
                        //“取消”按钮
                        Button btn2 = new Button();
                        btn2.Size = new Size(75, 23);
                        btn2.Font = new Font("宋体", 9);
                        btn2.Location = new Point(x, y);
                        btn2.Name = "btnCancel";
                        btn2.Text = MsgBoxButtonText.Cancel;
                        btn2.Click += btnCancel_Click;
                        pnlButtonContainer.Controls.Add(btn2);

                    }
                    break;
                case MsgBoxButtons.YesNo:
                    {
                        x = width - 80;
                        y = height - 30;
                        //“是”按钮
                        Button btn1 = new Button();
                        btn1.Size = new Size(75, 23);
                        btn1.Font = new Font("宋体", 9);
                        btn1.Location = new Point(x, y);
                        btn1.Name = "btnYes";
                        btn1.Text = MsgBoxButtonText.Yes;
                        btn1.Click += btnYes_Click;
                        pnlButtonContainer.Controls.Add(btn1);

                        x = width + 5;
                        y = height - 30;
                        //“否”按钮
                        Button btn2 = new Button();
                        btn2.Size = new Size(75, 23);
                        btn2.Font = new Font("宋体", 9);
                        btn2.Location = new Point(x, y);
                        btn2.Name = "btnNo";
                        btn2.Text = MsgBoxButtonText.No;
                        btn2.Click += btnNo_Click;
                        pnlButtonContainer.Controls.Add(btn2);

                    }
                    break;
                case MsgBoxButtons.YesNoCancel:
                    {
                        if (this.Width<260)
                        {
                            this.Width = 260;
                        }
                        width = this.pnlText.Width / 2;
                        height = this.pnlText.Height;
                        x = width - 120;
                        y = height - 30;
                        //“是”按钮
                        Button btn1 = new Button();
                        btn1.Size = new Size(75, 23);
                        btn1.Font = new Font("宋体", 9);
                        btn1.Location = new Point(x, y);
                        btn1.Name = "btnYes";
                        btn1.Text = MsgBoxButtonText.Yes;
                        btn1.Click += btnYes_Click;
                        pnlButtonContainer.Controls.Add(btn1);

                        x = width - 35;
                        y = height - 30;
                        //“否”按钮
                        Button btn2 = new Button();
                        btn2.Size = new Size(75, 23);
                        btn2.Font = new Font("宋体", 9);
                        btn2.Location = new Point(x, y);
                        btn2.Name = "btnNo";
                        btn2.Text = MsgBoxButtonText.No;
                        btn2.Click += btnNo_Click;
                        pnlButtonContainer.Controls.Add(btn2);

                        x = width + 50;
                        y = height - 30;
                        //“取消”按钮
                        Button btn3 = new Button();
                        btn3.Size = new Size(75, 23);
                        btn3.Font = new Font("宋体", 9);
                        btn3.Location = new Point(x, y);
                        btn3.Name = "btnCancel";
                        btn3.Text = MsgBoxButtonText.Cancel;
                        btn3.Click += btnCancel_Click;
                        pnlButtonContainer.Controls.Add(btn3);

                    }
                    break;
                case MsgBoxButtons.AbortRetryIgnore:
                    {
                        x = width - 120;
                        y = height - 30;
                        //“终止”按钮
                        Button btn1 = new Button();
                        btn1.Size = new Size(75, 23);
                        btn1.Font = new Font("宋体", 9);
                        btn1.Location = new Point(x, y);
                        btn1.Name = "btnAbort";
                        btn1.Text = MsgBoxButtonText.Abort;
                        btn1.Click += btnAbort_Click;
                        pnlButtonContainer.Controls.Add(btn1);

                        x = width - 35;
                        y = height - 30;
                        //“重试”按钮
                        Button btn2 = new Button();
                        btn2.Size = new Size(75, 23);
                        btn2.Font = new Font("宋体", 9);
                        btn2.Location = new Point(x, y);
                        btn2.Name = "btnRetry";
                        btn2.Text = MsgBoxButtonText.Retry;
                        btn2.Click += btnRetry_Click;
                        pnlButtonContainer.Controls.Add(btn2);

                        x = width + 50;
                        y = height - 30;
                        //“忽略”按钮
                        Button btn3 = new Button();
                        btn3.Size = new Size(75, 23);
                        btn3.Font = new Font("宋体", 9);
                        btn3.Location = new Point(x, y);
                        btn3.Name = "btnIgnore";
                        btn3.Text = MsgBoxButtonText.Ignore;
                        btn3.Click += btnIgnore_Click;
                        pnlButtonContainer.Controls.Add(btn3);


                    }
                    break;
                case MsgBoxButtons.RetryCancel:
                    {
                        x = width - 80;
                        y = height - 30;
                        //“重试”按钮
                        Button btn1 = new Button();
                        btn1.Size = new Size(75, 23);
                        btn1.Font = new Font("宋体", 9);
                        btn1.Location = new Point(x, y);
                        btn1.Name = "btnRetry";
                        btn1.Text = MsgBoxButtonText.Retry;
                        btn1.Click += btnRetry_Click;
                        pnlButtonContainer.Controls.Add(btn1);

                        x = width + 5;
                        y = height - 30;
                        //“取消”按钮
                        Button btn2 = new Button();
                        btn2.Size = new Size(75, 23);
                        btn2.Font = new Font("宋体", 9);
                        btn2.Location = new Point(x, y);
                        btn2.Name = "btnCancel";
                        btn2.Text = MsgBoxButtonText.Cancel;
                        btn2.Click += btnCancel_Click;
                        pnlButtonContainer.Controls.Add(btn2);

                    }
                    break;
                case MsgBoxButtons.OKCopy:
                    {
                        x = width - 80;
                        y = height - 30;
                        //“确认”按钮
                        Button btn1 = new Button();
                        btn1.Size = new Size(75, 23);
                        btn1.Font = new Font("宋体", 9);
                        btn1.Location = new Point(x, y);
                        btn1.Name = "btnOK";

                        btn1.Text = MsgBoxButtonText.OK;
                         btn1.Click += btnOK_Click;
                         pnlButtonContainer.Controls.Add(btn1);

                         x = width + 5;
                         y = height - 30;
                         //“复制”按钮
                         Button btn2 = new Button();
                         btn2.Size = new Size(75, 23);
                         btn2.Font = new Font("宋体", 9);
                         btn2.Location = new Point(x, y);
                         btn2.Name = "btnCopy";
                         btn2.Text = MsgBoxButtonText.Copy;
                         btn2.Click += btnCopy_Click;
                         pnlButtonContainer.Controls.Add(btn2);

                     }
                     break;
                 default:
                     {
                         x = width - 30;
                         y = height - 30;
                         //“确认”按钮
                         Button btn1 = new Button();
                         btn1.Size = new Size(75, 23);
                        btn1.Font = new Font("宋体", 9);
                         btn1.Location = new Point(x, y);
                         btn1.Name = "btnOK";
                          btn1.Text = MsgBoxButtonText.OK;
                         btn1.Click += btnOK_Click;
                        pnlButtonContainer.Controls.Add(btn1);
                     }
                     break;
             }
        }
        #region 按键返回

        #endregion

        private void btnCopy_Click(object sender, EventArgs e)
        {       
            this.Close();
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            MsgBox.result = MsgBoxDialogResult.Ignore;
            this.Close();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            MsgBox.result = MsgBoxDialogResult.Retry;
            this.Close();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            MsgBox.result = MsgBoxDialogResult.Abort;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MsgBox.result = MsgBoxDialogResult.No;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MsgBox.result = MsgBoxDialogResult.Yes;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MsgBox.result = MsgBoxDialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MsgBox.result = MsgBoxDialogResult.OK;
            this.Close();
        }
    }

    public class MsgBox
    {
        private static string defaultCaption = string.Empty;
        private static MsgBoxButtons defaultButtons = MsgBoxButtons.OK;
        private static MsgBoxIcon defaultIcon = MsgBoxIcon.None;
        /// <summary>
        /// 消息对话的结果
        /// </summary>
        internal static MsgBoxDialogResult result = MsgBoxDialogResult.None;
        /// <summary>
        /// 显示可包括文本，符号和按钮的消息框
        /// </summary>
        /// <param name="text">文本</param>
        /// <returns>结果</returns>
        public static MsgBoxDialogResult Show(string text)
        {
            return Show(text,defaultCaption,defaultButtons,defaultIcon);
        }
        /// <summary>
        /// 显示可包括文本，符号和按键消息框
        /// </summary>
        /// <param name="">文本</param>
        /// <param name="caption">标题</param>
        /// <returns>结果</returns>
        public static MsgBoxDialogResult Show(string text, string caption)
        {
            return Show(text, caption, defaultButtons, defaultIcon);
        }
        /// <summary>
        /// 显示可包括文本，符号和按钮的消息框
        /// </summary>
        /// <param name="text">文本</param>
        /// <param name="caption">标题</param>
        /// <param name="buttons">按钮</param>
        /// <returns>结果</returns>
        public static MsgBoxDialogResult Show(string text, string caption, MsgBoxButtons buttons)
        {
            return Show(text, caption, buttons, defaultIcon);
        }
        public static MsgBoxDialogResult Show(string text, string caption, MsgBoxButtons buttons, MsgBoxIcon icon)
        {
            DialogForm dialogForm = new DialogForm(text, caption, buttons);
            dialogForm.ShowDialog();
            return result;
        }

    }
    //[ComVisible(true)]
    internal class MsgBoxButtonText
    {
        // 摘要:
           //     消息框包含“确定”按钮的文本。
          public const string OK = "OK";
          // 摘要:
          //     消息框包含“是”按钮的文本。
          public const string Yes = "Yes";
         // 摘要:
         //     消息框包含“否”按钮的文本。
          public const string No = "No";
          // 摘要:
          //     消息框包含“取消”按钮的文本。
          public const string Cancel = "Cancel";
          // 摘要:
          //     消息框包含“重试”按钮的文本。
          public const string Retry = "Retry";
          // 摘要:
          //     消息框包含“忽略”按钮的文本。
          public const string Ignore = "Ignore";
          // 摘要:
          //     消息框包含“终止”按钮的文本。
          public const string Abort = "Abort";
          // 摘要:
          //     消息框包含“复制”按钮的文本。
          public const string Copy = "Copy";
    }
    public enum MsgBoxDialogResult
    {
        // 摘要:
          //     从对话框返回了 Nothing。这表明有模式对话框继续运行。
          None = 0,
          //
          // 摘要:
          //     对话框的返回值是 OK（通常从标签为“确定”的按钮发送）。
          OK = 1,
          //
          // 摘要:
          //     对话框的返回值是 Cancel（通常从标签为“取消”的按钮发送）。
          Cancel = 2,
          //
          // 摘要:
          //     对话框的返回值是 Abort（通常从标签为“中止”的按钮发送）。
          Abort = 3,
          //
          // 摘要:
          //     对话框的返回值是 Retry（通常从标签为“重试”的按钮发送）。
          Retry = 4,
          //
          // 摘要:
          //     对话框的返回值是 Ignore（通常从标签为“忽略”的按钮发送）。
          Ignore = 5,
          //
          // 摘要:
          //     对话框的返回值是 Yes（通常从标签为“是”的按钮发送）。
          Yes = 6,
          //
          // 摘要:
          //     对话框的返回值是 No（通常从标签为“否”的按钮发送）。
          No = 7,
    }
    public enum MsgBoxIcon
    {
        /// <summary>
        /// 无
        /// </summary>
        None=0,
        /// <summary>
        /// 错误
        /// </summary>
        Error=1,
        /// <summary>
        /// 问题
        /// </summary>
        Question=2,
        /// <summary>
        /// 停止
        /// </summary>
        Stop=3,
        /// <summary>
        /// 警告
        /// </summary>
        Warning=4,
        /// <summary>
        /// 信息提示
        /// </summary>
        Information=5,
        /// <summary>
        /// 崩溃
        /// </summary>
        SysBreak=6,
        /// <summary>
        /// 空值
        /// </summary>
        NoRecord=7,
    }
    public enum MsgBoxButtons
    {
        /// <summary>
        /// 确定
        /// </summary>
        OK=0,
        OKCancel=1,
        AbortRetryIgnore=2,
        YesNoCancel=3,
        YesNo=4,
        RetryCancel=5,
        OKCopy=6,

    }
}
