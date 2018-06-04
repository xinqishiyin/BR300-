using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BR300walkietalkie
{
    public partial class RollWait : Form
    {
        //DateTime dt;
        public RollWait()
        {
            InitializeComponent();
            Thread myThread = new Thread(DoData);
            myThread.IsBackground = true;
            myThread.Start(3000); //线程开始           
            //dt = DateTime.Now;                         
        }
   
          //记时  
        private delegate void DoDataDelegate(object number);
        /// <summary>  
        /// 进行循环  
        /// </summary>  
        /// <param name="number"></param>  
        private void DoData(object number)
        {
            if (progressBar1.InvokeRequired)
            {
                DoDataDelegate d = DoData;
                progressBar1.Invoke(d, number);
            }
            else
            {
                progressBar1.Maximum = (int)number;
                for (int i = 0; i < (int)number; i++)
                {
                    progressBar1.Value = i;
                    Application.DoEvents();
                }
                 //循环结束截止时间  
            }
        }

     
    }
}  
    
