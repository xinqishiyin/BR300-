using BR300walkietalkie.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BR300walkietalkie.Class
{
    
    public class ChannelItem
    {
        /// <summary>
        /// 读取头
        /// </summary>
        public const int readCode = 82;

        /// <summary>
        /// 握手发送协议
        /// </summary>
        public const string connSendCode = "48 49 54 41 4c 4b 49 45 38";

        /// <summary>
        /// 握手接收协议
        /// </summary>
        public const string connReciveCode = "06 54 41 4c 4b 49 45 38";


        /// <summary>
        /// 端口接收信息返回值
        /// </summary>
        public const int connRecive = 6;

        /// <summary>
        /// 发送确认
        /// </summary>
        public const int sureSend = 6;

        /// <summary>
        /// 握手确认
        /// </summary>
        public const int sureConn = 2;

        /// <summary>
        /// 发送获取数据的地址长度       
        /// </summary>
        public const int reciveLong = 4 * 16;

        /// <summary>
        /// 发送获取数据的初始地址
        /// </summary>
        public const int reciveStartAdress = 1 * 16;

        /// <summary>
        /// 写入头
        /// </summary>
        public const int writeCode = 87;

        /// <summary>
        /// 发送写入数据的初始地址
        /// </summary>
        public const int writeStartAdress = 1 * 16;

        /// <summary>
        /// 发送写入数据的地址长度
        /// </summary>
        public const int writeLong = 1 * 16;

        /// <summary>
        /// 读取设置信息
        /// </summary>
        public const string setReadCode = "52 0e 00 40";

        /// <summary>
        /// 写入设置信息
        /// </summary>
        public const string setWriteCode = "57 0E 20 10";

        /// <summary>
        /// 设置信息地址
        /// </summary>
        public const string setAdress = "01 00 01 00";

        //public static DataTable dt = new DataTable();
        public static Dictionary<string, string> CTCSStextToCode;
        public static Dictionary<string, string> CTCSScodeToText;




        #region string[] ctcss


        public static string[] ctcss =
        {
            "ff ff",
            "02 9E",
            //"02 B5",
            "02 CF",
            "02 E8",
            "03 02",
            "03 1D",
            "03 39",
            "03 56",
            "03 75",
            "03 93",
            "03 B4",
            "03 CE",
            "03 E8",
            "04 0B",
            "04 30",
            "04 55",
            "04 7C",
            "04 A4",
            "04 CE",
            "04 F9",
            "05 26",
            "05 55",
            "05 85",
            "05 B6",
            "05 EA",
            "06 1F",
            //"06 3E",
            "06 56",
            //"06 77",
            "06 8F",
            //"06 B1",
            "06 CA",
            //"06 ED",
            "07 07",
            //"07 2B",
            "07 46",
            //"07 6B",
            "07 88",
            //"07 AE",
            //"07 CB",
            "07 F3",
            //"08 11",
            "08 3B",
            "08 85",
            "08 D1",
            //"08 F3",
            "09 20",
            "09 72",
            "09 C7",
            //"09 ED"
        };
        
        #endregion

        #region string[] ctcssN
        public static string[] ctcssN =
        {            
            "13 28",
            "15 28",
            "16 28",
            "19 28",
            "1A 28",
            "1e 28",
            "23 28",
            "27 28",
            "29 28",
            "2b 28",
            "2c 28",
            "35 28",
            "39 28",
            "3a 28",
            "3b 28",
            "3c 28",
            "4c 28",
            "4d 28",
            "4e 28",
            "52 28",
            "55 28",
            "59 28",
            "5a 28",
            "5c 28",
            "63 28",
            "65 28",
            "6a 28",
            "6d 28",
            "6e 28",
            "72 28",
            "75 28",
            "7a 28",
            "7c 28",
            "85 28",
            "8a 28",
            "93 28",
            "95 28",
            "96 28",
            "a3 28",
            "a4 28",
            "a5 28",
            "a6 28",
            "a9 28",
            "aa 28",
            "ad 28",
            "b1 28",
            "b3 28",
            "b5 28",
            "b6 28",
            "b9 28",
            "bc 28",
            "c6 28",
            "c9 28",
            "cd 28",
            "d5 28",
            "d9 28",
            "da 28",
            "e3 28",
            "e6 28",
            "e9 28",
            "ee 28",
            "f4 28",
            "f5 28",
            "f9 28",
            "09 29",
            "0a 29",
            "0b 29",
            "13 29",
            "19 29",
            "1a 29",
            "25 29",
            "26 29",
            "2a 29",
            "2c 29",
            "2d 29",
            "32 29",
            "34 29",
            "35 29",
            "36 29",
            "43 29",
            "46 29",
            "4e 29",
            "53 29",
            "56 29",
            "5a 29",
            "66 29",
            "75 29",
            "86 29",
            "8a 29",
            "94 29",
            "97 29",
            "99 29",
            "9a 29",
            //"a5 29",
            "ac 29",
            "b2 29",
            "b4 29",
            "c3 29",
            "ca 29",
            "d3 29",
            "d9 29",
            "da 29",
            "dc 29",
            "e3 29",
            "ec 29"
        };
        #endregion

        #region string[] ctcssI
        public static string[] ctcssI =
        {
            "13 a8",
            "15 a8",
            "16 a8",
            "19 a8",
            "1A a8",
            "1e a8",
            "23 a8",
            "27 a8",
            "29 a8",
            "2b a8",
            "2c a8",
            "35 a8",
            "39 a8",
            "3a a8",
            "3b a8",
            "3c a8",
            "4c a8",
            "4d a8",
            "4e a8",
            "52 a8",
            "55 a8",
            "59 a8",
            "5a a8",
            "5c a8",
            "63 a8",
            "65 a8",
            "6a a8",
            "6d a8",
            "6e a8",
            "72 a8",
            "75 a8",
            "7a a8",
            "7c a8",
            "85 a8",
            "8a a8",
            "93 a8",
            "95 a8",
            "96 a8",
            "a3 a8",
            "a4 a8",
            "a5 a8",
            "a6 a8",
            "a9 a8",
            "aa a8",
            "ad a8",
            "b1 a8",
            "b3 a8",
            "b5 a8",
            "b6 a8",
            "b9 a8",
            "bc a8",
            "c6 a8",
            "c9 a8",
            "cd a8",
            "d5 a8",
            "d9 a8",
            "da a8",
            "e3 a8",
            "e6 a8",
            "e9 a8",
            "ee a8",
            "f4 a8",
            "f5 a8",
            "f9 a8",
            "09 A9",
            "0a A9",
            "0b A9",
            "13 A9",
            "19 A9",
            "1a A9",
            "25 A9",
            "26 A9",
            "2a A9",
            "2c A9",
            "2d A9",
            "32 A9",
            "34 A9",
            "35 A9",
            "36 A9",
            "43 A9",
            "46 A9",
            "4e A9",
            "53 A9",
            "56 A9",
            "5a A9",
            "66 A9",
            "75 A9",
            "86 A9",
            "8a A9",
            "94 A9",
            "97 A9",
            "99 A9",
            "9a A9",
            //"a5 A9",
            "ac A9",
            "b2 A9",
            "b4 A9",
            "c3 A9",
            "ca A9",
            "d3 A9",
            "d9 A9",
            "da A9",
            "dc A9",
            "e3 A9",
            "ec A9"
        };
        #endregion

        #region string[] ctcssText
        public static string[] ctcssText =
        {            
            "Off",
            "67.0",
            //"69.3",
            "71.9",
            "74.4",
            "77.0",
            "79.7",
            "82.5",
            "85.4",
            "88.5",
            "91.5",
            "94.8",
            "97.4",
            "100.0",
            "103.5",
            "107.2",
            "110.9",
            "114.8",
            "118.8",
            "123.0",
            "127.3",
            "131.8",
            "136.5",
            "141.3",
            "146.2",
            "151.4",
            "156.7",
            //"159.8",
            "162.2",
            //"165.5",
            "167.9",
            //"171.3",
            "173.8",
            //"177.3",
            "179.9",
            //"183.5",
            "186.2",
            //"189.9",
            "192.8",
            //"196.6",
            //"199.5",
            "203.5",
            //"206.5",
            "210.7",
            "218.1",
            "225.7",
            //"229.1",
            "233.6",
            "241.8",
            "250.3",
            //"254.1"
        };

        #endregion

        #region string[] ctcssIText
        public static string[] ctcssIText =
        {
            "D023I",
            "D025I",
            "D026I",
            "D031I",
            "D032I",
            "D036I",
            "D043I",
            "D047I",
            "D051I",
            "D053I",
            "D054I",
            "D065I",
            "D071I",
            "D072I",
            "D073I",
            "D074I",
            "D114I",
            "D115I",
            "D116I",
            "D122I",
            "D125I",
            "D131I",
            "D132I",
            "D134I",
            "D143I",
            "D145I",
            "D152I",
            "D155I",
            "D156I",
            "D162I",
            "D165I",
            "D172I",
            "D174I",
            "D205I",
            "D212I",
            "D223I",
            "D225I",
            "D226I",
            "D243I",
            "D244I",
            "D245I",
            "D246I",
            "D251I",
            "D252I",
            "D255I",
            "D261I",
            "D263I",
            "D265I",
            "D266I",
            "D271I",
            "D274I",
            "D306I",
            "D311I",
            "D315I",
            "D325I",
            "D331I",
            "D332I",
            "D343I",
            "D346I",
            "D351I",
            "D356I",
            "D364I",
            "D365I",
            "D371I",
            "D411I",
            "D412I",
            "D413I",
            "D423I",
            "D431I",
            "D432I",
            "D445I",
            "D446I",
            "D452I",
            "D454I",
            "D455I",
            "D462I",
            "D464I",
            "D465I",
            "D466I",
            "D503I",
            "D506I",
            "D516I",
            "D523I",
            "D526I",
            "D532I",
            "D546I",
            "D565I",
            "D606I",
            "D612I",
            "D624I",
            "D627I",
            "D631I",
            "D632I",
            //"D645I",
            "D654I",
            "D662I",
            "D664I",
            "D703I",
            "D712I",
            "D723I",
            "D731I",
            "D732I",
            "D734I",
            "D743I",
            "D754I"
        };
        #endregion

        #region string[] ctcssNtext
        public static string[] ctcssNtext =
        {         
            "D023N",
            "D025N",
            "D026N",
            "D031N",
            "D032N",
            "D036N",
            "D043N",
            "D047N",
            "D051N",
            "D053N",
            "D054N",
            "D065N",
            "D071N",
            "D072N",
            "D073N",
            "D074N",
            "D114N",
            "D115N",
            "D116N",
            "D122N",
            "D125N",
            "D131N",
            "D132N",
            "D134N",
            "D143N",
            "D145N",
            "D152N",
            "D155N",
            "D156N",
            "D162N",
            "D165N",
            "D172N",
            "D174N",
            "D205N",
            "D212N",
            "D223N",
            "D225N",
            "D226N",
            "D243N",
            "D244N",
            "D245N",
            "D246N",
            "D251N",
            "D252N",
            "D255N",
            "D261N",
            "D263N",
            "D265N",
            "D266N",
            "D271N",
            "D274N",
            "D306N",
            "D311N",
            "D315N",
            "D325N",
            "D331N",
            "D332N",
            "D343N",
            "D346N",
            "D351N",
            "D356N",
            "D364N",
            "D365N",
            "D371N",
            "D411N",
            "D412N",
            "D413N",
            "D423N",
            "D431N",
            "D432N",
            "D445N",
            "D446N",
            "D452N",
            "D454N",
            "D455N",
            "D462N",
            "D464N",
            "D465N",
            "D466N",
            "D503N",
            "D506N",
            "D516N",
            "D523N",
            "D526N",
            "D532N",
            "D546N",
            "D565N",
            "D606N",
            "D612N",
            "D624N",
            "D627N",
            "D631N",
            "D632N",
            //"D645N",
            "D654N",
            "D662N",
            "D664N",
            "D703N",
            "D712N",
            "D723N",
            "D731N",
            "D732N",
            "D734N",
            "D743N",
            "D754N"
        };
        #endregion

        #region OtherString [] Item


        public static string[] TXpower ={
            "High",
            "Low"
            };

        public static string[] WN ={
            "12.5K",
            "25K"
            };
        public static string[] bussyLock =
        {
            "Off",
            "On"
        };
        public static string[] bussyLockValue =
        {
            "fe",
            "ff"
        };
        public static string[] repeater =
        {
            "Off",
            "On"
        };
        public static string[] repeaterValue =
        {
            "95",
            "9d"
        };

        public static string[] scanning = {
            "Off",
            "On"
        };
        #endregion


        #region 封装字段
        public static string[] TXpower1
        {
            get
            {
                return TXpower;
            }

            set
            {
                TXpower = value;
            }
        }

        public static string[] WN1
        {
            get
            {
                return WN;
            }

            set
            {
                WN = value;
            }
        }

        public static string[] BussyLock
        {
            get
            {
                return bussyLock;
            }

            set
            {
                bussyLock = value;
            }
        }

        public static string[] BussyLockValue
        {
            get
            {
                return bussyLockValue;
            }

            set
            {
                bussyLockValue = value;
            }
        }

        public static string[] Repeater
        {
            get
            {
                return repeater;
            }

            set
            {
                repeater = value;
            }
        }

        public static string[] RepeaterValue
        {
            get
            {
                return repeaterValue;
            }

            set
            {
                repeaterValue = value;
            }
        }

        public static string[] Scanning
        {
            get
            {
                return scanning;
            }

            set
            {
                scanning = value;
            }
        }

        #endregion





        public static void addCTCSSdata()
        {
            CTCSStextToCode = new Dictionary<string, string>();
            
            for (int i = 0; i <ctcss.Length; i++)
            {
                CTCSStextToCode.Add(ctcssText[i],ctcss[i].ToLower());
            }
            for (int i = 0; i < ctcssN.Length; i++)
            {
                CTCSStextToCode.Add(ctcssNtext[i],ctcssN[i].ToLower());
            }
            for (int i = 0; i < ctcssIText.Length; i++)
            {
                CTCSStextToCode.Add(ctcssIText[i], ctcssI[i].ToLower());
            }

            CTCSScodeToText = new Dictionary<string, string>();
            for (int i = 0; i < ctcss.Length; i++)
            {
                CTCSScodeToText.Add(ctcss[i].ToLower(),ctcssText[i]);
            }
            for (int i = 0; i < ctcssN.Length; i++)
            {
                CTCSScodeToText.Add(ctcssN[i].ToLower(),ctcssNtext[i] );
            }
            for (int i = 0; i < ctcssIText.Length; i++)
            {
                CTCSScodeToText.Add(ctcssI[i].ToLower(),ctcssIText[i]);
            }
        }          
        
        public static CboItemIntity ctcssItemAdd(int i)
        {
            CboItemIntity ci = new CboItemIntity(ctcssText[i], ctcss[i]);
            return ci;
        }
        public static CboItemIntity ctcssIItemAdd(int i)
        {
            CboItemIntity ci = new CboItemIntity(ctcssIText[i], ctcssI[i]);
            return ci;
        }
        public static CboItemIntity ctcssNItemAdd(int i)
        {
            CboItemIntity ci = new CboItemIntity(ctcssNtext[i], ctcssN[i]);
            return ci;
        }
        public static CboItemIntity TXpowerItemAdd(int i)
        {
            CboItemIntity ci = new CboItemIntity(TXpower1[i], i);
            return ci;
        }

        public static CboItemIntity WNItemAdd(int i)
        {
            CboItemIntity ci = new CboItemIntity(WN1[i], i);
            return ci;
        }
        public static CboItemIntity bussyLockItemAdd(int i)
        {
            CboItemIntity ci = new CboItemIntity(BussyLock[i], i);
            return ci;
        }
        public static CboItemIntity repeaterItemAdd(int i)
        {
            CboItemIntity ci = new CboItemIntity(Repeater[i], i);
            return ci;
        }
        public static CboItemIntity scanningItemAdd(int i)
        {
            CboItemIntity ci = new CboItemIntity(Scanning[i], i);
            return ci;
        }

        public static int countCtcss()
        {
            return ctcss.Length;
        }

        public static int countCtcssI()
        {
            return ctcssI.Length;
        }

        public static int countCtcssN()
        {
            return ctcssN.Length;
        }

        public static int countTXPower()
        {
            return TXpower1.Length;
        }

        public static int countWN()
        {
            return WN1.Length;
        }

        public static int countBussyLock()
        {
            return BussyLock.Length;
        }

        public static int countRepeater()
        {
            return Repeater.Length;
        }
        public static int countScanning()
        {
            return Scanning.Length;
        }
    }

}
