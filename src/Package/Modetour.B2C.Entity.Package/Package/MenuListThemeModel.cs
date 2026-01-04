using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modetour.B2C.Entity.Package.Package
{
    public class MenuListThemeModel
    {
        [JsonProperty("ModeTouretail")]
        [XmlElement(ElementName = "ModeTouretail")]
        public MenuListThemeModelModeTour ModeTour { get; set; }
    }

    public partial class MenuListThemeModelModeTour
    {
        [JsonProperty("StartArea")]
        [XmlElement(ElementName = "StartArea")]
        public MenuListThemeModelStartArea StartArea { get; set; }

        [JsonProperty("item")]
        [XmlElement(ElementName = "item")]
        public MenuListThemeModelItem[] Item { get; set; }
    }

    public partial class MenuListThemeModelItem
    {
        [JsonProperty("label")]
        [XmlElement(ElementName = "label")]
        public string Label { get; set; }

        [JsonProperty("id")]
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }

        [JsonProperty("SubMain")]
        [XmlElement(ElementName = "SubMain")]
        public long SubMain { get; set; }

        [JsonProperty("Hidden")]
        [XmlElement(ElementName = "Hidden")]
        public string Hidden { get; set; }

        [JsonProperty("Depth")]
        [XmlElement(ElementName = "Depth")]
        public long Depth { get; set; }

        [JsonProperty("Path")]
        [XmlElement(ElementName = "Path")]
        public string Path { get; set; }

        [JsonProperty("Gubun")]
        [XmlElement(ElementName = "Gubun")]
        public string Gubun { get; set; }
    }

    public partial class MenuListThemeModelStartArea
    {
        [JsonProperty("value")]
        [XmlElement(ElementName = "value")]
        public string Value { get; set; }

        [JsonProperty("Gubun")]
        [XmlElement(ElementName = "Gubun")]
        public string Gubun { get; set; }
    }
}
