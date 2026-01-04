using System.Xml.Serialization;

namespace Modetour.B2C.Entity.Package.PackageXml
{
    [XmlRoot(ElementName = "Root")]
    public class MainBannerModel
    {
        [XmlArray(ElementName = "RollingBanner")]
        [XmlArrayItem(ElementName = "Item")]
        public List<BannerItemModel> RoolingBannerItem { get; set; }

        [XmlArray(ElementName = "FixedBanner")]
        [XmlArrayItem(ElementName = "Item")]
        public List<BannerItemModel> FixedBannerItem { get; set; }

        [XmlArray(ElementName = "Guerrilla")]
        [XmlArrayItem(ElementName = "Item")]
        public List<GuerrillaItemModel> GuerrillaItem { get; set; }

        [XmlElement(ElementName = "BigSale")]
        public BigSaleModel BigSale { get; set; }
    }
    public class BigSaleModel
    {
        [XmlElement(ElementName = "Item")]
        public BigSaleItemModel Item { get; set; }
    }

    public class GuerrillaItemModel
    {
        [XmlAttribute(AttributeName = "NO")]
        public string N0 { get; set; }

        [XmlAttribute(AttributeName = "NAME")]
        public string NAME { get; set; }

        [XmlElement(ElementName = "URL")]
        public string URL { get; set; }

        [XmlElement(ElementName = "Image")]
        public string Image { get; set; }

        [XmlElement(ElementName = "SellingStartDate")]
        public string SellingStartDate { get; set; }

        [XmlElement(ElementName = "SellingEndDate")]
        public string SellingEndDate { get; set; }

        [XmlElement(ElementName = "NewOpen")]
        public string NewOpen { get; set; }

        [XmlElement(ElementName = "Sort")]
        public string Sort { get; set; }

        [XmlElement(ElementName = "State")]
        public string State { get; set; }
    }

    public class BigSaleItemModel
    {
        [XmlAttribute(AttributeName = "NO")]
        public string N0 { get; set; }

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
