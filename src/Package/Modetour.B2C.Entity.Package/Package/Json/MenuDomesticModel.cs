using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Modetour.B2C.Entity.Package.Json
{
    public class MenuDomesticModel
    {
        [JsonProperty("item")]
        public List<SubItem1Domestic> Item1 { get; set; }
        [JsonProperty("StartArea")]
        public StartAreaDomestic StartArea { get; set; }
    }

    public class MenuDomesticRootModel
    {
        public MenuDomesticModel ModeTour { get; set; }
    }

    public class StartAreaDomestic
    {
        [JsonProperty("dlc")]
        public string Dlc { get; set; }
        [JsonProperty("gubun")]
        public string Gubun { get; set; }
        [JsonProperty("domestic")]
        public string Domestic { get; set; }
        [JsonProperty("selFirst")]
        public string DelFirst { get; set; }
        [JsonProperty("selSecond")]
        public string SelSecond { get; set; }
        [JsonProperty("theme")]
        public string Theme { get; set; }
        [JsonProperty("themeName")]
        public string ThemeName { get; set; }
    }
    public class SubItem1Domestic
    {
        [JsonProperty("label")]
        public string Label { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("SubMain")]
        public int SubMain { get; set; }
        [JsonProperty("Depth")]
        public int Depth { get; set; }
        [JsonProperty("Path")]
        public string Path { get; set; }
        [JsonProperty("Col")]
        public int Col { get; set; }
        [JsonProperty("Merge")]
        public string Merge { get; set; }
        [JsonProperty("item")]
        public List<SubItem2Domestic> Item { get; set; }
    }
    public class SubItem2Domestic
    {
        [JsonProperty("label")]
        public string Label2 { get; set; }
        [JsonProperty("id")]
        public string Id2 { get; set; }
        [JsonProperty("SubMain")]
        public int SubMain2 { get; set; }
        [JsonProperty("Depth")]
        public int Depth2 { get; set; }
        [JsonProperty("Path")]
        public string Path2 { get; set; }
        [JsonProperty("Col")]
        public int Col2 { get; set; }
        [JsonProperty("Theme")]
        public string Theme2 { get; set; }
        [JsonProperty("ThemeLabel")]
        public string ThemeLabel2 { get; set; }
        [JsonProperty("Merge")]
        public string Merge2 { get; set; }
    }
}
