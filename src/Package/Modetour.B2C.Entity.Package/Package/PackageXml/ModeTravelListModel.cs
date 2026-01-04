using System.Xml.Serialization;

namespace Modetour.B2C.Entity.Package.PackageXml
{
    [XmlRoot(ElementName = "Root")]
    public class ModeTravelListModel
    {
        [XmlElement(ElementName = "Banner")]
        public List<ModeTravelItemModel> Banner { set; get; }
    }
    public class ModeTravelItemModel
    {
        [XmlAttribute(AttributeName = "Type")]
        public string Type { set; get; }

        [XmlAttribute(AttributeName = "title")]
        public string title { set; get; }

        [XmlArray(ElementName = "TopBanner")]
        [XmlArrayItem(ElementName = "Item")]
        public List<BannerItemModel> TopBanner { set; get; }

        [XmlArray(ElementName = "FixedBanner")]
        [XmlArrayItem(ElementName = "Item")]
        public List<BannerItemModel> FixedBanner { set; get; }
    }
}
