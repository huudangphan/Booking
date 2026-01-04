using System.Xml.Serialization;

namespace Modetour.B2C.Entity.Package.PackageXml
{
    [XmlRoot(ElementName = "Root")]
    public class MainPromotionZoneModel
    {
        [XmlElement(ElementName = "SubPage")]
        public List<ZoneSubPageItemModel> SubPage { get; set; }
    }

    public class ZoneSubPageItemModel
    {
        [XmlAttribute(AttributeName = "THEMA_NO")]
        public string ThemeNo { get; set; }

        [XmlAttribute(AttributeName = "AREA_NO")]
        public string AreaNo { get; set; }

        [XmlAttribute(AttributeName = "NAVI")]
        public string Navi { get; set; }

        [XmlElement(ElementName = "Item")]
        public List<ZoneItemModel> Item { get; set; }

    }

    public class ZoneItemModel
    {
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "SubItem")]
        public List<ZoneSubItemModel> SubItem { get; set; }

    }


    public class ZoneSubItemModel
    {
        [XmlElement(ElementName = "p_NO")]
        public string Idx { get; set; }

        [XmlElement(ElementName = "Sort")]
        public string Sort { get; set; }

        [XmlElement(ElementName = "Price")]
        public string Price { get; set; }

        [XmlElement(ElementName = "P_Name")]
        public string P_Name { get; set; }

        [XmlElement(ElementName = "Image")]
        public string Image { get; set; }

    }
}
