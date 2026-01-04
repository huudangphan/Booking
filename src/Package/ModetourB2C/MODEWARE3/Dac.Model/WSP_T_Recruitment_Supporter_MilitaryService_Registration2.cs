namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_병역_등록2
/// </summary>
public class WSP_T_Recruitment_Supporter_MilitaryService_Registration2
{
	public const string SP_NAME = "WSP_T_채용_지원자_병역_등록2";

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
		/// 미필사유코드번호
		/// </summary>
		[Description("미필사유코드번호")]
		public string UnfinishedReasonCodeNumber { get; set; }
		/// <summary>
		/// 미필사유코드명
		/// </summary>
		[Description("미필사유코드명")]
		public string UnfinishedReasonCodeName { get; set; }
	}

}