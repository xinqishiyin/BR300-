using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BR300walkietalkie
{
    public partial class MainBaseForm : Form
    {
        public MainBaseForm()
        {
            InitializeComponent();
        }
        Point mouseOff;
        bool leftFlag;
        bool isMaxSize = false;

        private void BaseForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;
            if (this.Icon==null)
            {
                lblTitle.Location = new Point(12, 10);
            }
            else
            {
                lblTitle.Location = new Point(40,10);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);
                leftFlag = true;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);
                Location = mouseSet;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.notifyIcon1.Visible = true;
            this.WindowState = FormWindowState.Minimized;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isMaxSize)
            {
                this.WindowState = FormWindowState.Normal;
                isMaxSize = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                isMaxSize = true;
            }
            
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (isMaxSize)
            {
                this.WindowState = FormWindowState.Normal;
                isMaxSize = false;
                //this.Size = new Size(720, 530);
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                isMaxSize = true;
            }
        }


    }
}
