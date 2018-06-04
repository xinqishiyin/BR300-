using BR300walkietalkie.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace BR300walkietalkie
{
    public partial class Ports : BaseForm
    {
        public Ports()
        {
            InitializeComponent();
      
            this.StartPosition = FormStartPosition.CenterParent;
            string[] ses = MulGetHardwareInfo(HardwareEnum.Win32_PnPEntity, "Name");
            
            for (int i = 0; i < ses.Length; i++)
            {              //this.barSubItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Com_CheckedChanged);                              
                if (ses[i].ToString().Contains("COM"))
                {
                    comboBox1.Items.Add(ses[i].Substring(ses[i].Length - 5).Substring(0, 4));
                }
            }
            if (PortCommunication.ComName != null)
            {
                comboBox1.Text = PortCommunication.ComName;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            PortCommunication.ComName = comboBox1.Text;
               
            this.Close();
        }
        public void GetComList()
        {

            string[] ses = MulGetHardwareInfo(HardwareEnum.Win32_PnPEntity, "Name");
            //portItem.DropDownItems.Clear();
            for (int i = 0; i < ses.Length; i++)
            {
                //this.barSubItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Com_CheckedChanged);


                if (ses[i].ToString().Contains("USB"))
                {

                    PortCommunication.ComName = ses[i].Substring(ses[i].Length - 5).Substring(0, 4); ;
                }
            }
        }
        /// <summary>
        /// 枚举win32 api
        /// </summary>
        public enum HardwareEnum
        {
            // 硬件
            Win32_Processor, // CPU 处理器
            Win32_PhysicalMemory, // 物理内存条
            Win32_Keyboard, // 键盘
            Win32_PointingDevice, // 点输入设备，包括鼠标。
            Win32_FloppyDrive, // 软盘驱动器
            Win32_DiskDrive, // 硬盘驱动器
            Win32_CDROMDrive, // 光盘驱动器
            Win32_BaseBoard, // 主板
            Win32_BIOS, // BIOS 芯片
            Win32_ParallelPort, // 并口
            Win32_SerialPort, // 串口
            Win32_SerialPortConfiguration, // 串口配置
            Win32_SoundDevice, // 多媒体设置，一般指声卡。
            Win32_SystemSlot, // 主板插槽 (ISA & PCI & AGP)
            Win32_USBController, // USB 控制器
            Win32_NetworkAdapter, // 网络适配器
            Win32_NetworkAdapterConfiguration, // 网络适配器设置
            Win32_Printer, // 打印机
            Win32_PrinterConfiguration, // 打印机设置
            Win32_PrintJob, // 打印机任务
            Win32_TCPIPPrinterPort, // 打印机端口
            Win32_POTSModem, // MODEM
            Win32_POTSModemToSerialPort, // MODEM 端口
            Win32_DesktopMonitor, // 显示器
            Win32_DisplayConfiguration, // 显卡
            Win32_DisplayControllerConfiguration, // 显卡设置
            Win32_VideoController, // 显卡细节。
            Win32_VideoSettings, // 显卡支持的显示模式。

            // 操作系统
            Win32_TimeZone, // 时区
            Win32_SystemDriver, // 驱动程序
            Win32_DiskPartition, // 磁盘分区
            Win32_LogicalDisk, // 逻辑磁盘
            Win32_LogicalDiskToPartition, // 逻辑磁盘所在分区及始末位置。
            Win32_LogicalMemoryConfiguration, // 逻辑内存配置
            Win32_PageFile, // 系统页文件信息
            Win32_PageFileSetting, // 页文件设置
            Win32_BootConfiguration, // 系统启动配置
            Win32_ComputerSystem, // 计算机信息简要
            Win32_OperatingSystem, // 操作系统信息
            Win32_StartupCommand, // 系统自动启动程序
            Win32_Service, // 系统安装的服务
            Win32_Group, // 系统管理组
            Win32_GroupUser, // 系统组帐号
            Win32_UserAccount, // 用户帐号
            Win32_Process, // 系统进程
            Win32_Thread, // 系统线程
            Win32_Share, // 共享
            Win32_NetworkClient, // 已安装的网络客户端
            Win32_NetworkProtocol, // 已安装的网络协议
            Win32_PnPEntity,//all device
        }
        /// <summary>
        /// WMI取硬件信息
        /// </summary>
        /// <param name="hardType"></param>
        /// <param name="propKey"></param>
        /// <returns></returns>
        public static string[] MulGetHardwareInfo(HardwareEnum hardType, string propKey)
        {

            List<string> strs = new List<string>();
            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + hardType))
                {
                    var hardInfos = searcher.Get();
                    foreach (var hardInfo in hardInfos)
                    {
                        if (hardInfo.Properties[propKey].Value != null)
                        {
                            if (hardInfo.Properties[propKey].Value.ToString().Contains("COM"))
                            {
                                strs.Add(hardInfo.Properties[propKey].Value.ToString());
                            }
                        }

                    }
                    searcher.Dispose();
                }
                return strs.ToArray();
            }
            catch
            {
                return null;
            }
            finally
            { strs = null; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void xqComboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            string s = this.comboBox1.Items[e.Index].ToString();
            // 计算字符串尺寸（以像素为单位）
            SizeF ss = e.Graphics.MeasureString(s, e.Font);
            // 水平居中
            float left = (float)(e.Bounds.Width - ss.Width) / 2;
            if (left < 0) left = 0f;
            float top = (float)(e.Bounds.Height - ss.Height) / 2;
            // 垂直居中
            if (top < 0) top = 0f;
            top = top + this.comboBox1.ItemHeight * e.Index;
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
