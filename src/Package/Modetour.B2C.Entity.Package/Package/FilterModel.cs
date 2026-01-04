using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package
{
    public class FilterModel
    {
        [JsonProperty("filter")]
        public FilterNew[] Filter { get; set; }
    }
    public partial class FilterNew
    {
        [JsonProperty("filterName")]
        public string FilterName { get; set; }

        [JsonProperty("filterStatus")]
        public string FilterStatus { get; set; }

        [JsonProperty("details")]
        public Detail[] Details { get; set; }

        [JsonProperty("subFilters")]
        public SubFilter[] SubFilters { get; set; }
    }

    public partial class Detail
    {
        [JsonProperty("FromHour")]
        public long FromHour { get; set; }

        [JsonProperty("ToHour")]
        public long ToHour { get; set; }

        [JsonProperty("IsFixed")]
        public bool IsFixed { get; set; }
    }

    public partial class SubFilter
    {
        [JsonProperty("filterName")]
        public string FilterName { get; set; }

        [JsonProperty("filterStatus")]
        public string FilterStatus { get; set; }
    }
}
