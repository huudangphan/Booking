namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_공동구매항공권_예약리스트
/// </summary>
public class WSP_S_CMN_GroupReservationFlightTicket_ReservationList
{
	public const string SP_NAME = "WSP_S_CMN_공동구매항공권_예약리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 업체주문번호
		/// </summary>
		[Description("업체주문번호")]
		public string CompanyOrderNumber { get; set; }
		/// <summary>
		/// 수정일시작
		/// </summary>
		[Description("수정일시작")]
		public DateTime EditionDateStart { get; set; }
		/// <summary>
		/// 수정일끝
		/// </summary>
		[Description("수정일끝")]
		public DateTime EditionDateEnd { get; set; }
		/// <summary>
		/// IP
		/// </summary>
		[Description("IP")]
		public string IP { get; set; }
		/// <summary>
		/// APP
		/// </summary>
		[Description("APP")]
		public string APP { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 모두투어예약번호
		/// </summary>
		[Column("모두투어예약번호")]
		public int MODETOURBookingNumber { get; set; }
		/// <summary>
		/// 주문외부아이디
		/// </summary>
		[Column("주문외부아이디")]
		public string OrderExternalID { get; set; }
		/// <summary>
		/// 대기여부
		/// </summary>
		[Column("대기여부")]
		public string WaitingOrNot { get; set; }
		/// <summary>
		/// 입금상태
		/// </summary>
		[Column("입금상태")]
		public string DepositState { get; set; }
		/// <summary>
		/// 발권완료여부
		/// </summary>
		[Column("발권완료여부")]
		public string TicketIssuanceFinishOrNot { get; set; }
	}

	public class Result2 : IDbResult
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

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 매체별수납액
		/// </summary>
		[Column("매체별수납액")]
		public long EachMediaReceiptAmount { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// 수납일
		/// </summary>
		[Column("수납일")]
		public DateTime ReceiptDate { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 주문수납내역번호
		/// </summary>
		[Column("주문수납내역번호")]
		public int OrderReceiptHistoryNumber { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 결재
		/// </summary>
		[Column("결재")]
		public string Approval { get; set; }
		/// <summary>
		/// 카드사
		/// </summary>
		[Column("카드사")]
		public string CardCompany { get; set; }
		/// <summary>
		/// 수납액
		/// </summary>
		[Column("수납액")]
		public long ReceiptAmount { get; set; }
		/// <summary>
		/// 공급가액
		/// </summary>
		[Column("공급가액")]
		public long SupplyValue { get; set; }
		/// <summary>
		/// 수납비고
		/// </summary>
		[Column("수납비고")]
		public string ReceiptNote { get; set; }
		/// <summary>
		/// 현금영수증발행
		/// </summary>
		[Column("현금영수증발행")]
		public string CashReceiptPublish { get; set; }
		/// <summary>
		/// POS통장수납번호
		/// </summary>
		[Column("POS통장수납번호")]
		public int POS_BankbookReceiptNumber { get; set; }
		/// <summary>
		/// 통장번호
		/// </summary>
		[Column("통장번호")]
		public string BankbookNumber { get; set; }
		/// <summary>
		/// 분개번호
		/// </summary>
		[Column("분개번호")]
		public int DivertedNumber { get; set; }
		/// <summary>
		/// 거래번호
		/// </summary>
		[Column("거래번호")]
		public string TransactionNumber { get; set; }
		/// <summary>
		/// 승인아이디
		/// </summary>
		[Column("승인아이디")]
		public string ApprovalID { get; set; }
		/// <summary>
		/// 수납번호
		/// </summary>
		[Column("수납번호")]
		public int ReceiptNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public string RegisterDate { get; set; }
		/// <summary>
		/// 등록자번호
		/// </summary>
		[Column("등록자번호")]
		public int RegistererNumber { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public string Registerer { get; set; }
		/// <summary>
		/// 웹노출수납유형
		/// </summary>
		[Column("웹노출수납유형")]
		public string WebDisplayReceiptType { get; set; }
		/// <summary>
		/// 수납유형코드명
		/// </summary>
		[Column("수납유형코드명")]
		public string ReceiptTypeCodeName { get; set; }
		/// <summary>
		/// 수납유형코드
		/// </summary>
		[Column("수납유형코드")]
		public string ReceiptTypeCode { get; set; }
		/// <summary>
		/// 수납유형
		/// </summary>
		[Column("수납유형")]
		public string ReceiptType { get; set; }
		/// <summary>
		/// 입출금구분코드
		/// </summary>
		[Column("입출금구분코드")]
		public string InOutMoneyClassificationCode { get; set; }
		/// <summary>
		/// 승인날짜
		/// </summary>
		[Column("승인날짜")]
		public DateTime ApprovalDate { get; set; }
		/// <summary>
		/// 통장조정여부
		/// </summary>
		[Column("통장조정여부")]
		public string BankbookAdjustmentOrNot { get; set; }
		/// <summary>
		/// 수납일
		/// </summary>
		[Column("수납일")]
		public DateTime ReceiptDate { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 가상계좌번호
		/// </summary>
		[Column("가상계좌번호")]
		public string VirtualAccountNumber { get; set; }
		/// <summary>
		/// 가상계좌구분
		/// </summary>
		[Column("가상계좌구분")]
		public string VirtualAccountClassification { get; set; }
		/// <summary>
		/// 가상계좌구분한글명
		/// </summary>
		[Column("가상계좌구분한글명")]
		public string VirtualAccountClassificationKoreanName { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// 주문일
		/// </summary>
		[Column("주문일")]
		public DateTime OrderDate { get; set; }
		/// <summary>
		/// GROSS
		/// </summary>
		[Column("GROSS")]
		public long GROSS { get; set; }
		/// <summary>
		/// DISPLAY차액
		/// </summary>
		[Column("DISPLAY차액")]
		public long DISPLAY_Difference { get; set; }
		/// <summary>
		/// CHARGE
		/// </summary>
		[Column("CHARGE")]
		public long CHARGE { get; set; }
		/// <summary>
		/// TAX
		/// </summary>
		[Column("TAX")]
		public long TAX { get; set; }
		/// <summary>
		/// TAX2
		/// </summary>
		[Column("TAX2")]
		public int TAX2 { get; set; }
		/// <summary>
		/// 비자비용
		/// </summary>
		[Column("비자비용")]
		public long VisaExpense { get; set; }
		/// <summary>
		/// 서비스비용
		/// </summary>
		[Column("서비스비용")]
		public long ServiceExpense { get; set; }
		/// <summary>
		/// 총여행경비
		/// </summary>
		[Column("총여행경비")]
		public long TotalTravelExpense { get; set; }
		/// <summary>
		/// 완납입금일
		/// </summary>
		[Column("완납입금일")]
		public DateTime FullPaymentDepositDate { get; set; }
		/// <summary>
		/// 수납액
		/// </summary>
		[Column("수납액")]
		public long ReceiptAmount { get; set; }
		/// <summary>
		/// COMM
		/// </summary>
		[Column("COMM")]
		public long COMM { get; set; }
		/// <summary>
		/// 가격노출
		/// </summary>
		[Column("가격노출")]
		public string PriceDisplay { get; set; }
		/// <summary>
		/// 신청금입금일
		/// </summary>
		[Column("신청금입금일")]
		public DateTime RequestMoneyDepositDate { get; set; }
		/// <summary>
		/// 판매거래처
		/// </summary>
		[Column("판매거래처")]
		public int SalesCustomer { get; set; }
		/// <summary>
		/// 총액
		/// </summary>
		[Column("총액")]
		public long TotalAmount { get; set; }
		/// <summary>
		/// 변동총액
		/// </summary>
		[Column("변동총액")]
		public long FluctuateTotalAmount { get; set; }
		/// <summary>
		/// 유료센딩고객통화여부
		/// </summary>
		[Column("유료센딩고객통화여부")]
		public string FeeChargedSendingCustomerCallOrNot { get; set; }
		/// <summary>
		/// 유료센딩출발편명
		/// </summary>
		[Column("유료센딩출발편명")]
		public string FeeChargedSendingDepartureFlightName { get; set; }
		/// <summary>
		/// 유료센딩출발시간
		/// </summary>
		[Column("유료센딩출발시간")]
		public string FeeChargedSendingDepartureTime { get; set; }
		/// <summary>
		/// 유료센딩센딩담당
		/// </summary>
		[Column("유료센딩센딩담당")]
		public int FeeChargedSendingSendingResponsibility { get; set; }
		/// <summary>
		/// 결재TL_공동구매항공권
		/// </summary>
		[Column("결재TL_공동구매항공권")]
		public DateTime Approval_TL_GroupBookingTicket { get; set; }
		/// <summary>
		/// 출발후입금가능
		/// </summary>
		[Column("출발후입금가능")]
		public string AfterDepartureDepositPossible { get; set; }
		/// <summary>
		/// 대기여부
		/// </summary>
		[Column("대기여부")]
		public string WaitingOrNot { get; set; }
		/// <summary>
		/// 품목코드
		/// </summary>
		[Column("품목코드")]
		public string ProductListCode { get; set; }
		/// <summary>
		/// 여행계약서_기준금액분류
		/// </summary>
		[Column("여행계약서_기준금액분류")]
		public string TravelContract_StandardAmountClassification { get; set; }
		/// <summary>
		/// 여행계약서_기준금액_판매가
		/// </summary>
		[Column("여행계약서_기준금액_판매가")]
		public long TravelContract_StandardAmount_SellingPrice { get; set; }
		/// <summary>
		/// 여행계약서_기준금액_총액
		/// </summary>
		[Column("여행계약서_기준금액_총액")]
		public long TravelContract_StandardAmount_TotalAmount { get; set; }
		/// <summary>
		/// 카드승인제한여부
		/// </summary>
		[Column("카드승인제한여부")]
		public string CardApprovalLimitOrNot { get; set; }
		/// <summary>
		/// 입금상태
		/// </summary>
		[Column("입금상태")]
		public string DepositState { get; set; }
		/// <summary>
		/// 예약상태취소여부
		/// </summary>
		[Column("예약상태취소여부")]
		public string BookingStateCancelOrNot { get; set; }
		/// <summary>
		/// 미수유예승인
		/// </summary>
		[Column("미수유예승인")]
		public string UnpayedDelayApproval { get; set; }
		/// <summary>
		/// 일인당유류제세공과금
		/// </summary>
		[Column("일인당유류제세공과금")]
		public long EachSingleFeeChargedPublicFacilitiesTax { get; set; }
		/// <summary>
		/// 일인당유류제세공과금FOC
		/// </summary>
		[Column("일인당유류제세공과금FOC")]
		public long EachSingleFeeChargedPublicFacilitiesTax_FOC { get; set; }
		/// <summary>
		/// 유류제세공과금합산
		/// </summary>
		[Column("유류제세공과금합산")]
		public long FeeChargedPublicFacilitiesTaxSum { get; set; }
		/// <summary>
		/// 유류제세공과금합산FOC
		/// </summary>
		[Column("유류제세공과금합산FOC")]
		public long FeeChargedPublicFacilitiesTaxSum_FOC { get; set; }
		/// <summary>
		/// 일반인원
		/// </summary>
		[Column("일반인원")]
		public int NormalNumberOfPeople { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 구매수단코드
		/// </summary>
		[Column("구매수단코드")]
		public string BuyMethodCode { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// 예약자명
		/// </summary>
		[Column("예약자명")]
		public string BookerName { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 집전화
		/// </summary>
		[Column("집전화")]
		public string HomePhone { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 주민번호체크
		/// </summary>
		[Column("주민번호체크")]
		public string CitizenIDNumberCheck { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Column("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 예약자번호
		/// </summary>
		[Column("예약자번호")]
		public int BookerNumber { get; set; }
		/// <summary>
		/// 네이버ID
		/// </summary>
		[Column("네이버ID")]
		public string Naver_ID { get; set; }
	}

	public class Result8 : IDbResult
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Column("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// CHK_주민번호
		/// </summary>
		[Column("CHK_주민번호")]
		public string CHK_CitizenIDNumber { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Column("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 성별코드
		/// </summary>
		[Column("성별코드")]
		public string GenderCode { get; set; }
		/// <summary>
		/// 예약상태
		/// </summary>
		[Column("예약상태")]
		public string BookingState { get; set; }
		/// <summary>
		/// 내부결제가능
		/// </summary>
		[Column("내부결제가능")]
		public string InternalPaymentPossible { get; set; }
		/// <summary>
		/// 고객요청사항
		/// </summary>
		[Column("고객요청사항")]
		public string CustomerRequest { get; set; }
		/// <summary>
		/// 주민번호체크
		/// </summary>
		[Column("주민번호체크")]
		public string CitizenIDNumberCheck { get; set; }
		/// <summary>
		/// MT_NO
		/// </summary>
		[Column("MT_NO")]
		public string MT_NO { get; set; }
		/// <summary>
		/// 판매가
		/// </summary>
		[Column("판매가")]
		public long SellingPrice { get; set; }
		/// <summary>
		/// 여권유무
		/// </summary>
		[Column("여권유무")]
		public string PassportOrNot { get; set; }
		/// <summary>
		/// 여권번호
		/// </summary>
		[Column("여권번호")]
		public string PassportNumber { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Column("여권만료일")]
		public string PassportExpirationDate { get; set; }
		/// <summary>
		/// 여권코드
		/// </summary>
		[Column("여권코드")]
		public string PassportCode { get; set; }
		/// <summary>
		/// 판매종류코드
		/// </summary>
		[Column("판매종류코드")]
		public string SalesTypeCode { get; set; }
		/// <summary>
		/// 예약상태코드
		/// </summary>
		[Column("예약상태코드")]
		public string BookingStateCode { get; set; }
		/// <summary>
		/// 주문상태코드
		/// </summary>
		[Column("주문상태코드")]
		public string OrderStateCode { get; set; }
		/// <summary>
		/// 구매수단코드
		/// </summary>
		[Column("구매수단코드")]
		public string BuyMethodCode { get; set; }
		/// <summary>
		/// 판매일
		/// </summary>
		[Column("판매일")]
		public DateTime SalesDate { get; set; }
		/// <summary>
		/// 연락처체크
		/// </summary>
		[Column("연락처체크")]
		public string ContactCheck { get; set; }
		/// <summary>
		/// 집전화
		/// </summary>
		[Column("집전화")]
		public string HomePhone { get; set; }
		/// <summary>
		/// 휴대폰체크
		/// </summary>
		[Column("휴대폰체크")]
		public string PhoneCheck { get; set; }
		/// <summary>
		/// 이메일체크
		/// </summary>
		[Column("이메일체크")]
		public string EmailCheck { get; set; }
		/// <summary>
		/// 미국비자
		/// </summary>
		[Column("미국비자")]
		public string AmericaVisa { get; set; }
		/// <summary>
		/// 중국비자
		/// </summary>
		[Column("중국비자")]
		public string ChinaVisa { get; set; }
		/// <summary>
		/// 커미션금액
		/// </summary>
		[Column("커미션금액")]
		public long CommissionAmount { get; set; }
		/// <summary>
		/// 순수판매
		/// </summary>
		[Column("순수판매")]
		public long PureSales { get; set; }
		/// <summary>
		/// 판매비고
		/// </summary>
		[Column("판매비고")]
		public string SalesNote { get; set; }
		/// <summary>
		/// 추가판매
		/// </summary>
		[Column("추가판매")]
		public long AddSales { get; set; }
		/// <summary>
		/// 유류할증료
		/// </summary>
		[Column("유류할증료")]
		public long FuelSurchargeFee { get; set; }
		/// <summary>
		/// 제세공과금
		/// </summary>
		[Column("제세공과금")]
		public int PublicFacilitiesTax { get; set; }
		/// <summary>
		/// 비자비용
		/// </summary>
		[Column("비자비용")]
		public long VisaExpense { get; set; }
		/// <summary>
		/// 서비스비용
		/// </summary>
		[Column("서비스비용")]
		public long ServiceExpense { get; set; }
		/// <summary>
		/// 대기예약
		/// </summary>
		[Column("대기예약")]
		public string WaitingBooking { get; set; }
		/// <summary>
		/// 개인정보수집동의
		/// </summary>
		[Column("개인정보수집동의")]
		public string PersonalInfoCollectionAgree { get; set; }
		/// <summary>
		/// 개인정보제3자제공동의
		/// </summary>
		[Column("개인정보제3자제공동의")]
		public string PersonalInfo3rdPartyProvisionAgree { get; set; }
		/// <summary>
		/// 개인정보위탁동의
		/// </summary>
		[Column("개인정보위탁동의")]
		public string PersonalInfoConsignAgree { get; set; }
		/// <summary>
		/// 여행계약서확인
		/// </summary>
		[Column("여행계약서확인")]
		public string TravelContractConfirm { get; set; }
		/// <summary>
		/// 개인정보동의확인
		/// </summary>
		[Column("개인정보동의확인")]
		public string PersonalInfoAgreeConfirm { get; set; }
		/// <summary>
		/// 해외여행약관확인
		/// </summary>
		[Column("해외여행약관확인")]
		public string OverseaTravelTermsConfirm { get; set; }
		/// <summary>
		/// 이용기간및보유기간
		/// </summary>
		[Column("이용기간및보유기간")]
		public string UsePeriodAndHoldingPeriod { get; set; }
		/// <summary>
		/// 여권파일명
		/// </summary>
		[Column("여권파일명")]
		public string PassportFileName { get; set; }
		/// <summary>
		/// 여권파일명_뒷면
		/// </summary>
		[Column("여권파일명_뒷면")]
		public string PassportFileName_Backside { get; set; }
		/// <summary>
		/// 여권확인여부
		/// </summary>
		[Column("여권확인여부")]
		public string PassportConfirmOrNot { get; set; }
		/// <summary>
		/// 여행자PTID
		/// </summary>
		[Column("여행자PTID")]
		public int Traveler_PTID { get; set; }
		/// <summary>
		/// 판매종류
		/// </summary>
		[Column("판매종류")]
		public string SalesType { get; set; }
		/// <summary>
		/// 커미션율
		/// </summary>
		[Column("커미션율")]
		public long CommisionRate { get; set; }
		/// <summary>
		/// 여행계약서동의날짜
		/// </summary>
		[Column("여행계약서동의날짜")]
		public string TravelContractAgreeDate { get; set; }
		/// <summary>
		/// 개인정보동의날짜
		/// </summary>
		[Column("개인정보동의날짜")]
		public string PersonalInfoAgreeDate { get; set; }
		/// <summary>
		/// FOC
		/// </summary>
		[Column("FOC")]
		public string FOC { get; set; }
		/// <summary>
		/// 상품팀에게요청
		/// </summary>
		[Column("상품팀에게요청")]
		public string RequestToProductTeam { get; set; }
		/// <summary>
		/// CRS에서요청
		/// </summary>
		[Column("CRS에서요청")]
		public string RequestFrom_CRS { get; set; }
		/// <summary>
		/// LAND에게요청
		/// </summary>
		[Column("LAND에게요청")]
		public string RequestTo_LAND { get; set; }
		/// <summary>
		/// CHARGE비고
		/// </summary>
		[Column("CHARGE비고")]
		public string CHARGE_Note { get; set; }
		/// <summary>
		/// 적립예상투어마일리지
		/// </summary>
		[Column("적립예상투어마일리지")]
		public int AccumulationExpectedTourMileage { get; set; }
		/// <summary>
		/// 계약대표자
		/// </summary>
		[Column("계약대표자")]
		public string ContractRepresentative { get; set; }
		/// <summary>
		/// 마일리지적립요청
		/// </summary>
		[Column("마일리지적립요청")]
		public string MileageAccumulationRequest { get; set; }
		/// <summary>
		/// 취소일
		/// </summary>
		[Column("취소일")]
		public DateTime CancelDate { get; set; }
		/// <summary>
		/// 판매가구분
		/// </summary>
		[Column("판매가구분")]
		public string SellingPriceClassification { get; set; }
		/// <summary>
		/// 여권만료일1
		/// </summary>
		[Column("여권만료일1")]
		public DateTime PassportExpirationDate1 { get; set; }
		/// <summary>
		/// 티켓번호
		/// </summary>
		[Column("티켓번호")]
		public string TicketNumber { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 수정일
		/// </summary>
		[Column("수정일")]
		public DateTime EditionDate { get; set; }
		/// <summary>
		/// PNR
		/// </summary>
		[Column("PNR")]
		public string PNR { get; set; }
		/// <summary>
		/// 발권
		/// </summary>
		[Column("발권")]
		public string TicketIssuance { get; set; }
		/// <summary>
		/// 발권예정일
		/// </summary>
		[Column("발권예정일")]
		public DateTime TicketIssuanceExpectationDate { get; set; }
		/// <summary>
		/// 센딩구분
		/// </summary>
		[Column("센딩구분")]
		public int SendingClassification { get; set; }
	}

	public class Result9 : IDbResult
	{
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
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
		/// 출발편명
		/// </summary>
		[Column("출발편명")]
		public string DepartureFlightName { get; set; }
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
		/// 도착편명
		/// </summary>
		[Column("도착편명")]
		public string ArrivalFlightName { get; set; }
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
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
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
		/// 보유좌석
		/// </summary>
		[Column("보유좌석")]
		public int HoldingSeat { get; set; }
		/// <summary>
		/// 예약좌석
		/// </summary>
		[Column("예약좌석")]
		public int BookingSeat { get; set; }
		/// <summary>
		/// 단체구분
		/// </summary>
		[Column("단체구분")]
		public string GroupClassification { get; set; }
		/// <summary>
		/// 단체구분코드
		/// </summary>
		[Column("단체구분코드")]
		public string GroupClassificationCode { get; set; }
		/// <summary>
		/// 상품분류
		/// </summary>
		[Column("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// 잔여좌석
		/// </summary>
		[Column("잔여좌석")]
		public int AvailableSeat { get; set; }
		/// <summary>
		/// 제휴업체단체번호1
		/// </summary>
		[Column("제휴업체단체번호1")]
		public string AffiliateCompanyGroupNumber1 { get; set; }
		/// <summary>
		/// 기준커미션율
		/// </summary>
		[Column("기준커미션율")]
		public decimal StandardCommisionRate { get; set; }
		/// <summary>
		/// 재고번호
		/// </summary>
		[Column("재고번호")]
		public int StockNumber { get; set; }
		/// <summary>
		/// 취소기준일
		/// </summary>
		[Column("취소기준일")]
		public DateTime CancelStandardDate { get; set; }
		/// <summary>
		/// 인센티브여부
		/// </summary>
		[Column("인센티브여부")]
		public string IncentiveOrNot { get; set; }
		/// <summary>
		/// 도착도시
		/// </summary>
		[Column("도착도시")]
		public string ArrivalCity { get; set; }
		/// <summary>
		/// 적립예상투어마일리지
		/// </summary>
		[Column("적립예상투어마일리지")]
		public int AccumulationExpectedTourMileage { get; set; }
		/// <summary>
		/// 단체분류
		/// </summary>
		[Column("단체분류")]
		public string GroupClassification2 { get; set; }
		/// <summary>
		/// 접두어
		/// </summary>
		[Column("접두어")]
		public string Prefix { get; set; }
		/// <summary>
		/// 랜드사
		/// </summary>
		[Column("랜드사")]
		public string LandCompany { get; set; }
		/// <summary>
		/// 정산상태코드
		/// </summary>
		[Column("정산상태코드")]
		public string SettlementStateCode { get; set; }
		/// <summary>
		/// 상품코드2
		/// </summary>
		[Column("상품코드2")]
		public string ProductCode2 { get; set; }
		/// <summary>
		/// 인솔자
		/// </summary>
		[Column("인솔자")]
		public string Leader { get; set; }
		/// <summary>
		/// 출발편_도착일자
		/// </summary>
		[Column("출발편_도착일자")]
		public string DepartureFlight_ArrivalDate { get; set; }
		/// <summary>
		/// 귀국편_출발일자
		/// </summary>
		[Column("귀국편_출발일자")]
		public string ReturnToHomelandFlight_DepartureDate { get; set; }
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
		/// 제세공과금_소아N
		/// </summary>
		[Column("제세공과금_소아N")]
		public long PublicFacilitiesTax_Kid_N { get; set; }
		/// <summary>
		/// 제세공과금_어른
		/// </summary>
		[Column("제세공과금_어른")]
		public long PublicFacilitiesTax_Adult { get; set; }
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
		/// 골프장예약번호
		/// </summary>
		[Column("골프장예약번호")]
		public string GolfCourseBookingNumber { get; set; }
		/// <summary>
		/// 좌석등급
		/// </summary>
		[Column("좌석등급")]
		public string SeatClass { get; set; }
		/// <summary>
		/// 선택센딩_2일전
		/// </summary>
		[Column("선택센딩_2일전")]
		public DateTime SelectSending_2DaysBefore { get; set; }
	}

	public class Result10 : IDbResult
	{
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
		/// 현지도착시간
		/// </summary>
		[Column("현지도착시간")]
		public string LocalArrivalTime { get; set; }
		/// <summary>
		/// 도착항공편
		/// </summary>
		[Column("도착항공편")]
		public string ArrivalFlight { get; set; }
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
		/// 미팅시간
		/// </summary>
		[Column("미팅시간")]
		public string MeetingTime { get; set; }
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
		/// 기내숙박
		/// </summary>
		[Column("기내숙박")]
		public byte InFlightLogment { get; set; }
		/// <summary>
		/// 특전비고
		/// </summary>
		[Column("특전비고")]
		public string SpecialEventNote { get; set; }
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
		/// 출발확정
		/// </summary>
		[Column("출발확정")]
		public string DepartureConfirm { get; set; }
		/// <summary>
		/// 최소출발인원
		/// </summary>
		[Column("최소출발인원")]
		public int MinimumDepartureNumberOfPeople { get; set; }
		/// <summary>
		/// 가격확정
		/// </summary>
		[Column("가격확정")]
		public string PriceConfirm { get; set; }
		/// <summary>
		/// 취소료규정
		/// </summary>
		[Column("취소료규정")]
		public string CancelFeeRegulations { get; set; }
		/// <summary>
		/// 출발항공사
		/// </summary>
		[Column("출발항공사")]
		public string DepartureAirline { get; set; }
		/// <summary>
		/// 도착항공사
		/// </summary>
		[Column("도착항공사")]
		public string ArrivalAirline { get; set; }
		/// <summary>
		/// 인솔자확정
		/// </summary>
		[Column("인솔자확정")]
		public string LeaderConfirm { get; set; }
		/// <summary>
		/// 인솔자확정여부
		/// </summary>
		[Column("인솔자확정여부")]
		public string LeaderConfirmOrNot { get; set; }
		/// <summary>
		/// 인솔자동행여부
		/// </summary>
		[Column("인솔자동행여부")]
		public string LeaderAccompanyOrNot { get; set; }
		/// <summary>
		/// 선택센딩여부
		/// </summary>
		[Column("선택센딩여부")]
		public string SelectSendingOrNot { get; set; }
	}

	public class Result11 : IDbResult
	{
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 회사우편번호
		/// </summary>
		[Column("회사우편번호")]
		public string CompanyZipCode { get; set; }
		/// <summary>
		/// 회사주소
		/// </summary>
		[Column("회사주소")]
		public string CompanyAddress { get; set; }
		/// <summary>
		/// 회사전화
		/// </summary>
		[Column("회사전화")]
		public string CompanyPhone { get; set; }
		/// <summary>
		/// 회사팩스
		/// </summary>
		[Column("회사팩스")]
		public string CompanyFax { get; set; }
		/// <summary>
		/// 회사대표메일
		/// </summary>
		[Column("회사대표메일")]
		public string CompanyRepresentativeMail { get; set; }
		/// <summary>
		/// 개인이메일
		/// </summary>
		[Column("개인이메일")]
		public string PersonalEmail { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 판매직원명
		/// </summary>
		[Column("판매직원명")]
		public string SalesEmployeeName { get; set; }
		/// <summary>
		/// 판매직원전화번호
		/// </summary>
		[Column("판매직원전화번호")]
		public string SalesEmployeePhoneNumber { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Column("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 거래처등록번호
		/// </summary>
		[Column("거래처등록번호")]
		public string CustomerRegistrationNumber { get; set; }
		/// <summary>
		/// 거래처대표자
		/// </summary>
		[Column("거래처대표자")]
		public string CustomerRepresentative { get; set; }
		/// <summary>
		/// 담당직원번호
		/// </summary>
		[Column("담당직원번호")]
		public int ResponsibilityEmployeeNumber { get; set; }
		/// <summary>
		/// 직원이메일
		/// </summary>
		[Column("직원이메일")]
		public string EmployeeEmail { get; set; }
		/// <summary>
		/// 직원명
		/// </summary>
		[Column("직원명")]
		public string EmployeeName { get; set; }
		/// <summary>
		/// 직원휴대폰
		/// </summary>
		[Column("직원휴대폰")]
		public string EmployeePhone { get; set; }
		/// <summary>
		/// 직원회사전화
		/// </summary>
		[Column("직원회사전화")]
		public string EmployeeCompanyPhone { get; set; }
		/// <summary>
		/// 담당직원수신여부
		/// </summary>
		[Column("담당직원수신여부")]
		public string ResponsibilityEmployeeReceptionOrNot { get; set; }
		/// <summary>
		/// 담당OP번호
		/// </summary>
		[Column("담당OP번호")]
		public int Responsibility_OP_Number { get; set; }
		/// <summary>
		/// 담당OP명
		/// </summary>
		[Column("담당OP명")]
		public string Responsibility_OP_Name { get; set; }
		/// <summary>
		/// 담당OP휴대폰
		/// </summary>
		[Column("담당OP휴대폰")]
		public string Responsibility_OP_Phone { get; set; }
		/// <summary>
		/// 담당OP회사전화
		/// </summary>
		[Column("담당OP회사전화")]
		public string Responsibility_OP_CompanyPhone { get; set; }
		/// <summary>
		/// 담당OP수신여부
		/// </summary>
		[Column("담당OP수신여부")]
		public string Responsibility_OP_ReceptionOrNot { get; set; }
		/// <summary>
		/// 회사명
		/// </summary>
		[Column("회사명")]
		public string CompanyName { get; set; }
		/// <summary>
		/// 판매직원휴대폰
		/// </summary>
		[Column("판매직원휴대폰")]
		public string SalesEmployeePhone { get; set; }
		/// <summary>
		/// 법인명
		/// </summary>
		[Column("법인명")]
		public string CorporationName { get; set; }
		/// <summary>
		/// 판매직원
		/// </summary>
		[Column("판매직원")]
		public int SalesEmployee { get; set; }
		/// <summary>
		/// 판매OP
		/// </summary>
		[Column("판매OP")]
		public int Sales_OP { get; set; }
	}

	public class Result12 : IDbResult
	{
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Column("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Column("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 상태4
		/// </summary>
		[Column("상태4")]
		public string State4 { get; set; }
		/// <summary>
		/// 상태5
		/// </summary>
		[Column("상태5")]
		public string State5 { get; set; }
		/// <summary>
		/// 상태6
		/// </summary>
		[Column("상태6")]
		public string State6 { get; set; }
		/// <summary>
		/// 상태7
		/// </summary>
		[Column("상태7")]
		public string State7 { get; set; }
		/// <summary>
		/// 금액1
		/// </summary>
		[Column("금액1")]
		public long Amount1 { get; set; }
		/// <summary>
		/// 금액2
		/// </summary>
		[Column("금액2")]
		public long Amount2 { get; set; }
		/// <summary>
		/// 금액3
		/// </summary>
		[Column("금액3")]
		public long Amount3 { get; set; }
		/// <summary>
		/// 업체주문번호
		/// </summary>
		[Column("업체주문번호")]
		public string CompanyOrderNumber { get; set; }
	}

	public class Result13 : IDbResult
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 랜드사명
		/// </summary>
		[Column("랜드사명")]
		public string LandCompanyName { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Column("연락처")]
		public string Contact { get; set; }
	}

	public class Result14 : IDbResult
	{
		/// <summary>
		/// 항공사PNR
		/// </summary>
		[Column("항공사PNR")]
		public string Airline_PNR { get; set; }
		/// <summary>
		/// GDS코드
		/// </summary>
		[Column("GDS코드")]
		public string GDS_Code { get; set; }
		/// <summary>
		/// 주문아이템번호
		/// </summary>
		[Column("주문아이템번호")]
		public int OrderItemNumber { get; set; }
		/// <summary>
		/// GDS상품코드
		/// </summary>
		[Column("GDS상품코드")]
		public string GDS_ProductCode { get; set; }
		/// <summary>
		/// GDS상품명
		/// </summary>
		[Column("GDS상품명")]
		public string GDS_ProductName { get; set; }
		/// <summary>
		/// 요금
		/// </summary>
		[Column("요금")]
		public decimal Fare { get; set; }
		/// <summary>
		/// 수량
		/// </summary>
		[Column("수량")]
		public int Quantity { get; set; }
	}

	public class Result15 : IDbResult
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 판매직원
		/// </summary>
		[Column("판매직원")]
		public int SalesEmployee { get; set; }
		/// <summary>
		/// 판매OP
		/// </summary>
		[Column("판매OP")]
		public int Sales_OP { get; set; }
	}

	public class Result16 : IDbResult
	{
		/// <summary>
		/// 골프존상품XML
		/// </summary>
		[Column("골프존상품XML")]
		public string GolfZoneProduct_XML { get; set; }
	}

	public class Result17 : IDbResult
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 회원ID
		/// </summary>
		[Column("회원ID")]
		public string Member_ID { get; set; }
		/// <summary>
		/// 업체주문번호
		/// </summary>
		[Column("업체주문번호")]
		public string CompanyOrderNumber { get; set; }
		/// <summary>
		/// 주문일
		/// </summary>
		[Column("주문일")]
		public DateTime OrderDate { get; set; }
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
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 총여행경비
		/// </summary>
		[Column("총여행경비")]
		public long TotalTravelExpense { get; set; }
		/// <summary>
		/// 입금상태
		/// </summary>
		[Column("입금상태")]
		public string DepositState { get; set; }
		/// <summary>
		/// 결재TL_공동구매항공권
		/// </summary>
		[Column("결재TL_공동구매항공권")]
		public DateTime Approval_TL_GroupBookingTicket { get; set; }
		/// <summary>
		/// 출발후입금가능
		/// </summary>
		[Column("출발후입금가능")]
		public string AfterDepartureDepositPossible { get; set; }
		/// <summary>
		/// 대기여부
		/// </summary>
		[Column("대기여부")]
		public string WaitingOrNot { get; set; }
		/// <summary>
		/// 발권완료여부
		/// </summary>
		[Column("발권완료여부")]
		public string TicketIssuanceFinishOrNot { get; set; }
	}
}