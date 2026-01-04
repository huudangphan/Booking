namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_복지몰_단체예약_02
/// </summary>
public class WSP_T_CMN_WelfareMall_GroupReservation_02
{
	public const string SP_NAME = "WSP_T_CMN_복지몰_단체예약_02";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 예약자번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("예약자번호")]
		public int BookerNumber { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 재고번호
		/// </summary>
		[Description("재고번호")]
		public int StockNumber { get; set; }
		/// <summary>
		/// 출발공항코드
		/// </summary>
		[Description("출발공항코드")]
		public string DepartureAirportCode { get; set; }
		/// <summary>
		/// 도착공항코드
		/// </summary>
		[Description("도착공항코드")]
		public string ArrivalAirportCode { get; set; }
		/// <summary>
		/// 구매수단코드
		/// </summary>
		[Description("구매수단코드")]
		public string BuyMethodCode { get; set; }
		/// <summary>
		/// 내부결제가능
		/// </summary>
		[Description("내부결제가능")]
		public string InternalPaymentPossible { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Description("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 예약자명
		/// </summary>
		[Description("예약자명")]
		public string BookerName { get; set; }
		/// <summary>
		/// 예약자주민번호
		/// </summary>
		[Description("예약자주민번호")]
		public string BookerCitizenIDNumber { get; set; }
		/// <summary>
		/// 예약자연락처
		/// </summary>
		[Description("예약자연락처")]
		public string BookerContact { get; set; }
		/// <summary>
		/// 예약자핸드폰
		/// </summary>
		[Description("예약자핸드폰")]
		public string BookerPhone { get; set; }
		/// <summary>
		/// 예약자메일
		/// </summary>
		[Description("예약자메일")]
		public string BookerMail { get; set; }
		/// <summary>
		/// 예약자중복가입확인정보
		/// </summary>
		[Description("예약자중복가입확인정보")]
		public string BookerDuplicatedSignUpConfirmInfo { get; set; }
		/// <summary>
		/// 고객요청사항
		/// </summary>
		[Description("고객요청사항")]
		public string CustomerRequest { get; set; }
		/// <summary>
		/// 계약서_대표자이메일
		/// </summary>
		[Description("계약서_대표자이메일")]
		public string Contract_RepresentativeEmail { get; set; }
		/// <summary>
		/// 계약서_대표자명
		/// </summary>
		[Description("계약서_대표자명")]
		public string Contract_RepresentativeName { get; set; }
		/// <summary>
		/// 여행자한글명
		/// </summary>
		[Description("여행자한글명")]
		public string TravelerKoreanName { get; set; }
		/// <summary>
		/// 여행자영문성
		/// </summary>
		[Description("여행자영문성")]
		public string TravelerEnglishLastName { get; set; }
		/// <summary>
		/// 여행자영문명
		/// </summary>
		[Description("여행자영문명")]
		public string TravelerEnglishName { get; set; }
		/// <summary>
		/// 여행자주민번호
		/// </summary>
		[Description("여행자주민번호")]
		public string TravelerCitizenIDNumber { get; set; }
		/// <summary>
		/// 여행자성별코드
		/// </summary>
		[Description("여행자성별코드")]
		public string TravelerGenderCode { get; set; }
		/// <summary>
		/// 판매종류코드
		/// </summary>
		[Description("판매종류코드")]
		public string SalesTypeCode { get; set; }
		/// <summary>
		/// 예약상태코드
		/// </summary>
		[Description("예약상태코드")]
		public string BookingStateCode { get; set; }
		/// <summary>
		/// 주문상태코드
		/// </summary>
		[Description("주문상태코드")]
		public string OrderStateCode { get; set; }
		/// <summary>
		/// 여권유무
		/// </summary>
		[Description("여권유무")]
		public string PassportOrNot { get; set; }
		/// <summary>
		/// 여권번호
		/// </summary>
		[Description("여권번호")]
		public string PassportNumber { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Description("여권만료일")]
		public DateTime PassportExpirationDate { get; set; }
		/// <summary>
		/// 여권코드
		/// </summary>
		[Description("여권코드")]
		public string PassportCode { get; set; }
		/// <summary>
		/// 여행자전화
		/// </summary>
		[Description("여행자전화")]
		public string TravelerPhone { get; set; }
		/// <summary>
		/// 여행자HP
		/// </summary>
		[Description("여행자HP")]
		public string Traveler_HP { get; set; }
		/// <summary>
		/// 여행자이메일
		/// </summary>
		[Description("여행자이메일")]
		public string TravelerEmail { get; set; }
		/// <summary>
		/// 판매가
		/// </summary>
		[Description("판매가")]
		public int SellingPrice { get; set; }
		/// <summary>
		/// 판매액
		/// </summary>
		[Description("판매액")]
		public int SalesAmount { get; set; }
		/// <summary>
		/// 추가판매
		/// </summary>
		[Description("추가판매")]
		public int AddSales { get; set; }
		/// <summary>
		/// 할인가적용여부
		/// </summary>
		[Description("할인가적용여부")]
		public string DiscountPriceApplyOrNot { get; set; }
		/// <summary>
		/// 판매비고
		/// </summary>
		[Description("판매비고")]
		public string SalesNote { get; set; }
		/// <summary>
		/// 입장권구분
		/// </summary>
		[Description("입장권구분")]
		public string EntranceTicketClassification { get; set; }
		/// <summary>
		/// 입장권갯수
		/// </summary>
		[Description("입장권갯수")]
		public int EntranceTicketNumber { get; set; }
		/// <summary>
		/// 마일리지번호
		/// </summary>
		[Description("마일리지번호")]
		public string MileageNumber { get; set; }
		/// <summary>
		/// CRS에서요청
		/// </summary>
		[Description("CRS에서요청")]
		public string RequestFrom_CRS { get; set; }
		/// <summary>
		/// 특별약관동의
		/// </summary>
		[Description("특별약관동의")]
		public string SpecialTermsAgree { get; set; }
		/// <summary>
		/// 여권파일명
		/// </summary>
		[Description("여권파일명")]
		public string PassportFileName { get; set; }
		/// <summary>
		/// 예약자PTID
		/// </summary>
		[Description("예약자PTID")]
		public int Booker_PTID { get; set; }
		/// <summary>
		/// 결재TL_공동구매항공권
		/// </summary>
		[Description("결재TL_공동구매항공권")]
		public DateTime Approval_TL_GroupBookingTicket { get; set; }
		/// <summary>
		/// 투어마일리지번호
		/// </summary>
		[Description("투어마일리지번호")]
		public string TourMileageNumber { get; set; }
		/// <summary>
		/// 회원구분
		/// </summary>
		[Description("회원구분")]
		public string MemberClassification { get; set; }
		/// <summary>
		/// 마일리지적립요청
		/// </summary>
		[Description("마일리지적립요청")]
		public string MileageAccumulationRequest { get; set; }
		/// <summary>
		/// 클럽커미션율
		/// </summary>
		[Description("클럽커미션율")]
		public double ClubCommisionRate { get; set; }
		/// <summary>
		/// 여행자인증여부
		/// </summary>
		[Description("여행자인증여부")]
		public string TravelerVerificationOrNot { get; set; }
		/// <summary>
		/// 직판관계자
		/// </summary>
		[Description("직판관계자")]
		public int DirectSalesRelationshipPerson { get; set; }
		/// <summary>
		/// 여행자PTID
		/// </summary>
		[Description("여행자PTID")]
		public int Traveler_PTID { get; set; }
		/// <summary>
		/// WTYN
		/// </summary>
		[Description("WTYN")]
		public string WTYN { get; set; }
		/// <summary>
		/// 영업팀할인
		/// </summary>
		[Description("영업팀할인")]
		public int BusinessTeamDiscount { get; set; }
		/// <summary>
		/// 상품팀할인
		/// </summary>
		[Description("상품팀할인")]
		public int ProductTeamDiscount { get; set; }
		/// <summary>
		/// 판매가단체
		/// </summary>
		[Description("판매가단체")]
		public int SellingPriceGroup { get; set; }
		/// <summary>
		/// 특송상품미인증
		/// </summary>
		[Description("특송상품미인증")]
		public string SpecialDeliveryProductUnVerification { get; set; }
	}

}