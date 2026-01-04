using System.Xml.Serialization;

namespace Modetour.B2C.Entity.Model
{
    /// <summary>
    /// Error data model class
    /// </summary>
    [XmlRoot(ElementName = "ErrorMessage")]
    public class ErrorModel
    {
        [XmlElement(ElementName = "errorSource")]
        public SourceModel Source { set; get; }

        [XmlElement(ElementName = "errorMessageText")]
        public MessageModel Message { set; get; }

        [XmlElement(ElementName = "errorOriginal")]
        public string Original { set; get; }

        public class SourceModel
        {
            [XmlElement(ElementName = "gds")]
            public string GDS { set; get; }

            [XmlElement(ElementName = "method")]
            public string Method { set; get; }

            [XmlElement(ElementName = "server")]
            public string Server { set; get; }

            [XmlElement(ElementName = "requestAddr")]
            public string RequestIP { set; get; }
        }

        public class MessageModel
        {
            [XmlElement(ElementName = "description")]
            public string Description { set; get; }
        }
    }
}