using System.Xml.Serialization;

namespace Modetour.B2C.Entity.Package.PackageXml
{
    [XmlRoot(ElementName = "Root")]
    public class MainW1000Model
    {
        [XmlElement(ElementName = "SubPage")]
        public List<Subpage> SubItem { get; set; }
    }
    public class Subpage
    {
        [XmlAttribute(AttributeName = "THEMA_NO")]
        public string ThemeNo { get; set; }

        [XmlAttribute(AttributeName = "AREA_NO")]
        public string AreaNo { get; set; }

        [XmlElement(ElementName = "Item")]
        public List<Item> Item { get; set; }
    }
    public class Item
    {
        [XmlAttribute(AttributeName = "NO")]
        public string No { get; set; }

        [XmlElement(ElementName = "KeyWord")]
        public string KeyWord { get; set; }


        [XmlElement(ElementName = "URL")]
        public string URL { get; set; }

        [XmlElement(ElementName = "Image")]
        public string Image { get; set; }


        [XmlElement(ElementName = "NewOpen")]
        public string NewOpen { get; set; }

        [XmlElement(ElementName = "Sort")]
        public string Sort { get; set; }
    }
}
