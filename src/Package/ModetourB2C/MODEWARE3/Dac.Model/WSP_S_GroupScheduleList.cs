namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_단체일정리스트
/// </summary>
public class WSP_S_GroupScheduleList
{
	public const string SP_NAME = "WSP_S_단체일정리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Description("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
	}

	public class Result1 : IDbResult
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
		/// 보유좌석
		/// </summary>
		[Column("보유좌석")]
		public int HoldingSeat { get; set; }
		/// <summary>
		/// 재고번호
		/// </summary>
		[Column("재고번호")]
		public int StockNumber { get; set; }
		/// <summary>
		/// 일정번호
		/// </summary>
		[Column("일정번호")]
		public int ScheduleNumber { get; set; }
		/// <summary>
		/// 일정명
		/// </summary>
		[Column("일정명")]
		public string ScheduleName { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public string ArrivalDate { get; set; }
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
		/// 순번
		/// </summary>
		[Column("순번")]
		public int Order { get; set; }
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
		/// 상품가_어른
		/// </summary>
		[Column("상품가_어른")]
		public long ProductPrice_Adult { get; set; }
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
		/// 판매가_랜드
		/// </summary>
		[Column("판매가_랜드")]
		public long SellingPrice_Land { get; set; }
		/// <summary>
		/// 추가요금_TAX
		/// </summary>
		[Column("추가요금_TAX")]
		public long AddFare_TAX { get; set; }
		/// <summary>
		/// 추가요금_기타
		/// </summary>
		[Column("추가요금_기타")]
		public long AddFare_Other { get; set; }
		/// <summary>
		/// 추가요금_기타비고
		/// </summary>
		[Column("추가요금_기타비고")]
		public string AddFare_OtherNote { get; set; }
		/// <summary>
		/// 제한수수료율
		/// </summary>
		[Column("제한수수료율")]
		public decimal LimitFeeRate { get; set; }
		/// <summary>
		/// 판매가_신부
		/// </summary>
		[Column("판매가_신부")]
		public long SellingPrice_Bride { get; set; }
		/// <summary>
		/// 지상원가
		/// </summary>
		[Column("지상원가")]
		public long LocalOriginalPrice { get; set; }
		/// <summary>
		/// 판매마감
		/// </summary>
		[Column("판매마감")]
		public string SalesEnd { get; set; }
		/// <summary>
		/// 제휴여부
		/// </summary>
		[Column("제휴여부")]
		public string AffiliateOrNot { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public string RegisterDate { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public string Registerer { get; set; }
		/// <summary>
		/// 수정일
		/// </summary>
		[Column("수정일")]
		public string EditionDate { get; set; }
		/// <summary>
		/// 수정자
		/// </summary>
		[Column("수정자")]
		public string Editor { get; set; }
		/// <summary>
		/// 취소일
		/// </summary>
		[Column("취소일")]
		public string CancelDate { get; set; }
		/// <summary>
		/// 취소자
		/// </summary>
		[Column("취소자")]
		public string CancelPerson { get; set; }
		/// <summary>
		/// 정산상태
		/// </summary>
		[Column("정산상태")]
		public string SettlementState { get; set; }
		/// <summary>
		/// 정산마감일
		/// </summary>
		[Column("정산마감일")]
		public string SettlementEndDate { get; set; }
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
		/// 인솔자확정
		/// </summary>
		[Column("인솔자확정")]
		public string LeaderConfirm { get; set; }
		/// <summary>
		/// 여행기간
		/// </summary>
		[Column("여행기간")]
		public string TravelPeriod { get; set; }
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
		/// 미팅장소
		/// </summary>
		[Column("미팅장소")]
		public string MeetingPlace { get; set; }
		/// <summary>
		/// 미팅시간
		/// </summary>
		[Column("미팅시간")]
		public string MeetingTime { get; set; }
		/// <summary>
		/// 간략일정
		/// </summary>
		[Column("간략일정")]
		public string BriefSchedule { get; set; }
		/// <summary>
		/// 결재TL
		/// </summary>
		[Column("결재TL")]
		public string Approval_TL { get; set; }
		/// <summary>
		/// 여행자보험
		/// </summary>
		[Column("여행자보험")]
		public string TravelerInsurance { get; set; }
		/// <summary>
		/// 비자피
		/// </summary>
		[Column("비자피")]
		public string VisaFee { get; set; }
		/// <summary>
		/// 여권발급비
		/// </summary>
		[Column("여권발급비")]
		public string PassportIssuanceFee { get; set; }
		/// <summary>
		/// 현지안내원
		/// </summary>
		[Column("현지안내원")]
		public string LocalGuide { get; set; }
		/// <summary>
		/// 인천공항세
		/// </summary>
		[Column("인천공항세")]
		public string IncheonAirpotTax { get; set; }
		/// <summary>
		/// 관진금
		/// </summary>
		[Column("관진금")]
		public string GovernmentDeposit { get; set; }
		/// <summary>
		/// 전쟁보험료
		/// </summary>
		[Column("전쟁보험료")]
		public string WarInsuranceFee { get; set; }
		/// <summary>
		/// 유류할증료
		/// </summary>
		[Column("유류할증료")]
		public string FuelSurchargeFee { get; set; }
		/// <summary>
		/// 현지공항세
		/// </summary>
		[Column("현지공항세")]
		public string LocalAirportTax { get; set; }
		/// <summary>
		/// 공동경비
		/// </summary>
		[Column("공동경비")]
		public string JointExpense { get; set; }
		/// <summary>
		/// 관광지입장료
		/// </summary>
		[Column("관광지입장료")]
		public string SightseeingSpotEntranceFee { get; set; }
		/// <summary>
		/// 쇼핑여부
		/// </summary>
		[Column("쇼핑여부")]
		public string ShoppingOrNot { get; set; }
		/// <summary>
		/// 인솔자동행
		/// </summary>
		[Column("인솔자동행")]
		public string LeaderAccompany { get; set; }
		/// <summary>
		/// 이인일실
		/// </summary>
		[Column("이인일실")]
		public string TwoPersonOneRoom { get; set; }
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
		/// 쇼핑비고
		/// </summary>
		[Column("쇼핑비고")]
		public string ShoppingNote { get; set; }
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
		/// 안내원동행인원
		/// </summary>
		[Column("안내원동행인원")]
		public int GuideAccompanyNumberOfPeople { get; set; }
		/// <summary>
		/// 항공비고
		/// </summary>
		[Column("항공비고")]
		public string FlightNote { get; set; }
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
		/// NameTL
		/// </summary>
		[Column("NameTL")]
		public string NameTL { get; set; }
		/// <summary>
		/// 발권TL
		/// </summary>
		[Column("발권TL")]
		public string TicketIssuance_TL { get; set; }
		/// <summary>
		/// 재고보유좌석수
		/// </summary>
		[Column("재고보유좌석수")]
		public int StockHoldingSeatNumber { get; set; }
		/// <summary>
		/// 공유
		/// </summary>
		[Column("공유")]
		public string Sharing { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 예약좌석수
		/// </summary>
		[Column("예약좌석수")]
		public int BookingSeatNumber { get; set; }
		/// <summary>
		/// 연합
		/// </summary>
		[Column("연합")]
		public string Combination { get; set; }
		/// <summary>
		/// 연합모객
		/// </summary>
		[Column("연합모객")]
		public int CombinationAudience { get; set; }
		/// <summary>
		/// 재고타입
		/// </summary>
		[Column("재고타입")]
		public string StockType { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 공제
		/// </summary>
		[Column("공제")]
		public string Deduction { get; set; }
		/// <summary>
		/// 영업보증
		/// </summary>
		[Column("영업보증")]
		public string BusinessGuarantee { get; set; }
		/// <summary>
		/// 예치금
		/// </summary>
		[Column("예치금")]
		public string DepositMoney { get; set; }
		/// <summary>
		/// 보험가입계약금액
		/// </summary>
		[Column("보험가입계약금액")]
		public string InsuranceSignUpContractAmount { get; set; }
		/// <summary>
		/// 여행자보험가입여부
		/// </summary>
		[Column("여행자보험가입여부")]
		public string TravelerInsuranceSignUpOrNot { get; set; }
		/// <summary>
		/// 여행자보험회사
		/// </summary>
		[Column("여행자보험회사")]
		public string TravelerInsuranceCompany { get; set; }
		/// <summary>
		/// 여행자보험계약금액
		/// </summary>
		[Column("여행자보험계약금액")]
		public string TravelerInsuranceContractAmount { get; set; }
		/// <summary>
		/// 항공기
		/// </summary>
		[Column("항공기")]
		public string Airplane { get; set; }
		/// <summary>
		/// 항공기등급
		/// </summary>
		[Column("항공기등급")]
		public string AirplaneClass { get; set; }
		/// <summary>
		/// 기차
		/// </summary>
		[Column("기차")]
		public string Train { get; set; }
		/// <summary>
		/// 기차등급
		/// </summary>
		[Column("기차등급")]
		public string TrainClass { get; set; }
		/// <summary>
		/// 선박
		/// </summary>
		[Column("선박")]
		public string Shipping { get; set; }
		/// <summary>
		/// 선박등급
		/// </summary>
		[Column("선박등급")]
		public string ShippingClass { get; set; }
		/// <summary>
		/// 기타교통
		/// </summary>
		[Column("기타교통")]
		public string OtherTransportation { get; set; }
		/// <summary>
		/// 기타교통등급
		/// </summary>
		[Column("기타교통등급")]
		public string OtherTransportationClass { get; set; }
		/// <summary>
		/// 숙박시설
		/// </summary>
		[Column("숙박시설")]
		public string LogmentFacilities { get; set; }
		/// <summary>
		/// 숙박시설등급
		/// </summary>
		[Column("숙박시설등급")]
		public string LogmentFacilitiesClass { get; set; }
		/// <summary>
		/// 투숙인원
		/// </summary>
		[Column("투숙인원")]
		public byte NumberOfStayingPeople { get; set; }
		/// <summary>
		/// 인솔자
		/// </summary>
		[Column("인솔자")]
		public string Leader { get; set; }
		/// <summary>
		/// 안내원
		/// </summary>
		[Column("안내원")]
		public string Guide { get; set; }
		/// <summary>
		/// 현지여행사
		/// </summary>
		[Column("현지여행사")]
		public string LocalTravelCompany { get; set; }
		/// <summary>
		/// 현지교통1
		/// </summary>
		[Column("현지교통1")]
		public string LocalTransportation1 { get; set; }
		/// <summary>
		/// 현지교통승차인원
		/// </summary>
		[Column("현지교통승차인원")]
		public byte LocalTransportationNumberOfPassengers { get; set; }
		/// <summary>
		/// 현지교통2
		/// </summary>
		[Column("현지교통2")]
		public string LocalTransportation2 { get; set; }
		/// <summary>
		/// 현지교통3
		/// </summary>
		[Column("현지교통3")]
		public string LocalTransportation3 { get; set; }
		/// <summary>
		/// 교통운임
		/// </summary>
		[Column("교통운임")]
		public string TransportationFare { get; set; }
		/// <summary>
		/// 숙박식사료
		/// </summary>
		[Column("숙박식사료")]
		public string LogmentMealCost { get; set; }
		/// <summary>
		/// 안내자경비
		/// </summary>
		[Column("안내자경비")]
		public string GuideExpense { get; set; }
		/// <summary>
		/// 공항항만세
		/// </summary>
		[Column("공항항만세")]
		public string AirportDutyFree { get; set; }
		/// <summary>
		/// 관광기금
		/// </summary>
		[Column("관광기금")]
		public string SightseeingFund { get; set; }
		/// <summary>
		/// 제세금
		/// </summary>
		[Column("제세금")]
		public string Tax { get; set; }
		/// <summary>
		/// 입장료
		/// </summary>
		[Column("입장료")]
		public string EntranceFee { get; set; }
		/// <summary>
		/// 여권발급비
		/// </summary>
		[Column("여권발급비")]
		public string PassportIssuanceFee { get; set; }
		/// <summary>
		/// 비자발급비
		/// </summary>
		[Column("비자발급비")]
		public string VisaIssuanceFee { get; set; }
		/// <summary>
		/// 봉사료
		/// </summary>
		[Column("봉사료")]
		public string CharityFee { get; set; }
		/// <summary>
		/// 포터비
		/// </summary>
		[Column("포터비")]
		public string PorterFee { get; set; }
		/// <summary>
		/// 쇼핑
		/// </summary>
		[Column("쇼핑")]
		public string Shopping { get; set; }
		/// <summary>
		/// 선택관광
		/// </summary>
		[Column("선택관광")]
		public string SelectSightseeing { get; set; }
		/// <summary>
		/// 기타
		/// </summary>
		[Column("기타")]
		public string Other { get; set; }
		/// <summary>
		/// 기타내용
		/// </summary>
		[Column("기타내용")]
		public string OtherContent { get; set; }
		/// <summary>
		/// 여권발급료
		/// </summary>
		[Column("여권발급료")]
		public long PassportIssuanceFee2 { get; set; }
		/// <summary>
		/// 비자발급료
		/// </summary>
		[Column("비자발급료")]
		public long VisaIssuanceFee2 { get; set; }
	}
}