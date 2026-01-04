namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// GSP_T_휴가계_삭제_MOBILE
/// </summary>
public class GSP_T_VacationPlan_Delete_MOBILE
{
	public const string SP_NAME = "GSP_T_휴가계_삭제_MOBILE";

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