namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_채용지원현황_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_RecruitmentSupportCurrentState_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_채용지원현황_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 코드번호
		/// </summary>
		[Description("코드번호")]
		public int CodeNumber { get; set; }
		/// <summary>
		/// 횟수
		/// </summary>
		[Description("횟수")]
		public int Times { get; set; }
	}

}