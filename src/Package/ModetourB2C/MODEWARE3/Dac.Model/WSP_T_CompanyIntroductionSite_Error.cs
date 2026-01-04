namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_회사소개사이트_오류
/// </summary>
public class WSP_T_CompanyIntroductionSite_Error
{
	public const string SP_NAME = "WSP_T_회사소개사이트_오류";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 공고일련번호
		/// </summary>
		[Description("공고일련번호")]
		public int AnnounceSerialNumber { get; set; }
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 사용자브라우저
		/// </summary>
		[Description("사용자브라우저")]
		public string UserBrowser { get; set; }
		/// <summary>
		/// 오류내용
		/// </summary>
		[Description("오류내용")]
		public string ErrorContent { get; set; }
		/// <summary>
		/// 기타
		/// </summary>
		[Description("기타")]
		public string Other { get; set; }
	}

}