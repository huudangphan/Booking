using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package
{
    public class OverseasTravelVariableModel
    {
        [JsonProperty("Response")]
        public Response[] Response { get; set; }
    }
    public partial class Response
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public Category[] Categories { get; set; }

        [JsonProperty("set1", NullValueHandling = NullValueHandling.Ignore)]
        public Category[] Set1 { get; set; }

        [JsonProperty("set2", NullValueHandling = NullValueHandling.Ignore)]
        public Category[] Set2 { get; set; }

        [JsonProperty("exhibitions", NullValueHandling = NullValueHandling.Ignore)]
        public Category[] Exhibitions { get; set; }

        [JsonProperty("regions", NullValueHandling = NullValueHandling.Ignore)]
        public RegionOverseas[] Regions { get; set; }
    }

    public partial class Category
    {
        [JsonProperty("registerType")]
        public string RegisterType { get; set; }

        [JsonProperty("commonImage")]
        public string[] CommonImage { get; set; }

        [JsonProperty("exhibitionId")]
        
        public long ExhibitionId { get; set; }

        [JsonProperty("exhibitionTitle")]
        public string ExhibitionTitle { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Tags { get; set; }

        [JsonProperty("exposurePeriod")]
        public ExposurePeriodOverseas ExposurePeriod { get; set; }

        [JsonProperty("subTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string? SubTitle { get; set; }

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public long? Price { get; set; }
    }

    public partial class ExposurePeriodOverseas
    {
        [JsonProperty("startDate")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateTimeOffset EndDate { get; set; }
    }

    public partial class RegionOverseas
    {
        [JsonProperty("id")]
       
        public long Id { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("exhibitions")]
        public Category[] Exhibitions { get; set; }
    }

}
