using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BR300walkietalkie.Models
{
    public partial class AdvancedForm : BaseForm
    {
        public AdvancedForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbTimeOut.SelectedIndex = 4;
            cmbSque.SelectedIndex = 5;
            cmbVoice.SelectedIndex = 1;
            cmbBatte.SelectedIndex = 0;
            cmbVoxLevel.SelectedIndex = 0;
            txtPowOnName.Text = "MIDLAND";
            chkRogerBeep.Checked = true;
            cmbBrightnessLev.SelectedIndex = 2;
            chkKeyTone.Checked = true;
            cmbScanMode.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbBatte.SelectedIndex == 0) BR3Channel.br3.PowerSaving = true;
            else BR3Channel.br3.PowerSaving = false;
            BR3Channel.br3.VoiceAnnouncements = cmbVoice.SelectedIndex;
            BR3Channel.br3.SquelchLevel = cmbSque.SelectedIndex;
            BR3Channel.br3.TxLimit = cmbTimeOut.SelectedIndex;
            BR3Channel.br3.ScanMode = cmbScanMode.SelectedIndex;
            BR3Channel.br3.Brightness = cmbBrightnessLev.SelectedIndex+1;
            BR3Channel.br3.Display = txtPowOnName.Text;
            BR3Channel.br3.VoiceLevel = cmbVoxLevel.SelectedIndex;
            BR3Channel.br3.BeepSound = chkKeyTone.Checked;
            BR3Channel.br3.RogerTone = chkRogerBeep.Checked;           
            this.Close();         
        }

        private void AdvancedForm_Load(object sender, EventArgs e)
        {
            if (BR3Channel.br3.PowerSaving) cmbBatte.SelectedIndex = 0;
            else cmbBatte.SelectedIndex = 1;
            cmbVoice.SelectedIndex = BR3Channel.br3.VoiceAnnouncements;
            cmbSque.SelectedIndex = BR3Channel.br3.SquelchLevel;
            cmbTimeOut.SelectedIndex = BR3Channel.br3.TxLimit;
            chkKeyTone.Checked = BR3Channel.br3.BeepSound;
            chkRogerBeep.Checked = BR3Channel.br3.RogerTone;
            cmbVoxLevel.SelectedIndex = BR3Channel.br3.VoiceLevel;
            txtPowOnName.Text = BR3Channel.br3.Display;
            cmbBrightnessLev.SelectedIndex = BR3Channel.br3.Brightness-1;
            cmbScanMode.SelectedIndex = BR3Channel.br3.ScanMode;    
        }

        private void txtPowOnName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPowOnName.Text.Length >= 10)
            {
                if (e.KeyChar == 8||e.KeyChar == 13)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                if ((int)e.KeyChar >= 97)
                {
                    e.KeyChar = (char)((int)e.KeyChar - 32);
                }
                //限制只能输入1-9的数字字母ABCD，退格键，回车
                if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || e.KeyChar == 13 || e.KeyChar == 8 || ((int)e.KeyChar >= 65 && (int)e.KeyChar <= 90) || ((int)e.KeyChar >= 97 && (int)e.KeyChar <= 122))
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
