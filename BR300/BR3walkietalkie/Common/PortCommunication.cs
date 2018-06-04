using System;
using System.IO.Ports;
using System.Linq;
using System.Threading;

namespace BR300walkietalkie.Common
{
    public static class PortCommunication
    {
        /*连接端口*/
        static SerialPort sp;
        public static int shu = 0;
        public static string s = "";
        public static int reciveLong = 0;

        /*时钟*/
        public static System.Timers.Timer timerSend = new System.Timers.Timer();
        /*超时时间*/
        public static int timeout = 2000;
        /*串口名称*/
        public static string ComName;



        //字节数组转16进制更简单的，利用BitConverter.ToString方法
        //string str0x = BitConverter.ToString(result, 0, result.Length).Replace("-"," ");

        /// <summary>
        /// 端口配置信息
        /// </summary>
        private static void sedserial()
        {
            sp.BaudRate = 9600;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.DataBits = 8;
            sp.Handshake = Handshake.None;
            sp.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
            sp.ReadTimeout = 288;
            sp.WriteTimeout = 200;
        }

        public static void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            //SerialPort sp = (SerialPort)sender;
            //string indata = sp.ReadExisting();
            #region MyRegion
            //    int count = sp.BytesToRead;
            //    //sss+=sp.ReadExisting();
            //    string recive = "";
            //    if (count <= 0)  return;           
            //    while (count< reciveLong)
            //    {
            //        Thread.Sleep(10);
            //        if (sp.IsOpen)
            //        {
            //            count = sp.BytesToRead;
            //        }
            //    }

            //    byte[] data = new byte[count];
            ////sp.ReadExisting();
            //    sp.Read(data, 0, count);
            //    if (count != 0)
            //    {
            //        s = "";
            //    }
            //    foreach (byte item in data)
            //    {
            //        recive += " " + Convert.ToInt16(item).ToString("X2");
            //    }
            //    s = recive.ToLower().Trim();
            #endregion
           // Thread.Sleep(50);
            int count = sp.BytesToRead;
            if (count <= 0) return;
            byte[] data = new byte[count];
            //sp.ReadExisting();
            sp.Read(data, 0, count);

            foreach (byte item in data)
            {
                s += " " + Convert.ToInt16(item).ToString("X2").ToLower().Trim();
            }
        }

        public static void NewSerialPort()
        {
            if (sp == null)
            {
                sp = new SerialPort(ComName);
            }
            else
            {
                sp.PortName = ComName;
            }

        }
        public static void openPort()
        {
            if (sp == null)
            {
                return;
            }
            if (!sp.IsOpen)
            {
                sedserial();

                sp.Open();//打开端口，进行监控  

                Thread.Sleep(100);
                //sp.DataReceived +=serialPort_DataReceived;
            }

        }


        /// <summary>
        /// 关闭商品连接
        /// </summary>
        public static void closePort()
        {
            if (sp == null)
            {
                return;
            }
            if (sp.IsOpen)
                sp.DataReceived -= serialPort_DataReceived;
            Thread.Sleep(1000);
            sp.Close();
        }

        /// <summary>
        /// 发送信息
        /// </summary>
        /// <param name="tsx">要发送的信息</param>
        /// <returns></returns>
        public static bool sendMassge(string tsx)
        {
            sp.DiscardInBuffer();
            string[] dat = tsx.Split(' ');
            byte[] data = new byte[dat.Count()];
            for (int i = 0; i < dat.Count(); i++)
            {
                data[i] = Convert.ToByte(Convert.ToInt32(dat[i], 16));

            }
            sp.Write(data, 0, data.Count());

            return true;
        }

        /// <summary>
        /// 发送接收信息
        /// </summary>
        /// <param name="write">写信息</param>
        /// <param name="read">读信息</param>
        public static void senderMsg(string write, string read)
        {
            s = "";
            sendMassge(write);
            timerSend.Enabled = false;
            timerSend.Interval = timeout;
            timerSend.Enabled = true;
            while (s != read) ;
        }
        /// <summary>
        /// 发送接收信息
        /// </summary>
        /// <param name="write">写信息</param>
        /// <param name="read">读信息</param>
        public static void senderMsg(string write, string read, int lenth)
        {
            //s = "";
            //reciveLong = lenth;
            //sendMassge(write);
            //MainForm.timerSend.Enabled = false;
            //MainForm.timerSend.Interval = MainForm.timeout;
            //MainForm.timerSend.Enabled = true;

            //while (s != read) ;

            s = "";
            reciveLong = lenth;
            sendMassge(write);
            timerSend.Enabled = false;
            timerSend.Interval = timeout;
            timerSend.Enabled = true;
            int si = s.Split(' ').Count();
            while (s.Split(' ').Count() < lenth + 1) ;
            //string sad = s.Substring(1);
            while (s.Substring(1) != read) ;
        }


        /// <summary>
        /// 发送指令接收信息
        /// </summary>
        /// <param name="write">发送的指令</param>
        /// <returns>接收的信息</returns>
        public static string reciveMsg(string write, int lenth)
        {
            //s = "";
            //reciveLong = lenth;
            //sendMassge(write);
            //MainForm.timerSend.Enabled = false;
            //MainForm.timerSend.Interval = MainForm.timeout;
            //MainForm.timerSend.Enabled = true;

            //while (s == "") ;
            ////Thread.Sleep(shotsleep);
            //return s;

            s = "";
            reciveLong = lenth;
            sendMassge(write);
            timerSend.Enabled = false;
            timerSend.Interval = timeout;
            timerSend.Enabled = true;
            string[] adfw = s.Split(' ');
            while (s.Split(' ').Count() < lenth + 1) ;

            //Thread.Sleep(shotsleep);
            return s.Substring(1);
        }
        /// <summary>
        /// 发送指令接收信息
        /// </summary>
        /// <param name="write">发送的指令</param>
        /// <returns>接收的信息</returns>
        public static string reciveMsg(string write)
        {
            s = "";
            sendMassge(write);
            timerSend.Enabled = false;
            timerSend.Interval = timeout;
            timerSend.Enabled = true;

            while (s == "") ;
            //Thread.Sleep(shotsleep);
            return s;
        }

        public static void FirstCon(string write, string read, int lenth)
        {
            s = "";
            reciveLong = lenth;
            timerSend.Enabled = false;
            timerSend.Interval = timeout;
            timerSend.Enabled = true;
            sendMassge(write);
            while (s.Split(' ').Count() < lenth + 1) ;
        }
    }
}
