using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package
{
    public class TravelReviewModel
    {
        [JsonProperty("result1")]
        public Result1[] Result1 { get; set; }

        [JsonProperty("result2")]
        public Result2[] Result2 { get; set; }
    }
    public partial class Result1
    {
        [JsonProperty("SerialNumber")]
        public int SerialNumber { get; set; }

        [JsonProperty("PTID")]
        public int Ptid { get; set; }

        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("RegisterDate")]
        public DateTime RegisterDate { get; set; }

        [JsonProperty("GroupName")]
        public string GroupName { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Writer")]
        public string Writer { get; set; }

        [JsonProperty("SearchNumber")]
        public int SearchNumber { get; set; }

        [JsonProperty("Recommend")]
        public int Recommend { get; set; }

        [JsonProperty("Image")]
        public string Image { get; set; }

        [JsonProperty("SatisfactionRate")]
 
        public int SatisfactionRate { get; set; }

        [JsonProperty("Region")]
        public string Region { get; set; }

        [JsonProperty("Open")]
      
        public string Open { get; set; }

        [JsonProperty("Picture")]
        public string Picture { get; set; }

        [JsonProperty("RegionPLID")]
        public int RegionPlid { get; set; }

        [JsonProperty("TravelSpot")]
        public string TravelSpot { get; set; }

        [JsonProperty("ItemClassification")]
        public string ItemClassification { get; set; }

        [JsonProperty("Position")]
        public int Position { get; set; }

        [JsonProperty("GuestRoom")]
        public int GuestRoom { get; set; }

        [JsonProperty("Service")]
        public int Service { get; set; }

        [JsonProperty("Price")]
        public int Price { get; set; }

        [JsonProperty("Content")]
        public string Content { get; set; }

        [JsonProperty("GroupNumber")]
        public string GroupNumber { get; set; }

        [JsonProperty("DepartureDate")]
        public string DepartureDate { get; set; }

        [JsonProperty("TravelPeriod")]
        public string TravelPeriod { get; set; }

        [JsonProperty("RepresentativeHotel")]
        public string RepresentativeHotel { get; set; }

        [JsonProperty("HotelClass")]
        public string HotelClass { get; set; }

        [JsonProperty("AirlineName")]
        public string AirlineName { get; set; }

        [JsonProperty("Hashtag")]
        public string Hashtag { get; set; }

        [JsonProperty("expectDetails")]
        public string ExpectDetails { get; set; }

        [JsonProperty("attachedFiles")]
        public string AttachedFiles { get; set; }

        [JsonProperty("totalLike")]
        public string TotalLike { get; set; }

        [JsonProperty("delDate")]
        public string DelDate { get; set; }

        [JsonProperty("delBy")]
        public string DelBy { get; set; }

        [JsonProperty("hideBy")]
        public string HideBy { get; set; }
    }

    public partial class Result2
    {
        [JsonProperty("SatisfactionRate_Number")]
        public int SatisfactionRateNumber { get; set; }

        [JsonProperty("SatisfactionRate_Sum")]
        public int SatisfactionRateSum { get; set; }

        [JsonProperty("SatisfactionRate_Average")]
        public int SatisfactionRateAverage { get; set; }
    }
}
