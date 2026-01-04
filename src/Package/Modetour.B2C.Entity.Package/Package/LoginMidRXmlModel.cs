using System.Xml.Serialization;

namespace Modetour.B2C.Entity.Package
{
    [XmlRoot(ElementName = "Root")]
    public class LoginMidRModel
    {
        [XmlElement(ElementName = "Sector")]
        public Sector Sector { get; set; }
    }
    public class LoginMidRXmlModel
    {
        public LoginMidRModel Product { get; set; }

    }
    public class Sector
    {
        [XmlAttribute(AttributeName = "name")]
        public string name { get; set; }

        [XmlElement(ElementName = "explan")]
        public string explan { get; set; }
        [XmlElement(ElementName = "Item")]
        public List<ItemLoginMidR> Item { get; set; }
    }
    public class ItemLoginMidR
    {
        [XmlAttribute(AttributeName = "open")]
        public string open { get; set; }
        [XmlElement(ElementName = "title")]
        public title title { get; set; }
        [XmlElement(ElementName = "imgUrl")]
        public imgUrl imgUrl { get; set; }

        [XmlElement(ElementName = "linkUrl")]
        public linkUrl linkUrl { get; set; }




    }
    public class linkUrl
    {
        public string value { get; set; }
    }
    public class imgUrl
    {
        public string value { get; set; }
    }
    public class title
    {
        public string value { get; set; }
    }
}
