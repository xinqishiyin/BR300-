using System;
using System.Text;
using System.Security.Cryptography;

namespace BR300walkietalkie.Common
{
    public class Encryption
    {
        /*---------------------MD5加密---------------------------*/

        /*
             *MD5加密算法

            我想这是大家都常听过的算法，可能也用的比较多。那么什么是MD5算法呢？MD5全称是message-digest algorithm 5，
            简单的说就是单向的加密，即是说无法根据密文推导出明文。

            MD5主要用途：

            1、对一段信息生成信息摘要，该摘要对该信息具有唯一性,可以作为数字签名。

            2、用于验证文件的有效性(是否有丢失或损坏的数据),

            3、对用户密码的加密，

            4、在哈希函数中计算散列值

            从上边的主要用途中我们看到，由于算法的某些不可逆特征，在加密应用上有较好的
            安全性。通过使用MD5加密算法，我们输入一个任意长度的字节串，都会生成一个128
            位的整数。所以根据这一点MD5被广泛的用作密码加密。下面我就像大家演示一下怎样
            进行密码加密。 
         */


        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">要加密的字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string Md5_Encryption(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] palindata = Encoding.Default.GetBytes(str);
            byte[] encryptdata = md5.ComputeHash(palindata);
            return Convert.ToBase64String(encryptdata);
        }

        /*-----------------------RSA加密------------------------------*/

        /*
            * RSA加密算法

            在谈RSA加密算法之前，我们需要先了解下两个专业名词，对称加密和非对称加密。

            对称加密即：含有一个称为密钥的东西，在消息发送前使用密钥对消息进行加密，
                        在对方收到消息之后，使用相同的密钥进行解密

            非对称加密即：加密和解密使用不同的密钥的一类加密算法。这类加密算法通常有两
                          个密钥A和B，使用密钥A加密数据得到的密文，只有密钥B可以进行解
                          密操作（即使密钥A也无法解密），相反，使用了密钥B加密数据得到
                          的密文，只有密钥A可以解密。这两个密钥分别称为私钥和公钥，顾名
                          思义，私钥就是你个人保留，不能公开的密钥，而公钥则是公开给加
                          解密操作的另一方的。根据不同用途，对数据进行加密所使用的密钥
                          也不相同（有时用公钥加密，私钥解密；有时相反用私钥加密，公钥
                          解密）。非对称加密的代表算法是RSA算法。

            了解了这两个名词下面来讲，RSA加密算法。RSA取名来自开发他们三者的名字。RSA是
            目前最有影响力的公钥加密算法，多用于数据加密和数字签名。虽然有这么大的影响力，
            但是同时它也有一些弊端，它产生密钥很麻烦，受到素数产生技术的限制，因而难以做
            到一次一密，分组长度太大等。
         */

        /// <summary>
        /// RSA加密
        /// </summary>
        /// <param name="str">要加密的字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string RSA_Encryption(string str)
        {
            CspParameters param = new CspParameters();
            param.KeyContainerName = "oa_erp_dowork";//密匙容器的名称，保持加密解密一致才能解密成功
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param))
            {
                byte[] plaindata = Encoding.Default.GetBytes(str);//将要加密的字符串转换为字节数组
                byte[] encryptdata = rsa.Encrypt(plaindata, false);//将加密后的字节数据转换为新的加密字节数组
                return Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为字符串
            }
        }
        /// <summary>
        /// RSA解密
        /// </summary>
        /// <param name="ciphertext">需要解密的字符串</param>
        /// <returns>解密后的字符串</returns>
        private string RSA_Decrypt(string ciphertext)
        {
            CspParameters param = new CspParameters();
            param.KeyContainerName = "oa_erp_dowork";
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param))
            {
                byte[] encryptdata = Convert.FromBase64String(ciphertext);
                byte[] decryptdata = rsa.Decrypt(encryptdata, false);
                return Encoding.Default.GetString(decryptdata);
            }
        }

        /*
         *示例：
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            using (StreamWriter sw = new StreamWriter(Server.MapPath("PublicKey.xml")))//产生公匙
            {
                sw.WriteLine(rsa.ToXmlString(false));
            }
            using (StreamWriter sw = new StreamWriter(Server.MapPath("PrivateKey.xml")))//产生私匙（也包含私匙）
            {
                sw.WriteLine(rsa.ToXmlString(true));
            }
         */


        /*------------------------------------DES加密------------------------------------------------*/

        /*DES加密：使用一个 56 位的密钥以及附加的 8 位奇偶校验位，产生最大 64 位的分组大小。这是一个迭代的分组密码，
         使用称为 Feistel 的技术，其中将加密的文本块分成两半。使用子密钥对其中一半应用循环功能，然后将输出与另一半进行
         “异或”运算；接着交换这两半，这一过程会继续下去，但最后一个循环不交换。DES 使用 16 个循环，使用异或，置换，代
         换，移位操作四种基本运算。
         */

        //static byte[] buffer;

        static DESCryptoServiceProvider DesCSP = new DESCryptoServiceProvider();

        /// <summary>
        /// 进行DES加密。
        /// </summary>
        /// <param name="pToEncrypt">要加密的字符串。</param>
        /// <param name="sKey">密钥，且必须为8位。</param>
        /// <returns>以Base64格式返回的加密字符串。</returns>
        public static string DES_Encryption(string pToEncrypt, string sKey)
        {
            if (pToEncrypt==null)
            {
                return "";
            }
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                byte[] inputByteArray = Encoding.UTF8.GetBytes(pToEncrypt);
                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    cs.Close();
                }
                string str = Convert.ToBase64String(ms.ToArray());
                ms.Close();
                return str;
            }
        }

        /// <summary>
        /// 进行DES解密。
        /// </summary>
        /// <param name="pToDecrypt">要解密的以Base64</param>
        /// <param name="sKey">密钥，且必须为8位。</param>
        /// <returns>已解密的字符串。</returns>
        public static string DES_Decrypt(string pToDecrypt, string sKey)
        {
            if (pToDecrypt==null)
            {
                return "";
            }
            byte[] inputByteArray = Convert.FromBase64String(pToDecrypt);
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    cs.Close();
                }
                string str = Encoding.UTF8.GetString(ms.ToArray());
                ms.Close();
                return str;
            }
        }
    }
}
