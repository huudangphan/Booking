namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_공동구매항공권_편도
/// </summary>
public class USP_S_GroupReservationFlightTicket_OneWay
{
	public const string SP_NAME = "USP_S_공동구매항공권_편도";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 출발도시
		/// </summary>
		[Description("출발도시")]
		public string DepartureCity { get; set; }
		/// <summary>
		/// 대륙코드
		/// </summary>
		[Description("대륙코드")]
		public string ContinentCode { get; set; }
		/// <summary>
		/// 도착도시
		/// </summary>
		[Description("도착도시")]
		public string ArrivalCity { get; set; }
		/// <summary>
		/// 출발일1
		/// </summary>
		[Description("출발일1")]
		public DateTime DepartureDate1 { get; set; }
		/// <summary>
		/// 출발일2
		/// </summary>
		[Description("출발일2")]
		public DateTime DepartureDate2 { get; set; }
		/// <summary>
		/// 현재페이지
		/// </summary>
		[Description("현재페이지")]
		public int CurrentPage { get; set; }
		/// <summary>
		/// 페이지당글개수
		/// </summary>
		[Description("페이지당글개수")]
		public int EachPageCharactersNumber { get; set; }
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
		/// <summary>
		/// 전체페이지수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체페이지수")]
		public int EntirePageNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 재고번호
		/// </summary>
		[Column("재고번호")]
		public int StockNumber { get; set; }
		/// <summary>
		/// 대륙코드
		/// </summary>
		[Column("대륙코드")]
		public string ContinentCode { get; set; }
		/// <summary>
		/// 대륙명
		/// </summary>
		[Column("대륙명")]
		public string ContinentName { get; set; }
		/// <summary>
		/// 대륙명_한글
		/// </summary>
		[Column("대륙명_한글")]
		public string ContinentName_Korean { get; set; }
		/// <summary>
		/// 항공
		/// </summary>
		[Column("항공")]
		public string Flight { get; set; }
		/// <summary>
		/// 항공사
		/// </summary>
		[Column("항공사")]
		public string Airline { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 귀국일
		/// </summary>
		[Column("귀국일")]
		public DateTime ReturnToHomelandDate { get; set; }
		/// <summary>
		/// 출발지코드
		/// </summary>
		[Column("출발지코드")]
		public string DeparturesCode { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// 도착지코드
		/// </summary>
		[Column("도착지코드")]
		public string ArrivalsCode { get; set; }
		/// <summary>
		/// 도착지
		/// </summary>
		[Column("도착지")]
		public string Arrivals { get; set; }
		/// <summary>
		/// 기간
		/// </summary>
		[Column("기간")]
		public byte Period { get; set; }
		/// <summary>
		/// 정상요금
		/// </summary>
		[Column("정상요금")]
		public int NormalFare { get; set; }
		/// <summary>
		/// 성인요금
		/// </summary>
		[Column("성인요금")]
		public int AdultFare { get; set; }
		/// <summary>
		/// 소아요금
		/// </summary>
		[Column("소아요금")]
		public int KidFare { get; set; }
		/// <summary>
		/// 유아요금
		/// </summary>
		[Column("유아요금")]
		public int ToddlerFare { get; set; }
		/// <summary>
		/// TAX
		/// </summary>
		[Column("TAX")]
		public long TAX { get; set; }
		/// <summary>
		/// TAX소아
		/// </summary>
		[Column("TAX소아")]
		public long TAX_Kid { get; set; }
		/// <summary>
		/// TAX유아
		/// </summary>
		[Column("TAX유아")]
		public long TAX_Toddler { get; set; }
		/// <summary>
		/// 제세공과금
		/// </summary>
		[Column("제세공과금")]
		public int PublicFacilitiesTax { get; set; }
		/// <summary>
		/// 소아제세공과금
		/// </summary>
		[Column("소아제세공과금")]
		public int KidPublicFacilitiesTax { get; set; }
		/// <summary>
		/// 유아제세공과금
		/// </summary>
		[Column("유아제세공과금")]
		public int ToddlerPublicFacilitiesTax { get; set; }
		/// <summary>
		/// 잔여좌석
		/// </summary>
		[Column("잔여좌석")]
		public int AvailableSeat { get; set; }
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
		/// 최소출발인원
		/// </summary>
		[Column("최소출발인원")]
		public int MinimumDepartureNumberOfPeople { get; set; }
		/// <summary>
		/// 출발편명
		/// </summary>
		[Column("출발편명")]
		public string DepartureFlightName { get; set; }
		/// <summary>
		/// 출발시간
		/// </summary>
		[Column("출발시간")]
		public string DepartureTime { get; set; }
		/// <summary>
		/// 현지도착시간
		/// </summary>
		[Column("현지도착시간")]
		public string LocalArrivalTime { get; set; }
		/// <summary>
		/// 귀국편명
		/// </summary>
		[Column("귀국편명")]
		public string ReturnToHomelandFlightName { get; set; }
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
		/// E티켓여부
		/// </summary>
		[Column("E티켓여부")]
		public string E_TicketOrNot { get; set; }
		/// <summary>
		/// 웹판매TL
		/// </summary>
		[Column("웹판매TL")]
		public DateTime WebSales_TL { get; set; }
		/// <summary>
		/// 프로모션
		/// </summary>
		[Column("프로모션")]
		public string Promotion { get; set; }
		/// <summary>
		/// 잔여좌석2
		/// </summary>
		[Column("잔여좌석2")]
		public int AvailableSeat2 { get; set; }
		/// <summary>
		/// 최종도착지코드
		/// </summary>
		[Column("최종도착지코드")]
		public string FinalArrivalsCode { get; set; }
		/// <summary>
		/// 최종도착지
		/// </summary>
		[Column("최종도착지")]
		public string FinalArrivals { get; set; }
		/// <summary>
		/// 한국도착지코드
		/// </summary>
		[Column("한국도착지코드")]
		public string KoreanArrivalsCode { get; set; }
		/// <summary>
		/// 한국도착지
		/// </summary>
		[Column("한국도착지")]
		public string KoreanArrivals { get; set; }
		/// <summary>
		/// 대표CLASS
		/// </summary>
		[Column("대표CLASS")]
		public string Representative_CLASS { get; set; }
		/// <summary>
		/// 박수
		/// </summary>
		[Column("박수")]
		public byte NightNumber { get; set; }
		/// <summary>
		/// 공동운항_출발적용여부
		/// </summary>
		[Column("공동운항_출발적용여부")]
		public string Codeshare_DepartureApplyOrNot { get; set; }
		/// <summary>
		/// 공동운항_출발편명
		/// </summary>
		[Column("공동운항_출발편명")]
		public string Codeshare_DepartureFlightName { get; set; }
		/// <summary>
		/// 출발편_공동운항사
		/// </summary>
		[Column("출발편_공동운항사")]
		public string DepartureFlight_CodeshareCompany { get; set; }
		/// <summary>
		/// 공동운항_도착적용여부
		/// </summary>
		[Column("공동운항_도착적용여부")]
		public string Codeshare_ArrivalApplyOrNot { get; set; }
		/// <summary>
		/// 공동운항_도착편명
		/// </summary>
		[Column("공동운항_도착편명")]
		public string Codeshare_ArrivalFlightName { get; set; }
		/// <summary>
		/// 도착편_공동운항사
		/// </summary>
		[Column("도착편_공동운항사")]
		public string ArrivalFlight_CodeshareCompany { get; set; }
		/// <summary>
		/// 웹판매잔여좌석
		/// </summary>
		[Column("웹판매잔여좌석")]
		public int WebSalesAvailableSeat { get; set; }
	}
}