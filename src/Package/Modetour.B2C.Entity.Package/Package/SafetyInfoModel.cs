namespace Modetour.B2C.Entity.Package
{
    /// <summary>
	/// 안전정보
	/// </summary>
	public class SafetyInfoModel
    {
        /// <summary>
        /// 국가명
        /// </summary>
        public string CountryName { get; set; }
        /// <summary>
        /// 남색경보
        /// </summary>
        public string Blue { get; set; }
        /// <summary>
        /// 남색경보내용
        /// </summary>
        public string BlueContents { get; set; }
        /// <summary>
        /// 황색경보
        /// </summary>
        public string Yellow { get; set; }
        /// <summary>
        /// 황색경보내용
        /// </summary>
        public string YellowContents { get; set; }
        /// <summary>
        /// 적색경보
        /// </summary>
        public string Red { get; set; }
        /// <summary>
        /// 적색경보내용
        /// </summary>
        public string RedContents { get; set; }
        /// <summary>
        /// 긴급연락처
        /// </summary>
        public string EmergencyContact { get; set; }
        /// <summary>
        /// 사건사고
        /// </summary>
        public string Accident { get; set; }
    }
}
