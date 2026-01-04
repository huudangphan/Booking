using Modetour.B2C.Commons.Model;
using System.Xml;

namespace Modetour.B2C.Commons.Helper
{
    public interface IXmlHelper
    {
        public string ConvertString(object obj);
        public string ConvertString(object obj, string elemname);
        public object ConvertObject(XmlDocument xml, Type type);
        public object ConvertObject(string xml, Type type);
        public XmlDocument Load(string path, APIEncodingType encodingType = APIEncodingType.UTF8, APIRequestType requestType = APIRequestType.GET);
        public XMLDocumentObject LoadXmlByGubun(string XmlDoc, Int16 Gubun);
    }
}
