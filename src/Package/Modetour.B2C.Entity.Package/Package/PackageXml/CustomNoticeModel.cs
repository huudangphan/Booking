using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modetour.B2C.Entity.Package.Package.PackageXml
{
    public class CustomNoticeModel
    {
        [JsonProperty("Items")]
        public List<Item> Items { get; set; }
    }
    //public partial class CustomNoticeModel
    //{
    //    [JsonProperty("Root")]
    //    public Root Root { get; set; }
    //}

    //public partial class Root
    //{
    //    [JsonProperty("Data")]
    //    public Data Data { get; set; }
    //}

    //public partial class Data
    //{
    //    [JsonProperty("Items")]
    //    public Item[] Items { get; set; }
    //}
    public class Item
    {
        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Content")]
        public string Content { get; set; }

        [JsonProperty("RepresentativeImage")]
        public string RepresentativeImage { get; set; }

        [JsonProperty("Path")]
        public string Path { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("ProductName")]
        public string ProductName { get; set; }

        [JsonProperty("GroupNumber")]
        public int? GroupNumber { get; set; }

        [JsonProperty("ProductCode")]
        public string ProductCode { get; set; }

        [JsonProperty("DepartureDate")]
        public DateTimeOffset DepartureDate { get; set; }

        [JsonProperty("ProductType")]
        public string ProductType { get; set; }

        [JsonProperty("NumberOfDays")]
        public long NumberOfDays { get; set; }

        [JsonProperty("PeopleAvailable")]
        public long PeopleAvailable { get; set; }

        [JsonProperty("Sort")]
        //  [JsonConverter(typeof(ParseStringConverter))]
        public long Sort { get; set; }
    }
}


