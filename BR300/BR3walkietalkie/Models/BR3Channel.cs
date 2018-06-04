using BR300walkietalkie.Class;
using BR300walkietalkie.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BR300walkietalkie.Controls;
using Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;

namespace BR300walkietalkie.Models
{
    public partial class BR3Channel : Form
    {
        int focuRow = 0;
        int focuCol = 0;
        public static System.Data.DataTable dt = new System.Data.DataTable();
        public bool isChange = false;        
        string FileString = "";

        //ComboBox cmbTXFreq = new ComboBox();
        public BR3Channel()
        {
            InitializeComponent();         
            br3 = new Class.BR3Class();
            br3.TxLimit = 4;
            br3.SquelchLevel = 5;
            br3.VoiceAnnouncements = 1;
            br3.PowerSaving = true;          
            adItem();
            br3.ShotPress1 = 3;
            br3.ShotPress2 = 1;
            br3.LongPress1 = 6;
            br3.LongPress2 = 2;
            br3.ScanMode = 0;
            br3.BeepSound = true;
            br3.Brightness = 3;
            br3.RogerTone = true;
            br3.DisplayMode = 2;
            br3.Display = "MIDLAND";
            br3.VoiceLevel = 0;


            this.Companding.DataPropertyName = "Companding";
            this.Companding.FillWeight = 103.5533F;
            this.Companding.HeaderText = "Companding";
            this.Companding.Name = "Companding";
            this.Companding.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Companding.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //cmbDisplayMode.SelectedIndex = 2;
            //txtDisplay.Text = "MIDLAND";
            //cmbSquelchLevel.SelectedIndex = 6;
            //cmbTXLimit.SelectedIndex = 6;
            //cmbShotPress1.SelectedIndex = 1;
            //cmbShotPress2.SelectedIndex = 6;
            //cmbLongPress1.SelectedIndex = 3;
            ////cmbLongPress2.SelectedIndex = 2;
            //cmbVoiceLevel.SelectedIndex = 0;
            //cmbVoiceDelay.SelectedIndex = 2;

            //cmbPPT.SelectedIndex = 0;
            //cmbStartUpCH.SelectedIndex = 0;
            //cmbVoiceAnnouncements.SelectedIndex = 0;
            //cmbScanMode.SelectedIndex = 0;
            //chkBeepSound.Checked = true;
            //chkPowerSaving.Checked = true;

            this.gridControl1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;            
            //this.gridControl1.DataError += delegate (object sender, DataGridViewDataErrorEventArgs e)
            //{
                
            //};
            isChange = false;
            Models.ModelClass.models[0].MinFrequency = 400;
            Models.ModelClass.models[0].MaxFrequency = 470;
           
            //cmbRxFreq.DrawMode = DrawMode.OwnerDrawVariable;
            //cmbRxFreq.DrawItem += cmbRxFreq_DrawItem;
            cmbRxFreq.Visible = false;
            
        }

        private void cmbRxFreq_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            e.DrawBackground();
            Brush myBrush = Brushes.Black;
            System.Drawing.Font ft = new System.Drawing.Font("宋体", 9f); e.Graphics.DrawString(cbo.GetItemText(cbo.Items[e.Index]), ft,
                 myBrush, e.Bounds, StringFormat.GenericDefault);
            //注意 cbo.GetItemText(cbo.Items[e.Index])来获取Item的Text，
            //若直接cbo.Items[e.Index].ToString()则会输出System.Data.DataRowView
            e.DrawFocusRectangle();
        }
        //重绘 
       

        private void BR3Channel_Load(object sender, EventArgs e)
        {
            Type type = gridControl1.GetType();
            System.Reflection.PropertyInfo pi = type.GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            pi.SetValue(gridControl1, true, null);
            
            //cmbFTO.SelectedIndex = 0;
            
        }
        private void InitializaDatatable(int rowcount)
        {
            dt.Clear();
            dt.TableName = "BR3";
            if (dt.Columns.Count == 0)
            {
                for (int i = 0; i < 14; i++)
                {
                    dt.Columns.Add(Enum.Parse(typeof(BR3), i.ToString()).ToString());
                }
            }
            for (int i = 0; i < rowcount; i++)
            {
                DataRow dr = dt.NewRow();
                dr[ChannelBR3.Channel] = i + 1;
                dt.Rows.Add(dr);
            }
            gridControl1.DataSource = dt;

            //this.cmbTXFreq.Location = this.gridControl1.GetCellDisplayRectangle(2, 0, true).Location;
            //this.cmbTXFreq.Size = this.gridControl1.GetCellDisplayRectangle(2, 0, true).Size;
            this.cmbRxFreq.Location = this.gridControl1.GetCellDisplayRectangle(2, 0, true).Location;
            this.cmbRxFreq.Size = this.gridControl1.GetCellDisplayRectangle(2, 0, true).Size;


            //this.cmbRxFreq.RightToLeft = RightToLeft.Yes;

            //cmbRxFreq.Enter += cmbRxFreq_Enter;
        }

       

        public void ShowData(string str)
        {
            string[] see;
            str = str.Substring(3);
            see = str.Split('|');
            dt = Common.Common.StringToDataTable(see[0]);
            //---chkBeepSound.Checked = Convert.ToBoolean(see[1]);
            br3.BeepSound = Convert.ToBoolean(see[1]);
            //---txtDisplay.Text = see[2];
            br3.Display = see[2];
            //cmbDisplayMode.SelectedIndex = Convert.ToInt32(see[3]);
            //cmbFTO.SelectedIndex = Convert.ToInt32(see[4]);
            br3.LongPress1 = Convert.ToInt32(see[5]);
            br3.LongPress2 = Convert.ToInt32(see[6]);
            //---chkPowerSaving.Checked = Convert.ToBoolean(see[7]);
            br3.PowerSaving = Convert.ToBoolean(see[7]);
            //cmbPPT.SelectedIndex = Convert.ToInt32(see[8]);
            //---cmbScanMode.SelectedIndex = Convert.ToInt32(see[9]);
            br3.ScanMode = Convert.ToInt32(see[9]);
            br3.ShotPress1 = Convert.ToInt32(see[10]);
            br3.ShotPress2 = Convert.ToInt32(see[11]);

            //---cmbSquelchLevel.SelectedIndex = Convert.ToInt32(see[12]);
            br3.SquelchLevel = Convert.ToInt32(see[12]);
            //cmbTXLimit.SelectedIndex = Convert.ToInt32(see[13]);
            //txtTXStart.Text = see[14];
            //txtTXStop.Text = see[15];
            //cmbVoiceAnnouncements.SelectedIndex = Convert.ToInt32(see[16]);
            //cmbVoiceDelay.SelectedIndex = Convert.ToInt32(see[17]);
            //---cmbVoiceLevel.SelectedIndex = Convert.ToInt32(see[18]);
            br3.VoiceLevel = Convert.ToInt32(see[18]);
            //cmbStartUpCH.SelectedIndex = Convert.ToInt32(see[19]);
            //br3.StartupCh= Convert.ToInt32(see[19]);
            gridControl1.DataSource = dt;
        }

        private void Init()
        {
            string path = Environment.CurrentDirectory + "\\BR3.dat";
            if (!File.Exists(path))
            {
                //InitializaDatatable();
                return;
            }
            string obj = Common.Common.Deserialize(path);
            string str =Common.Encryption.DES_Decrypt(obj, "11111111");
            
            if (str.Substring(0, 3) == "BR3")
            {
                
                ShowData(str);
            }
            else
            {
                MsgBox.Show("Read Fail,Please Select the correct file");
            }
            isChange = false;
        }
        private void adItem()
        {
            #region ChannelItem

            for (int i = 0; i < Class.ChannelItem.countCtcss(); i++)
            {
                CTCSDec.Items.Add(ChannelItem.ctcssItemAdd(i).ToString());
                CTCSEnc.Items.Add(ChannelItem.ctcssItemAdd(i).ToString());
            }

            for (int i = 0; i < ChannelItem.countCtcssN(); i++)
            {
                CTCSDec.Items.Add(ChannelItem.ctcssNItemAdd(i).ToString());
                CTCSEnc.Items.Add(ChannelItem.ctcssNItemAdd(i).ToString());
            }
            for (int i = 0; i < ChannelItem.countCtcssI(); i++)
            {
               CTCSDec.Items.Add(ChannelItem.ctcssIItemAdd(i).ToString());
                CTCSEnc.Items.Add(ChannelItem.ctcssIItemAdd(i).ToString());
            }

            for (int i = 0; i < 99; i++)
            {
                if (i <= 1)
                {
                    cmbRxFreq.Items.Add((464.5000 + i * 0.05000).ToString("#0.0000"));
                    //cmbTXFreq.Items.Add((464.5000 + i * 0.05000).ToString("#0.0000"));
                }
                else if (i <= 7)
                {
                    switch (i)
                    {
                        case 2: cmbRxFreq.Items.Add(467.7625.ToString("#0.0000")); break;
                        case 3: cmbRxFreq.Items.Add(467.8125.ToString("#0.0000"));  break;
                        default: cmbRxFreq.Items.Add((467.8500 + (i - 4) * 0.025).ToString("#0.0000"));  break;
                    }
                }
                else if (i <= 21)
                {
                    cmbRxFreq.Items.Add((461.0375 + 0.025 * (i - 8)).ToString("#0.0000"));
                    //cmbTXFreq.Items.Add((461.0375 + 0.025 * (i - 8)).ToString("#0.0000"));
                }
                else if (i <= 28)
                {
                    cmbRxFreq.Items.Add((462.7625 + 0.025 * (i - 22)).ToString("#0.0000"));
                    //cmbTXFreq.Items.Add((462.7625 + 0.025 * (i - 22)).ToString("#0.0000"));
                }
                else if (i <= 32)
                {
                    cmbRxFreq.Items.Add((464.4875 + 0.025 * (i - 29)).ToString("#0.0000"));
                    //cmbTXFreq.Items.Add((464.4875 + 0.025 * (i - 29)).ToString("#0.0000"));
                }
                else if (i <= 46)
                {
                    cmbRxFreq.Items.Add((466.0375 + 0.025 * (i - 33)).ToString("#0.0000"));
                   // cmbTXFreq.Items.Add((466.0375 + 0.025 * (i - 33)).ToString("#0.0000"));
                }
                else if (i <= 51)
                {
                    switch (i)
                    {
                        case 47: cmbRxFreq.Items.Add(467.7875.ToString("#0.0000"));  break;
                        case 48: cmbRxFreq.Items.Add(467.8375.ToString("#0.0000"));  break;
                        case 49: cmbRxFreq.Items.Add(467.8625.ToString("#0.0000"));  break;
                        case 50: cmbRxFreq.Items.Add(467.8875.ToString("#0.0000"));  break;
                        case 51: cmbRxFreq.Items.Add(467.9125.ToString("#0.0000"));  break;
                    }
                }
                else if (i <= 55)
                {
                    cmbRxFreq.Items.Add((469.4875 + 0.025 * (i - 52)).ToString("#0.0000"));
                    //cmbTXFreq.Items.Add((469.4875 + 0.025 * (i - 52)).ToString("#0.0000"));
                }
                else if (i <= 59)
                {
                    switch (i)
                    {
                        case 56: cmbRxFreq.Items.Add(462.1875.ToString("#0.0000"));  break;
                        case 57: cmbRxFreq.Items.Add(462.4625.ToString("#0.0000"));  break;
                        case 58: cmbRxFreq.Items.Add(462.4875.ToString("#0.0000"));  break;
                        case 59: cmbRxFreq.Items.Add(462.5125.ToString("#0.0000"));  break;
                    }
                }
                else if (i <= 63)
                {
                    switch (i)
                    {
                        case 60: cmbRxFreq.Items.Add(467.1875.ToString("#0.0000"));  break;
                        case 61: cmbRxFreq.Items.Add(467.4625.ToString("#0.0000"));  break;
                        case 62: cmbRxFreq.Items.Add(467.4875.ToString("#0.0000"));  break;
                        case 63: cmbRxFreq.Items.Add(467.5125.ToString("#0.0000"));  break;
                    }
                }
                else if (i <= 70)
                {
                    switch (i)
                    {
                        case 64: cmbRxFreq.Items.Add(451.1875.ToString("#0.0000"));  break;
                        case 65: cmbRxFreq.Items.Add(451.2375.ToString("#0.0000"));  break;
                        case 66: cmbRxFreq.Items.Add(451.2875.ToString("#0.0000")); break;
                        case 67: cmbRxFreq.Items.Add(451.3375.ToString("#0.0000")); break;
                        case 68: cmbRxFreq.Items.Add(451.4375.ToString("#0.0000")); break;
                        case 69: cmbRxFreq.Items.Add(451.5375.ToString("#0.0000")); break;
                        case 70: cmbRxFreq.Items.Add(451.6375.ToString("#0.0000")); break;
                    }
                }
                else if (i <= 76)
                {
                    switch (i)
                    {
                        case 71: cmbRxFreq.Items.Add(452.3125.ToString("#0.0000"));  break;
                        case 72: cmbRxFreq.Items.Add(452.5375.ToString("#0.0000"));  break;
                        case 73: cmbRxFreq.Items.Add(452.4125.ToString("#0.0000"));  break;
                        case 74: cmbRxFreq.Items.Add(452.5125.ToString("#0.0000"));  break;
                        case 75: cmbRxFreq.Items.Add(452.7625.ToString("#0.0000"));  break;
                        case 76: cmbRxFreq.Items.Add(452.8625.ToString("#0.0000"));  break;
                    }
                }
                else if (i <= 79)
                {
                    cmbRxFreq.Items.Add((456.1875 + 0.05 * (i - 77)).ToString("#0.0000"));
                    //cmbTXFreq.Items.Add((456.1875 + 0.05 * (i - 77)).ToString("#0.0000"));
                }
                else if (i <= 89)
                {
                    cmbRxFreq.Items.Add((468.2125 + 0.05 * (i - 80)).ToString("#0.0000"));
                    //cmbTXFreq.Items.Add((468.2125 + 0.05 * (i - 80)).ToString("#0.0000"));
                }
                else if (i <= 93)
                {
                    cmbRxFreq.Items.Add((456.3375 + 0.1 * (i - 90)).ToString("#0.0000"));
                    //cmbTXFreq.Items.Add((456.3375 + 0.1 * (i - 90)).ToString("#0.0000"));
                }
                else
                {
                    switch (i)
                    {                                                               
                        case 94: cmbRxFreq.Items.Add(457.3125.ToString("#0.0000")); break;
                        case 95: cmbRxFreq.Items.Add(457.4125.ToString("#0.0000")); break;
                        case 96: cmbRxFreq.Items.Add(457.5125.ToString("#0.0000")); break;
                        case 97: cmbRxFreq.Items.Add(457.7625.ToString("#0.0000")); break;
                        case 98: cmbRxFreq.Items.Add(457.8625.ToString("#0.0000")); break;
                    }
                }
                this.cmbRxFreq.Font = TXFrequency.DefaultCellStyle.Font;              
            }
            


                #endregion

                /*****************************************************************************************/

                #region 其他 Item



                TXPower.Items.Add("Low");

            TXPower.Items.Add("High");

            /*****************************************************************************************/


            WN.Items.Add("Narrow");

            WN.Items.Add("Wide");

            /*****************************************************************************************/

            BusyLock.Items.Add("Yes");

            BusyLock.Items.Add("No");
            /*****************************************************************************************/


            Companding.Items.Add("Yes");
            Companding.Items.Add("No");

            PPTID.Items.Add("Yes");
            PPTID.Items.Add("No");

            /*****************************************************************************************/
            Scrambling.Items.Add("Yes");
            Scrambling.Items.Add("No");



            ScanningAdd.Items.Add("Yes");
            ScanningAdd.Items.Add("No");

            Repeater.Items.Add("Yes");
            Repeater.Items.Add("No");

            Clone.Items.Add("Yes");
            Clone.Items.Add("No");

            #endregion


            this.cmbRxFreq.AutoCompleteMode = AutoCompleteMode.Suggest; //输入提示
            this.cmbRxFreq.AutoCompleteSource = AutoCompleteSource.ListItems;       
            //gridControl1.Controls.Add(this.cmbRxFreq);


        }


        internal void newBR3Channel()
        {
            InitializaDatatable(16);
        }
        #region 表单新建打开打印保存


        internal void OpenBR3Channel()
        {
            //if (isChange == true)
            //{
            //    switch (MsgBox.Show("Whether to save the settings ?", "point out", MsgBoxButtons.YesNoCancel))
            //    {
            //        case MsgBoxDialogResult.Yes:
            //            SaveBR3ChannelAs();
            //            break;                    
            //    }
            //}
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open";
            ofd.Filter = "Dat|*.dat";            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileString = ofd.FileName;
                string obj = Common.Common.Deserialize(ofd.FileName);
                obj = Common.Common.Deserialize(ofd.FileName);
                string str =Common.Encryption.DES_Decrypt(obj, "11111111");
                str = Common.Encryption.DES_Decrypt(obj, "11111111");
                if (str.Substring(0, 3) == "BR3")
                {                    
                    ShowData(str);
                    isChange = false;
                }
                else
                {
                    MsgBox.Show("Read Fail,Please Select the correct file");
                }
            }
        }

        internal void SaveBR3Channel()
        {
            GetWriteData();
            if (FileString == "")
            {
                SaveBR3ChannelAs();
            }
            else
            {
                if (Common.Common.WriteDat(FileString, Common.Encryption.DES_Encryption(getSaveStr(), "11111111")))
                {
                    MsgBox.Show("Save Success !");
                    isChange = false;
                }
                else
                {
                    MsgBox.Show("Save Filed !");
                }
            }
            
        }

        public void SaveBR3ChannelAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.Title = "BR3 Save As";
            sfd.Filter = "Dat|*.dat";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileString = sfd.FileName;
                if (Common.Common.WriteDat(sfd.FileName, Common.Encryption.DES_Encryption(getSaveStr(), "11111111")))
                {
                    isChange = false;
                    MsgBox.Show("Save Success !");
                }
                else
                {
                    MsgBox.Show("Save Filed !");
                }
            }
        }
        private string getSaveStr()
        {
            gridControl1.EndEdit();
            GetWriteData();
            //cmbDisplayMode.SelectedIndex = 2;
            //txtDisplay.Text = "MIDLAND";
            //cmbSquelchLevel.SelectedIndex = 6;
            //cmbTXLimit.SelectedIndex = 6;
            //cmbShotPress1.SelectedIndex = 1;
            //cmbShotPress2.SelectedIndex = 6;
            //cmbLongPress1.SelectedIndex = 3;
            ////cmbLongPress2.SelectedIndex = 2;
            //cmbVoiceLevel.SelectedIndex = 0;
            //cmbVoiceDelay.SelectedIndex = 2;

            //cmbPPT.SelectedIndex = 0;
            //cmbStartUpCH.SelectedIndex = 0;
            //cmbVoiceAnnouncements.SelectedIndex = 0;
            //cmbScanMode.SelectedIndex = 0;
            //chkBeepSound.Checked = true;
            //chkPowerSaving.Checked = true;

            string str = "BR3" + Common.Common.DataTableToString(dt)
                + "|" + br3.BeepSound.ToString()
                + "|" + br3.Display.ToString()
                + "|" + br3.DisplayMode.ToString()
                + "|" + br3.Fto.ToString()
                + "|" + br3.LongPress1.ToString()
                + "|" + br3.LongPress2.ToString()
                + "|" + br3.PowerSaving.ToString()
                + "|" + br3.Ppt.ToString()
                + "|" + br3.ScanMode.ToString()
                + "|" + br3.ShotPress1.ToString()
                + "|" + br3.ShotPress2.ToString()
                + "|" + br3.SquelchLevel.ToString()
                + "|" + br3.TxLimit.ToString()
                + "|" + br3.TxStart.ToString()
                + "|" + br3.TxStop.ToString()
                + "|" + br3.VoiceAnnouncements.ToString()
                + "|" + br3.VoiceDelay.ToString()
                + "|" + br3.VoiceLevel.ToString()
                + "|" + br3.StartupCh.ToString();
                return str;
          
        }

        public void PrintDt()
        {

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Interphone frequency table";
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.PrintPreviewDataGridView(gridControl1);

        }


        #endregion


        #region 读写
        public void readMessage()
        {
            //loading.ShowWaitForm();

            cmbRxFreq.TabStop = false;
            cmbRxFreq.Visible = false;
            if (!ReadWrite.BR3.connect())
            {
                MsgBox.Show(Common.Common.massage);
                return;
            }
            if (!ReadWrite.BR3.BR3Read())
            {
                MsgBox.Show(Common.Common.massage);
                return;
            }
            this.Invoke(new System.Action(() =>
            {
                ShowData(ReadWrite.BR3.recive);
            }));
            MainForm.issessce = true;
            Common.PortCommunication.timerSend.Enabled = false;
            Common.PortCommunication.timerSend.Interval = 5;
            Common.PortCommunication.timerSend.Enabled = true;

            Common.Common.massage = "Read complete";
            //MsgBox.Show("Read complete");
            //MainForm.conn.Abort();
            cmbRxFreq.TabStop = true;
        }
        public static Class.BR3Class br3;
        public void writeMessage()
        {
            cmbRxFreq.TabStop = false;
            cmbRxFreq.Visible = false;
            if (!GetWriteData())
            {
                MainForm.dataerrer = false;
                PortCommunication.timerSend.Interval = 1;
                return;
            }
            if (!ReadWrite.BR3.connect())
            {
                MsgBox.Show(Common.Common.massage);
                return;
            }
            if (!ReadWrite.BR3.BR3Write(br3))
            {
                MsgBox.Show(Common.Common.massage);
                return ;
            }
            MainForm.issessce = true;
            Common.PortCommunication.timerSend.Enabled = false;
            Common.PortCommunication.timerSend.Interval = 5;
            Common.PortCommunication.timerSend.Enabled = true;
            Common.Common.massage = "Write Complete";
            cmbRxFreq.TabStop = true;
            return ;
            //MsgBox.Show("Write complete");
        }


        private void ShowData(string[] reciveData)
        {
            string str = "";
            int x;
            int H4 ;
            int L4 ;
            string[] reciveN;
            dt.Rows.Clear();
            for (int i = 0; i < 16; i++)
            {
                DataRow dr = dt.NewRow();
                dr[ChannelBR3.Channel] = i + 1;
                dt.Rows.Add(dr);
            }
            
            for (int i = 0; i < 16; i++)
            {

                reciveN = reciveData[i * 2 + 2].Split(' ');
                if (reciveN[7].ToLower() != "ff")
                {
                    dt.Rows[i][ChannelBR3.TXFrequency] = (Convert.ToDouble(reciveN[7]) * 10 + Convert.ToDouble(reciveN[6]) * 0.1 + Convert.ToDouble(reciveN[5]) * 0.001 + Convert.ToDouble(reciveN[4]) * 0.00001).ToString("#0.0000");
                    dt.Rows[i][ChannelBR3.RXFrequency] = (Convert.ToDouble(reciveN[11]) * 10 + Convert.ToDouble(reciveN[10]) * 0.1 + Convert.ToDouble(reciveN[9]) * 0.001 + Convert.ToDouble(reciveN[8]) * 0.00001).ToString("#0.0000");

                    reciveN = reciveData[i * 2 + 3].Split(' ');
                    if (reciveN[4].ToLower() == "ff"|| reciveN[5].ToLower() == "ff")
                    {
                        dt.Rows[i][ChannelBR3.CTCSDec] = "Off";
                    }
                    else if (Common.Common.hexToDec(reciveN[5]) < 8 * 16)
                    {
                        dt.Rows[i][ChannelBR3.CTCSDec] = (Convert.ToDouble(reciveN[5]) * 10 + Convert.ToDouble(reciveN[4]) * 0.1).ToString("#0.0");//reciveN[5]+ reciveN[4];

                    }
                    else if (Common.Common.hexToDec(reciveN[5]) >= 12 * 16)
                    {
                        dt.Rows[i][ChannelBR3.CTCSDec] = "D" + (Convert.ToDouble(Common.Common.hexToDec(reciveN[5]) - 12 * 16)).ToString() + Convert.ToDouble(reciveN[4]).ToString("#00") + "I";//reciveN[5]+ reciveN[4];
                    }
                    else
                    {
                    
                        dt.Rows[i][ChannelBR3.CTCSDec] = "D" + (Convert.ToDouble(Common.Common.hexToDec(reciveN[5]) - 8 * 16)).ToString() + Convert.ToDouble(reciveN[4]).ToString("#00") + "N";
                    }
                    if (reciveN[6].ToLower() == "ff" || reciveN[7].ToLower() == "ff")
                    {
                       
                        dt.Rows[i][ChannelBR3.CTCSEnc] = "Off";
                    }
                    else if (Common.Common.hexToDec(reciveN[7]) < 8 * 16)
                    {
                        
                        dt.Rows[i][ChannelBR3.CTCSEnc] = (Convert.ToDouble(reciveN[7])* 10 + Convert.ToDouble(reciveN[6]) * 0.1).ToString("#0.0");// reciveN[7] + reciveN[6];
                    }
                    else if (Common.Common.hexToDec(reciveN[7]) >= 12 * 16)
                    {
                        dt.Rows[i][ChannelBR3.CTCSEnc] = "D" + (Convert.ToDouble(Common.Common.hexToDec(reciveN[7]) - 12 * 16)).ToString() + Convert.ToDouble(reciveN[6]).ToString("#00") + "I";//reciveN[5]+ reciveN[4];
                    }
                    else
                    {
                       
                        string asdsd= "D" + (Convert.ToDouble(Common.Common.hexToDec(reciveN[7]) - 8 * 16) ).ToString() + Convert.ToDouble(reciveN[6]).ToString("#00") + "N";
                        if (i == 7)
                        {
                            asdsd = "D" + (Convert.ToDouble(Common.Common.hexToDec(reciveN[7]) - 8 * 16) ).ToString() + Convert.ToDouble(reciveN[6]).ToString("#00") + "N";
                        }
                        dt.Rows[i][ChannelBR3.CTCSEnc] = "D" + (Convert.ToDouble(Common.Common.hexToDec(reciveN[7]) - 8 * 16)).ToString() + Convert.ToDouble(reciveN[6]).ToString("#00") + "N";

                    }
                    x = Common.Common.hexToDec(reciveN[8]);
                    H4 = x / 16;
                    L4 = x % 16;
                    dt.Rows[i][ChannelBR3.PPTID] = Convert.ToBoolean(H4 / 8) ? "No" : "Yes";
                    dt.Rows[i][ChannelBR3.Companding] = Convert.ToBoolean(H4 % 8 / 4) ? "No" : "Yes";
                    dt.Rows[i][ChannelBR3.Scrambling] = Convert.ToBoolean(H4 % 8 % 4 / 2) ? "No" : "Yes";
                    dt.Rows[i][ChannelBR3.ScanningAdd] = Convert.ToBoolean(H4 % 8 % 4 % 2) ? "No" : "Yes";
                    dt.Rows[i][ChannelBR3.TXPower] = Convert.ToBoolean(L4 / 8) ? "High" : "Low";
                    dt.Rows[i][ChannelBR3.WN] = Convert.ToBoolean(L4 % 8 / 4) ? "Narrow" : "Wide";
                    dt.Rows[i][ChannelBR3.BusyLock] = Convert.ToBoolean(L4 % 8 % 4 % 2) ? "No" : "Yes";
                    dt.Rows[i][ChannelBR3.Repeater] = Convert.ToBoolean(L4 % 8 % 4 / 2) ? "Yes" : "No";
                    x= Common.Common.hexToDec(reciveN[9]);
                    H4 = x / 16;
                    L4 = x % 16;
                    dt.Rows[i][ChannelBR3.Clone] = Convert.ToBoolean(L4 % 8 % 4 % 2) ? "Yes" : "No";
                }
            }
            MainForm.barEditItem3.Value = 94;
            //57 07 90 08  57 07 98 08 开机显示名称  reciveData[32*7+18]和reciveData[32*7+19]
            str = reciveData[32 * 7 + 18] + " " + reciveData[32 * 7 + 19];
            reciveN = str.Split(' ');
            br3.Display = NumToLetter(Common.Common.hexToDec(reciveN[4])) + NumToLetter(Common.Common.hexToDec(reciveN[5])) + NumToLetter(Common.Common.hexToDec(reciveN[6]))
                + NumToLetter(Common.Common.hexToDec(reciveN[7])) + NumToLetter(Common.Common.hexToDec(reciveN[8])) + NumToLetter(Common.Common.hexToDec(reciveN[9]))
                + NumToLetter(Common.Common.hexToDec(reciveN[10])) + NumToLetter(Common.Common.hexToDec(reciveN[11])) + NumToLetter(Common.Common.hexToDec(reciveN[16]))
                + NumToLetter(Common.Common.hexToDec(reciveN[17]));
            //if (Common.Common.hexToDec(reciveN[23]) <= 99)
            //{
            //    cmbStartUpCH.SelectedIndex = Common.Common.hexToDec(reciveN[23]);
            //}
            //else
            //{
            //    cmbStartUpCH.SelectedIndex = 0;
            //}
            //chkRogerTone.Checked = Common.Common.hexToDec(reciveN[22])==1? true:false;
            if (Common.Common.hexToDec(reciveN[21]) > 4)
            {
                br3.Brightness = 4;
            }
            else
            {
                br3.Brightness = Common.Common.hexToDec(reciveN[21]);
            }
            br3.RogerTone= Common.Common.hexToDec(reciveN[22]) == 1 ? true : false;
            ////57 07 a0 08 发射开始  reciveData[32*27+20]
            //str = reciveData[32 * 7 + 20];
            //reciveN = str.Split(' ');
            //txtTXStart.Text = "";
            //for (int i = 4; i < 12; i++)
            //{
            //    if (reciveN[i].ToLower() != "ff")
            //    {
            //        txtTXStart.Text += reciveN[i].Substring(1, 1);
            //    }
            //}


            //57 07 C0 08   PTT ID和语音语言 reciveData[32*27+24]
            str = reciveData[32 * 7 + 24];
            reciveN = str.Split(' ');
            int x1 = Common.Common.hexToDec(reciveN[4]) / 16;
            int x2 = Common.Common.hexToDec(reciveN[4]) % 16;
            switch (x1)
            {
                case 0:
                    //---cmbScanMode.SelectedIndex = 0;
                    br3.ScanMode = 0;
                    //cmbPPT.SelectedIndex = 0;
                    break;
                case 1:
                    //---cmbScanMode.SelectedIndex = 0;
                    br3.ScanMode = 0;
                    //cmbPPT.SelectedIndex = 1;
                    break;
                case 2:
                    //---cmbScanMode.SelectedIndex = 0;
                    br3.ScanMode = 0;
                    //cmbPPT.SelectedIndex = 2;
                    break;
                case 3:
                    //---cmbScanMode.SelectedIndex = 0;
                    br3.ScanMode = 0;
                    //cmbPPT.SelectedIndex = 3;
                    break;
                case 4:
                    //---cmbScanMode.SelectedIndex = 1;
                    br3.ScanMode = 1;
                    //cmbPPT.SelectedIndex = 0;
                    break;
                case 5:
                    //---cmbScanMode.SelectedIndex = 1;
                    br3.ScanMode = 1;
                    //cmbPPT.SelectedIndex = 1;
                    break;
                case 6:
                    //---cmbScanMode.SelectedIndex = 1;
                    br3.ScanMode = 1;
                    //cmbPPT.SelectedIndex = 2;
                    break;
                case 7:
                    //---cmbScanMode.SelectedIndex = 1;
                    br3.ScanMode = 1;
                    //cmbPPT.SelectedIndex = 3;
                    break;
                case 8:
                    //---cmbScanMode.SelectedIndex = 2;
                    br3.ScanMode = 2;
                    //cmbPPT.SelectedIndex = 0;
                    break;
                case 9:
                    //---cmbScanMode.SelectedIndex = 2;
                    br3.ScanMode = 2;
                    //cmbPPT.SelectedIndex = 1;
                    break;
                case 10:
                    //---cmbScanMode.SelectedIndex = 2;
                    br3.ScanMode = 2;
                    //cmbPPT.SelectedIndex = 2;
                    break;
                case 11:
                    //---cmbScanMode.SelectedIndex = 2;
                    br3.ScanMode = 2;
                    //cmbPPT.SelectedIndex = 3;
                    break;
                default:
                    break;
            }
            switch (x2)
            {
                case 0:
                    //---cmbVoiceAnnouncements.SelectedIndex = 0;
                    br3.VoiceAnnouncements = 0;
                    //---chkBeepSound.Checked = false;
                    br3.BeepSound = false;
                    //---chkPowerSaving.Checked = false; ;
                    br3.PowerSaving = false;
                    break;
                case 1:
                    //---cmbVoiceAnnouncements.SelectedIndex = 0;
                    br3.VoiceAnnouncements = 0;
                    //---chkBeepSound.Checked = true;
                    br3.BeepSound = true;
                    //---chkPowerSaving.Checked = false; 
                    br3.PowerSaving = false;
                    break;
                case 2:
                    //---cmbVoiceAnnouncements.SelectedIndex = 0;
                    br3.VoiceAnnouncements = 0;
                    //---chkBeepSound.Checked = false;
                    br3.BeepSound = false;
                    //---chkPowerSaving.Checked = true; ;
                    br3.PowerSaving = true;
                    break;
                case 3:
                    //---cmbVoiceAnnouncements.SelectedIndex = 0;
                    br3.VoiceAnnouncements = 0;
                    //---chkBeepSound.Checked = true;
                    br3.BeepSound = true;
                    //---chkPowerSaving.Checked = true; 
                    br3.PowerSaving = true;
                    break;
                case 4:
                    //---cmbVoiceAnnouncements.SelectedIndex = 1;
                    br3.VoiceAnnouncements = 1;
                    //---chkBeepSound.Checked = false;
                    br3.BeepSound = false;
                    //---chkPowerSaving.Checked = false; 
                    br3.PowerSaving = false;
                    break;
                case 5:
                    //---cmbVoiceAnnouncements.SelectedIndex = 1;
                    br3.VoiceAnnouncements = 1;
                    //---chkBeepSound.Checked = true;
                    br3.BeepSound = true;
                    //---chkPowerSaving.Checked = false; 
                    br3.PowerSaving = false;
                    break;
                case 6:
                    //---cmbVoiceAnnouncements.SelectedIndex = 1;
                    br3.VoiceAnnouncements = 1;
                    //---chkBeepSound.Checked = false;
                    br3.BeepSound = false;
                    //---chkPowerSaving.Checked = true; 
                    br3.PowerSaving = true;
                    break;
                case 7:
                    //---cmbVoiceAnnouncements.SelectedIndex = 1;
                    br3.VoiceAnnouncements = 1;
                    //---chkBeepSound.Checked = true;
                    br3.BeepSound = true;
                    //---chkPowerSaving.Checked = true; 
                    br3.PowerSaving = true;
                    break;
                case 8:
                    //---cmbVoiceAnnouncements.SelectedIndex = 2;
                    br3.VoiceAnnouncements = 2;
                    //---chkBeepSound.Checked = false;
                    br3.BeepSound = false;
                    //---chkPowerSaving.Checked = false;
                    br3.PowerSaving = false;
                    break;
                case 9:
                    //---cmbVoiceAnnouncements.SelectedIndex = 2;
                    br3.VoiceAnnouncements = 2;
                    //---chkBeepSound.Checked = true;
                    br3.BeepSound = false;
                    //---chkPowerSaving.Checked = false; 
                    br3.PowerSaving = false;
                    break;
                case 10:
                    //---cmbVoiceAnnouncements.SelectedIndex = 2;
                    br3.VoiceAnnouncements = 2;
                    //---chkBeepSound.Checked = false;
                    br3.BeepSound = false;
                    //---chkPowerSaving.Checked = true; 
                    br3.PowerSaving = true;
                    break;
                case 11:
                    //---cmbVoiceAnnouncements.SelectedIndex = 2;
                    br3.VoiceAnnouncements = 2;
                    //---chkBeepSound.Checked = true;
                    br3.BeepSound = true;
                    //---chkPowerSaving.Checked = true; 
                    br3.PowerSaving = true;
                    break;
                default:
                    break;
            }
            MainForm.barEditItem3.Value = 98;
            ////静噪等级
            //---cmbSquelchLevel.SelectedIndex = Common.Common.hexToDec(reciveN[5]);
            br3.SquelchLevel= Common.Common.hexToDec(reciveN[5]);
            //侧键1短
            switch (Common.Common.hexToDec(reciveN[6]))
            {
                case 0:
                    br3.ShotPress1 = 0;
                    break;
                case 1:
                    br3.ShotPress1 = 1;
                    break;
                case 2:
                    br3.ShotPress1 = 2;
                    break;
                case 3:
                    br3.ShotPress1 = 3;
                    break;
                case 5:
                    br3.ShotPress1 = 4;
                    break;
                case 6:
                    br3.ShotPress1 = 5;
                    break;
                case 7:
                    br3.ShotPress1 = 6;
                    break;
                default:
                    break;
            }
            ////发射限时
            //cmbTXLimit.SelectedIndex = Common.Common.hexToDec(reciveN[7]);
            ////声控等级
            //---cmbVoiceLevel.SelectedIndex = Common.Common.hexToDec(reciveN[8]);
            br3.VoiceLevel = Common.Common.hexToDec(reciveN[8]);
            //侧键2短
            switch (Common.Common.hexToDec(reciveN[9]))
            {
                case 0:
                    br3.ShotPress2 = 0;
                    break;
                case 1:
                    br3.ShotPress2 = 1;
                    break;
                case 2:
                    br3.ShotPress2 = 2;
                    break;
                case 3:
                    br3.ShotPress2 = 3;
                    break;
                case 5:
                    br3.ShotPress2 = 4;
                    break;
                case 6:
                    br3.ShotPress2 = 5;
                    break;
                case 7:
                    br3.ShotPress2 = 6;
                    break;
                default:
                    break;
            }
            ////声控延迟时间
            //cmbVoiceDelay.SelectedIndex = Common.Common.hexToDec(reciveN[11]);


            //57 07 d8 08   侧键长按与开机显示方式 reciveData[32*27+27]
            str = reciveData[32 * 7 + 27];
            reciveN = str.Split(' ');

            //if (reciveN[4] == "60" && reciveN[5] == "44" && reciveN[6] == "80" && reciveN[7] == "44")
            //{
            //    cmbFTO.SelectedIndexChanged -= cmbFTO_SelectedIndexChanged;
            //    cmbFTO.SelectedIndex = 0;
            //    cmbFTO.SelectedIndexChanged += cmbFTO_SelectedIndexChanged;
            //}
            //else if (reciveN[4] == "00" && reciveN[5] == "45" && reciveN[6] == "00" && reciveN[7] == "52")
            //{
            //    cmbFTO.SelectedIndexChanged -= cmbFTO_SelectedIndexChanged;
            //    cmbFTO.SelectedIndex = 1;
            //    cmbFTO.SelectedIndexChanged += cmbFTO_SelectedIndexChanged;
            //}

            //57 07 C8 08   侧键长按与开机显示方式 reciveData[32*27+25]
            str = reciveData[32 * 7 + 25];
            reciveN = str.Split(' ');
            //侧键1长
            switch (Common.Common.hexToDec(reciveN[4]))
            {
                case 0:
                    br3.LongPress1 = 0;
                    break;
                case 1:
                    br3.LongPress1 = 1;
                    break;
                case 2:
                    br3.LongPress1 = 2;
                    break;
                case 3:
                    br3.LongPress1 = 3;
                    break;
                case 5:
                    br3.LongPress1 = 4;
                    break;
                case 6:
                    br3.LongPress1 = 5;
                    break;
                case 7:
                    br3.LongPress1 = 6;
                    break;
                default:
                    break;
            }
            //侧键2长         

            switch (Common.Common.hexToDec(reciveN[5]))
            {
                case 0:
                    br3.LongPress2 = 0;
                    break;
                case 1:
                    br3.LongPress2 = 1;
                    break;
                case 2:
                    br3.LongPress2 = 2;
                    break;
                case 3:
                    br3.LongPress2 = 3;
                    break;
                case 5:
                    br3.LongPress2 = 4;
                    break;
                case 6:
                    br3.LongPress2 = 5;
                    break;
                case 7:
                    br3.LongPress2 = 6;
                    break;
                default:
                    br3.LongPress2 = 0;
                    break;
            }


            ////开机显示方式
            //cmbDisplayMode.SelectedIndex = Common.Common.hexToDec(reciveN[6]);


            //MainForm.barEditItem3.Value = 100;
            ////57 07 e0 08   发射结束码 reciveData[32*27+28]
            //str = reciveData[32 * 7 + 28];
            //reciveN = str.Split(' ');
            //txtTXStop.Text = "";
            //for (int i = 4; i < 12; i++)
            //{
            //    if (reciveN[i].ToLower() != "ff")
            //    {
            //        txtTXStop.Text += reciveN[i].Substring(1, 1);
            //    }
            //}           
        }

        private bool GetWriteData()
        {
            decimal dec;
            gridControl1.EndEdit();            
            //br3.BeepSound = true; 
            br3.Channel = dt;
            //br3.Display = "MIDLAND";
            br3.DisplayMode = 2;
            br3.Fto = 0;
            //br3.LongPress1 = 3;
            //br3.LongPress2 = 0;       
            //br3.PowerSaving = chkPowerSaving.Checked;
            br3.Ppt = 0;
            //br3.ScanMode = 0;
            //br3.ShotPress1 = 1;
            //br3.ShotPress2 = 6;
            //br3.SquelchLevel = cmbSquelchLevel.SelectedIndex;
            //br3.TxLimit = cmbTXLimit.SelectedIndex;
            br3.TxStart = "";
            br3.TxStop = "";
            //br3.VoiceAnnouncements = 0;            
            br3.VoiceDelay = 2;
            //br3.VoiceLevel = 0;
            br3.StartupCh = 0;
            //br3.RogerTone =true;
            br3.DtRowCount = dt.Rows.Count;
            for (int i = 0; i < br3.DtRowCount; i++)
            {
                if ( dt.Rows[i][ChannelBR3.RXFrequency]!=null&& dt.Rows[i][ChannelBR3.RXFrequency].ToString()!="")
                {                    
                    dec = Convert.ToDecimal(dt.Rows[i][ChannelBR3.RXFrequency]);
                    if (dec < Models.ModelClass.models[0].MinFrequency | dec > Models.ModelClass.models[0].MaxFrequency)
                    {
                        MsgBox.Show("Frequency range of " + Models.ModelClass.models[0].MinFrequency + "MHZ-" + Models.ModelClass.models[0].MaxFrequency + "MHZ");
                        gridControl1.CurrentCell = gridControl1.Rows[i].Cells[1];
                        return false;
                    }
                }
                if (dt.Rows[i][ChannelBR3.TXFrequency] != null && dt.Rows[i][ChannelBR3.TXFrequency].ToString() != "")
                {
                    dec = Convert.ToDecimal(dt.Rows[i][ChannelBR3.TXFrequency]);
                    if (dec < Models.ModelClass.models[0].MinFrequency | dec > Models.ModelClass.models[0].MaxFrequency)
                    {
                        MsgBox.Show("Frequency range of " + Models.ModelClass.models[0].MinFrequency + "MHZ-" + Models.ModelClass.models[0].MaxFrequency + "MHZ");
                        gridControl1.CurrentCell = gridControl1.Rows[i].Cells[3];
                        return false;
                    }
                }

            }
            return true;
        }

        /// <summary>
        /// 按规则数据转为字线  41：A   42：B .....5A：Z   02为空格
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private string NumToLetter(int num)
        {
            switch (num)
            {
                case 2: return " ";
                case 4 * 16 + 1: return "A";
                case 4 * 16 + 2: return "B";
                case 4 * 16 + 3: return "C";
                case 4 * 16 + 4: return "D";
                case 4 * 16 + 5: return "E";
                case 4 * 16 + 6: return "F";
                case 4 * 16 + 7: return "G";
                case 4 * 16 + 8: return "H";
                case 4 * 16 + 9: return "I";
                case 4 * 16 + 10: return "J";
                case 4 * 16 + 11: return "K";
                case 4 * 16 + 12: return "L";
                case 4 * 16 + 13: return "M";
                case 4 * 16 + 14: return "N";
                case 4 * 16 + 15: return "O";
                case 5 * 16: return "P";
                case 5 * 16 + 1: return "Q";
                case 5 * 16 + 2: return "R";
                case 5 * 16 + 3: return "S";
                case 5 * 16 + 4: return "T";
                case 5 * 16 + 5: return "U";
                case 5 * 16 + 6: return "V";
                case 5 * 16 + 7: return "W";
                case 5 * 16 + 8: return "X";
                case 5 * 16 + 9: return "Y";
                case 5 * 16 + 10: return "Z";
                default: return "";

            }
        }


        #endregion
        /// <summary>
        /// 接收频率改变时   发射频率跟着改变       
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repositoryItemTextEdit1_Leave(object sender, EventArgs e)
        {
            gridControl1.EndEdit();
          
            DataGridViewTextBoxEditingControl te = (DataGridViewTextBoxEditingControl)sender;
            //if (!te.Focus())
            //{
            //    return;
            //}


            int index = te.EditingControlRowIndex;
           
            decimal sadj = Models.ModelClass.models[0].MinFrequency;
            decimal writdat;
            if (te.Text.Trim() == "")
            {
                dt.Rows[index][Class.ChannelBR3.TXFrequency] = "";
                dt.Rows[index][Class.ChannelBR3.BusyLock] = "";
                dt.Rows[index][Class.ChannelBR3.CTCSDec] = "";
                dt.Rows[index][Class.ChannelBR3.CTCSEnc] = "";
                dt.Rows[index][Class.ChannelBR3.Companding] = "";
                dt.Rows[index][Class.ChannelBR3.ScanningAdd] = "";
                dt.Rows[index][Class.ChannelBR3.TXPower] = "";
                dt.Rows[index][Class.ChannelBR3.WN] = "";
                dt.Rows[index][Class.ChannelBR3.PPTID] = "";
                dt.Rows[index][Class.ChannelBR3.Scrambling] = "";
                return;
            }
            else
            {
                try
                {
                    writdat = Convert.ToDecimal(te.Text);
                }
                catch (Exception)
                {

                    return;
                }

            }
            if (writdat < Models.ModelClass.models[0].MinFrequency | writdat > Models.ModelClass.models[0].MaxFrequency)
            {
                MessageBox.Show("Frequency range of " + Models.ModelClass.models[0].MinFrequency + "MHZ-" + Models.ModelClass.models[0].MaxFrequency + "MHZ");

                dt.Rows[index][Class.ChannelBR3.RXFrequency] = te.Text = sadj.ToString("#0.0000");

            }
            else
            {
                dt.Rows[index][Class.ChannelBR3.RXFrequency] = te.Text = writdat.ToString("#0.0000");

            }
            string str = dt.Rows[index][2].ToString();
            if (dt.Rows[index][Class.ChannelBR3.TXFrequency].ToString().Trim() == "")
            {
                dt.Rows[index][Class.ChannelBR3.TXFrequency] = te.Text;
                dt.Rows[index][Class.ChannelBR3.BusyLock] = "No";
                dt.Rows[index][Class.ChannelBR3.CTCSDec] = "Off";
                dt.Rows[index][Class.ChannelBR3.CTCSEnc] = "Off";
                dt.Rows[index][Class.ChannelBR3.Companding] = "Yes";
                dt.Rows[index][Class.ChannelBR3.ScanningAdd] = "Yes";
                dt.Rows[index][Class.ChannelBR3.TXPower] = "Low";
                dt.Rows[index][Class.ChannelBR3.WN] = "Narrow";
                dt.Rows[index][Class.ChannelBR3.PPTID] = "Yes";
                dt.Rows[index][Class.ChannelBR3.Scrambling] = "Yes";
            }
            else
            {
                if (Convert.ToDecimal(dt.Rows[index][Class.ChannelBR3.TXFrequency]) < Models.ModelClass.models[0].MinFrequency | Convert.ToDecimal(dt.Rows[index][Class.ChannelBR3.TXFrequency]) > Models.ModelClass.models[0].MaxFrequency)
                {
                    MessageBox.Show("Frequency range of " + Models.ModelClass.models[0].MinFrequency + "MHZ-" + Models.ModelClass.models[0].MaxFrequency + "MHZ");

                    dt.Rows[index][Class.ChannelBR3.TXFrequency] = dt.Rows[index][Class.ChannelBR3.RXFrequency];
                }
            }

            //gridControl1.DataSource = dt;
            gridControl1.Update();
        }

        /// <summary>
        /// 发射频率改变时 整理格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repositoryItemTextEdit2_Leave(object sender, EventArgs e)
        {
            DataGridViewTextBoxEditingControl te = (DataGridViewTextBoxEditingControl)sender;

        
            int index = te.EditingControlRowIndex;
            decimal sadj = Models.ModelClass.models[0].MinFrequency;
            decimal writdat;
            if (te.Text.Trim() == "")
            {
                return;
            }
            else
            {
                try
                {
                    writdat = Convert.ToDecimal(te.Text);
                }
                catch (Exception)
                {
                    MsgBox.Show("Input error !");
                    te.Focus();
                    return;
                }
            }
            if (writdat < Models.ModelClass.models[0].MinFrequency | writdat > Models.ModelClass.models[0].MaxFrequency)
            {
                MsgBox.Show("Frequency range of " + Models.ModelClass.models[0].MinFrequency + "MHZ-" + Models.ModelClass.models[0].MaxFrequency + "MHZ");

                te.Leave -= repositoryItemTextEdit2_Leave;
                dt.Rows[index][Class.ChannelBR3.TXFrequency] = te.Text = sadj.ToString("#0.0000");
                //te.Leave += repositoryItemTextEdit2_Leave;
            }
            else
            {
                te.Leave -= repositoryItemTextEdit2_Leave;
                dt.Rows[index][Class.ChannelBR3.TXFrequency] = writdat.ToString("#0.0000");
            }
            gridControl1.Update();
        }
        private void cmbDisplayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbDisplayMode.SelectedIndex == 1)
            //{
            //    txtDisplay.Text = "cmbDisplayMode";
            //}
            //else if (cmbDisplayMode.SelectedIndex == 2)
            //{
            //    txtDisplay.Text = "MIDLAND";
            //}
        }

        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (txtTXStart.Text.Length >= 10)
            //{
            //    if (e.KeyChar == 8)
            //    {
            //        e.Handled = false;
            //    }
            //    else
            //    {
            //        e.Handled = true;
            //    }
            //}
            //else
            //{
            //    if ((int)e.KeyChar >= 97)
            //    {
            //        e.KeyChar = (char)((int)e.KeyChar - 32);
            //    }
            //    //限制只能输入1-9的数字字母ABCD，退格键，回车
            //    if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || e.KeyChar == 13 || e.KeyChar == 8 || ((int)e.KeyChar >= 65 && (int)e.KeyChar <= 90) || ((int)e.KeyChar >= 97 && (int)e.KeyChar <= 122))
            //    {
                    
            //        e.Handled = false;
            //    }
            //    else
            //    {
            //        e.Handled = true;
            //    }
            //}
        }

        private void txtTXStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (txtTXStart.Text.Length >= 8)
            //{
            //    if (e.KeyChar == 8)
            //    {
            //        e.Handled = false;
            //    }
            //    else
            //    {
            //        e.Handled = true;
            //    }

            //}
            //else
            //{
            //    if ((int)e.KeyChar >= 97)
            //    {
            //        e.KeyChar = (char)((int)e.KeyChar - 32);
            //    }
            //    //限制只能输入1-9的数字字母ABCD，退格键，回车
            //    if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || e.KeyChar == 13 || e.KeyChar == 8 )
            //    {
                    
            //        e.Handled = false;
            //    }
            //    else
            //    {
            //        e.Handled = true;
            //    }
            //}
        }

        private void txtTXStop_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (txtTXStop.Text.Length >= 8)
            //{
            //    if (e.KeyChar == 8)
            //    {
            //        e.Handled = false;
            //    }
            //    else
            //    {
            //        e.Handled = true;
            //    }
            //}
            //else
            //{
            //    if ((int)e.KeyChar >= 97)
            //    {
            //        e.KeyChar = (char)((int)e.KeyChar - 32);
            //    }
            //    //限制只能输入1-9的数 退格键，回车
            //    if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || e.KeyChar == 13 || e.KeyChar == 8 )
            //    {
                   
            //        e.Handled = false;
            //    }
            //    else
            //    {
            //        e.Handled = true;
            //    }
            //}
        }

        
        private void gridControl1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            isChange = true;       
            if (this.gridControl1.CurrentCell.ColumnIndex == gridControl1.Columns[Class.ChannelBR3.CTCSDec].Index)
            {
                DataGridViewComboBoxEditingControl cmb = (DataGridViewComboBoxEditingControl)e.Control;
                cmb.SelectedIndexChanged -= CTCSDec_SelectedIndexChanged;
                cmb.SelectedIndexChanged += CTCSDec_SelectedIndexChanged;
                //e.Control.TextChanged -= Comb_TextUpdate;
                //e.Control.TextChanged += Comb_TextUpdate;
            }           
        }

        private void CTCSDec_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewComboBoxEditingControl comb = (DataGridViewComboBoxEditingControl)sender;
            int index = comb.EditingControlRowIndex;
            string coms = comb.Text;
            comb.SelectedIndexChanged -= CTCSDec_SelectedIndexChanged;
            dt.Rows[index][Class.ChannelBR3.CTCSDec] = coms;
            dt.Rows[index][Class.ChannelBR3.CTCSEnc] = coms;
            comb.SelectedIndexChanged += CTCSDec_SelectedIndexChanged;
            gridControl1.Update();
        }

        private void FreqComb_SelectChannge(object sender, EventArgs e)
        {
            DataGridViewComboBoxEditingControl comb = (DataGridViewComboBoxEditingControl)sender;
            int index = comb.EditingControlRowIndex;
            string coms = comb.Text;

            dt.Rows[index][Class.ChannelBR3.RXFrequency] = coms;
            dt.Rows[index][Class.ChannelBR3.TXFrequency] = coms;

            gridControl1.Update();
        }
        private void Comb_TextUpdate(object sender, EventArgs e)
        {
            DataGridViewComboBoxEditingControl comb = (DataGridViewComboBoxEditingControl)sender;
            int index = comb.EditingControlRowIndex;
            string coms = comb.Text.Trim();
            if (coms=="")
            {
                return;
            }
            comb.TextChanged -= Comb_TextUpdate;
            dt.Rows[index][Class.ChannelBR3.CTCSEnc] = coms;
            dt.Rows[index][Class.ChannelBR3.CTCSDec] = coms;
            gridControl1.Update();
        }



        private void TextBoxDec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (sender is System.Windows.Forms.TextBox)
            {
                System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
                if (tb.Text.Contains('.') && e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            else if (sender is System.Windows.Forms.ComboBox)
            {
                System.Windows.Forms.ComboBox tb = (System.Windows.Forms.ComboBox)sender;
                if (tb.Text.Contains('.') && e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }


        }
        private void gridControl1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.cmbRxFreq.Visible = false;
            DataGridViewCell cell = this.gridControl1.Rows[e.RowIndex].Cells[e.ColumnIndex];           
            System.Drawing.Rectangle rect = this.gridControl1.GetCellDisplayRectangle(cell.ColumnIndex, cell.RowIndex, true);
            switch (e.ColumnIndex)
            {
                case 1:
                    focuRow = e.RowIndex;
                    focuCol = e.ColumnIndex;
                    cmbRxFreq.Location = rect.Location;                 
                    cmbRxFreq.Size = rect.Size;                 
                    comfirmComboBoxValue(this.cmbRxFreq, (String)cell.Value);
                    System.Drawing.Font ft = new System.Drawing.Font("宋体", 10f);
                    cmbRxFreq.Font = ft;
                    this.cmbRxFreq.Visible = true;
                    cmbRxFreq.Focus();        
                    cmbRxFreq.SelectAll();
                    break;
                case 3:
                    focuRow = e.RowIndex;
                    focuCol = e.ColumnIndex;
                    this.cmbRxFreq.Location = rect.Location;
                    this.cmbRxFreq.Size = rect.Size; 
                    comfirmComboBoxValue(this.cmbRxFreq, (String)cell.Value);
                    System.Drawing.Font fa = new System.Drawing.Font("宋体", 10f);
                    cmbRxFreq.Font = fa;
                    this.cmbRxFreq.Visible = true;
                    cmbRxFreq.Focus();              
                    cmbRxFreq.SelectAll();
                    break;
              
                default:
                    break;
            }
        }


        /// <summary>
        /// 给表的列赋值
        /// </summary>
        /// <param name="com"></param>
        /// <param name="cellValue"></param>
        private void comfirmComboBoxValue(ComboBox com, String cellValue)
        {
            com.SelectedIndex = -1;
            if (cellValue == null)
            {
                com.Text = "";
                return;
            }
            com.Text = cellValue;
            foreach (Object item in com.Items)
            {
                if ((String)item == cellValue)
                {
                    com.SelectedItem = item;
                }
            }
        }
             
       
        private void Initializa16Datatable()
        {
            dt.Clear();
            dt.TableName = "BR3";
            if (dt.Columns.Count == 0)
            {
                for (int i = 0; i < 14; i++)
                {
                    dt.Columns.Add(Enum.Parse(typeof(BR3), i.ToString()).ToString());

                }
            }
            for (int i = 0; i < 16; i++)
            {
                DataRow dr = dt.NewRow();
                dr[ChannelBR3.Channel] = i + 1;
                dt.Rows.Add(dr);
            }
            gridControl1.DataSource = dt;
        }
        public void set400DefaultFre()
        {
            focuCol = 1;
            focuRow = 0;
            cmbRxFreq.Visible = false;
            InitializaDatatable(16);
            for (int i = 0; i < 16; i++)
            {
                switch (i%4)
                {
                    case 0:
                        dt.Rows[i][ChannelBR3.RXFrequency] = 464.55000 .ToString("#0.0000");
                        dt.Rows[i][ChannelBR3.TXFrequency] = 464.55000 .ToString("#0.0000");
                        break;
                    case 1:
                        dt.Rows[i][ChannelBR3.RXFrequency] = 467.92500.ToString("#0.0000");
                        dt.Rows[i][ChannelBR3.TXFrequency] = 467.92500.ToString("#0.0000");
                        break;
                    case 2:
                        dt.Rows[i][ChannelBR3.RXFrequency] = 467.85000.ToString("#0.0000");
                        dt.Rows[i][ChannelBR3.TXFrequency] = 467.85000.ToString("#0.0000");
                        break;
                    case 3:
                        dt.Rows[i][ChannelBR3.RXFrequency] = 467.87500.ToString("#0.0000");
                        dt.Rows[i][ChannelBR3.TXFrequency] = 467.87500.ToString("#0.0000");
                        break;
                    default:
                        break;
                }
                switch (i/4)
                {
                    case 0:
                        dt.Rows[i][ChannelBR3.CTCSDec] = "67.0";
                        dt.Rows[i][ChannelBR3.CTCSEnc] = "67.0";
                        break;
                    case 1:
                        dt.Rows[i][ChannelBR3.CTCSDec] = "82.5";
                        dt.Rows[i][ChannelBR3.CTCSEnc] = "82.5";
                        break;
                    case 2:
                        dt.Rows[i][ChannelBR3.CTCSDec] = "179.9";
                        dt.Rows[i][ChannelBR3.CTCSEnc] = "179.9";
                        break;
                    case 3:
                        dt.Rows[i][ChannelBR3.CTCSDec] = "Off";
                        dt.Rows[i][ChannelBR3.CTCSEnc] = "Off";
                        break;
                    default:
                        break;
                }
                dt.Rows[i][ChannelBR3.BusyLock] = "No";          
                dt.Rows[i][ChannelBR3.Companding] = "No";
                dt.Rows[i][ChannelBR3.ScanningAdd] = "Yes";
                dt.Rows[i][ChannelBR3.TXPower] = "High";
                dt.Rows[i][ChannelBR3.WN] = "Narrow";
                dt.Rows[i][ChannelBR3.PPTID] = "No";
                dt.Rows[i][ChannelBR3.Scrambling] = "No";
                dt.Rows[i][ChannelBR3.Repeater] = "No";
                dt.Rows[i][ChannelBR3.Clone] = "Yes";
            }
        }
      
     

        private void cmbRxFreq_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxDec_KeyPress(sender,e);
        }

        private void cmbRxFreq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                this.cmbRxFreq.Visible = false;
                DataGridViewCell cellx = this.gridControl1.Rows[focuRow+1].Cells[focuCol];
                System.Drawing.Rectangle rect = this.gridControl1.GetCellDisplayRectangle(cellx.ColumnIndex, cellx.RowIndex, true);
                cmbRxFreq.Location = rect.Location;
                cmbRxFreq.Size = rect.Size;
                gridControl1.CurrentCell = cellx;
                comfirmComboBoxValue(this.cmbRxFreq, (String)cellx.Value);
                this.cmbRxFreq.Visible = true;
                cmbRxFreq.Focus();
                cmbRxFreq.SelectAll();
            }
        }

        private void cmbRxFreq_Leave(object sender, EventArgs e)
        {            
            decimal isa = 400;    
            
            DataGridViewCell cell = this.gridControl1.Rows[focuRow].Cells[focuCol];
            if (this.cmbRxFreq.Text.Trim() == "")
            {
                return;
            }
            try
            {
                isa = Convert.ToDecimal(this.cmbRxFreq.Text.Trim());
            }
            catch (Exception)
            {
                cmbRxFreq.Focus();
                return;
            }
           
            switch (focuCol)
            {
                case 1:
                    if (isa < Models.ModelClass.models[0].MinFrequency | isa > Models.ModelClass.models[0].MaxFrequency)
                    {
                        MessageBox.Show("Frequency range of " + Models.ModelClass.models[0].MinFrequency + "MHZ-" + Models.ModelClass.models[0].MaxFrequency + "MHZ");

                        dt.Rows[focuRow][Class.ChannelBR3.RXFrequency] = Models.ModelClass.models[0].MinFrequency.ToString("#0.0000");
                        dt.Rows[focuRow][Class.ChannelBR3.TXFrequency] = Models.ModelClass.models[0].MinFrequency.ToString("#0.0000");
                    }
                    else
                    {
                        dt.Rows[focuRow][Class.ChannelBR3.RXFrequency] = isa.ToString("#0.0000");
                        dt.Rows[focuRow][Class.ChannelBR3.TXFrequency] = isa.ToString("#0.0000");
                    }
                    
                    //this.cmbRxFreq.Visible = false;
                    break;
                case 3:
                    dt.Rows[focuRow][Class.ChannelBR3.TXFrequency]= isa.ToString("#0.0000");
                    
                    //this.cmbRxFreq.Visible = false;
                    break;
                default:
                    break;
            }
            
            gridControl1.Update();
  
        }
    }
}
