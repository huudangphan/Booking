namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_T_휴가계_결재2
/// </summary>
public class GSP_T_VacationPlan_Approval2
{
	public const string SP_NAME = "GSP_T_휴가계_결재2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 휴가번호
		/// </summary>
		[Description("휴가번호")]
		public int VacationNumber { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 결재자
		/// </summary>
		[Description("결재자")]
		public int Approver { get; set; }
		/// <summary>
		/// 결재코드
		/// </summary>
		[Description("결재코드")]
		public string ApprovalCode { get; set; }
		/// <summary>
		/// 챗봇결재사용
		/// </summary>
		[Description("챗봇결재사용")]
		public string ChatbotApprovalUse { get; set; }
	}

}