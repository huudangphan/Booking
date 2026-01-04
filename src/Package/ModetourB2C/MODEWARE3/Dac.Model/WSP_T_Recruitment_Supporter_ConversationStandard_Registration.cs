namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_회화수준_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_ConversationStandard_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_회화수준_등록";

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
		/// 회화수준코드번호
		/// </summary>
		[Description("회화수준코드번호")]
		public int ConversationStandardCodeNumber { get; set; }
		/// <summary>
		/// 회화수준코드명
		/// </summary>
		[Description("회화수준코드명")]
		public string ConversationStandardCodeName { get; set; }
		/// <summary>
		/// 특이사항
		/// </summary>
		[Description("특이사항")]
		public string Specific { get; set; }
	}

}