namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_판매주문
/// </summary>
public class USP_T_SaleOrder2
{
	public const string SP_NAME = "USP_T_판매주문";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 주문구분코드
		/// </summary>
		[Description("주문구분코드")]
		public string OrderClassificationCode { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Description("이벤트번호")]
		public int EventNumber { get; set; }
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
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 카드승인
		/// </summary>
		[Description("카드승인")]
		public string CardApproval { get; set; }
		/// <summary>
		/// 미수유예
		/// </summary>
		[Description("미수유예")]
		public string UnpayedDelay { get; set; }
		/// <summary>
		/// 신청금입금
		/// </summary>
		[Description("신청금입금")]
		public string RequestMoneyDeposit { get; set; }
		/// <summary>
		/// 거래처내예약공유
		/// </summary>
		[Description("거래처내예약공유")]
		public string SharingBookingAmongCustomers { get; set; }
		/// <summary>
		/// 판매수정
		/// </summary>
		[Description("판매수정")]
		public string SalesEdition { get; set; }
		/// <summary>
		/// 중국비자접수완료
		/// </summary>
		[Description("중국비자접수완료")]
		public string ChinaVisaReceiptFinish { get; set; }
		/// <summary>
		/// 직판유형
		/// </summary>
		[Description("직판유형")]
		public string DirectSalesType { get; set; }
		/// <summary>
		/// 영업수익미비사유
		/// </summary>
		[Description("영업수익미비사유")]
		public string BusinessProfitIncompleteReason { get; set; }
		/// <summary>
		/// 수수료과다사유
		/// </summary>
		[Description("수수료과다사유")]
		public string FeeExcessiveReason { get; set; }
		/// <summary>
		/// CRS인보이스
		/// </summary>
		[Description("CRS인보이스")]
		public string CRS_Invoice { get; set; }
		/// <summary>
		/// 가라예약여부
		/// </summary>
		[Description("가라예약여부")]
		public string FakeReservationOrNot { get; set; }
		/// <summary>
		/// 인센티브코드
		/// </summary>
		[Description("인센티브코드")]
		public string IncentiveCode { get; set; }
		/// <summary>
		/// 예약IP
		/// </summary>
		[Description("예약IP")]
		public string BookingIP { get; set; }
		/// <summary>
		/// 예약컴퓨터
		/// </summary>
		[Description("예약컴퓨터")]
		public string BookingComputer { get; set; }
		/// <summary>
		/// 예약처
		/// </summary>
		[Description("예약처")]
		public string Booking { get; set; }
		/// <summary>
		/// 이전수익
		/// </summary>
		[Description("이전수익")]
		public int PreviousProfit { get; set; }
		/// <summary>
		/// BP예약
		/// </summary>
		[Description("BP예약")]
		public string BP_Booking { get; set; }
		/// <summary>
		/// 콜센터예약
		/// </summary>
		[Description("콜센터예약")]
		public string CallCenterBooking { get; set; }
		/// <summary>
		/// 콜센터거래처배분
		/// </summary>
		[Description("콜센터거래처배분")]
		public string CallCenterCustomerDistribution { get; set; }
		/// <summary>
		/// 미팅간소화
		/// </summary>
		[Description("미팅간소화")]
		public string MeetingSimplify { get; set; }
		/// <summary>
		/// 단체성격
		/// </summary>
		[Description("단체성격")]
		public string GroupCharacter { get; set; }
		/// <summary>
		/// 단체피켓
		/// </summary>
		[Description("단체피켓")]
		public string GroupPlacard { get; set; }
		/// <summary>
		/// 단체피켓기타
		/// </summary>
		[Description("단체피켓기타")]
		public string GroupPlacardOther { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 현금영수증삭제
		/// </summary>
		[Description("현금영수증삭제")]
		public string CashReceiptDelete { get; set; }
		/// <summary>
		/// 계약동의자동발송여부
		/// </summary>
		[Description("계약동의자동발송여부")]
		public string ContractAgreeAutoSendingOrNot { get; set; }
		/// <summary>
		/// 개인정보자동발송여부
		/// </summary>
		[Description("개인정보자동발송여부")]
		public string PersonalInfoAutoSendOrNot { get; set; }
		/// <summary>
		/// 직판증빙서류
		/// </summary>
		[Description("직판증빙서류")]
		public string DirectSalesEvidenceDocument { get; set; }
		/// <summary>
		/// 계약서_대표자미설정
		/// </summary>
		[Description("계약서_대표자미설정")]
		public string Contract_RepresentativeNotSetting { get; set; }
		/// <summary>
		/// 인센티브예약
		/// </summary>
		[Description("인센티브예약")]
		public string IncentiveBooking { get; set; }
		/// <summary>
		/// 오버컴예약
		/// </summary>
		[Description("오버컴예약")]
		public string OvercomeBooking { get; set; }
		/// <summary>
		/// 결재TL_공동구매항공권
		/// </summary>
		[Description("결재TL_공동구매항공권")]
		public DateTime Approval_TL_GroupBookingTicket { get; set; }
		/// <summary>
		/// 총액대비커미션
		/// </summary>
		[Description("총액대비커미션")]
		public string TotalAmountPrepareCommission { get; set; }
		/// <summary>
		/// 커미션VAT포함
		/// </summary>
		[Description("커미션VAT포함")]
		public string Commission_VAT_Included { get; set; }
		/// <summary>
		/// 수정자
		/// </summary>
		[Description("수정자")]
		public int Editor { get; set; }
		/// <summary>
		/// 캠페인ID
		/// </summary>
		[Description("캠페인ID")]
		public string Campaign_ID { get; set; }
		/// <summary>
		/// 쿠키발급일
		/// </summary>
		[Description("쿠키발급일")]
		public DateTime CookieIssuanceDate { get; set; }
		/// <summary>
		/// 홈쇼핑해피콜적용여부
		/// </summary>
		[Description("홈쇼핑해피콜적용여부")]
		public string HomeShoppingHappyCallApplyOrNot { get; set; }
		/// <summary>
		/// 파트너여행사배분여부
		/// </summary>
		[Description("파트너여행사배분여부")]
		public string PartnerTravelCompanyDistributionOrNot { get; set; }
	}

}