using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modetour.B2C.Entity.Package
{
    [XmlRoot(ElementName = "Root")]
    public class MainPlanModel
    {
        [XmlElement(ElementName = "Banner")]
        public List<BannerModel> Banner { get; set; }
    }

    public class BannerModel
    {
        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "SubPage")]
        public List<SubPageBannerItemModel> SubPage { get; set; }

    }

    public class SubPageBannerItemModel
    {
        [XmlAttribute(AttributeName = "THEMA_NO")]
        public string ThemeNo { get; set; }

        [XmlAttribute(AttributeName = "AREA_NO")]
        public string AreaNo { get; set; }

        [XmlElement(ElementName = "Item")]
        public List<BannerItemModel> Item { get; set; }
    }

    public class BannerItemModel
    {
        [XmlAttribute(AttributeName = "NO")]
        public string NO { get; set; }

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
