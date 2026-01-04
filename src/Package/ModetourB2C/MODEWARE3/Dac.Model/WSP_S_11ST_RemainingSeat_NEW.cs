namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_11ST_잔여좌석_NEW
/// </summary>
public class WSP_S_11ST_RemainingSeat_NEW
{
	public const string SP_NAME = "WSP_S_11ST_잔여좌석_NEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Description("도착일")]
		public DateTime ArrivalDate { get; set; }
		/// <summary>
		/// 박수
		/// </summary>
		[Description("박수")]
		public int NightNumber { get; set; }
		/// <summary>
		/// 일수
		/// </summary>
		[Description("일수")]
		public int DaysNumber { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Description("항공코드")]
		public string FlightCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 최소출발인원
		/// </summary>
		[Column("최소출발인원")]
		public int MinimumDepartureNumberOfPeople { get; set; }
		/// <summary>
		/// 예약가능일
		/// </summary>
		[Column("예약가능일")]
		public string BookingPossibleDate { get; set; }
		/// <summary>
		/// 출발확정
		/// </summary>
		[Column("출발확정")]
		public string DepartureConfirm { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 판매가_어른2
		/// </summary>
		[Column("판매가_어른2")]
		public long SellingPrice_Adult2 { get; set; }
		/// <summary>
		/// 판매가_소아N2
		/// </summary>
		[Column("판매가_소아N2")]
		public long SellingPrice_Kid_N2 { get; set; }
		/// <summary>
		/// 판매가_소아E2
		/// </summary>
		[Column("판매가_소아E2")]
		public long SellingPrice_Kid_E2 { get; set; }
		/// <summary>
		/// 판매가_유아2
		/// </summary>
		[Column("판매가_유아2")]
		public long SellingPrice_Toddler2 { get; set; }
		/// <summary>
		/// 유류할증료_어른2
		/// </summary>
		[Column("유류할증료_어른2")]
		public long FuelSurchargeFee_Adult2 { get; set; }
		/// <summary>
		/// 유류할증료_소아N2
		/// </summary>
		[Column("유류할증료_소아N2")]
		public long FuelSurchargeFee_Kid_N2 { get; set; }
		/// <summary>
		/// 유류할증료_유아2
		/// </summary>
		[Column("유류할증료_유아2")]
		public long FuelSurchargeFee_Toddler2 { get; set; }
		/// <summary>
		/// 제세공과금_어른2
		/// </summary>
		[Column("제세공과금_어른2")]
		public long PublicFacilitiesTax_Adult2 { get; set; }
		/// <summary>
		/// 제세공과금_소아N2
		/// </summary>
		[Column("제세공과금_소아N2")]
		public long PublicFacilitiesTax_Kid_N2 { get; set; }
		/// <summary>
		/// 제세공과금_유아2
		/// </summary>
		[Column("제세공과금_유아2")]
		public long PublicFacilitiesTax_Toddler2 { get; set; }
		/// <summary>
		/// 판매마감
		/// </summary>
		[Column("판매마감")]
		public string SalesEnd { get; set; }
		/// <summary>
		/// NameTL
		/// </summary>
		[Column("NameTL")]
		public string NameTL { get; set; }
		/// <summary>
		/// 재고보유좌석수
		/// </summary>
		[Column("재고보유좌석수")]
		public int StockHoldingSeatNumber { get; set; }
		/// <summary>
		/// 잔여좌석수
		/// </summary>
		[Column("잔여좌석수")]
		public string AvailableSeatNumber { get; set; }
		/// <summary>
		/// 인센티브여부
		/// </summary>
		[Column("인센티브여부")]
		public string IncentiveOrNot { get; set; }
	}
}