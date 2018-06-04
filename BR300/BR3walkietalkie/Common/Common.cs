using System;

using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using BR300walkietalkie.Controls;

namespace BR300walkietalkie.Common
{
    public class Common
    {
        public static string massage = "";

        /// <summary>
        /// 保存dat文件
        /// </summary>
        /// <param name="pfiledat">保存路径</param>
        public static bool WriteDat(string pfiledat, string dat)
        {
         
            FileStream fs;
            fs = new FileStream(pfiledat, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            try
            {
                //为文件打开一个二进制写入器
                //dat = Encryption.DES_Encryption(dat,"11111111");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dat);
                //bf.Serialize(fs, Symmetric.RijndaelEncryptor(Symmetric.DataTableToString(GetDgvToTable(dataGridView1))));
                fs.Close();
                return true;
            }
            catch (Exception )
            {                
                fs.Close();
                return false;
            }
        }
        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string Deserialize(string path)
        {
            string dtt="";
            if (!File.Exists(path))
            {
                return null;
            }           
            FileStream fs = new FileStream(path, FileMode.Open);
            try
            {
               
                BinaryFormatter bf = new BinaryFormatter();
                dtt = bf.Deserialize(fs).ToString();
               // dtt = Encryption.DES_Decrypt(dtt);
                //dtt = Symmetric.StringToDataTable(Symmetric.RijndaelDecryptor((string)bf.Deserialize(fs)));
                fs.Close();
            }
            catch (Exception)
            {
                MsgBox.Show("读取文件失败！");
                fs.Close();              
            }
            return dtt;
        }
       

        public static DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // 列强制转换
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }

            // 循环行
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }


        /// <summary>
        /// 2位16进制转十进制
        /// </summary>
        /// <returns></returns>
        public static int hexToDec(string hex)
        {
            return Convert.ToInt32(hex, 16);
        }

     
        
        /// <summary>
        /// 十进制转十六进制
        /// </summary>
        /// <param name="dec">数值</param>
        /// <param name="hexLong">16进制位数</param>
        /// <returns>十六进制</returns>
        public static string decToHex(int dec,int hexLong)
        {
            string hex = Convert.ToInt16(dec / 256).ToString("X2");
            hex += " " + Convert.ToInt16(dec % 256).ToString("X2");

            return hex;
        }
        /// <summary>
        /// 十进制转十六进制
        /// </summary>
        /// <param name="dec"></param>
        /// <returns></returns>
        public static string decToHex(int dec)
        {            
            string hex = Convert.ToInt16(dec).ToString("X2");           
            return hex;
        }





        /// <summary>
        /// DataTable 到 string
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DataTableToString(DataTable dt)
        {
            dt.TableName = "dd";
            //!@&,#$%,^&*为字段的拼接字符串
            //为了防止连接字符串不在DataTable数据中存在，特意将拼接字符串写成特殊的字符！
            StringBuilder strData = new StringBuilder();
            StringWriter sw = new StringWriter();

            //DataTable 的当前数据结构以 XML 架构形式写入指定的流
            dt.WriteXmlSchema(sw);
            strData.Append(sw.ToString());
            sw.Close();
            strData.Append("@&@");
            for (int i = 0; i < dt.Rows.Count; i++)           //遍历dt的行
            {
                DataRow row = dt.Rows[i];
                if (i > 0)                                    //从第二行数据开始，加上行的连接字符串
                {
                    strData.Append("#$%");
                }
                for (int j = 0; j < dt.Columns.Count; j++)    //遍历row的列
                {
                    if (j > 0)                                //从第二个字段开始，加上字段的连接字符串
                    {
                        strData.Append("^&*");
                    }
                    strData.Append(Convert.ToString(row[j])); //取数据
                }
            }

            return strData.ToString();
        }



        /// <summary>
        /// string 到 DataTable
        /// </summary>
        /// <param name="strdata"></param>
        /// <returns></returns>
        public static DataTable StringToDataTable(string strdata)
        {
            if (string.IsNullOrEmpty(strdata)|strdata=="")
            {
                return null;
            }
            DataTable dt = new DataTable();
            string[] strSplit = { "@&@" };
            string[] strRow = { "#$%" };    //分解行的字符串
            string[] strColumn = { "^&*" }; //分解字段的字符串

            string[] strArr = strdata.Split(strSplit, StringSplitOptions.None);
            StringReader sr = new StringReader(strArr[0]);
            
            dt.ReadXmlSchema(sr);  
            sr.Close();


            string strTable = strArr[1]; //取表的数据
            if (!string.IsNullOrEmpty(strTable))
            {
                string[] strRows = strTable.Split(strRow, StringSplitOptions.None); //解析成行的字符串数组
                for (int rowIndex = 0; rowIndex < strRows.Length; rowIndex++)       //行的字符串数组遍历
                {
                    string vsRow = strRows[rowIndex]; //取行的字符串
                    string[] vsColumns = vsRow.Split(strColumn, StringSplitOptions.None); //解析成字段数组
                    dt.Rows.Add(vsColumns);
                }
            }
            return dt;
        }
      

    }
}
