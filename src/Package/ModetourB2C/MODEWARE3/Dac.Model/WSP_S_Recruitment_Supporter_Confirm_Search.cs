namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_채용_지원자_확인_검색
/// </summary>
public class WSP_S_Recruitment_Supporter_Confirm_Search
{
	public const string SP_NAME = "WSP_S_채용_지원자_확인_검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 채용공고ID
		/// </summary>
		[Description("채용공고ID")]
		public decimal RecruitmentAnnounce_ID { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Description("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 핸드폰번호
		/// </summary>
		[Description("핸드폰번호")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 결과
		/// </summary>
		[Column("결과")]
		public string RESULT { get; set; }
	}
}