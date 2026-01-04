using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modetour.B2C.Entity.Package.Package
{
    public class MenuListRelationModel
    {
        [XmlElement(ElementName = "relation")]
        [JsonProperty("relation")]
        public MenuListRelationModelRelation Relation { get; set; }
    }

    public partial class MenuListRelationModelRelation
    {
        [XmlElement(ElementName = "item")]
        [JsonProperty("item")]
        public List<MenuListRelationModelItem> Item { get; set; }
    }

    public partial class MenuListRelationModelItem
    {
        [XmlElement(ElementName = "LocID")]
        [JsonProperty("LocID")]
        public string LocId { get; set; }

        [XmlElement(ElementName = "TheID")]
        [JsonProperty("TheID")]
        public string TheID { get; set; }
    }
}
