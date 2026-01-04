namespace Modetour.B2C.Entity.Package
{
    public class ExtG_ReviewsModel
    {
        /// <summary>
        /// 작성자
        /// Writer
        /// </summary>
        public string author_name { get; set; }
        /// <summary>
        /// 작성자 구글홈 주소
        /// Author Google Home Address
        /// </summary>
        public string author_url { get; set; }
        /// <summary>
        /// 작성언어
        /// written language
        /// </summary>
        public string language { get; set; }
        /// <summary>
        /// 작성자 프로필 이미지 주소
        ///  Author profile image address
        /// </summary>
        public string profile_photo_url { get; set; }
        /// <summary>
        /// 평점
        /// grade
        /// </summary>
        public string rating { get; set; }
        /// <summary>
        /// 리뷰내용
        /// Review contents
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// 작성일자
        /// Date of issue
        /// </summary>
        public string time { get; set; }

    }
}
