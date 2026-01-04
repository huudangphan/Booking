using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Commons.Helper
{
    public class RSAHelper
    {
        /// <summary>
        /// RSA 개체 생성
        /// </summary>
        private static RSACryptoServiceProvider _RSA = new RSACryptoServiceProvider();
        private static RSAParameters _privateKey = RSA.Create().ExportParameters(true);

        private static bool createKey = true;
        /// <summary>
        /// 개인키/공개키 생성을 매번 새롭게 할지 고정된 값을 사용하지 지정
        /// </summary>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        ///         RSAHelper.CreateKey = flase; //true : 개인키를 프로세스 단위별로 새롭게 생성, false : 생성키 고정
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool CreateKey { set { createKey = value; } }

        /// <summary>
        /// 개인키 생성
        /// </summary>
        /// <returns type="string"><![CDATA[PrivateKey를 XML 문자열로 반환
        /// <RSAKeyValue><Modulus></Modulus><Exponent></Exponent><P></P><Q></Q><DP></DP><DQ></DQ><InverseQ></InverseQ><D></D></RSAKeyValue>]]></returns>
        /// <example>PublicKey 기준으로 암호화
        ///     <code>
        ///         <![CDATA[
        ///         RSAHelper.CreateKey = flase; //개인키를 프로세스 단위별로 새롭게 생성 여부
        ///            
        ///         DebugHelper.WriteLine("result : ",  RSAHelper.PrivateKey);
        ///         ]]>
        ///     </code>
        ///     <result>
        ///         <![CDATA[
        ///         result : <RSAKeyValue><Modulus>0CXnjmDAwwk2nk68q7F4R2WB8hYvrRmfD+ryn9Eh/1jJF2d4zyYxSBiLWaqyJi0oXcDdk8NaAgP5l/AFyYrePQEfR+TSdhqdKAAROu/+3nKJbz+GQtaaT8mqPNrnzQpzUwMpTlnHCeWYcxF3GnejASyIoOEBbhFcDeioAK9a/zc=</Modulus><Exponent>AQAB</Exponent><P>8HiOYx0zhB79rt+mvW5WdpjZ7m31EyTwB+LJ9X8t5hZH6FR1mxH6OGm/pjhs1DXBByXp2D7WAWfN9BHElCB1Bw==</P><Q>3Zb9XfCL+AbskT3/Cp7UWGPQplk0OQP03TZW4LBkk/4LOZGvGtq/wo0rWM2U9N7wqCoqciEJBnnTsYL5z3RIUQ==</Q><DP>s5oXHsfMlj1fU6EPNCSYx3NaMc5GYMoRzJICLS2T5ml1w3xxaiR/MmspDMjP359WUDRs92nXBK23ETfEDq4/OQ==</DP><DQ>lrl3ighvDLyY+Yp0CqNSyPTMHfqbXRTl3/pwSdFx+IBa3kPMGbYlrY4cqADei1mB1MEpsgvqea8wYZQ3m/b6oQ==</DQ><InverseQ>cwwprQZ7CrSx1bJH1yD3DQp5Hrm0z5rv1XMTIPOOz3vffpJCpIFjRJoBzpfb0J6WSq+rBcoMVvtVG5UgvlOi6g==</InverseQ><D>oExAqpZ6fPlQddQ/Wp5e+eUDkRNi/hUYOWMAHPIrE4Ilw39tO2K3W0WDs7dQYTQvvRv1yIEOhTTYeBlh65elk8O8H3EQYm9hd02nYjwT2PtgQmkYqKvEssR5uDEuS/O5JaguWBgW3ardYXSKYq6zbCYMccDjhMuQ22VApLLEaSE=</D></RSAKeyValue>
        ///         ]]>
        ///     </result>
        /// </example>
        public static string PrivateKey
        {
            get
            {
                if (createKey)
                {
                    _RSA.ImportParameters(_privateKey);
                    return _RSA.ToXmlString(true);
                }
                else
                {
                    //IIS에서마다 다른 Key 발급으로 인한 문제로 미리 생성하여 활용함
                    return "<RSAKeyValue><Modulus>0CXnjmDAwwk2nk68q7F4R2WB8hYvrRmfD+ryn9Eh/1jJF2d4zyYxSBiLWaqyJi0oXcDdk8NaAgP5l/AFyYrePQEfR+TSdhqdKAAROu/+3nKJbz+GQtaaT8mqPNrnzQpzUwMpTlnHCeWYcxF3GnejASyIoOEBbhFcDeioAK9a/zc=</Modulus><Exponent>AQAB</Exponent><P>8HiOYx0zhB79rt+mvW5WdpjZ7m31EyTwB+LJ9X8t5hZH6FR1mxH6OGm/pjhs1DXBByXp2D7WAWfN9BHElCB1Bw==</P><Q>3Zb9XfCL+AbskT3/Cp7UWGPQplk0OQP03TZW4LBkk/4LOZGvGtq/wo0rWM2U9N7wqCoqciEJBnnTsYL5z3RIUQ==</Q><DP>s5oXHsfMlj1fU6EPNCSYx3NaMc5GYMoRzJICLS2T5ml1w3xxaiR/MmspDMjP359WUDRs92nXBK23ETfEDq4/OQ==</DP><DQ>lrl3ighvDLyY+Yp0CqNSyPTMHfqbXRTl3/pwSdFx+IBa3kPMGbYlrY4cqADei1mB1MEpsgvqea8wYZQ3m/b6oQ==</DQ><InverseQ>cwwprQZ7CrSx1bJH1yD3DQp5Hrm0z5rv1XMTIPOOz3vffpJCpIFjRJoBzpfb0J6WSq+rBcoMVvtVG5UgvlOi6g==</InverseQ><D>oExAqpZ6fPlQddQ/Wp5e+eUDkRNi/hUYOWMAHPIrE4Ilw39tO2K3W0WDs7dQYTQvvRv1yIEOhTTYeBlh65elk8O8H3EQYm9hd02nYjwT2PtgQmkYqKvEssR5uDEuS/O5JaguWBgW3ardYXSKYq6zbCYMccDjhMuQ22VApLLEaSE=</D></RSAKeyValue>";
                }
            }
        }

        /// <summary>
        /// 공개키 생성
        /// </summary>
        /// <returns type="string"><![CDATA[PublicKey를 XML 문자열로 반환
        /// <RSAKeyValue><Modulus></Modulus><Exponent></Exponent></RSAKeyValue>]]></returns>
        /// <example>PublicKey 기준으로 암호화
        ///     <code>
        ///         <![CDATA[
        ///         RSAHelper.CreateKey = flase; //개인키를 프로세스 단위별로 새롭게 생성 여부
        ///            
        ///         DebugHelper.WriteLine("result : ",  RSAHelper.PublicKey);
        ///         ]]>
        ///     </code>
        ///     <result>
        ///         <![CDATA[
        ///         result : <RSAKeyValue><Modulus>0CXnjmDAwwk2nk68q7F4R2WB8hYvrRmfD+ryn9Eh/1jJF2d4zyYxSBiLWaqyJi0oXcDdk8NaAgP5l/AFyYrePQEfR+TSdhqdKAAROu/+3nKJbz+GQtaaT8mqPNrnzQpzUwMpTlnHCeWYcxF3GnejASyIoOEBbhFcDeioAK9a/zc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>
        ///         ]]>
        ///     </result>
        /// </example>
        public static string PublicKey
        {
            get
            {

                if (createKey)
                {
                    RSAParameters publicKey = new RSAParameters();
                    publicKey.Modulus = _privateKey.Modulus;
                    publicKey.Exponent = _privateKey.Exponent;
                    _RSA.ImportParameters(publicKey);

                    return _RSA.ToXmlString(false);
                }
                else
                {
                    //IIS에서마다 다른 Key 발급으로 인한 문제로 미리 생성하여 활용함
                    return "<RSAKeyValue><Modulus>0CXnjmDAwwk2nk68q7F4R2WB8hYvrRmfD+ryn9Eh/1jJF2d4zyYxSBiLWaqyJi0oXcDdk8NaAgP5l/AFyYrePQEfR+TSdhqdKAAROu/+3nKJbz+GQtaaT8mqPNrnzQpzUwMpTlnHCeWYcxF3GnejASyIoOEBbhFcDeioAK9a/zc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
                }
            }
        }

        /// <summary>
        /// RSA 암호화
        /// </summary>
        /// <param name="getValue" type="string"></param>
        /// <param name="pubKey" type="string"></param>
        /// <returns></returns>
        /// <example>PublicKey 기준으로 암호화
        ///     <code>
        ///         <![CDATA[
        ///         RSAHelper.CreateKey = flase; //개인키를 프로세스 단위별로 새롭게 생성 여부
        ///         string 암호된값 = RSAHelper.RSAEncrypt("이 문자는 암호화 해야해!!!!",RSAHelper.PublicKey);
        ///            
        ///         DebugHelper.WriteLine("result : ",  암호된값);
        ///         ]]>
        ///     </code>
        ///     <result>
        ///         <![CDATA[
        ///         result : Oo6PpUvEakK61eauFT2PvjzAgzTHSWqQQeFZVwQbm67S3ZqR0qiJXqOUqgcPJBfdfu+3z4W+kokwu74ME9XKn63bUQ5DNnfqCRrsK/xb9wpOkifKK9poo9FOstQIHDOUMkbOSN7dD61v+Z4qmrOazMcXhmhn9/u2SBuP7EmUB3Q=  
        ///         ]]>
        ///     </result>
        /// </example>
        public static string RSAEncrypt(string getValue, string pubKey)
        {
            if (string.IsNullOrEmpty(getValue)) return getValue;

            string rsaEncrypt = string.Empty;
            try
            {
                _RSA.FromXmlString(pubKey);

                //암호화할 문자열을 UFT8인코딩
                byte[] inbuf = (new UTF8Encoding()).GetBytes(getValue);
                //암호화
                byte[] encbuf = _RSA.Encrypt(inbuf, false);
                //암호화된 문자열 Base64인코딩
                rsaEncrypt = Convert.ToBase64String(encbuf);
            }
            catch { }

            return rsaEncrypt;
        }

        /// <summary>
        /// RSA 복호화
        /// </summary>
        /// <param name="getValue" type="string"></param>
        /// <param name="priKey" type="string">개인키</param>
        /// <returns></returns>
        /// <example>PrivateKey 기준으로 복호화
        ///     <code>
        ///         <![CDATA[
        ///         RSAHelper.CreateKey = flase; //개인키를 프로세스 단위별로 새롭게 생성 여부
        ///         string 암호된값 = RSAHelper.RSAEncrypt("이 문자는 암호화 해야해!!!!",RSAHelper.PublicKey);
        ///            
        ///         DebugHelper.WriteLine("result : ",  RSAHelper.RSADecrypt(암호된값,RSAHelper.PrivateKey));
        ///         ]]>
        ///     </code>
        ///     <result>
        ///         <![CDATA[
        ///         result : 이 문자는 암호화 해야해!!!!
        ///         ]]>
        ///     </result>
        /// </example>
        public static string RSADecrypt(string getValue, string priKey)
        {
            if (string.IsNullOrEmpty(getValue)) return getValue;

            string rsaDecrypt = string.Empty;
            try
            {
                _RSA.FromXmlString(priKey);

                //sValue문자열을 바이트배열로 변환
                byte[] srcbuf = Convert.FromBase64String(getValue.ToString());
                //바이트배열 복호화
                byte[] decbuf = _RSA.Decrypt(srcbuf, false);

                //복호화 바이트배열을 문자열로 변환
                rsaDecrypt = (new UTF8Encoding()).GetString(decbuf, 0, decbuf.Length);
            }
            catch { }
            return rsaDecrypt;

        }


        /// <summary>
        /// RSA 스크립트
        /// </summary>
        /// <returns></returns>
        /// <example>클라이언트에서 필요한 RSA JS파일 리스트
        ///     <code>
        ///         <![CDATA[
        ///         RSAHelper.RSAScript();
        ///         ]]>
        ///     </code>
        ///     <result>
        ///         <![CDATA[
        ///         ]]>
        ///     </result>
        /// </example>
        public static string RSAScript()
        {
            return "<script type='text/javascript' src='//js.modetour.com/Cryptography/RSA/NCL/System.js'></script>"
                    + "<script type='text/javascript' src='//js.modetour.com/Cryptography/RSA/NCL/System.IO.js'></script>"
                    + "<script type='text/javascript' src='//js.modetour.com/Cryptography/RSA/NCL/System.Text.js'></script>"
                    + "<script type='text/javascript' src='//js.modetour.com/Cryptography/RSA/NCL/System.Convert.js'></script>"
                    + "<script type='text/javascript' src='//js.modetour.com/Cryptography/RSA/NCL/System.BitConverter.js'></script>"
                    + "<script type='text/javascript' src='//js.modetour.com/Cryptography/RSA/NCL/System.BigInt.js'></script>"
                    + "<script type='text/javascript' src='//js.modetour.com/Cryptography/RSA/NCL/System.Security.Cryptography.js'></script>"
                    + "<script type='text/javascript' src='//js.modetour.com/Cryptography/RSA/NCL/System.Security.Cryptography.SHA1.js'></script>"
                    + "<script type='text/javascript' src='//js.modetour.com/Cryptography/RSA/NCL/System.Security.Cryptography.RSA.js'></script>";
        }

    }
}
