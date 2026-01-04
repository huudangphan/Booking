namespace Modetour.B2C.Entity.Package
{
    /// <summary>
	/// 장소키워드
	/// </summary>
	public class PlaceKeywordModel
    {
        /// <summary>
        /// 일정_세부번호
        /// </summary>
        public int ItiDetailNo { get; set; }
        /// <summary>
        /// 장소번호
        /// </summary>
        public int PlaceNo { get; set; }
        /// <summary>
        /// 키워드분류코드
        /// </summary>
        public string KeyordCategory { get; set; }
        /// <summary>
        /// 키워드
        /// </summary>
        public string Keyword { get; set; }
    }
}
