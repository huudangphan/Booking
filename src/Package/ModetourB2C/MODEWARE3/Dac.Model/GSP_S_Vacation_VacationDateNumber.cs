namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_휴가_휴가일수
/// </summary>
public class GSP_S_Vacation_VacationDateNumber
{
	public const string SP_NAME = "GSP_S_휴가_휴가일수";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 시작일
		/// </summary>
		[Description("시작일")]
		public string StartDate { get; set; }
		/// <summary>
		/// 마침일
		/// </summary>
		[Description("마침일")]
		public string FinishDate { get; set; }
		/// <summary>
		/// 휴일포함여부
		/// </summary>
		[Description("휴일포함여부")]
		public string HolidayIncludedOrNot { get; set; }
		/// <summary>
		/// 휴가일수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("휴가일수")]
		public int VacationDaysNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 날짜
		/// </summary>
		[Column("날짜")]
		public string Date { get; set; }
		/// <summary>
		/// 요일
		/// </summary>
		[Column("요일")]
		public string Day { get; set; }
	}
}