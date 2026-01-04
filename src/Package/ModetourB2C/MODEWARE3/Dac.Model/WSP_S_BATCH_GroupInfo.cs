namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_BATCH_단체정보
/// </summary>
public class WSP_S_BATCH_GroupInfo
{
	public const string SP_NAME = "WSP_S_BATCH_단체정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호리스트
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("단체번호리스트")]
		public List<TYPE_GroupNumber> GroupNumberList { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 단체상세정보
		/// </summary>
		[Description("단체상세정보")]
		public string GroupDetailInfo { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
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
		/// 최소출발인원
		/// </summary>
		[Column("최소출발인원")]
		public int MinimumDepartureNumberOfPeople { get; set; }
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
		/// 조기예약할인
		/// </summary>
		[Column("조기예약할인")]
		public string EarlyBookingDiscount { get; set; }
		/// <summary>
		/// 판매가_어른
		/// </summary>
		[Column("판매가_어른")]
		public long SellingPrice_Adult { get; set; }
		/// <summary>
		/// 판매가_소아N
		/// </summary>
		[Column("판매가_소아N")]
		public long SellingPrice_Kid_N { get; set; }
		/// <summary>
		/// 판매가_소아E
		/// </summary>
		[Column("판매가_소아E")]
		public long SellingPrice_Kid_E { get; set; }
		/// <summary>
		/// 판매가_유아
		/// </summary>
		[Column("판매가_유아")]
		public long SellingPrice_Toddler { get; set; }
		/// <summary>
		/// 유류할증료_어른
		/// </summary>
		[Column("유류할증료_어른")]
		public long FuelSurchargeFee_Adult { get; set; }
		/// <summary>
		/// 유류할증료_소아N
		/// </summary>
		[Column("유류할증료_소아N")]
		public long FuelSurchargeFee_Kid_N { get; set; }
		/// <summary>
		/// 유류할증료_소아E
		/// </summary>
		[Column("유류할증료_소아E")]
		public long FuelSurchargeFee_Kid_E { get; set; }
		/// <summary>
		/// 유류할증료_유아
		/// </summary>
		[Column("유류할증료_유아")]
		public long FuelSurchargeFee_Toddler { get; set; }
		/// <summary>
		/// 제세공과금_어른
		/// </summary>
		[Column("제세공과금_어른")]
		public long PublicFacilitiesTax_Adult { get; set; }
		/// <summary>
		/// 제세공과금_소아N
		/// </summary>
		[Column("제세공과금_소아N")]
		public long PublicFacilitiesTax_Kid_N { get; set; }
		/// <summary>
		/// 제세공과금_소아E
		/// </summary>
		[Column("제세공과금_소아E")]
		public long PublicFacilitiesTax_Kid_E { get; set; }
		/// <summary>
		/// 제세공과금_유아
		/// </summary>
		[Column("제세공과금_유아")]
		public long PublicFacilitiesTax_Toddler { get; set; }
		/// <summary>
		/// 판매가_랜드
		/// </summary>
		[Column("판매가_랜드")]
		public long SellingPrice_Land { get; set; }
		/// <summary>
		/// 추가요금_기타
		/// </summary>
		[Column("추가요금_기타")]
		public long AddFare_Other { get; set; }
		/// <summary>
		/// 추가요금_싱글룸
		/// </summary>
		[Column("추가요금_싱글룸")]
		public long AddFare_SingleRoom { get; set; }
		/// <summary>
		/// 요금비고
		/// </summary>
		[Column("요금비고")]
		public string FareNote { get; set; }
		/// <summary>
		/// 현지필수경비여부
		/// </summary>
		[Column("현지필수경비여부")]
		public string LocalRequiredExpenseOrNot { get; set; }
		/// <summary>
		/// 현지필수경비_통화
		/// </summary>
		[Column("현지필수경비_통화")]
		public string LocalRequiredExpense_Call { get; set; }
		/// <summary>
		/// 현지필수경비
		/// </summary>
		[Column("현지필수경비")]
		public int LocalRequiredExpense { get; set; }
		/// <summary>
		/// 현지필수경비_소아
		/// </summary>
		[Column("현지필수경비_소아")]
		public int LocalRequiredExpense_Kid { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
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
		/// 잔여좌석
		/// </summary>
		[Column("잔여좌석")]
		public string AvailableSeat { get; set; }
		/// <summary>
		/// 발권TTL
		/// </summary>
		[Column("발권TTL")]
		public DateTime TicketIssuance_TTL { get; set; }
		/// <summary>
		/// NameTL
		/// </summary>
		[Column("NameTL")]
		public string NameTL { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 수정일
		/// </summary>
		[Column("수정일")]
		public DateTime EditionDate { get; set; }
		/// <summary>
		/// 제휴여부
		/// </summary>
		[Column("제휴여부")]
		public string AffiliateOrNot { get; set; }
		/// <summary>
		/// 제휴단체번호
		/// </summary>
		[Column("제휴단체번호")]
		public int AffiliatedGroupNumber { get; set; }
		/// <summary>
		/// 방문지리스트
		/// </summary>
		[Column("방문지리스트")]
		public string VisitPlaceList { get; set; }
		/// <summary>
		/// 대표이미지0
		/// </summary>
		[Column("대표이미지0")]
		public string RepresentativeImage0 { get; set; }
		/// <summary>
		/// 대표이미지1
		/// </summary>
		[Column("대표이미지1")]
		public string RepresentativeImage1 { get; set; }
		/// <summary>
		/// 대표이미지2
		/// </summary>
		[Column("대표이미지2")]
		public string RepresentativeImage2 { get; set; }
		/// <summary>
		/// 대표이미지3
		/// </summary>
		[Column("대표이미지3")]
		public string RepresentativeImage3 { get; set; }
		/// <summary>
		/// 대표이미지4
		/// </summary>
		[Column("대표이미지4")]
		public string RepresentativeImage4 { get; set; }
		/// <summary>
		/// 대표이미지5
		/// </summary>
		[Column("대표이미지5")]
		public string RepresentativeImage5 { get; set; }
		/// <summary>
		/// 대표이미지6
		/// </summary>
		[Column("대표이미지6")]
		public string RepresentativeImage6 { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 기내숙박
		/// </summary>
		[Column("기내숙박")]
		public byte InFlightLogment { get; set; }
		/// <summary>
		/// 직항여부
		/// </summary>
		[Column("직항여부")]
		public string DirectFlightOrNot { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 출발편_도착일자
		/// </summary>
		[Column("출발편_도착일자")]
		public string DepartureFlight_ArrivalDate { get; set; }
		/// <summary>
		/// 출발도시명
		/// </summary>
		[Column("출발도시명")]
		public string DepartureCityName { get; set; }
		/// <summary>
		/// 도착도시명
		/// </summary>
		[Column("도착도시명")]
		public string ArrivalCityName { get; set; }
		/// <summary>
		/// 출발항공편
		/// </summary>
		[Column("출발항공편")]
		public string DepartureFlight { get; set; }
		/// <summary>
		/// 출발비행시간
		/// </summary>
		[Column("출발비행시간")]
		public string DepartureFlightDuration { get; set; }
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
		/// 경유출발일정표시
		/// </summary>
		[Column("경유출발일정표시")]
		public string TransitDepartureScheduleDisplay { get; set; }
		/// <summary>
		/// 출발편_경유도시명
		/// </summary>
		[Column("출발편_경유도시명")]
		public string DepartureFlight_TransitCityName { get; set; }
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
		/// 출발편_경유도시_출발일자
		/// </summary>
		[Column("출발편_경유도시_출발일자")]
		public DateTime DepartureFlight_TransitCity_DepartureDate { get; set; }
		/// <summary>
		/// 출발편_경유도시_출발시간
		/// </summary>
		[Column("출발편_경유도시_출발시간")]
		public string DepartureFlight_TransitCity_DepartureTime { get; set; }
		/// <summary>
		/// 출발편경유비행시간
		/// </summary>
		[Column("출발편경유비행시간")]
		public string DepartureFlightTransitFlightDuration { get; set; }
		/// <summary>
		/// 출발편_경유도시_편명
		/// </summary>
		[Column("출발편_경유도시_편명")]
		public string DepartureFlight_TransitCity_FlightName { get; set; }
		/// <summary>
		/// 귀국편_출발일자
		/// </summary>
		[Column("귀국편_출발일자")]
		public string ReturnToHomelandFlight_DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public string ArrivalDate { get; set; }
		/// <summary>
		/// 한국출발도시명
		/// </summary>
		[Column("한국출발도시명")]
		public string KoreanDepartureCityName { get; set; }
		/// <summary>
		/// 한국도착도시명
		/// </summary>
		[Column("한국도착도시명")]
		public string KoreanArrivalCityName { get; set; }
		/// <summary>
		/// 도착항공편
		/// </summary>
		[Column("도착항공편")]
		public string ArrivalFlight { get; set; }
		/// <summary>
		/// 도착비행시간
		/// </summary>
		[Column("도착비행시간")]
		public string ArrivalFlightDuration { get; set; }
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
		/// 경유도착일정표시
		/// </summary>
		[Column("경유도착일정표시")]
		public string TransitArrivalScheduleDisplay { get; set; }
		/// <summary>
		/// 귀국편_경유도시명
		/// </summary>
		[Column("귀국편_경유도시명")]
		public string ReturnToHomelandFlight_TransitCityName { get; set; }
		/// <summary>
		/// 귀국편_경유도착도시명
		/// </summary>
		[Column("귀국편_경유도착도시명")]
		public string ReturnToHomelandFlight_TransitArrivalCityName { get; set; }
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
		/// 귀국편경유비행시간
		/// </summary>
		[Column("귀국편경유비행시간")]
		public string ReturnToHomelandFlightTransitFlightDuration { get; set; }
		/// <summary>
		/// 귀국편경유출발일자
		/// </summary>
		[Column("귀국편경유출발일자")]
		public DateTime ReturnToHomelandFlightTransitDepartureDate { get; set; }
		/// <summary>
		/// 귀국편경유출발시간
		/// </summary>
		[Column("귀국편경유출발시간")]
		public string ReturnToHomelandFlightTransitDepartureTime { get; set; }
		/// <summary>
		/// 귀국편_경유도시_편명
		/// </summary>
		[Column("귀국편_경유도시_편명")]
		public string ReturnToHomelandFlight_TransitCity_FlightName { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 일정코드
		/// </summary>
		[Column("일정코드")]
		public string ScheduleCode { get; set; }
		/// <summary>
		/// 방문지리스트
		/// </summary>
		[Column("방문지리스트")]
		public string VisitPlaceList { get; set; }
	}
}