namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_보훈_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_WarVeteran_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_보훈_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 보훈대상여부
		/// </summary>
		[Description("보훈대상여부")]
		public string WarVeteranCandidateOrNot { get; set; }
		/// <summary>
		/// 보훈번호
		/// </summary>
		[Description("보훈번호")]
		public string WarVeteranNumber { get; set; }
		/// <summary>
		/// 보훈사유코드번호
		/// </summary>
		[Description("보훈사유코드번호")]
		public int WarVeteranReasonCodeNumber { get; set; }
		/// <summary>
		/// 보훈사유코드명
		/// </summary>
		[Description("보훈사유코드명")]
		public string WarVeteranReasonCodeName { get; set; }
		/// <summary>
		/// 보훈대상자와의관계
		/// </summary>
		[Description("보훈대상자와의관계")]
		public string RelationshipWithWarVeteranCandidateperson { get; set; }
	}

}