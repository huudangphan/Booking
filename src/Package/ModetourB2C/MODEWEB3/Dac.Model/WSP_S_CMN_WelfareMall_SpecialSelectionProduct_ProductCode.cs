namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_복지몰_특선상품_상품코드
/// </summary>
public class WSP_S_CMN_WelfareMall_SpecialSelectionProduct_ProductCode
{
	public const string SP_NAME = "WSP_S_CMN_복지몰_특선상품_상품코드";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GUBUN
		/// </summary>
		[Description("GUBUN")]
		public string GUBUN { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// SITENO
		/// </summary>
		[Description("SITENO")]
		public int SITENO { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 출발일조건
		/// </summary>
		[Description("출발일조건")]
		public string DepartureDateCondition { get; set; }
		/// <summary>
		/// 가격조건
		/// </summary>
		[Description("가격조건")]
		public string PriceCondition { get; set; }
		/// <summary>
		/// 박일
		/// </summary>
		[Description("박일")]
		public string NightDate { get; set; }
		/// <summary>
		/// 항공코드목록
		/// </summary>
		[Description("항공코드목록")]
		public string FlightCodeList { get; set; }
		/// <summary>
		/// 요일목록
		/// </summary>
		[Description("요일목록")]
		public string DayList { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Description("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 출발일1
		/// </summary>
		[Description("출발일1")]
		public string DepartureDate1 { get; set; }
		/// <summary>
		/// 출발일2
		/// </summary>
		[Description("출발일2")]
		public string DepartureDate2 { get; set; }
	}

}