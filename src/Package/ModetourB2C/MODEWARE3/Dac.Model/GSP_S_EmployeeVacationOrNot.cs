namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_사원휴가여부
/// </summary>
public class GSP_S_EmployeeVacationOrNot
{
	public const string SP_NAME = "GSP_S_사원휴가여부";

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
		/// 사원번호
		/// </summary>
		[Column("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 날짜
		/// </summary>
		[Column("날짜")]
		public string Date { get; set; }
	}
}