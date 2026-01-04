namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// GSP_S_휴가_휴가날짜_MOBILE
/// </summary>
public class GSP_S_Vacation_VacationDate_MOBILE
{
	public const string SP_NAME = "GSP_S_휴가_휴가날짜_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 시작일
		/// </summary>
		[Description("시작일")]
		public string StartDate { get; set; }
		/// <summary>
		/// 휴가일수
		/// </summary>
		[Description("휴가일수")]
		public int VacationDaysNumber { get; set; }
		/// <summary>
		/// 휴가날짜
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 10)]
		[Description("휴가날짜")]
		public string VacationDate { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 날짜
		/// </summary>
		[Column("날짜")]
		public string Date { get; set; }
	}
}