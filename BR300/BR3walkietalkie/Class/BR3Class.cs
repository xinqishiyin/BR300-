using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BR300walkietalkie.Class
{
    public class BR3Class
    {
        int dtRowCount;
        /// <summary>
        /// 频率范围
        /// </summary>
        int fto;
        /// <summary>
        /// 发射开始码
        /// </summary>
        string txStart;
        /// <summary>
        /// 发射结束码
        /// </summary>
        string txStop;
        /// <summary>
        /// 开机显示
        /// </summary>
        string display;
        /// <summary>
        /// 开机显示模式
        /// </summary>
        int displayMode;
        /// <summary>
        /// 静噪等级
        /// </summary>
        int squelchLevel;
        /// <summary>
        /// 发射时限
        /// </summary>
        int txLimit;
        /// <summary>
        /// 声控等级
        /// </summary>
        int voiceLevel;
        /// <summary>
        /// 声控延迟时间
        /// </summary>
        int voiceDelay;
        /// <summary>
        /// 扫描模式
        /// </summary>
        int scanMode;
        /// <summary>
        /// 侧键1短按
        /// </summary>
        int shotPress1;
        /// <summary>
        /// 侧键2短按
        /// </summary>
        int shotPress2;
        /// <summary>
        /// 侧键1长按
        /// </summary>
        int longPress1;
        /// <summary>
        /// 侧键2长按
        /// </summary>
        int longPress2;
        /// <summary>
        /// PPT ID
        /// </summary>
        int ppt;
        /// <summary>
        /// 语音播报
        /// </summary>
        int voiceAnnouncements;
        /// <summary>
        /// 开机信道
        /// </summary>
        int startupCh;

        bool rogerTone;
        /// <summary>
        /// 电池省电
        /// </summary>
        bool powerSaving;
        /// <summary>
        /// 哔音
        /// </summary>
        bool beepSound;
        /// <summary>
        /// 克隆
        /// </summary>
        bool clone;

        /// <summary>
        /// 通道列表
        /// </summary>
        DataTable channel;

        /// <summary>
        /// 显示亮度
        /// </summary>
        int brightness;
        /// <summary>
        /// 发射开始码
        /// </summary>
        public string TxStart
        {
            get
            {
                return txStart;
            }

            set
            {
                txStart = value;
            }
        }
        /// <summary>
        /// 发射结束码
        /// </summary>
        public string TxStop
        {
            get
            {
                return txStop;
            }

            set
            {
                txStop = value;
            }
        }
        /// <summary>
        /// 开机显示
        /// </summary>
        public string Display
        {
            get
            {
                return display;
            }

            set
            {
                display = value;
            }
        }
        /// <summary>
        /// 频率范围
        /// </summary>
        public int Fto
        {
            get
            {
                return fto;
            }

            set
            {
                fto = value;
            }
        }
        /// <summary>
        /// 开机显示模式
        /// </summary>
        public int DisplayMode
        {
            get
            {
                return displayMode;
            }

            set
            {
                displayMode = value;
            }
        }
        /// <summary>
        /// 静噪等级
        /// </summary>
        public int SquelchLevel
        {
            get
            {
                return squelchLevel;
            }

            set
            {
                squelchLevel = value;
            }
        }
        /// <summary>
        /// 发身时限
        /// </summary>
        public int TxLimit
        {
            get
            {
                return txLimit;
            }

            set
            {
                txLimit = value;
            }
        }
        /// <summary>
        /// 声控等级
        /// </summary>
        public int VoiceLevel
        {
            get
            {
                return voiceLevel;
            }

            set
            {
                voiceLevel = value;
            }
        }
        /// <summary>
        /// 声控延迟时间
        /// </summary>
        public int VoiceDelay
        {
            get
            {
                return voiceDelay;
            }

            set
            {
                voiceDelay = value;
            }
        }
        /// <summary>
        /// 扫描模式
        /// </summary>
        public int ScanMode
        {
            get
            {
                return scanMode;
            }

            set
            {
                scanMode = value;
            }
        }
        /// <summary>
        /// 按键1短按
        /// </summary>
        public int ShotPress1
        {
            get
            {
                return shotPress1;
            }

            set
            {
                shotPress1 = value;
            }
        }
        /// <summary>
        /// 按键2短按
        /// </summary>
        public int ShotPress2
        {
            get
            {
                return shotPress2;
            }

            set
            {
                shotPress2 = value;
            }
        }
        /// <summary>
        /// 按键1长按
        /// </summary>
        public int LongPress1
        {
            get
            {
                return longPress1;
            }

            set
            {
                longPress1 = value;
            }
        }
        /// <summary>
        /// 按键2长按
        /// </summary>
        public int LongPress2
        {
            get
            {
                return longPress2;
            }

            set
            {
                longPress2 = value;
            }
        }
        /// <summary>
        /// PPT ID
        /// </summary>
        public int Ppt
        {
            get
            {
                return ppt;
            }

            set
            {
                ppt = value;
            }
        }

        /// <summary>
        /// 语音播报方式
        /// </summary>
        public int VoiceAnnouncements
        {
            get
            {
                return voiceAnnouncements;
            }

            set
            {
                voiceAnnouncements = value;
            }
        }
        /// <summary>
        /// 电池省电
        /// </summary>
        public bool PowerSaving
        {
            get
            {
                return powerSaving;
            }

            set
            {
                powerSaving = value;
            }
        }
        /// <summary>
        /// 哔 音
        /// </summary>
        public bool BeepSound
        {
            get
            {
                return beepSound;
            }

            set
            {
                beepSound = value;
            }
        }
        /// <summary>
        /// 通道列表
        /// </summary>
        public DataTable Channel
        {
            get
            {
                return channel;
            }

            set
            {
                channel = value;
            }
        }
        /// <summary>
        /// 开机信道
        /// </summary>
        public int StartupCh
        {
            get
            {
                return startupCh;
            }

            set
            {
                startupCh = value;
            }
        }

        public bool RogerTone
        {
            get
            {
                return rogerTone;
            }

            set
            {
                rogerTone = value;
            }
        }
        /// <summary>
        /// 克隆
        /// </summary>
        public bool Clone1
        {
            get
            {
                return clone;
            }

            set
            {
                clone = value;
            }
        }
        /// <summary>
        /// 显示亮度
        /// </summary>
        public int Brightness
        {
            get
            {
                return brightness;
            }

            set
            {
                brightness = value;
            }
        }

        public int DtRowCount
        {
            get
            {
                return dtRowCount;
            }

            set
            {
                dtRowCount = value;
            }
        }
    }
    public class ChannelBR3
    {
        /// <summary>
        /// 通道
        /// </summary>
        public static string Channel = "Channel";
        /// <summary>
        /// 接收频率
        /// </summary>
        public static string RXFrequency = "RXFrequency";
        /// <summary>
        /// ctc解码
        /// </summary>
        public static string CTCSDec = "CTCSDec";
        /// <summary>
        /// 发送频率
        /// </summary>
        public static string TXFrequency = "TXFrequency";
        /// <summary>
        /// ctc编码
        /// </summary>
        public static string CTCSEnc = "CTCSEnc";
        /// <summary>
        /// 扫描
        /// </summary>
        public static string ScanningAdd = "ScanningAdd";
        /// <summary>
        /// 宽带
        /// </summary>
        public static string WN = "WN";
        /// <summary>
        /// 发射功率
        /// </summary>
        public static string TXPower = "TXPower";
        /// <summary>
        /// 忙锁
        /// </summary>
        public static string BusyLock = "BusyLock";
        /// <summary>
        /// 扰码
        /// </summary>
        public static string Scrambling = "Scrambling";
        /// <summary>
        /// 压扩
        /// </summary>
        public static string Companding = "Companding";
        /// <summary>
        /// 中继
        /// </summary>
        public static string Repeater = "Repeater";
        /// <summary>
        /// PPTID
        /// </summary>
        public static string PPTID = "PPTID";
        /// <summary>
        /// Clone
        /// </summary>
        public static string Clone = "Clone";

    }
    public enum BR3
    {
        Channel,
        RXFrequency,
        CTCSDec,
        TXFrequency,
        CTCSEnc,
        ScanningAdd,
        WN,
        TXPower,
        BusyLock,
        Scrambling,
        Companding,
        Repeater,
        PPTID,
        Clone
    }
}
