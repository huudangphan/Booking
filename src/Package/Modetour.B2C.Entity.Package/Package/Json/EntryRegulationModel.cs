using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package.Json
{
    public class EntryRegulationModel
    {
        [JsonProperty("CreateDateTime")]
        public string CreateDateTime { get; set; }

        [JsonProperty("nationList")]
        public NationList[] NationList { get; set; }
    }
    public partial class NationList
    {
        [JsonProperty("Continent")]
        public string Continent { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("AreaCategory")]
        public string[] AreaCategory { get; set; }

        [JsonProperty("restrictionContentList")]
        public RestrictionContentList[] RestrictionContentList { get; set; }
    }

    public partial class RestrictionContentList
    {
        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Contents")]
        public string Contents { get; set; }
    }
}
