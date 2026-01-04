using Newtonsoft.Json;

namespace Modetour.B2C.Entity.Package.Package
{
    public class SearchHistoryModel
    {
        [JsonProperty("Regions")]
        public Regions Regions { get; set; }

        [JsonProperty("SearchHistory")]
        public SearchHistory SearchHistory { get; set; }
    }
    public partial class Regions
    {
        [JsonProperty("Domestic")]
        public RegionsDomestic[] Domestic { get; set; }

        [JsonProperty("Overseas")]
        public RegionsDomestic[] Overseas { get; set; }
    }

    public partial class RegionsDomestic
    {
        [JsonProperty("RegionName")]
        public string RegionName { get; set; }

        [JsonProperty("RegionCode")]
        public string RegionCode { get; set; }
    }

    public partial class SearchHistory
    {
        [JsonProperty("Domestic")]
        public SearchHistoryDomestic[] Domestic { get; set; }

        [JsonProperty("Overseas")]
        public SearchHistoryDomestic[] Overseas { get; set; }
    }

    public partial class SearchHistoryDomestic
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("Region")]
        public string Region { get; set; }

        [JsonProperty("StartDate")]
        public string StartDate { get; set; }

        [JsonProperty("EndDate")]
        public DateTimeOffset EndDate { get; set; }

        [JsonProperty("Category")]
        public string Category { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }


}
