using BR300walkietalkie.Class;
using BR300walkietalkie.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BR300walkietalkie.ReadWrite
{
    public static class BR3
    {
        public static string[] recive = new string[32 * 8];
        internal static bool connect()
        {
            
            PortCommunication.senderMsg(BR3SendCode.connSendCode, BR3SendCode.connReciveCode, 1);
            MainForm.barEditItem3.Value  = 1;

            PortCommunication.senderMsg(BR3SendCode.connSendSure, BR3SendCode.connReciveSure, 8);
            MainForm.barEditItem3.Value  = 2;
            PortCommunication.senderMsg(BR3SendCode.connReSureCode, BR3SendCode.connReciveCode, 1);
            MainForm.barEditItem3.Value  = 3;
            //lblConnect.Text = "握手完成";
            //progressBar1.Value = 4;
            //MsgBox.Show("握手成功");
            return true;
        }

        internal static bool BR3Read()
        {                
            for (int i = 0; i < 32*8; i++)
            {
                recive[i] = PortCommunication.reciveMsg(BR3SendCode.readSendCode + " " + Common.Common.decToHex(BR3SendCode.readStartAdress+i*8, 8) + " " + Common.Common.decToHex(BR3SendCode.readAdressLenth), BR3SendCode.readAdressLenth+4);            
                MainForm.barEditItem3.Value = (4+i/3)/1;
            }
            PortCommunication.sendMassge("62");
            return true;
        }

        internal static bool BR3Write(Class.BR3Class br3 )
        {
            string str;
            PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.writeStartAdress + 0 * 8, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)+" "+ BR3SendCode.writeNull, BR3SendCode.connReciveCode, 1);
            PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.writeStartAdress + 1 * 8, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth) + " " + BR3SendCode.writeNull, BR3SendCode.connReciveCode, 1);
            for (int i = 0;i<99; i++)
            {
                if (i<br3.DtRowCount)
                {
                    if (br3.Channel.Rows[i][Class.ChannelBR3.TXFrequency] != null && br3.Channel.Rows[i][ChannelBR3.TXFrequency].ToString() != "")
                    {
                        PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.writeStartAdress + (i + 1) * 16, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)
                           + " " + decFrequencyToHex(Convert.ToDouble(br3.Channel.Rows[i][ChannelBR3.TXFrequency])) + " " + decFrequencyToHex(Convert.ToDouble(br3.Channel.Rows[i][ChannelBR3.RXFrequency]))
                           , BR3SendCode.connReciveCode, 1);
                        str = br3.Channel.Rows[i][ChannelBR3.Clone].ToString() == "Yes" ? "ff" : "fe";
                        PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.writeStartAdress + (i + 1) * 16 + 8, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)
                           + " " + CTCSToHex(br3.Channel.Rows[i][ChannelBR3.CTCSDec].ToString()) + " " + CTCSToHex(br3.Channel.Rows[i][ChannelBR3.CTCSEnc].ToString())
                           + " " + ChannelParam(br3.Channel.Rows[i]) + " " + str + " ff ff"
                            , BR3SendCode.connReciveCode, 1);
                    }
                    else
                    {
                        PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.writeStartAdress + (i + 1) * 16, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)
                           + " ff ff ff ff ff ff ff ff"
                           , BR3SendCode.connReciveCode, 1);

                        PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.writeStartAdress + (i + 1) * 16 + 8, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)
                           + " ff ff ff ff ff ff ff ff"
                            , BR3SendCode.connReciveCode, 1);
                    }
                }
                else
                {
                    PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.writeStartAdress + (i + 1) * 16, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)
                           + " ff ff ff ff ff ff ff ff"
                           , BR3SendCode.connReciveCode, 1);

                    PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.writeStartAdress + (i + 1) * 16 + 8, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)
                       + " ff ff ff ff ff ff ff ff"
                        , BR3SendCode.connReciveCode, 1);
                }
                
                MainForm.barEditItem3.Value =Convert.ToInt32( i / 1.2 + 4);//82.5+4
            }
            string[] dis = CodeToHex(br3.Display);
            //57 07 90 08
            PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.dispalyAdress1, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)
                + " " + dis[0]+" " +dis[1]+" "+dis[2]+" " + dis[3]+" " +dis[4]+" "+dis[5]+" " +dis[6]+" " +dis[7]
                , BR3SendCode.connReciveCode, 1);
            MainForm.barEditItem3.Value = 88;
            //57 07 98 08        

            //PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.dispalyAdress2, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)
            //    + " " + dis[8] + " " + dis[9] + " ff ff ff ff ff "/*+Common.Common.decToHex(br3.RogerTone==true? 1:0 ) +" "*/+ Common.Common.decToHex((br3.StartupCh))
            //    , BR3SendCode.connReciveCode, 1);
            PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.dispalyAdress2, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)
                + " " + dis[8] + " " + dis[9] + " ff ff ff "+ Common.Common.decToHex(br3.Brightness) + " " + Common.Common.decToHex(br3.RogerTone==true? 1:0 ) + " " + Common.Common.decToHex((br3.StartupCh))
                , BR3SendCode.connReciveCode, 1);
            MainForm.barEditItem3.Value = 90;
            //57 07 a0 08
            PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.TxStartAdress, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)
                + " " + TxCodeToHex(br3.TxStart)
                , BR3SendCode.connReciveCode, 1);
            MainForm.barEditItem3.Value = 92;
            //57 07 c0 08
            PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.pragramAdress, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)
                + " " + Common.Common.decToHex((br3.Ppt+br3.ScanMode*4)*16+(br3.BeepSound?1:0)+(br3.PowerSaving?1:0)*2+br3.VoiceAnnouncements*4)
                +" "+ Common.Common.decToHex(br3.SquelchLevel)+" "+ pressToHex(br3.ShotPress1)+" "+ Common.Common.decToHex(br3.TxLimit)+" "+ Common.Common.decToHex(br3.VoiceLevel)+" "+pressToHex(br3.ShotPress2)+" ff "+ Common.Common.decToHex(br3.VoiceDelay)
                , BR3SendCode.connReciveCode, 1);
            MainForm.barEditItem3.Value = 94;
            //57 07 c8 08
            if (br3.Fto==0)
            {
                //PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.pragramAdress1, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)
                //+ " " + pressToHex(br3.LongPress1) + " 0a " + Common.Common.decToHex(br3.DisplayMode) + " ff ff ff ff ff"
                //, BR3SendCode.connReciveCode, 1);
                PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.pragramAdress1, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)
               + " " + pressToHex(br3.LongPress1) + " " + pressToHex(br3.LongPress2) + " " + Common.Common.decToHex(br3.DisplayMode) + " ff ff ff ff ff"
               , BR3SendCode.connReciveCode, 1);
            }
            else if (br3.Fto==1)
            {
                PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.pragramAdress1, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)
                + " " + pressToHex(br3.LongPress1) + " " + pressToHex(br3.LongPress2) + " " + Common.Common.decToHex(br3.DisplayMode) + " ff ff ff ff ff"
                , BR3SendCode.connReciveCode, 1);                
            }
            MainForm.barEditItem3.Value = 96;
            //57 07 d8 08

            if (br3.Fto==0)
            {
                PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.Fto, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)
                + " 60 44 80 44 ff ff ff ff"
                , BR3SendCode.connReciveCode, 1);
            }
            else if (br3.Fto == 1)
            {               
                PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.Fto, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)
                + " 00 45 00 52 ff ff ff ff"
                , BR3SendCode.connReciveCode, 1);
            }
            MainForm.barEditItem3.Value = 98;

         
            //57 07 e0 08
            PortCommunication.senderMsg(BR3SendCode.writeSendCode + " " + Common.Common.decToHex(BR3SendCode.TxStopAdress, 8) + " " + Common.Common.decToHex(BR3SendCode.writeAdressLenth)
               + " " + TxCodeToHex(br3.TxStop)
               , BR3SendCode.connReciveCode, 1);
            MainForm.barEditItem3.Value = 100;
            PortCommunication.sendMassge("62");
            return true;
        }

        /// <summary>
        /// 侧键转换
        /// </summary>
        /// <returns></returns>
        private static string pressToHex(int i)
        {
            switch (i)
            {
                case 0:return "00";
                case 1:return "01";
                case 2:return "02";
                case 3:return "03";
                case 4:return "05";
                case 5:return "06";
                case 6:return "07";
                default:return "ff";
            }
            
        }

        /// <summary>
        /// 发射开始结束码按规则转16进制
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        private static string TxCodeToHex(string code)
        {
          
                int count = code.Length;
            switch (count)
            {
                case 0:
                    return "ff ff ff ff ff ff ff ff";
                case 1:
                    return "0" + code.Substring(0, 1) + " ff ff ff ff ff ff ff";
                case 2:
                    return "0" + code.Substring(0, 1) + " 0" + code.Substring(1, 1) + " ff ff ff ff ff ff";
                case 3:
                    return "0" + code.Substring(0, 1) + " 0" + code.Substring(1, 1) + " 0" + code.Substring(2, 1) + " ff ff ff ff ff";
                case 4:
                    return "0" + code.Substring(0, 1) + " 0" + code.Substring(1, 1) + " 0" + code.Substring(2, 1) + " 0" + code.Substring(3, 1) + " ff ff ff ff";
                case 5:
                    return "0" + code.Substring(0, 1) + " 0" + code.Substring(1, 1) + " 0" + code.Substring(2, 1) + " 0" + code.Substring(3, 1) + " 0" + code.Substring(4, 1) + " ff ff ff";
                case 6:
                    return "0" + code.Substring(0, 1) + " 0" + code.Substring(1, 1) + " 0" + code.Substring(2, 1) + " 0" + code.Substring(3, 1) + " 0" + code.Substring(4, 1) + " 0" + code.Substring(5, 1) + " ff ff";

                case 7:
                    return "0" + code.Substring(0, 1) + " 0" + code.Substring(1, 1) + " 0" + code.Substring(2, 1) + " 0" + code.Substring(3, 1) + " 0" + code.Substring(4, 1) + " 0" + code.Substring(5, 1) + " 0" + code.Substring(6, 1) + " ff";

                case 8:
                    return "0" + code.Substring(0, 1) + " 0" + code.Substring(1, 1) + " 0" + code.Substring(2, 1) + " 0" + code.Substring(3, 1) + " 0" + code.Substring(4, 1) + " 0" + code.Substring(5, 1) + " 0" + code.Substring(6, 1) + " 0" + code.Substring(7, 1);
                default:
                    return "ff ff ff ff ff ff ff ff";
            }



        }

        /// <summary>
        /// 字母转16进制码
        /// </summary>
        /// <returns></returns>
        private static string[] CodeToHex(string code)
        {
            if (code.Trim() == "")
            {

                return new string[] { "ff", "ff", "ff", "ff", "ff", "ff", "ff", "ff", "ff", "ff" };
            }
            else
            {
                string[] str = new string[10];
                for (int i = 0; i < code.Length; i++)
                {
                    str[i] = code.Substring(i, 1) == " " ? "02" : Common.Common.decToHex((short)System.Text.Encoding.ASCII.GetBytes(code.Substring(i, 1))[0]);
                }
                for (int i = code.Length; i < 10; i++)
                {
                    str[i] = "ff";
                }
                return str;
            }
        }

        /// <summary>
        /// 通道各功能按规则转16进制码
        /// </summary>
        /// <param name="br3"></param>
        /// <returns></returns>
        private static string ChannelParam(DataRow br3)
        {
            int x = 0;
            x += ((br3[ChannelBR3.ScanningAdd].ToString() == "Yes" )? 0 : 16);//bit4
            x +=( (br3[ChannelBR3.Scrambling].ToString() == "Yes") ? 0 : 32);  //bit5
            x += ((br3[ChannelBR3.Companding].ToString() == "No" )? 64 :0);   //bit6
            x += ((br3[ChannelBR3.PPTID].ToString() == "Yes") ? 0 : 128);  //bit7

            x += ((br3[ChannelBR3.BusyLock].ToString() == "Yes") ? 0 : 1);//bit0
            x += ((br3[ChannelBR3.Repeater].ToString() == "Yes") ? 2 : 0);//bit1
            x += ((br3[ChannelBR3.WN].ToString() == "Narrow") ? 4 : 0);   //bit2
            x += ((br3[ChannelBR3.TXPower].ToString() == "Low") ? 0 : 8); //bit3
            return Common.Common.decToHex(x);

        }

        /// <summary>
        /// ctcs转化成16进制码
        /// </summary>
        private static string CTCSToHex(string ctcs)
        {
            if (ctcs=="Off")
            {
                return "ff ff";
            }
            else if (ctcs.Substring(ctcs.Length-1,1)=="N")
            {
               int a=  Convert.ToInt32(ctcs.Substring(1, 3));

                return (a % 100).ToString() + " 8" + (a / 100).ToString("#0");
            }
            else if (ctcs.Substring(ctcs.Length - 1, 1) == "I")
            {
                int a = Convert.ToInt32(ctcs.Substring(1, 3));
                return (a % 100).ToString() + " c" + (a / 100).ToString("#0");
            }
            else
            {
                int a = Convert.ToInt32( Convert.ToDouble(ctcs)*10);
            
                return (a % 100).ToString("#00") + " " + (a / 100).ToString("#00");
            }
        }
        /// <summary>
        /// 频率按规则转化成16进制码
        /// </summary>
        private static string decFrequencyToHex(double frequency)
        {
            int i = Convert.ToInt32( frequency * 100000);
            return (i % 100).ToString() + " " + (i / 100 % 100).ToString() + " " + (i / 10000 % 100).ToString() + " " + (i / 1000000 % 100).ToString();
        }
    }
}
