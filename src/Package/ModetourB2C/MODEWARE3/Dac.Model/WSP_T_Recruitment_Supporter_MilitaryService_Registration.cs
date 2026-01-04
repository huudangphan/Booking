namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_병역_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_MilitaryService_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_병역_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 병역구분코드번호
		/// </summary>
		[Description("병역구분코드번호")]
		public int MilitaryServiceClassificationCodeNumber { get; set; }
		/// <summary>
		/// 병역구분코드명
		/// </summary>
		[Description("병역구분코드명")]
		public string MilitaryServiceClassificationCodeName { get; set; }
		/// <summary>
		/// 군별코드번호
		/// </summary>
		[Description("군별코드번호")]
		public int MilitaryGroupCodeNumber { get; set; }
		/// <summary>
		/// 군별코드명
		/// </summary>
		[Description("군별코드명")]
		public string MilitaryGroupCodeName { get; set; }
		/// <summary>
		/// 입대일
		/// </summary>
		[Description("입대일")]
		public DateTime JoinMilitaryDate { get; set; }
		/// <summary>
		/// 제대일
		/// </summary>
		[Description("제대일")]
		public DateTime ArmyDischargeDate { get; set; }
		/// <summary>
		/// 계급코드번호
		/// </summary>
		[Description("계급코드번호")]
		public int RankingCodeNumber { get; set; }
		/// <summary>
		/// 계급코드명
		/// </summary>
		[Description("계급코드명")]
		public string RankingCodeName { get; set; }
		/// <summary>
		/// 병과코드번호
		/// </summary>
		[Description("병과코드번호")]
		public int MilitaryBranchCodeNumber { get; set; }
		/// <summary>
		/// 병과코드명
		/// </summary>
		[Description("병과코드명")]
		public string MilitaryBranchCodeName { get; set; }
		/// <summary>
		/// 전역사유코드번호
		/// </summary>
		[Description("전역사유코드번호")]
		public int MilitaryDischargeReasonCodeNumber { get; set; }
		/// <summary>
		/// 전역사유코드명
		/// </summary>
		[Description("전역사유코드명")]
		public string MilitaryDischargeReasonCodeName { get; set; }
	}

}