using System.Xml.Serialization;

namespace Modetour.B2C.Entity.Package.PackageXml
{
    [XmlRoot(ElementName = "Root")]
    public class MainMarketingAreaModel
    {
        [XmlArray(ElementName = "MarketingBanner")]
        [XmlArrayItem(ElementName = "Item")]
        public List<BannerMarketingItemModel> MarketingBanner { set; get; }

        [XmlArray(ElementName = "SpecialExhibitionBanner")]
        [XmlArrayItem(ElementName = "Item")]
        public List<BannerMarketingItemModel> SpecialExhibitionBanner { set; get; }
    }
    public class BannerMarketingItemModel
    {

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "URL")]
        public string URL { get; set; }

        [XmlElement(ElementName = "BImage")]
        public string BImage { get; set; }


        [XmlElement(ElementName = "Image")]
        public string Image { get; set; }

        [XmlElement(ElementName = "NewOpen")]
        public string NewOpen { get; set; }

        [XmlElement(ElementName = "Sort")]
        public string Sort { get; set; }
    }
}