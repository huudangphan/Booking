using ModetourB2C.Dac.Model.MODEWEB3;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Modetour.B2C.Entity.Package.Package.TravelCore
{
    public class TravelReviewViewModel
    {
        public int? TotalReview { get; set; }
        public int? TotalRate { get; set; }
        public float? SatisfactionAverageRate { get; set; }
        public float? SatisfactionScheduleRate { get; set; }
        public float? SatisfactionHotelRate { get; set; }
        public float? SatisfactionAirlineRate { get; set; }
        public float? SatisfactionPriceRate { get; set; }
        public float? SatisfactionTourRate { get; set; }
        public float? SatisfactionValueForMoneyRate { get; set; }
        public List<ReiviewItem> ListOldReview { get; set; }
        public List<DataReviewsReponseModel> ListNewReview { get; set; }
    }

    public class ReiviewItem : WSP_S_CMN_TravelReview_List.Result1
    {
    }

    public class NewReiviewItem
    {

        [XmlElement(ElementName = "SerialNumber")]
        [JsonProperty("SerialNumber")]
        public int SerialNumber { get; set; } = new Random().Next(1, 50000);

        [XmlElement(ElementName = "Title")]
        [JsonProperty("Title")]
        public string? Title { get; set; } = "일정표 개무시, 옵션 강제(강요x 강제o) 인생 최악의여행";

        [XmlElement(ElementName = "Writer")]
        [JsonProperty("Writer")]
        public string? Writer { get; set; } = "김모두모두별명";

        [XmlElement(ElementName = "WriterAvatar")]
        [JsonProperty("WriterAvatar")]
        public string? WriterAvatar { get; set; } = "https://img.modetour.com/air/logo/00.png";
        [XmlElement(ElementName = "WriterLocation")]
        [JsonProperty("WriterLocation")] 


        public string? WriterLocation { get; set; } = "오사카, 일본";


        [XmlElement(ElementName = "Content")]
        [JsonProperty("Content")]
        public string? Content { get; set; } = "솔레아리조트에 있는 카약체험도 재밌었어요. \r\n시간되시는 분들에게 적극 추천하고 싶네요. 솔레아리조트에 숙박\r\n하시는 분은 쿠폰으로 이용할수 있으니 이용을 권장합니다!\r\n첫날부터 마지막까지 친절하게 안내해주신 가이드 조이님께 감사 \r\n드립니다.";

        [XmlElement(ElementName = "ReviewTravelImages")]
        [JsonProperty("ReviewTravelImages")]
        public string ReviewTravelImages { get; set; } 


        [XmlElement(ElementName = "ReviewComments")]
        [JsonProperty("ReviewComments")]
        public string ReviewComments { get; set; } 


        [XmlElement(ElementName = "HagTags")]
        [JsonProperty("HagTags")]
        public string[] HagTags { get; set; } 

        [XmlElement(ElementName = "TotalComment")]
        [JsonProperty("TotalComment")]
        public int? TotalComment { get; set; } 

        [XmlElement(ElementName = "TotalLike")]
        [JsonProperty("TotalLike")]
        public string TotalLike { get; set; } 
        [XmlElement(ElementName = "CreatedDate")]
        [JsonProperty("CreatedDate")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }

    public class ReviewTravelImageItem
    {

        [XmlElement(ElementName = "LocationName")]
        [JsonProperty("LocationName")]
        public string? LocationName { get; set; }

        [XmlElement(ElementName = "ImageLink")]
        [JsonProperty("ImageLink")]
        public string? ImageLink { get; set; }
    }

    public class ReviewCommentItem
    {

        [XmlElement(ElementName = "SerialNumber")]
        [JsonProperty("SerialNumber")]
        public int SerialNumber { get; set; } = new Random().Next(1, 50000);

        [XmlElement(ElementName = "Writer")]
        [JsonProperty("Writer")]
        public string? Writer { get; set; }

        [XmlElement(ElementName = "Comment")]
        [JsonProperty("Comment")]
        public string? Comment { get; set; }
        [XmlElement(ElementName = "CreatedDate")]
        [JsonProperty("CreatedDate")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}