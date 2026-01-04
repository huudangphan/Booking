namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_BP테마이벤트
/// </summary>
public class WSP_S_BPThemeEvent
{
	public const string SP_NAME = "WSP_S_BP테마이벤트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// SITENO
		/// </summary>
		[Description("SITENO")]
		public int SITENO { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
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

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// 상품타이틀
		/// </summary>
		[Column("상품타이틀")]
		public string ProductTitle { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Column("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 최소가격
		/// </summary>
		[Column("최소가격")]
		public long MinimumPrice { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 가격
		/// </summary>
		[Column("가격")]
		public long Price { get; set; }
	}
}