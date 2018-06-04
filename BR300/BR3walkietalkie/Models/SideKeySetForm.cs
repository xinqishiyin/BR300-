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
    public partial class SideKeySetForm : BaseForm
    {
        public SideKeySetForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;           
        }
        private void Init()
        {
            cmbLongPress1.SelectedIndex = BR3Channel.br3.LongPress1;
            cmbLongPress2.SelectedIndex = BR3Channel.br3.LongPress2;
            cmbShotPress1.SelectedIndex = BR3Channel.br3.ShotPress1;
            cmbShotPress2.SelectedIndex = BR3Channel.br3.ShotPress2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbShotPress1.SelectedIndex = 3;
            cmbShotPress2.SelectedIndex = 1;
            cmbLongPress1.SelectedIndex = 6;
            cmbLongPress2.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BR3Channel.br3.LongPress1 = cmbLongPress1.SelectedIndex;
            BR3Channel.br3.LongPress2 = cmbLongPress2.SelectedIndex;
            BR3Channel.br3.ShotPress1 = cmbShotPress1.SelectedIndex;
            BR3Channel.br3.ShotPress2 = cmbShotPress2.SelectedIndex;
            this.Close();
        }

        private void SideKeySetForm_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
