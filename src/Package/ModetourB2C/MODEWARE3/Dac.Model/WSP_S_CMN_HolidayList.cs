namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_휴일리스트
/// </summary>
public class WSP_S_CMN_HolidayList
{
	public const string SP_NAME = "WSP_S_CMN_휴일리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 기간1
		/// </summary>
		[Description("기간1")]
		public string Period1 { get; set; }
		/// <summary>
		/// 기간2
		/// </summary>
		[Description("기간2")]
		public string Period2 { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 년월일
		/// </summary>
		[Column("년월일")]
		public string YearMonthDate { get; set; }
		/// <summary>
		/// 법정공휴일
		/// </summary>
		[Column("법정공휴일")]
		public string LegalNationalHoliday { get; set; }
		/// <summary>
		/// 법정휴일
		/// </summary>
		[Column("법정휴일")]
		public string LegalHoliday { get; set; }
	}
}