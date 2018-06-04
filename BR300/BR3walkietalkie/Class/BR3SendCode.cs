using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BR300walkietalkie
{
    public class BR3SendCode
    {
        /// <summary>
        /// 握手发送字符串
        /// </summary>
        public static string connSendCode = "02 50 52 4f 47 52 41 4d";

        /// <summary>
        /// 上位机回应字符串
        /// </summary>
        public static string connReciveCode = "06";
        /// <summary>
        /// 上位机回应字符串
        /// </summary>
        public static string connReSureCode = "06";

        /// <summary>
        /// 确认连接字符串
        /// </summary>
        public static string connSendSure = "02";

        /// <summary>
        /// 确认连接接收字符串
        /// </summary>
        public static string connReciveSure = "53 4d 50 35 35 38 ff ff";


        public static string readSendCode = "52";
        public static int readStartAdress = 0;
        public static int readAdressLenth = 8;


        public static string writeSendCode = "57";
        public static int writeStartAdress = 0;
        public static int writeAdressLenth = 8;

        public static string writeNull = "ff ff ff ff ff ff ff ff";
        /// <summary>
        /// 开机显示地址1
        /// </summary>
        public static int dispalyAdress1 = 7 * 16 * 16 + 9 * 16;
        /// <summary>
        /// 开机显示地址2
        /// </summary>
        public static int dispalyAdress2 = 7 * 16 * 16 + 9 * 16+8;
        /// <summary>
        /// 发射开始码地址
        /// </summary>
        public static int TxStartAdress =7*16*16+10*16;
        /// <summary>
        /// 扫描模式，PTT ID 语音语言 省电，哔音 静噪等级，侧键1短，发射限时，声控等级，侧键2短 声控延迟时间 设置地址
        /// </summary>
        public static int pragramAdress = 7 * 16 * 16 + 12 * 16;
        /// <summary>
        /// 侧键1长 侧键2长 开机显示方式 设置地址
        /// </summary>
        public static int pragramAdress1 = 7 * 16 * 16 + 12 * 16+8;
        /// <summary>
        /// 频率范围地址
        /// </summary>
        public static int Fto = 7 * 16 * 16 + 13 * 16 + 8;
        /// <summary>
        /// 发射结束码地址
        /// </summary>
        public static int TxStopAdress = 7 * 16 * 16 + 14 * 16;

    }
}
