using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package
{
    public class ProductMasterModel
    {
        [JsonProperty("MasterCodeId")]
        public string MasterCodeId { get; set; }

        [JsonProperty("MasterCode")]
        public string MasterCode { get; set; }

        [JsonProperty("MasterCodeName")]
        public string MasterCodeName { get; set; }

        [JsonProperty("ExposureStartDate")]
        public DateTime ExposureStartDate { get; set; }

        [JsonProperty("ExposureEndDate")]
        public DateTime ExposureEndDate { get; set; }

        [JsonProperty("NightsAndDays")]
        public string NightsAndDays { get; set; }

        [JsonProperty("DeviceType")]
        public string DeviceType { get; set; }

        [JsonProperty("Descriptions")]
        public string Descriptions { get; set; }

        [JsonProperty("Image")]
        public Uri Image { get; set; }

        [JsonProperty("Hashtags")]
        public string Hashtags { get; set; }

        [JsonProperty("AreaIds")]
        public string[] AreaIds { get; set; }

        [JsonProperty("AreaNames")]
        public string AreaNames { get; set; }

        [JsonProperty("ProductCodes")]
        public ProductCode[] ProductCodes { get; set; }
    }
    public partial class ProductCode
    {
        [JsonProperty("AsisProductNo")]
        public string AsisProductNo { get; set; }

        [JsonProperty("BadgeImages")]
        public Uri[] BadgeImages { get; set; }
        [JsonProperty("AirCode")]
        public string AirCode { get; set; }
        [JsonProperty("Pcode")]
        public string PCode { get; set; }
    }

}
