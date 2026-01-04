using Newtonsoft.Json;

namespace Modetour.B2C.Entity.Package.Package
{
    public class ProductMasterResponse
    {
        [JsonProperty("ProductMaster")]
        public List<ProductMaster> ProductMaster { get; set; }

        [JsonProperty("Filter")]
        public Filter Filter { get; set; }
    }
    public partial class Filter
    {
        [JsonProperty("OriginalTravelFeeRange")]
        public OriginalTravelFeeRange OriginalTravelFeeRange { get; set; }
        [JsonProperty("TravelFee")]
        public TravelFee TravelFee { get; set; }

        [JsonProperty("StartingPoint")]
        public IEnumerable<FilterTravelConcept> StartingPoint { get; set; }

        [JsonProperty("TravelConcept")]
        public IEnumerable<FilterTravelConcept> TravelConcept { get; set; }

        [JsonProperty("Transport")]
        public IEnumerable<FilterTravelConcept> Transport { get; set; }

        [JsonProperty("Promotion")]
        public List<FilterTravelConcept> Promotion { get; set; }

        [JsonProperty("TourCondition")]
        public TourConditionC TourCondition { get; set; }

        [JsonProperty("TravelPeriod")]
        public IEnumerable<FilterTravelConcept> TravelPeriod { get; set; }

        [JsonProperty("DepatureTime")]
        public IEnumerable<FilterTravelConcept> DepatureTime { get; set; }

        [JsonProperty("DepatureDay")]
        public IEnumerable<FilterTravelConcept> DepatureDay { get; set; }

        [JsonProperty("Lodgment")]
        public IEnumerable<FilterTravelConcept> Lodgment { get; set; }

        [JsonProperty("ProductBrand")]
        public DepatureDay[] ProductBrand { get; set; }
        [JsonProperty("Theme")]
        public IEnumerable<FilterTravelConcept> Theme { get; set; }
    }
    public partial class OriginalTravelFeeRange
    {
        [JsonProperty("MinPrice")]
        public long MinPrice { get; set; }

        [JsonProperty("MaxPrice")]
        public long MaxPrice { get; set; }
    }
    public partial class DepatureDay
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }
    }

    public partial class Transport
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("Logo")]
        public Uri Logo { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }
    }

    public partial class TravelFee
    {
        [JsonProperty("MinPrice")]
        public long MinPrice { get; set; }

        [JsonProperty("MaxPrice")]
        public long MaxPrice { get; set; }
    }

    public partial class ProductMaster
    {
        [JsonProperty("MasterCode")]
        public string MasterCode { get; set; }
        public string MasterCodeId { get; set; }

        [JsonProperty("MasterProductName")]
        public string MasterProductName { get; set; }
        [JsonProperty("Descriptions")]
        public string Descriptions { get; set; }

        [JsonProperty("Price")]
        public long Price { get; set; }

        [JsonProperty("Period")]
        public string Period { get; set; }

        //[JsonProperty("AirCode")]
        //public string AirCode { get; set; }

        //[JsonProperty("AirName")]
        //public string AirName { get; set; }

        //[JsonProperty("Logo")]
        //public Uri Logo { get; set; }

        [JsonProperty("Image")]
        public Uri Image { get; set; }
        public List<string> DepatureFrom { get; set; }
        public string DepatureTo { get; set; }

        public DateTime DepatureDate { get; set; }

        public DateTime ArriveDate { get; set; }

        [JsonProperty("TravelType")]
        public string TravelType { get; set; }

        [JsonProperty("Tags")]
        public string Tags { get; set; }

        [JsonProperty("PriceList")]
        public PriceList PriceList { get; set; }
        public string DeviceType { get; set; }
        public List<Area> Areas { get; set; }
        public string Description { get; set; }
        public List<ProductCodes> ProductCodes { get; set; }
    }

    public partial class PriceList
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }
    }

    public partial class Tag
    {
        [JsonProperty("Id")]

        public long Id { get; set; }

        [JsonProperty("Content")]
        public string Content { get; set; }
    }
    public class Area
    {
        public string id { get; set; }
        public string name { get; set; }
    }
    public class ProductCodes
    {
        public string AsisProductNo { get; set; }
        public Uri[] BadgeImages { get; set; }
        public string AirCode { get; set; }
        public string PCode { get; set; }
        public string MarketingAirCode { get { return AirCode.Substring(0, 2); } set { } }
        public string MarketingAirName { get; set; }
    }

    public class FilterTravelConcept
    {
        public string FilterStatus { get; set; }
        //public List<Grade> TravelConcept { get; set; }    
        public string code { get; set; }
        public string name { get; set; }
        public int cnt { get; set; }
    }
    public class FilterPromotion
    {
        public string FilterStatus { get; set; }
        public List<FilterListPromotion> FilterPromotionList { get; set; }
    }
    public class FilterListPromotion
    {
        public string code { get; set; }
        public string value { get; set; }
    }

    public class TransportFilter
    {
        public string FilterStatus { get; set; }
        public string[] StartingPoint { get; set; }
    }
    public class TravelConcepFilter
    {

    }
}