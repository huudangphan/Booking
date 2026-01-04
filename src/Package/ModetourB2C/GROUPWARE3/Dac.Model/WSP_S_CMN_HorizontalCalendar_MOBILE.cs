namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// WSP_S_CMN_가로달력_MOBILE
/// </summary>
public class WSP_S_CMN_HorizontalCalendar_MOBILE
{
	public const string SP_NAME = "WSP_S_CMN_가로달력_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
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
		/// 요일
		/// </summary>
		[Column("요일")]
		public string Day { get; set; }
		/// <summary>
		/// 법정휴일
		/// </summary>
		[Column("법정휴일")]
		public string LegalHoliday { get; set; }
		/// <summary>
		/// 법정공휴일
		/// </summary>
		[Column("법정공휴일")]
		public string LegalNationalHoliday { get; set; }
		/// <summary>
		/// 약정휴일
		/// </summary>
		[Column("약정휴일")]
		public string ContractHoliday { get; set; }
		/// <summary>
		/// 갯수
		/// </summary>
		[Column("갯수")]
		public int Number { get; set; }
	}
}