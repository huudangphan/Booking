using System.Xml;
using System.Xml.Serialization;
namespace Modetour.B2C.Entity
{
    [XmlRoot(ElementName = "Root")]
    public class MainProductModel
    {
        [XmlElement(ElementName = "SubPage")]
        public List<MainProductSubPageModel> SubPage { get; set; }
    }

    public class MainProductSubPageModel
    {
        [XmlAttribute(AttributeName = "THEMA_NO")]
        public string ThemeNo { get; set; }

        [XmlAttribute(AttributeName = "AREA_NO")]
        public string AreaNo { get; set; }

        [XmlElement(ElementName = "Item")]
        public List<MainProductItemModel> Item { get; set; }
    }

    public class MainProductItemModel
    {
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "Sort")]
        public string Sort { get; set; }

        [XmlElement(ElementName = "SubItem")]
        public List<MainProductSubItemModel> SubItem { get; set; }

    }

    public class MainProductSubItemModel
    {

        [XmlElement(ElementName = "BannerType")]
        public string BannerType { get; set; }

        [XmlElement(ElementName = "Image")]
        public string Image { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "Sort")]
        public string Sort { get; set; }

        [XmlElement(ElementName = "Price")]
        public string Price { get; set; }


        [XmlElement(ElementName = "p_NO")]
        public string PNo { get; set; }


        [XmlElement(ElementName = "P_Code")]
        public string PCode { get; set; }


        [XmlElement(ElementName = "P_Name")]
        public string P_Name { get; set; }
        [XmlElement(ElementName = "Discount")]
        public List<DiscountItem> Discount { get; set; }

    }
    public class DiscountItem
    {
        [XmlElement(ElementName = "Display")]
        public List<DisplayItem> Display { get; set; }
        //[XmlElement(ElementName = "IconPath")]
        //public string Iconpath { get; set; }
        //[XmlAttribute(AttributeName = "MasterNumber")]
        public double MasterNumber { get; set; }
        [XmlAttribute(AttributeName = "Rate_Price")]
        public double Rate_Price { get; set; }
    }
    public class DisplayItem
    {
        private DateTime? SDate;
        [XmlIgnore]
        public DateTime? _SDate
        {
            get { return SDate; }
            set { SDate = value; }
        }
        [XmlAttribute(AttributeName = "SDate")]
        public string SDateString
        {
            get
            {
                return SDate.HasValue ? XmlConvert.ToString(SDate.Value, XmlDateTimeSerializationMode.Unspecified)
           : string.Empty;
            }
            set
            {
                SDate = !string.IsNullOrEmpty(value) ? XmlConvert.ToDateTime(value, XmlDateTimeSerializationMode.Unspecified) : (DateTime?)null;
            }
        }
        private DateTime? EDate { get; set; }
        [XmlIgnore]
        public DateTime? _EDate
        {
            get { return EDate; }
            set { EDate = value; }
        }
        [XmlAttribute(AttributeName = "EDate")]
        public string EDateString
        {
            get
            {
                return SDate.HasValue ? XmlConvert.ToString(EDate.Value, XmlDateTimeSerializationMode.Unspecified)
           : string.Empty;
            }
            set
            {
                EDate = !string.IsNullOrEmpty(value) ? XmlConvert.ToDateTime(value, XmlDateTimeSerializationMode.Unspecified) : (DateTime?)null;
            }
        }
    }
    public enum TravelItems
    {
        FreeSchedule = 1,
        NoTip = 2,
        NoGuide = 3,
        NoShopping = 4,
        OptionalSighteeing = 5
    }
    public enum DepatureDayOfWeek
    {
        Monday = 2,
        Tuesday = 3,
        Wednesday = 4,
        Thursday = 5,
        Friday = 6,
        Saturday = 7,
        Sunday = 8,
    }
    public enum TravelType
    {
        Honeymoon = 3,
        freeTravel = 4,
        golfTrip = 5,
        cruise = 7,
        Korea_Jeju = 88
    }

}