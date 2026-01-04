using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package
{
    public class CommentResponse
    {
        [JsonProperty("content")]
        public Content[] Content { get; set; }
    }
    public partial class Content
    {
        [JsonProperty("serialNumber")]
        public int SerialNumber { get; set; }

        [JsonProperty("ptid")]
        public int Ptid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("registerDate")]
        public DateTimeOffset RegisterDate { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("writer")]
        public string Writer { get; set; }

        [JsonProperty("searchNumber")]
        public int SearchNumber { get; set; }

        [JsonProperty("recommend")]
        public int Recommend { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("satisfactionRate")]

        public int SatisfactionRate { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("open")]

        public int Open { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("regionPLID")]
        public int RegionPlid { get; set; }

        [JsonProperty("travelSpot")]
        public string TravelSpot { get; set; }

        [JsonProperty("itemClassification")]
        public string ItemClassification { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("guestRoom")]
        public int GuestRoom { get; set; }

        [JsonProperty("service")]
        public int Service { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("content")]
        public string ContentContent { get; set; }

        [JsonProperty("groupNumber")]
        public int GroupNumber { get; set; }

        [JsonProperty("departureDate")]
        public DateTimeOffset DepartureDate { get; set; }

        [JsonProperty("travelPeriod")]
        public string TravelPeriod { get; set; }

        [JsonProperty("representativeHotel")]
        public object RepresentativeHotel { get; set; }

        [JsonProperty("hotelClass")]
        public object HotelClass { get; set; }

        [JsonProperty("airlineName")]
        public string AirlineName { get; set; }

        [JsonProperty("FatherCommentId")]
        public int FatherCommentId { get; set; }

        [JsonProperty("Depth")]
        public int Depth { get; set; }
    }
}
