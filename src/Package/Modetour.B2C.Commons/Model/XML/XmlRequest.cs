using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Modetour.B2C.Commons.Model
{
    public class XmlRequest
    {
        private string mServerUrl;
        private string mMethod = "POST";
        private string mContentType = "text/xml";
        private string mXmlData;

        /// <summary>
        /// Send() 메서드에서 사용할 요청 URL
        /// </summary>
        public string ServerUrl
        {
            get { return mServerUrl; }
            set { mServerUrl = value; }
        }

        /// <summary>
        /// Send() 메서드에서 사용할 요청 Method
        /// </summary>
        public string Method
        {
            get { return mMethod; }
            set { mMethod = value; }
        }

        /// <summary>
        /// Send() 메서드에서 사용할 요청 ContentType
        /// </summary>
        public string ContentType
        {
            get { return mContentType; }
            set { mContentType = value; }
        }

        /// <summary>
        /// Send() 메서드에서 사용할 요청 XmlData
        /// </summary>
        public string XmlData
        {
            get { return mXmlData; }
            set { mXmlData = value; }
        }

        /// <summary>
        /// HttpWebReqeust 방식을 이용하여 데이타 전송 후 결과값 리턴
        /// </summary>
        /// <returns>XMLDocument 형식의 결과 Data</returns>
        public XmlElement Send()
        {
            XmlDocument resXml = new XmlDocument();

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(this.ServerUrl);
            req.KeepAlive = false;
            req.Method = this.Method;
            req.ContentType = this.ContentType;
            //req.ContentLength = mReqXmlDoc.Length;

            StreamWriter reqStream = new StreamWriter(req.GetRequestStream(), Encoding.UTF8);
            reqStream.Write(this.XmlData);
            reqStream.Close();

            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader resStream = new StreamReader(res.GetResponseStream(), Encoding.UTF8);

            resXml.LoadXml(resStream.ReadToEnd());
            resStream.Close();

            return resXml.DocumentElement;
        }

        /// <summary>
        /// HttpWebReqeust 방식을 이용하여 데이타 전송
        /// </summary>
        public XmlElement SendPost2()
        {
            try
            {
                System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                byte[] ByteData = encoding.GetBytes(this.XmlData);

                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(this.ServerUrl);
                req.UserAgent = "0"; //HttpContext.Current.Request.ServerVariables["HTTP_USER_AGENT"].ToString();
                req.KeepAlive = false;
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = ByteData.Length;

                Stream reqStream = req.GetRequestStream();
                reqStream.Write(ByteData, 0, ByteData.Length);
                reqStream.Close();

                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                StreamReader resStream = new StreamReader(res.GetResponseStream(), Encoding.UTF8);

                XmlDocument resXml = new XmlDocument();
                resXml.LoadXml(resStream.ReadToEnd());
                resStream.Close();

                return resXml.DocumentElement;
            }
            catch (Exception ex)
            {
                XmlDocument XmlErr = new XmlDocument();
                XmlErr.LoadXml(String.Format("<x><Err><![CDATA[{0}]]></Err></x>", ex.ToString()));

                return XmlErr.DocumentElement;
            }
        }


        /// <summary>
        /// HttpWebReqeust POST 방식을 이용하여 데이타 전송 후 결과값 리턴
        /// </summary>
        /// <returns>XMLDocument 형식의 결과 Data</returns>
        public XmlElement PostSend()
        {
            XmlDocument resXml = new XmlDocument();

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(this.ServerUrl);
            req.KeepAlive = false;
            req.Method = "POST";
            req.ContentType = this.ContentType;

            StreamWriter reqStream = new StreamWriter(req.GetRequestStream(), Encoding.Default);
            reqStream.Write(this.XmlData);
            reqStream.Close();

            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader resStream = new StreamReader(res.GetResponseStream(), Encoding.Default);

            resXml.LoadXml(resStream.ReadToEnd());
            resStream.Close();

            return resXml.DocumentElement;
        }

        /// <summary>
        /// HttpWebReqeust POST 방식을 이용하여 데이타 전송 후 결과값 리턴
        /// </summary>
        /// <param name="encoding">전송시 Encoding 방식</param>
        /// <returns></returns>
        public XmlElement PostSend(string encoding)
        {
            XmlDocument resXml = new XmlDocument();

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(this.ServerUrl);
            req.KeepAlive = false;
            req.Method = "POST";
            req.ContentType = this.ContentType;

            StreamWriter reqStream = new StreamWriter(req.GetRequestStream(), Encoding.GetEncoding(encoding));
            reqStream.Write(this.XmlData);
            reqStream.Close();

            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader resStream = new StreamReader(res.GetResponseStream(), Encoding.Default);

            resXml.LoadXml(resStream.ReadToEnd());
            resStream.Close();

            return resXml.DocumentElement;
        }

        /// <summary>
        /// HttpWebReqeust GET 방식을 이용하여 데이타 전송 후 결과값 리턴
        /// </summary>
        /// <returns>XMLDocument 형식의 결과 Data</returns>
        public XmlElement GetSend()
        {
            XmlDocument resXml = new XmlDocument();

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(this.ServerUrl);
            req.KeepAlive = false;
            req.Method = "GET";
            req.ContentType = "application/x-www-form-urlencoded";

            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader resStream = new StreamReader(res.GetResponseStream(), Encoding.Default);

            resXml.LoadXml(resStream.ReadToEnd());
            resStream.Close();

            return resXml.DocumentElement;
        }

        /// <summary>
        /// HttpWebReqeust GET 방식을 이용하여 데이타 전송 후 결과값 리턴
        /// </summary>
        /// <param name="encoding">전송시 Encoding 방식</param>
        /// <returns>XMLDocument 형식의 결과 Data</returns>
        public XmlElement GetSend(string encoding)
        {
            XmlDocument resXml = new XmlDocument();

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(this.ServerUrl);
            req.KeepAlive = false;
            req.Method = "GET";
            req.ContentType = "application/x-www-form-urlencoded";

            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader resStream = new StreamReader(res.GetResponseStream(), Encoding.GetEncoding(encoding));

            resXml.LoadXml(resStream.ReadToEnd());
            resStream.Close();

            return resXml.DocumentElement;
        }

        /// <summary>
        /// HttpWebReqeust GET 방식을 이용하여 데이타 전송 후 결과값 리턴
        /// </summary>
        /// <param name="encoding">전송시 Encoding 방식</param>
        /// <returns>XMLDocument 형식의 결과 Data</returns>


        /// <summary>
        /// HttpWebReqeust 방식을 이용하여 데이타 전송만 하기
        /// </summary>
        public void SendOnly()
        {
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            byte[] ByteData = encoding.GetBytes(this.XmlData);

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(this.ServerUrl);
            req.KeepAlive = false;
            req.Method = this.Method;
            req.ContentType = this.ContentType;
            req.ContentLength = ByteData.Length;

            Stream reqStream = req.GetRequestStream();
            reqStream.Write(ByteData, 0, ByteData.Length);
            reqStream.Close();
        }

        /// <summary>
        /// HttpWebReqeust 방식을 이용하여 데이타 전송
        /// </summary>
        public XmlElement SendPost()
        {
            try
            {
                System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                byte[] ByteData = encoding.GetBytes(this.XmlData);

                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(this.ServerUrl);
                req.KeepAlive = false;
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = ByteData.Length;

                Stream reqStream = req.GetRequestStream();
                reqStream.Write(ByteData, 0, ByteData.Length);
                reqStream.Close();

                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                StreamReader resStream = new StreamReader(res.GetResponseStream(), Encoding.UTF8);

                XmlDocument resXml = new XmlDocument();
                resXml.LoadXml(resStream.ReadToEnd());
                resStream.Close();

                return resXml.DocumentElement;
            }
            catch (Exception ex)
            {
                XmlDocument XmlErr = new XmlDocument();
                XmlErr.LoadXml(String.Format("<x><Err><![CDATA[{0}]]></Err></x>", ex.ToString()));

                return XmlErr.DocumentElement;
            }
        }

    }
}
