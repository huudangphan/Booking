namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// 직원직무코드검색
/// </summary>
public class WorkerJobCodeSearch
{
	public const string SP_NAME = "직원직무코드검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// cnt
		/// </summary>
		[Column("cnt")]
		public int cnt { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 직무코드
		/// </summary>
		[Column("직무코드")]
		public string DutyCode { get; set; }
	}
}