namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// WSP_S_CMN_휴일리스트_MOBILE
/// </summary>
public class WSP_S_CMN_HolidayList_MOBILE
{
	public const string SP_NAME = "WSP_S_CMN_휴일리스트_MOBILE";

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
	}
}