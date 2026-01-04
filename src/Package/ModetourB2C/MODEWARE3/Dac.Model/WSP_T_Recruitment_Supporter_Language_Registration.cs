namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_어학_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_Language_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_어학_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 어학구분코드번호
		/// </summary>
		[Description("어학구분코드번호")]
		public int LanguageClassificationCodeNumber { get; set; }
		/// <summary>
		/// 어학구분코드명
		/// </summary>
		[Description("어학구분코드명")]
		public string LanguageClassificationCodeName { get; set; }
		/// <summary>
		/// 어학시험코드번호
		/// </summary>
		[Description("어학시험코드번호")]
		public int LanguageTestCodeNumber { get; set; }
		/// <summary>
		/// 어학시험코드명
		/// </summary>
		[Description("어학시험코드명")]
		public string LanguageTestCodeName { get; set; }
		/// <summary>
		/// 점수
		/// </summary>
		[Description("점수")]
		public int Score { get; set; }
		/// <summary>
		/// 어학등급코드번호
		/// </summary>
		[Description("어학등급코드번호")]
		public int LanguageClassCodeNumber { get; set; }
		/// <summary>
		/// 어학등급코드명
		/// </summary>
		[Description("어학등급코드명")]
		public string LanguageClassCodeName { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Description("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 시험일자
		/// </summary>
		[Description("시험일자")]
		public DateTime TestDate { get; set; }
	}

}