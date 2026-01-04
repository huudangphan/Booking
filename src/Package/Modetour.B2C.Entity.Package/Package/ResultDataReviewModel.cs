namespace Modetour.B2C.Entity.Package
{

    public class ResultDataReviewModel
    {
        public string ReviewId { get; set; }
        public string WriterName { get; set; }
        public string WriterNickName { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public string DepartureDate { get; set; }
        public string ProductTitle { get; set; }

        public int TotalPoint { get; set; }
        public int SchedulePoint { get; set; }
        public int HotelPoint { get; set; }
        public int AirPoint { get; set; }
        public int FoodPoint { get; set; }
        public Boolean IsDomastic { get; set; }
        public int? LikeCount { get; set; }
        public int? AsisMemberNo { get; set; }
        public string[] AsisAdditionalInfo { get; set; }
        public Boolean? IsDisplayReview { get; set; }
        public string[] Hashtag { get; set; }
        public List<Images> Images { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int AsisOrderNumber { get; set; }

        public int AsisGroupNumber { get; set; }

        public List<History> History { get; set; }

        public List<Comments> Comments { get; set; }
    }
    public class Images
    {
        public string ReviewPhotoId { get; set; }
        public int SortOrder { get; set; }
        public string ImageUrl { get; set; }
        public Decimal Latitude { get; set; }
        public Decimal Longitude { get; set; }
        public string PlaceName { get; set; }
    }
    public class History
    {
        public string ProductReviewHistoryId { get; set; }
        public string ReviewId { get; set; }
        public Boolean IsDisplayReview { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
    public class Comments
    {
        public string ReviewCommentId { get; set; }
        public Boolean IsReComment { get; set; }
        public string WriterNickName { get; set; }
        public string WriterName { get; set; }
        public int? AsisMemberNo { get; set; }
        public string Contents { get; set; }

        public int SortOrder { get; set; }
        public List<ReComments> ReComments { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
    public class ReComments
    {
        public string ReviewCommentId { get; set; }
        public Boolean IsReComment { get; set; }
        public string RefReviewCommentId { get; set; }
        public string RefWriterNickName { get; set; }
        public string WriterNickName { get; set; }
        public string WriterName { get; set; }

        public int? AsisMemberNo { get; set; }
        public string Contents { get; set; }
        public int SortOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}