namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_단체예약완료_철도패스
/// </summary>
public class WSP_S_CMN_GroupReservationFinish_RailwayPASS
{
	public const string SP_NAME = "WSP_S_CMN_단체예약완료_철도패스";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
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
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
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
		public string SalesCustomer { get; set; }
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
	}

	public class Result2 : IDbResult
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
	}

	public class Result3 : IDbResult
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
		/// 수령구분
		/// </summary>
		[Column("수령구분")]
		public string ReceiptClassification { get; set; }
		/// <summary>
		/// 수령일자
		/// </summary>
		[Column("수령일자")]
		public DateTime ReceiptDate { get; set; }
		/// <summary>
		/// 수령시간
		/// </summary>
		[Column("수령시간")]
		public string ReceiptTime { get; set; }
		/// <summary>
		/// 방문주소
		/// </summary>
		[Column("방문주소")]
		public string VisitAddress { get; set; }
	}

	public class Result4 : IDbResult
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
	}
}