namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_T_휴가계_삭제
/// </summary>
public class GSP_T_VacationPlan_Delete
{
	public const string SP_NAME = "GSP_T_휴가계_삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 휴가번호
		/// </summary>
		[Description("휴가번호")]
		public string VacationNumber { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
	}

}