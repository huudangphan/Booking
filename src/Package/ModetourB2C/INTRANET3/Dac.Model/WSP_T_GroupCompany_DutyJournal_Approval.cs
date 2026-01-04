namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_그룹사_업무일지_결재
/// </summary>
public class WSP_T_GroupCompany_DutyJournal_Approval
{
	public const string SP_NAME = "WSP_T_그룹사_업무일지_결재";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일지번호
		/// </summary>
		[Description("일지번호")]
		public string JournalNumber { get; set; }
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
	}

}