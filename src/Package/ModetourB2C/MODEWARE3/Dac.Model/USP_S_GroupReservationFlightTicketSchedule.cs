namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_공동구매항공권스케쥴
/// </summary>
public class USP_S_GroupReservationFlightTicketSchedule
{
	public const string SP_NAME = "USP_S_공동구매항공권스케쥴";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 재고번호
		/// </summary>
		[Description("재고번호")]
		public int StockNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 항공사
		/// </summary>
		[Column("항공사")]
		public string Airline { get; set; }
		/// <summary>
		/// 출발도시
		/// </summary>
		[Column("출발도시")]
		public string DepartureCity { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// 출발지공항영문
		/// </summary>
		[Column("출발지공항영문")]
		public string DeparturesAirportEnglish { get; set; }
		/// <summary>
		/// 출발지공항국문
		/// </summary>
		[Column("출발지공항국문")]
		public string DeparturesAirportKorean { get; set; }
		/// <summary>
		/// 도착도시
		/// </summary>
		[Column("도착도시")]
		public string ArrivalCity { get; set; }
		/// <summary>
		/// 도착지
		/// </summary>
		[Column("도착지")]
		public string Arrivals { get; set; }
		/// <summary>
		/// 도착지공항영문
		/// </summary>
		[Column("도착지공항영문")]
		public string ArrivalsAirportEnglish { get; set; }
		/// <summary>
		/// 도착지공항국문
		/// </summary>
		[Column("도착지공항국문")]
		public string ArrivalsAirportKorean { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
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
		/// 도착시간
		/// </summary>
		[Column("도착시간")]
		public string ArrivalTime { get; set; }
		/// <summary>
		/// 예약가능좌석
		/// </summary>
		[Column("예약가능좌석")]
		public int BookingPossibleSeat { get; set; }
		/// <summary>
		/// 비행시간
		/// </summary>
		[Column("비행시간")]
		public string FlightDuration { get; set; }
		/// <summary>
		/// 경유편비행시간
		/// </summary>
		[Column("경유편비행시간")]
		public string TransitFlightFlightDuration { get; set; }
		/// <summary>
		/// 경유편명
		/// </summary>
		[Column("경유편명")]
		public string TransitFlightName { get; set; }
		/// <summary>
		/// 경유편항공사명
		/// </summary>
		[Column("경유편항공사명")]
		public string TransitFlightAirlineName { get; set; }
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
		/// 웹판매TL
		/// </summary>
		[Column("웹판매TL")]
		public DateTime WebSales_TL { get; set; }
		/// <summary>
		/// 예약좌석
		/// </summary>
		[Column("예약좌석")]
		public int BookingSeat { get; set; }
		/// <summary>
		/// 최소출발인원
		/// </summary>
		[Column("최소출발인원")]
		public int MinimumDepartureNumberOfPeople { get; set; }
		/// <summary>
		/// 현지도착시간
		/// </summary>
		[Column("현지도착시간")]
		public string LocalArrivalTime { get; set; }
		/// <summary>
		/// 현지출발시간
		/// </summary>
		[Column("현지출발시간")]
		public string LocalDepartureTime { get; set; }
		/// <summary>
		/// 출발편_도착일자
		/// </summary>
		[Column("출발편_도착일자")]
		public DateTime DepartureFlight_ArrivalDate { get; set; }
		/// <summary>
		/// 귀국편_출발일자
		/// </summary>
		[Column("귀국편_출발일자")]
		public DateTime ReturnToHomelandFlight_DepartureDate { get; set; }
		/// <summary>
		/// 귀국편_도착일자
		/// </summary>
		[Column("귀국편_도착일자")]
		public DateTime ReturnToHomelandFlight_ArrivalDate { get; set; }
		/// <summary>
		/// 출발편_경유도시_도착일
		/// </summary>
		[Column("출발편_경유도시_도착일")]
		public DateTime DepartureFlight_TransitCity_ArrivalDate { get; set; }
		/// <summary>
		/// 출발편_경유도시_도착시간
		/// </summary>
		[Column("출발편_경유도시_도착시간")]
		public string DepartureFlight_TransitCity_ArrivalTime { get; set; }
		/// <summary>
		/// 출발편_경유도시_비행시간
		/// </summary>
		[Column("출발편_경유도시_비행시간")]
		public string DepartureFlight_TransitCity_FlightDuration { get; set; }
		/// <summary>
		/// 출발편_경유도시코드
		/// </summary>
		[Column("출발편_경유도시코드")]
		public string DepartureFlight_TransitCityCode { get; set; }
		/// <summary>
		/// 출발편_경유도시
		/// </summary>
		[Column("출발편_경유도시")]
		public string DepartureFlight_TransitCity { get; set; }
		/// <summary>
		/// 출발편_경유도시영문
		/// </summary>
		[Column("출발편_경유도시영문")]
		public string DepartureFlight_TransitCityEnglish { get; set; }
		/// <summary>
		/// 귀국편_경유도시_도착일
		/// </summary>
		[Column("귀국편_경유도시_도착일")]
		public DateTime ReturnToHomelandFlight_TransitCity_ArrivalDate { get; set; }
		/// <summary>
		/// 귀국편_경유도시_도착시간
		/// </summary>
		[Column("귀국편_경유도시_도착시간")]
		public string ReturnToHomelandFlight_TransitCity_ArrivalTime { get; set; }
		/// <summary>
		/// 귀국편_경유도시_비행시간
		/// </summary>
		[Column("귀국편_경유도시_비행시간")]
		public string ReturnToHomelandFlight_TransitCity_FlightDuration { get; set; }
		/// <summary>
		/// 귀국편_경유도시코드
		/// </summary>
		[Column("귀국편_경유도시코드")]
		public string ReturnToHomelandFlight_TransitCityCode { get; set; }
		/// <summary>
		/// 귀국편_경유도시
		/// </summary>
		[Column("귀국편_경유도시")]
		public string ReturnToHomelandFlight_TransitCity { get; set; }
		/// <summary>
		/// 귀국편_경유도시영문
		/// </summary>
		[Column("귀국편_경유도시영문")]
		public string ReturnToHomelandFlight_TransitCityEnglish { get; set; }
		/// <summary>
		/// 인디비성인요금
		/// </summary>
		[Column("인디비성인요금")]
		public int IndividualAdultFare { get; set; }
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
		/// <summary>
		/// 대표CLASS
		/// </summary>
		[Column("대표CLASS")]
		public string Representative_CLASS { get; set; }
	}
}