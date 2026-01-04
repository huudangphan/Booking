namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_찜단체리스트
/// </summary>
public class WSP_S_FavoriteGroupList
{
	public const string SP_NAME = "WSP_S_찜단체리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 찜일련번호
		/// </summary>
		[Column("찜일련번호")]
		public int FavoriteSerialNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 단체상품명
		/// </summary>
		[Column("단체상품명")]
		public string GroupProductName { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 항공사명
		/// </summary>
		[Column("항공사명")]
		public string AirlineName { get; set; }
		/// <summary>
		/// 단체이미지
		/// </summary>
		[Column("단체이미지")]
		public string GroupImage { get; set; }
		/// <summary>
		/// 판매가_어른
		/// </summary>
		[Column("판매가_어른")]
		public long SellingPrice_Adult { get; set; }
		/// <summary>
		/// 제세공과금_어른
		/// </summary>
		[Column("제세공과금_어른")]
		public long PublicFacilitiesTax_Adult { get; set; }
		/// <summary>
		/// 추가요금_TAX
		/// </summary>
		[Column("추가요금_TAX")]
		public long AddFare_TAX { get; set; }
		/// <summary>
		/// 판매마감
		/// </summary>
		[Column("판매마감")]
		public string SalesEnd { get; set; }
		/// <summary>
		/// 출발확정
		/// </summary>
		[Column("출발확정")]
		public string DepartureConfirm { get; set; }
		/// <summary>
		/// 가격확정
		/// </summary>
		[Column("가격확정")]
		public string PriceConfirm { get; set; }
		/// <summary>
		/// 일정확정
		/// </summary>
		[Column("일정확정")]
		public string ScheduleConfirm { get; set; }
		/// <summary>
		/// 호텔확정
		/// </summary>
		[Column("호텔확정")]
		public string HotelConfirm { get; set; }
		/// <summary>
		/// 항공확정
		/// </summary>
		[Column("항공확정")]
		public string FlightConfirm { get; set; }
		/// <summary>
		/// 가격
		/// </summary>
		[Column("가격")]
		public long Price { get; set; }
		/// <summary>
		/// 인솔자확정
		/// </summary>
		[Column("인솔자확정")]
		public string LeaderConfirm { get; set; }
		/// <summary>
		/// 인솔자동행
		/// </summary>
		[Column("인솔자동행")]
		public string LeaderAccompany { get; set; }
		/// <summary>
		/// 비자
		/// </summary>
		[Column("비자")]
		public string Visa { get; set; }
		/// <summary>
		/// 상품등급
		/// </summary>
		[Column("상품등급")]
		public string ProductClass { get; set; }
		/// <summary>
		/// 상품등급명
		/// </summary>
		[Column("상품등급명")]
		public string ProductClassName { get; set; }
		/// <summary>
		/// 예약좌석수
		/// </summary>
		[Column("예약좌석수")]
		public string BookingSeatNumber { get; set; }
		/// <summary>
		/// 잔여좌석
		/// </summary>
		[Column("잔여좌석")]
		public string AvailableSeat { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 출발시간
		/// </summary>
		[Column("출발시간")]
		public string DepartureTime { get; set; }
		/// <summary>
		/// 출발요일
		/// </summary>
		[Column("출발요일")]
		public string DepartureDay { get; set; }
		/// <summary>
		/// 출발항공편
		/// </summary>
		[Column("출발항공편")]
		public string DepartureFlight { get; set; }
		/// <summary>
		/// 현지도착시간
		/// </summary>
		[Column("현지도착시간")]
		public string LocalArrivalTime { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public string ArrivalDate { get; set; }
		/// <summary>
		/// 현지출발시간
		/// </summary>
		[Column("현지출발시간")]
		public string LocalDepartureTime { get; set; }
		/// <summary>
		/// 도착시간
		/// </summary>
		[Column("도착시간")]
		public string ArrivalTime { get; set; }
		/// <summary>
		/// 도착요일
		/// </summary>
		[Column("도착요일")]
		public string ArrivalDay { get; set; }
		/// <summary>
		/// 도착항공편
		/// </summary>
		[Column("도착항공편")]
		public string ArrivalFlight { get; set; }
		/// <summary>
		/// 대표국가
		/// </summary>
		[Column("대표국가")]
		public string RepresentativeCountry { get; set; }
		/// <summary>
		/// 대표도시
		/// </summary>
		[Column("대표도시")]
		public string RepresentativeCity { get; set; }
		/// <summary>
		/// 대표호텔등급
		/// </summary>
		[Column("대표호텔등급")]
		public string RepresentativeHotelClass { get; set; }
		/// <summary>
		/// 쇼핑횟수
		/// </summary>
		[Column("쇼핑횟수")]
		public int ShoppingTimes { get; set; }
		/// <summary>
		/// 현지필수경비여부
		/// </summary>
		[Column("현지필수경비여부")]
		public string LocalRequiredExpenseOrNot { get; set; }
		/// <summary>
		/// 현지필수경비
		/// </summary>
		[Column("현지필수경비")]
		public int LocalRequiredExpense { get; set; }
		/// <summary>
		/// 현지필수경비_통화
		/// </summary>
		[Column("현지필수경비_통화")]
		public string LocalRequiredExpense_Call { get; set; }
		/// <summary>
		/// 가이드확정
		/// </summary>
		[Column("가이드확정")]
		public string GuideConfirmed { get; set; }
	}
}