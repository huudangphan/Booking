using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package
{
    public class StartLocationModel
    {
        [JsonProperty("StartLocation")]
        public StartLocation[] StartLocation { get; set; }
    }
    public partial class StartLocation
    {
        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Label")]
        public string Label { get; set; }
    }
}
