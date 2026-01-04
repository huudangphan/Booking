namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_웹구역_단체리스트_다구역
/// </summary>
public class WSP_S_WebArea_GroupList_MultipleArea
{
	public const string SP_NAME = "WSP_S_웹구역_단체리스트_다구역";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구역번호
		/// </summary>
		[Description("구역번호")]
		public string AreaNumber { get; set; }
		/// <summary>
		/// 게시물수
		/// </summary>
		[Description("게시물수")]
		public int PostNumber { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public DateTime DepartureDate { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public int SORT { get; set; }
		/// <summary>
		/// 재고번호
		/// </summary>
		[Column("재고번호")]
		public int StockNumber { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Column("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 가격
		/// </summary>
		[Column("가격")]
		public int Price { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public int Image { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 이전가격
		/// </summary>
		[Column("이전가격")]
		public int PreviousPrice { get; set; }
		/// <summary>
		/// 구역번호
		/// </summary>
		[Column("구역번호")]
		public int AreaNumber { get; set; }
		/// <summary>
		/// 웹페이지
		/// </summary>
		[Column("웹페이지")]
		public string WebPage { get; set; }
		/// <summary>
		/// 항공사명
		/// </summary>
		[Column("항공사명")]
		public string AirlineName { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public DateTime ArrivalDate { get; set; }
		/// <summary>
		/// 출발시간
		/// </summary>
		[Column("출발시간")]
		public string DepartureTime { get; set; }
		/// <summary>
		/// 도착시간
		/// </summary>
		[Column("도착시간")]
		public string ArrivalTime { get; set; }
		/// <summary>
		/// TAX
		/// </summary>
		[Column("TAX")]
		public long TAX { get; set; }
		/// <summary>
		/// 제세공과금
		/// </summary>
		[Column("제세공과금")]
		public int PublicFacilitiesTax { get; set; }
		/// <summary>
		/// 잔여좌석수
		/// </summary>
		[Column("잔여좌석수")]
		public int AvailableSeatNumber { get; set; }
		/// <summary>
		/// 기간
		/// </summary>
		[Column("기간")]
		public byte Period { get; set; }
		/// <summary>
		/// 보유좌석수
		/// </summary>
		[Column("보유좌석수")]
		public int HoldingSeatNumber { get; set; }
		/// <summary>
		/// 예약좌석수
		/// </summary>
		[Column("예약좌석수")]
		public int BookingSeatNumber { get; set; }
		/// <summary>
		/// 웹판매가능좌석
		/// </summary>
		[Column("웹판매가능좌석")]
		public int WebSalesPossibleSeat { get; set; }
		/// <summary>
		/// 웹판매좌석
		/// </summary>
		[Column("웹판매좌석")]
		public int WebSalesSeat { get; set; }
		/// <summary>
		/// 잔여좌석수2
		/// </summary>
		[Column("잔여좌석수2")]
		public int AvailableSeatNumber2 { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public long Order { get; set; }
	}
}