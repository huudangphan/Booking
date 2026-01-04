namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_단체예약_연동
/// </summary>
public class WSP_S_CMN_GroupReservation_Integration
{
	public const string SP_NAME = "WSP_S_CMN_단체예약_연동";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
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
		/// 주문일
		/// </summary>
		[Column("주문일")]
		public DateTime OrderDate { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 출발확정
		/// </summary>
		[Column("출발확정")]
		public string DepartureConfirm { get; set; }
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
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Column("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
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
		/// 예약상태명
		/// </summary>
		[Column("예약상태명")]
		public string BookingStateName { get; set; }
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
		/// 할인금액
		/// </summary>
		[Column("할인금액")]
		public long DiscountAmount { get; set; }
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
		/// 판매비고
		/// </summary>
		[Column("판매비고")]
		public string SalesNote { get; set; }
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
	}
}