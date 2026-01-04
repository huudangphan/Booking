namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_SO_거래처_예약
/// </summary>
public class WSP_SO_Customer_Reservation
{
	public const string SP_NAME = "WSP_SO_거래처_예약";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 년월
		/// </summary>
		[Description("년월")]
		public string YearMonth { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 구분2
		/// </summary>
		[Description("구분2")]
		public string Classification2 { get; set; }
	}

}