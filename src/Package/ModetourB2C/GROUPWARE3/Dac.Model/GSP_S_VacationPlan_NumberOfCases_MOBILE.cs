namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// GSP_S_휴가계_건수_MOBILE
/// </summary>
public class GSP_S_VacationPlan_NumberOfCases_MOBILE
{
	public const string SP_NAME = "GSP_S_휴가계_건수_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// CNT
		/// </summary>
		[Column("CNT")]
		public int CNT { get; set; }
	}
}