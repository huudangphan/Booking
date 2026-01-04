using Modetour.B2C.Entity.Package.TravelCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.TravelCore
{


    public class AreaModel
    {
        [JsonProperty("AreaKeywordId")]
        public string AreaKeywordId { get; set; }
        [JsonProperty("CountryUnique")]
        public string CountryUnique { get; set; }
        [JsonProperty("KoreanName")]
        public string KoreanName { get; set; }
        [JsonProperty("EnglishName")]
        public string EnglishName { get; set; }
        [JsonProperty("SimilarWord")]
        public string SimilarWord { get; set; }
        [JsonProperty("CountryAreaKeywordId")]
        public string CountryAreaKeywordId { get; set; }
        [JsonProperty("AirportIATA")]
        public string AirportIATA { get; set; }
        [JsonProperty("AirportICAO")]
        public string AirportICAO { get; set; }

    }

    public class KeyWordProductModel
    {
        [JsonProperty("Area")]
        public List<AreaModel> Area { get; set; }
    }

}
