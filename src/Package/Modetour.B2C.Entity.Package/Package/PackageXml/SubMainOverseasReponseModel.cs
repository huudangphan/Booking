using System.Xml.Serialization;

namespace Modetour.B2C.Entity.Package.PackageXml
{
    [XmlRoot(ElementName = "Root")]
    public class SubMainOverseasReponseModel
    {
        [XmlElement(ElementName = "Item")]
        public List<ItemSubMainOverseas> Item { get; set; }
    }
    public class SubMainOverseasXmlReponseModel
    {
        public SubMainOverseasReponseModel Root { get; set; }
    }
    public class ItemSubMainOverseas
    {
        [XmlAttribute(AttributeName = "idx")]
        public string idx { get; set; }
        [XmlAttribute(AttributeName = "sort")]
        public string sort { get; set; }
        [XmlAttribute(AttributeName = "price")]
        public string price { get; set; }
        [XmlAttribute(AttributeName = "p_Name")]
        public string p_Name { get; set; }
        [XmlAttribute(AttributeName = "image")]
        public string image { get; set; }
        [XmlAttribute(AttributeName = "title")]
        public string title { get; set; }
    }
}
