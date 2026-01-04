namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// GSP_S_휴가계_부서_리스트_MOBILE
/// </summary>
public class GSP_S_VacationPlan_Department_List_MOBILE
{
	public const string SP_NAME = "GSP_S_휴가계_부서_리스트_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 부서번호
		/// </summary>
		[Column("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
	}
}