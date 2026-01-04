using Modetour.B2C.Commons.Model;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Modetour.B2C.Commons.Helper
{
    public class XmlHelper : IXmlHelper
    {
        public string ConvertString(object obj)
        {
            string result = string.Empty;

            if (obj.GetType() == typeof(string))
            {
                result = obj.ToString();
            }
            else
            {
                var ns = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
                var serializer = new XmlSerializer(obj.GetType());
                var setting = new XmlWriterSettings();
                setting.Indent = true;
                setting.OmitXmlDeclaration = true;
                using (StringWriter stream = new StringWriter())
                using (var writer = XmlWriter.Create(stream, setting))
                {
                    serializer.Serialize(writer, obj, ns);
                    result = stream.ToString();
                }
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="elemname"></param>
        /// <returns></returns>
        public string ConvertString(object obj, string elemname)
        {
            string result = string.Empty;

            if (obj.GetType() == typeof(string))
            {
                result = obj.ToString();
            }
            else
            {
                var ns = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
                var serializer = new XmlSerializer(obj.GetType(), new XmlRootAttribute(elemname));
                var setting = new XmlWriterSettings();
                setting.Indent = true;
                setting.OmitXmlDeclaration = true;
                using (StringWriter stream = new StringWriter())
                using (var writer = XmlWriter.Create(stream, setting))
                {
                    serializer.Serialize(writer, obj, ns);
                    result = stream.ToString();
                }
            }

            return result;
        }

        /// <summary>
        /// Xml문자열을 해당 Type의 object로 변환
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public object ConvertObject(XmlDocument xml, Type type)
        {
            StringWriter sw = new StringWriter();
            XmlTextWriter xw = new XmlTextWriter(sw);
            xml.WriteTo(xw);
            object result = new object();

            try
            {
                var serializer = new XmlSerializer(type);
                using (TextReader reader = new StringReader(sw.ToString()))
                {
                    result = serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {

                result = null;
            }

            return result;
        }
        /// <summary>
        /// Convert XML string to object of the corresponding type
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public object ConvertObject(string xml, Type type)
        {
            object result = new object();

            try
            {
                var serializer = new XmlSerializer(type);
                using (TextReader reader = new StringReader(xml))
                {
                    result = serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                result = null;
            }

            return result;
        }
        /// <summary>
        /// XML 문서 가져오기
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public XmlDocument Load(string path, APIEncodingType encodingType = APIEncodingType.UTF8, APIRequestType requestType = APIRequestType.GET)
        {
            return Load(path, string.Empty, string.Empty, encodingType, requestType);
        }

        /// <summary>
        /// XML 문서 가져오기
        /// </summary>
        /// <param name="path"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static XmlDocument Load(string path, string data, APIEncodingType encodingType = APIEncodingType.UTF8, APIRequestType requestType = APIRequestType.GET)
        {
            return Load(path, string.Empty, data, encodingType, requestType);
        }

        /// <summary>
        /// XML 문서 가져오기
        /// </summary>
        /// <param name="path"></param>
        /// <param name="method"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static XmlDocument Load(string path, string method, string data, APIEncodingType encodingType = APIEncodingType.UTF8, APIRequestType requestType = APIRequestType.GET)
        {
            ResultModel result = APIHelper.Call(path, method, data, APIContentType.XML, encodingType, requestType);

            XmlDocument doc = null;
            if (result.Code == "0")
            {
                doc = new XmlDocument();
                doc.LoadXml(result.Data.ToString());
            }

            return doc;
        }

        public static string Load(string xmlUrl, string method, string data, string xslUrl, APIEncodingType encodingType = APIEncodingType.UTF8, APIRequestType requestType = APIRequestType.GET)
        {
            XmlDocument doc = Load(xmlUrl, method, data, encodingType, requestType);

            return Load(doc, xslUrl);
        }

        public static string Load(XmlDocument doc, string xslUrl, APIEncodingType encodingType = APIEncodingType.UTF8, APIRequestType requestType = APIRequestType.GET)
        {
            string result = string.Empty;

            StringWriter xmlTransWriter = new StringWriter();
            XslCompiledTransform xslDoc = new XslCompiledTransform();
            xslDoc.Load(xslUrl, XsltSettings.Default, new XmlUrlResolver());
            xslDoc.Transform((IXPathNavigable)doc, null, xmlTransWriter);

            result = xmlTransWriter.ToString();

            xmlTransWriter.Close();
            xmlTransWriter.Dispose();

            return result;
        }
        public static string ConvertToXml(object dataToSerialize)
        {
            if (dataToSerialize == null) return null;

            using (StringWriter stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(dataToSerialize.GetType());
                serializer.Serialize(stringwriter, dataToSerialize);
                return stringwriter.ToString();
            }
        }


        /// <summary>
        /// Xml텍스트를 Load
        /// </summary>
        /// <param name="XmlDoc">Xml데이터 또는 Xml파일 주소</param>
        /// <param name="Gubun">0 : XmlDoc값은 URL 또는 APP로컬경로, 1 : XmlDoc값은 String</param>
        /// <returns>XmlDocument</returns>
        public XMLDocumentObject LoadXmlByGubun(string XmlDoc, Int16 Gubun)
        {
            XMLDocumentObject ReturnXml = new XMLDocumentObject();
            try
            {
                if (Gubun == 0)
                {
                    if (XmlDoc.ToLower().StartsWith("http://"))
                    {
                        ReturnXml.Load(XmlDoc);
                    }
                    else
                    {
                        FileInfo Fs = new FileInfo(XmlDoc);
                        if (Fs.Exists)
                        {
                            FileStream XmlStr = new FileStream(XmlDoc, FileMode.Open);
                            ReturnXml.Load(XmlStr);
                            XmlStr.Close();
                            XmlStr.Dispose();
                        }
                        else
                        {
                            ReturnXml = null;
                        }
                    }//end if
                }
                else
                {
                    ReturnXml.LoadXml(XmlDoc);
                }//end if
            }
            catch (XmlException ex)
            {
                ReturnXml = null;
            }
            return ReturnXml;
        }
    }
}
