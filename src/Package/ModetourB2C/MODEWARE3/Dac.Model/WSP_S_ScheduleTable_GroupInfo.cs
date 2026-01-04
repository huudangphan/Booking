namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_일정표_단체정보
/// </summary>
public class WSP_S_ScheduleTable_GroupInfo
{
	public const string SP_NAME = "WSP_S_일정표_단체정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 단체구분코드
		/// </summary>
		[Column("단체구분코드")]
		public string GroupClassificationCode { get; set; }
		/// <summary>
		/// 단체구분
		/// </summary>
		[Column("단체구분")]
		public string GroupClassification { get; set; }
		/// <summary>
		/// 단체종류
		/// </summary>
		[Column("단체종류")]
		public string GroupType { get; set; }
		/// <summary>
		/// 단체분류
		/// </summary>
		[Column("단체분류")]
		public string GroupClassification2 { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public DateTime ArrivalDate { get; set; }
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
		/// 항공사명
		/// </summary>
		[Column("항공사명")]
		public string AirlineName { get; set; }
		/// <summary>
		/// 접두어
		/// </summary>
		[Column("접두어")]
		public string Prefix { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 접미어
		/// </summary>
		[Column("접미어")]
		public string Suffix { get; set; }
		/// <summary>
		/// 접두어명
		/// </summary>
		[Column("접두어명")]
		public string PrefixName { get; set; }
		/// <summary>
		/// 판매가_어른
		/// </summary>
		[Column("판매가_어른")]
		public int SellingPrice_Adult { get; set; }
		/// <summary>
		/// 판매가_소아N
		/// </summary>
		[Column("판매가_소아N")]
		public int SellingPrice_Kid_N { get; set; }
		/// <summary>
		/// 판매가_소아E
		/// </summary>
		[Column("판매가_소아E")]
		public int SellingPrice_Kid_E { get; set; }
		/// <summary>
		/// 판매가_유아
		/// </summary>
		[Column("판매가_유아")]
		public int SellingPrice_Toddler { get; set; }
		/// <summary>
		/// 판매가_어른_총액
		/// </summary>
		[Column("판매가_어른_총액")]
		public long SellingPrice_Adult_TotalAmount { get; set; }
		/// <summary>
		/// 판매가_소아N_총액
		/// </summary>
		[Column("판매가_소아N_총액")]
		public long SellingPrice_Kid_N_TotalAmount { get; set; }
		/// <summary>
		/// 판매가_소아E_총액
		/// </summary>
		[Column("판매가_소아E_총액")]
		public long SellingPrice_Kid_E_TotalAmount { get; set; }
		/// <summary>
		/// 판매가_유아_총액
		/// </summary>
		[Column("판매가_유아_총액")]
		public long SellingPrice_Toddler_TotalAmount { get; set; }
		/// <summary>
		/// 판매가_랜드
		/// </summary>
		[Column("판매가_랜드")]
		public int SellingPrice_Land { get; set; }
		/// <summary>
		/// 인센티브여부
		/// </summary>
		[Column("인센티브여부")]
		public string IncentiveOrNot { get; set; }
		/// <summary>
		/// 마스터번호
		/// </summary>
		[Column("마스터번호")]
		public int MasterNumber { get; set; }
		/// <summary>
		/// 할인율
		/// </summary>
		[Column("할인율")]
		public decimal DiscountRate { get; set; }
		/// <summary>
		/// 할인액
		/// </summary>
		[Column("할인액")]
		public int DiscountAmount { get; set; }
		/// <summary>
		/// 할인조건
		/// </summary>
		[Column("할인조건")]
		public string DiscountCondition { get; set; }
		/// <summary>
		/// 프로모션명
		/// </summary>
		[Column("프로모션명")]
		public string PromotionName { get; set; }
		/// <summary>
		/// 로고파일
		/// </summary>
		[Column("로고파일")]
		public string LogoFile { get; set; }
		/// <summary>
		/// 상품가_어른_총액
		/// </summary>
		[Column("상품가_어른_총액")]
		public long ProductPrice_Adult_TotalAmount { get; set; }
		/// <summary>
		/// 상품가_소아N_총액
		/// </summary>
		[Column("상품가_소아N_총액")]
		public long ProductPrice_Kid_N_TotalAmount { get; set; }
		/// <summary>
		/// 상품가_소아E_총액
		/// </summary>
		[Column("상품가_소아E_총액")]
		public long ProductPrice_Kid_E_TotalAmount { get; set; }
		/// <summary>
		/// 상품가_유아_총액
		/// </summary>
		[Column("상품가_유아_총액")]
		public long ProductPrice_Toddler_TotalAmount { get; set; }
		/// <summary>
		/// 상품가_어른
		/// </summary>
		[Column("상품가_어른")]
		public long ProductPrice_Adult { get; set; }
		/// <summary>
		/// 상품가_소아N
		/// </summary>
		[Column("상품가_소아N")]
		public long ProductPrice_Kid_N { get; set; }
		/// <summary>
		/// 상품가_소아E
		/// </summary>
		[Column("상품가_소아E")]
		public long ProductPrice_Kid_E { get; set; }
		/// <summary>
		/// 상품가_유아
		/// </summary>
		[Column("상품가_유아")]
		public long ProductPrice_Toddler { get; set; }
		/// <summary>
		/// 상품가_랜드
		/// </summary>
		[Column("상품가_랜드")]
		public long ProductPrice_Land { get; set; }
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
		/// 추가요금_싱글룸
		/// </summary>
		[Column("추가요금_싱글룸")]
		public long AddFare_SingleRoom { get; set; }
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
		public long LocalRequiredExpense { get; set; }
		/// <summary>
		/// 현지필수경비_소아
		/// </summary>
		[Column("현지필수경비_소아")]
		public int LocalRequiredExpense_Kid { get; set; }
		/// <summary>
		/// 현지필수경비_유아
		/// </summary>
		[Column("현지필수경비_유아")]
		public int LocalRequiredExpense_Toddler { get; set; }
		/// <summary>
		/// 비지니스추가요금
		/// </summary>
		[Column("비지니스추가요금")]
		public long BusinessAddFare { get; set; }
		/// <summary>
		/// 가족요금프로모션사용여부
		/// </summary>
		[Column("가족요금프로모션사용여부")]
		public string FamilyFarePromotionUseOrNot { get; set; }
		/// <summary>
		/// 어른유료인원
		/// </summary>
		[Column("어른유료인원")]
		public int AdultFeeChargedNumberOfPeople { get; set; }
		/// <summary>
		/// 소아N유료인원
		/// </summary>
		[Column("소아N유료인원")]
		public int Kid_N_FeeChargedNumberOfPeople { get; set; }
		/// <summary>
		/// 소아E유료인원
		/// </summary>
		[Column("소아E유료인원")]
		public int Kid_E_FeeChargedNumberOfPeople { get; set; }
		/// <summary>
		/// 유아유료인원
		/// </summary>
		[Column("유아유료인원")]
		public int ToddlerFeeChargedNumberOfPeople { get; set; }
		/// <summary>
		/// 어른무료인원
		/// </summary>
		[Column("어른무료인원")]
		public int AdultFreeNumberOfPeople { get; set; }
		/// <summary>
		/// 소아N무료인원
		/// </summary>
		[Column("소아N무료인원")]
		public int Kid_N_FreeNumberOfPeople { get; set; }
		/// <summary>
		/// 소아E무료인원
		/// </summary>
		[Column("소아E무료인원")]
		public int Kid_E_FreeNumberOfPeople { get; set; }
		/// <summary>
		/// 유아무료인원
		/// </summary>
		[Column("유아무료인원")]
		public int ToddlerFreeNumberOfPeople { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 제휴여부
		/// </summary>
		[Column("제휴여부")]
		public string AffiliateOrNot { get; set; }
		/// <summary>
		/// 판매마감
		/// </summary>
		[Column("판매마감")]
		public string SalesEnd { get; set; }
		/// <summary>
		/// 판매마감_여행플래너
		/// </summary>
		[Column("판매마감_여행플래너")]
		public string SalesEnd_TravelPlanner { get; set; }
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
		/// 조인여부
		/// </summary>
		[Column("조인여부")]
		public string JoinOrNot { get; set; }
		/// <summary>
		/// 메인여부
		/// </summary>
		[Column("메인여부")]
		public string MainOrNot { get; set; }
		/// <summary>
		/// 행사인원
		/// </summary>
		[Column("행사인원")]
		public int EventNumberOfPeople { get; set; }
		/// <summary>
		/// 랜드조인
		/// </summary>
		[Column("랜드조인")]
		public int LandJoin { get; set; }
		/// <summary>
		/// LND
		/// </summary>
		[Column("LND")]
		public int LND { get; set; }
		/// <summary>
		/// 예약좌석수
		/// </summary>
		[Column("예약좌석수")]
		public string BookingSeatNumber { get; set; }
		/// <summary>
		/// NameTL
		/// </summary>
		[Column("NameTL")]
		public string NameTL { get; set; }
		/// <summary>
		/// 안내원동행인원
		/// </summary>
		[Column("안내원동행인원")]
		public int GuideAccompanyNumberOfPeople { get; set; }
		/// <summary>
		/// 상품코드2
		/// </summary>
		[Column("상품코드2")]
		public string ProductCode2 { get; set; }
		/// <summary>
		/// 상품등급
		/// </summary>
		[Column("상품등급")]
		public string ProductClass { get; set; }
		/// <summary>
		/// 조기예약할인
		/// </summary>
		[Column("조기예약할인")]
		public string EarlyBookingDiscount { get; set; }
		/// <summary>
		/// 시리즈연동
		/// </summary>
		[Column("시리즈연동")]
		public string SeriesConnected { get; set; }
		/// <summary>
		/// 단체좌석사용여부
		/// </summary>
		[Column("단체좌석사용여부")]
		public string GroupSeatUseOrNot { get; set; }
		/// <summary>
		/// 내부판매AD여부
		/// </summary>
		[Column("내부판매AD여부")]
		public string InternalSales_AD_OrNot { get; set; }
		/// <summary>
		/// 단체간략키워드
		/// </summary>
		[Column("단체간략키워드")]
		public string GroupBriefKeyword { get; set; }
		/// <summary>
		/// P단체번호
		/// </summary>
		[Column("P단체번호")]
		public int P_GroupNumber { get; set; }
		/// <summary>
		/// 박수
		/// </summary>
		[Column("박수")]
		public byte NightNumber { get; set; }
		/// <summary>
		/// 일수
		/// </summary>
		[Column("일수")]
		public byte DaysNumber { get; set; }
		/// <summary>
		/// 여행기간
		/// </summary>
		[Column("여행기간")]
		public string TravelPeriod { get; set; }
		/// <summary>
		/// 출발항공편
		/// </summary>
		[Column("출발항공편")]
		public string DepartureFlight { get; set; }
		/// <summary>
		/// 출발시간
		/// </summary>
		[Column("출발시간")]
		public string DepartureTime { get; set; }
		/// <summary>
		/// 도착항공편
		/// </summary>
		[Column("도착항공편")]
		public string ArrivalFlight { get; set; }
		/// <summary>
		/// 도착시간
		/// </summary>
		[Column("도착시간")]
		public string ArrivalTime { get; set; }
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
		/// 미팅장소코드
		/// </summary>
		[Column("미팅장소코드")]
		public string MeetingPlaceCode { get; set; }
		/// <summary>
		/// 미팅장소2
		/// </summary>
		[Column("미팅장소2")]
		public string MeetingPlace2 { get; set; }
		/// <summary>
		/// 미팅시간
		/// </summary>
		[Column("미팅시간")]
		public string MeetingTime { get; set; }
		/// <summary>
		/// 여행자보험
		/// </summary>
		[Column("여행자보험")]
		public string TravelerInsurance { get; set; }
		/// <summary>
		/// 여행자보험담당
		/// </summary>
		[Column("여행자보험담당")]
		public string TravelerInsuranceResponsibility { get; set; }
		/// <summary>
		/// 포함비고
		/// </summary>
		[Column("포함비고")]
		public string IncludedNote { get; set; }
		/// <summary>
		/// 불포함비고
		/// </summary>
		[Column("불포함비고")]
		public string UnincludedNote { get; set; }
		/// <summary>
		/// 유의사항비고
		/// </summary>
		[Column("유의사항비고")]
		public string NoticeNote { get; set; }
		/// <summary>
		/// 특전비고
		/// </summary>
		[Column("특전비고")]
		public string SpecialEventNote { get; set; }
		/// <summary>
		/// 공통특전비고
		/// </summary>
		[Column("공통특전비고")]
		public string GeneralBonusNote { get; set; }
		/// <summary>
		/// 쇼핑비고
		/// </summary>
		[Column("쇼핑비고")]
		public string ShoppingNote { get; set; }
		/// <summary>
		/// 쇼핑시유의사항
		/// </summary>
		[Column("쇼핑시유의사항")]
		public string NotesWhenShopping { get; set; }
		/// <summary>
		/// 추가경비비고
		/// </summary>
		[Column("추가경비비고")]
		public string AddExpenseNote { get; set; }
		/// <summary>
		/// 특이사항비고
		/// </summary>
		[Column("특이사항비고")]
		public string SpecificNote { get; set; }
		/// <summary>
		/// 요금비고
		/// </summary>
		[Column("요금비고")]
		public string FareNote { get; set; }
		/// <summary>
		/// 여행추천비고
		/// </summary>
		[Column("여행추천비고")]
		public string TravelRecommendNote { get; set; }
		/// <summary>
		/// 여권비자비고
		/// </summary>
		[Column("여권비자비고")]
		public string PassportVisaNote { get; set; }
		/// <summary>
		/// 취소료규정
		/// </summary>
		[Column("취소료규정")]
		public string CancelFeeRegulations { get; set; }
		/// <summary>
		/// 수신자부담전화
		/// </summary>
		[Column("수신자부담전화")]
		public string ReceiverDebitPhone { get; set; }
		/// <summary>
		/// 현지연락처
		/// </summary>
		[Column("현지연락처")]
		public string LocalContact { get; set; }
		/// <summary>
		/// 싱글추가요금
		/// </summary>
		[Column("싱글추가요금")]
		public string SingleAddFare { get; set; }
		/// <summary>
		/// 동영상정보
		/// </summary>
		[Column("동영상정보")]
		public string VideoInfo { get; set; }
		/// <summary>
		/// 방사용조건비고
		/// </summary>
		[Column("방사용조건비고")]
		public string RoomUseConditionNote { get; set; }
		/// <summary>
		/// 긴급연락처
		/// </summary>
		[Column("긴급연락처")]
		public string EmergencyContact { get; set; }
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
		/// 최소출발인원
		/// </summary>
		[Column("최소출발인원")]
		public int MinimumDepartureNumberOfPeople { get; set; }
		/// <summary>
		/// 비자
		/// </summary>
		[Column("비자")]
		public string Visa { get; set; }
		/// <summary>
		/// 유류할증료비고
		/// </summary>
		[Column("유류할증료비고")]
		public string FuelSurchargeFeeNote { get; set; }
		/// <summary>
		/// 특별약관
		/// </summary>
		[Column("특별약관")]
		public string SpecialTerms { get; set; }
		/// <summary>
		/// 질문과답변
		/// </summary>
		[Column("질문과답변")]
		public string QuestionAndAnswer { get; set; }
		/// <summary>
		/// 현지행사정보
		/// </summary>
		[Column("현지행사정보")]
		public string LocalEventInfo { get; set; }
		/// <summary>
		/// 고객별특이사항
		/// </summary>
		[Column("고객별특이사항")]
		public string EachCustomerSpecific { get; set; }
		/// <summary>
		/// 가이드확정
		/// </summary>
		[Column("가이드확정")]
		public string GuideConfirmed { get; set; }
		/// <summary>
		/// 쇼핑횟수
		/// </summary>
		[Column("쇼핑횟수")]
		public int ShoppingTimes { get; set; }
		/// <summary>
		/// 물놀이안전노출여부
		/// </summary>
		[Column("물놀이안전노출여부")]
		public string WaterPlaySafetyDisplayOrNot { get; set; }
		/// <summary>
		/// 현장안전지침서노출여부
		/// </summary>
		[Column("현장안전지침서노출여부")]
		public string ActualPlaceSafetyGuidelineDisplayOrNot { get; set; }
		/// <summary>
		/// 이인일실
		/// </summary>
		[Column("이인일실")]
		public string TwoPersonOneRoom { get; set; }
		/// <summary>
		/// B2C인센티브분류
		/// </summary>
		[Column("B2C인센티브분류")]
		public string B2C_IncentiveClassification { get; set; }
		/// <summary>
		/// 이동경로이미지주소
		/// </summary>
		[Column("이동경로이미지주소")]
		public string NavigationRouteImageAddress { get; set; }
		/// <summary>
		/// 예약좌석수1
		/// </summary>
		[Column("예약좌석수1")]
		public int BookingSeatNumber1 { get; set; }
		/// <summary>
		/// 잔여좌석수
		/// </summary>
		[Column("잔여좌석수")]
		public int AvailableSeatNumber { get; set; }
		/// <summary>
		/// 지급방식코드
		/// </summary>
		[Column("지급방식코드")]
		public string PaymentMethodCode { get; set; }
		/// <summary>
		/// 연합
		/// </summary>
		[Column("연합")]
		public string Combination { get; set; }
		/// <summary>
		/// 출발도시
		/// </summary>
		[Column("출발도시")]
		public string DepartureCity { get; set; }
		/// <summary>
		/// 출발도시명
		/// </summary>
		[Column("출발도시명")]
		public string DepartureCityName { get; set; }
		/// <summary>
		/// 출발공항명
		/// </summary>
		[Column("출발공항명")]
		public string DepartureAirportName { get; set; }
		/// <summary>
		/// 도착도시
		/// </summary>
		[Column("도착도시")]
		public string ArrivalCity { get; set; }
		/// <summary>
		/// 도착도시명
		/// </summary>
		[Column("도착도시명")]
		public string ArrivalCityName { get; set; }
		/// <summary>
		/// 한국출발도시
		/// </summary>
		[Column("한국출발도시")]
		public string KoreanDepartureCity { get; set; }
		/// <summary>
		/// 한국출발도시명
		/// </summary>
		[Column("한국출발도시명")]
		public string KoreanDepartureCityName { get; set; }
		/// <summary>
		/// 한국도착도시
		/// </summary>
		[Column("한국도착도시")]
		public string KoreanArrivalCity { get; set; }
		/// <summary>
		/// 한국도착도시명
		/// </summary>
		[Column("한국도착도시명")]
		public string KoreanArrivalCityName { get; set; }
		/// <summary>
		/// 출발비행시간
		/// </summary>
		[Column("출발비행시간")]
		public string DepartureFlightDuration { get; set; }
		/// <summary>
		/// 도착비행시간
		/// </summary>
		[Column("도착비행시간")]
		public string ArrivalFlightDuration { get; set; }
		/// <summary>
		/// 교통수단코드
		/// </summary>
		[Column("교통수단코드")]
		public string TransportationMethodCode { get; set; }
		/// <summary>
		/// 선박여부
		/// </summary>
		[Column("선박여부")]
		public string ShippingOrNot { get; set; }
		/// <summary>
		/// 교통수단
		/// </summary>
		[Column("교통수단")]
		public string TransportationMethod { get; set; }
		/// <summary>
		/// 최종도착지
		/// </summary>
		[Column("최종도착지")]
		public string FinalArrivals { get; set; }
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
		/// 출발편_경유도시_출발시간
		/// </summary>
		[Column("출발편_경유도시_출발시간")]
		public string DepartureFlight_TransitCity_DepartureTime { get; set; }
		/// <summary>
		/// 출발편_경유도시_경유편_비행시간
		/// </summary>
		[Column("출발편_경유도시_경유편_비행시간")]
		public string DepartureFlight_TransitCity_TransitFlight_FlightDuration { get; set; }
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
		/// 귀국편_경유도시_출발시간
		/// </summary>
		[Column("귀국편_경유도시_출발시간")]
		public string ReturnToHomelandFlight_TransitCity_DepartureTime { get; set; }
		/// <summary>
		/// 귀국편_경유도시_경유편_비행시간
		/// </summary>
		[Column("귀국편_경유도시_경유편_비행시간")]
		public string ReturnToHomelandFlight_TransitCity_TransitFlight_FlightDuration { get; set; }
		/// <summary>
		/// 출발편_경유도시_편명
		/// </summary>
		[Column("출발편_경유도시_편명")]
		public string DepartureFlight_TransitCity_FlightName { get; set; }
		/// <summary>
		/// 귀국편_경유도시_편명
		/// </summary>
		[Column("귀국편_경유도시_편명")]
		public string ReturnToHomelandFlight_TransitCity_FlightName { get; set; }
		/// <summary>
		/// 출발편_경유도시_출발일자
		/// </summary>
		[Column("출발편_경유도시_출발일자")]
		public DateTime DepartureFlight_TransitCity_DepartureDate { get; set; }
		/// <summary>
		/// 귀국편_경유도시_출발일자
		/// </summary>
		[Column("귀국편_경유도시_출발일자")]
		public DateTime ReturnToHomelandFlight_TransitCity_DepartureDate { get; set; }
		/// <summary>
		/// 출발편_경유도시코드
		/// </summary>
		[Column("출발편_경유도시코드")]
		public string DepartureFlight_TransitCityCode { get; set; }
		/// <summary>
		/// 출발편_경유도시명
		/// </summary>
		[Column("출발편_경유도시명")]
		public string DepartureFlight_TransitCityName { get; set; }
		/// <summary>
		/// 귀국편_경유도시코드
		/// </summary>
		[Column("귀국편_경유도시코드")]
		public string ReturnToHomelandFlight_TransitCityCode { get; set; }
		/// <summary>
		/// 귀국편_경유도시명
		/// </summary>
		[Column("귀국편_경유도시명")]
		public string ReturnToHomelandFlight_TransitCityName { get; set; }
		/// <summary>
		/// 공동운항_출발편명
		/// </summary>
		[Column("공동운항_출발편명")]
		public string Codeshare_DepartureFlightName { get; set; }
		/// <summary>
		/// 공동운항_도착편명
		/// </summary>
		[Column("공동운항_도착편명")]
		public string Codeshare_ArrivalFlightName { get; set; }
		/// <summary>
		/// 경유출발일정표시
		/// </summary>
		[Column("경유출발일정표시")]
		public string TransitDepartureScheduleDisplay { get; set; }
		/// <summary>
		/// 경유도착일정표시
		/// </summary>
		[Column("경유도착일정표시")]
		public string TransitArrivalScheduleDisplay { get; set; }
		/// <summary>
		/// 출발공동운항코드
		/// </summary>
		[Column("출발공동운항코드")]
		public string DepartureCodeshareCode { get; set; }
		/// <summary>
		/// 도착공동운항코드
		/// </summary>
		[Column("도착공동운항코드")]
		public string ArrivalCodeshareCode { get; set; }
		/// <summary>
		/// 출발공동운항명
		/// </summary>
		[Column("출발공동운항명")]
		public string DepartureCodeshareName { get; set; }
		/// <summary>
		/// 도착공동운항명
		/// </summary>
		[Column("도착공동운항명")]
		public string ArrivalCodeshareName { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 상품분류
		/// </summary>
		[Column("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 상품분류2
		/// </summary>
		[Column("상품분류2")]
		public string ProductClassification2 { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 대표이미지묶음
		/// </summary>
		[Column("대표이미지묶음")]
		public string RepresentativeImagePack { get; set; }
		/// <summary>
		/// 대표이미지종류
		/// </summary>
		[Column("대표이미지종류")]
		public string RepresentativeImageType { get; set; }
		/// <summary>
		/// 대표국가명
		/// </summary>
		[Column("대표국가명")]
		public string RepresentativeCountryName { get; set; }
		/// <summary>
		/// 여행경보사건사고
		/// </summary>
		[Column("여행경보사건사고")]
		public string TravelWarningIncidentAccident { get; set; }
		/// <summary>
		/// 인솔자PTID
		/// </summary>
		[Column("인솔자PTID")]
		public int Leader_PTID { get; set; }
		/// <summary>
		/// 인솔자동행
		/// </summary>
		[Column("인솔자동행")]
		public string LeaderAccompany { get; set; }
		/// <summary>
		/// 인솔자확정
		/// </summary>
		[Column("인솔자확정")]
		public string LeaderConfirm { get; set; }
		/// <summary>
		/// 안전정보국가별
		/// </summary>
		[Column("안전정보국가별")]
		public string SafetyInfoEachCountry { get; set; }
		/// <summary>
		/// 현장안전고지문구
		/// </summary>
		[Column("현장안전고지문구")]
		public string ActualPlaceSafetyNoticeWords { get; set; }
		/// <summary>
		/// 적립예상투어마일리지
		/// </summary>
		[Column("적립예상투어마일리지")]
		public int AccumulationExpectedTourMileage { get; set; }
		/// <summary>
		/// 소아N적립예상투어마일리지
		/// </summary>
		[Column("소아N적립예상투어마일리지")]
		public double Kid_N_AccumulationExpectedTourMileage { get; set; }
		/// <summary>
		/// 소아E적립예상투어마일리지
		/// </summary>
		[Column("소아E적립예상투어마일리지")]
		public double Kid_E_AccumulationExpectedTourMileage { get; set; }
		/// <summary>
		/// 예약가능일
		/// </summary>
		[Column("예약가능일")]
		public string BookingPossibleDate { get; set; }
		/// <summary>
		/// 영업보증
		/// </summary>
		[Column("영업보증")]
		public string BusinessGuarantee { get; set; }
		/// <summary>
		/// 여행자보험가입여부
		/// </summary>
		[Column("여행자보험가입여부")]
		public string TravelerInsuranceSignUpOrNot { get; set; }
		/// <summary>
		/// 여행자보험계약금액
		/// </summary>
		[Column("여행자보험계약금액")]
		public string TravelerInsuranceContractAmount { get; set; }
		/// <summary>
		/// 인솔자사번
		/// </summary>
		[Column("인솔자사번")]
		public string LeaderEmployeeIdentifiedNumber { get; set; }
		/// <summary>
		/// 인솔자성명
		/// </summary>
		[Column("인솔자성명")]
		public string LeaderName { get; set; }
		/// <summary>
		/// 인솔자성별
		/// </summary>
		[Column("인솔자성별")]
		public string LeaderGender { get; set; }
		/// <summary>
		/// 인솔자경력
		/// </summary>
		[Column("인솔자경력")]
		public int LeaderExperience { get; set; }
		/// <summary>
		/// 인솔자출장경력
		/// </summary>
		[Column("인솔자출장경력")]
		public string LeaderBusinessTripExperience { get; set; }
		/// <summary>
		/// 인솔자자격사항
		/// </summary>
		[Column("인솔자자격사항")]
		public string LeaderQualificationItem { get; set; }
		/// <summary>
		/// 인솔자본인소개
		/// </summary>
		[Column("인솔자본인소개")]
		public string LeaderSelfIntroduction { get; set; }
		/// <summary>
		/// 인솔자사진노출여부
		/// </summary>
		[Column("인솔자사진노출여부")]
		public string LeaderPictureDisplayOrNot { get; set; }
		/// <summary>
		/// 인솔자개인정보공개동의
		/// </summary>
		[Column("인솔자개인정보공개동의")]
		public string LeaderPersonalInfoReleaseAgree { get; set; }
		/// <summary>
		/// 일정버전
		/// </summary>
		[Column("일정버전")]
		public double ScheduleVersion { get; set; }
		/// <summary>
		/// 다른버전보기가능여부
		/// </summary>
		[Column("다른버전보기가능여부")]
		public int OtherVersionSeeingPossibleOrNot { get; set; }
		/// <summary>
		/// 담당부서명
		/// </summary>
		[Column("담당부서명")]
		public string ResponsibilityDepartmentName { get; set; }
		/// <summary>
		/// 키워드
		/// </summary>
		[Column("키워드")]
		public string Keyword { get; set; }
		/// <summary>
		/// 센딩여부
		/// </summary>
		[Column("센딩여부")]
		public string SendingOrNot { get; set; }
	}
}