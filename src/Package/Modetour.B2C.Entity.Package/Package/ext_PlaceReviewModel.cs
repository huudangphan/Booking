namespace Modetour.B2C.Entity.Package
{
    public class Ext_PlaceReviewModel
    {
        public string header { get; set; }
        public Ext_PlaceReviewResponseModel response { get; set; }
    }

    public class Ext_PlaceReviewResponseModel
    {
        /// <summary>
        /// 대표아이콘
        /// </summary>
        public string iconUrl { get; set; }
        /// <summary>
        /// 호텔등급
        /// </summary>
        public string reviewRating { get; set; }
        /// <summary>
        /// 총 리뷰수
        /// </summary>
        public string reviewTotal { get; set; }
        /// <summary>
        /// 리뷰 더보기 url
        /// </summary>
        public string reviewMore { get; set; }
        /// <summary>
        /// 호텔 순위
        /// </summary>
        public string hotelRanking { get; set; }
        /// <summary>
        /// 리뷰 쓰기 url
        /// </summary>
        public string reviewWriteUrl { get; set; }
        /// <summary>
        /// 선호유형별 카운트
        /// </summary>
        public Ext_PlaceReviewPreferenceTypesModel preferenceTypes { get; set; }
        /// <summary>
        /// 리뷰컨텐츠
        /// </summary>
        public Ext_PlaceReviewContentsModel reviews { get; set; }

    }

    public class Ext_PlaceReviewPreferenceTypesModel
    {
        /// <summary>
        /// arr 선호유형별 카운트
        /// </summary>
        public List<Ext_PlaceReviewPreferenceTypeModel> preferenceType { get; set; }
    }

    public class Ext_PlaceReviewPreferenceTypeModel
    {
        /// <summary>
        /// 선호유형
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 카운트
        /// </summary>
        public string count { get; set; }
    }

    public class Ext_PlaceReviewContentsModel
    {
        /// <summary>
        ///  arr 리뷰내용
        /// </summary>
        public List<Ext_PlaceReviewContentModel> review { get; set; }
    }

    public class Ext_PlaceReviewContentModel
    {
        /// <summary>
        /// 리뷰ID
        /// </summary>
        public string reviewId { get; set; }
        /// <summary>
        /// 평점
        /// </summary>
        public string reviewCount { get; set; }
        /// <summary>
        /// 작성일
        /// </summary>
        public string writeDate { get; set; }
        /// <summary>
        /// 평점url
        /// </summary>
        public string ratingImageUrl { get; set; }
        /// <summary>
        /// 내용 더보기 url
        /// </summary>
        public string moreViewUrl { get; set; }
        /// <summary>
        /// 리뷰자 국가/도시
        /// </summary>
        public string userLocation { get; set; }
        /// <summary>
        /// 리뷰자
        /// </summary>
        public string userName { get; set; }
        /// <summary>
        /// 제목
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 내용
        /// </summary>
        public string content { get; set; }

    }
}
