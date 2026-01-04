namespace Modetour.B2C.Entity.Package
{
    public class ReviewsReponseModel
    {
        public int total { get; set; }
        public List<DataReviewsReponseModel> data { get; set; }
    }
    public class DataReviewsReponseModel
    {
        //public string id { get; set; }
        public string index { get; set; }
        public string subject { get; set; }
        //public string email { get; set; }
        public string writer { get; set; }
        public string startDate { get; set; }
        public string contents { get; set; }
        public int expect { get; set; }
        public string ptid { get; set; }
        public string proGubun { get; set; }
        public int totalLike { get; set; }
        public int totalComment { get; set; }
        public string[] hashtag { get; set; }

        public string countryName { get; set; }

        public string cityName { get; set; }

        public string delDate { get; set; }

        public string delBy { get; set; }

        public Boolean hideBy { get; set; }
        public int OrderNumber { get; set; }

        public int GroupNumber { get; set; }

        public List<ImagesModel> Images { get; set; }

        public List<CommentsDataModel> comments { get; set; }

        public int SchedulePoint { get; set; }
        public int HotelPoint { get; set; }
        public int AirPoint { get; set; }
        public int FoodPoint { get; set; }
        public string writerAvatar { get; set; }
        
        public string[] AsisAdditionalInfo { get; set; }
    }

    public class CommentsDataModel
    {
        public string ReviewCommentId { get; set; }
        public bool IsReComment { get; set; }
        public string WriterNickName { get; set; }
        public string WriterName { get; set; }
        public int? AsisMemberNo { get; set; }
        public string Contents { get; set; }

        public int SortOrder { get; set; }
        public List<ReCommentsModel> ReComments { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
    public class ReCommentsModel
    {
        public string ReviewCommentId { get; set; }
        public bool IsReComment { get; set; }
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
    public class ImagesModel
    {
        public string ReviewPhotoId { get; set; }
        public int SortOrder { get; set; }
        public string ImageUrl { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string PlaceName { get; set; }

    }
}
