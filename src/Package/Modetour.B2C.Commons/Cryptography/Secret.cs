using Modetour.B2C.Commons.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Commons
{
    public class Secret
    {
        /// <summary>
        /// MD5함수  
        /// </summary>
        /// <param name="Txt"></param>
        /// <returns>리턴 글자수 : 32</returns>
        public static string MD5Hash(string Txt)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            StringBuilder sBuilder = new StringBuilder();
            foreach (byte data in md5.ComputeHash(Encoding.Default.GetBytes(Txt)))
                sBuilder.Append(data.ToString("x2"));

            return sBuilder.ToString();
        }

        public static string CRC64Hash(string Txt)
        {
            CRC64 crc64 = new CRC64();
            StringBuilder sBuilder = new StringBuilder();
            foreach (byte data in crc64.ComputeHash(Encoding.Default.GetBytes(Txt)))
                sBuilder.Append(data.ToString("x2"));

            return sBuilder.ToString();
        }

    }
}
