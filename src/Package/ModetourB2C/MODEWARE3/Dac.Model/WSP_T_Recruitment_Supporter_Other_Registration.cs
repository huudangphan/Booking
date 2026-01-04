namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_기타_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_Other_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_기타_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 기타사항
		/// </summary>
		[Description("기타사항")]
		public string Others { get; set; }
		/// <summary>
		/// 기타사항내용
		/// </summary>
		[Description("기타사항내용")]
		public string OthersContent { get; set; }
		/// <summary>
		/// 기타사항상세내용
		/// </summary>
		[Description("기타사항상세내용")]
		public string OthersDetailContent { get; set; }
	}

}