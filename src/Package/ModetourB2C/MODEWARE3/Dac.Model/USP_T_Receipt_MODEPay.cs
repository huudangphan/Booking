namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_수납_모두페이
/// </summary>
public class USP_T_Receipt_MODEPay
{
	public const string SP_NAME = "USP_T_수납_모두페이";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 수납번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("수납번호")]
		public int ReceiptNumber { get; set; }
		/// <summary>
		/// 수납일
		/// </summary>
		[Description("수납일")]
		public DateTime ReceiptDate { get; set; }
		/// <summary>
		/// 결제인증업무구분
		/// </summary>
		[Description("결제인증업무구분")]
		public string PaymentVerificationTaskClassification { get; set; }
		/// <summary>
		/// 상점아이디
		/// </summary>
		[Description("상점아이디")]
		public string Shop_ID { get; set; }
		/// <summary>
		/// 고객ID
		/// </summary>
		[Description("고객ID")]
		public string Customer_ID { get; set; }
		/// <summary>
		/// 업체주문번호
		/// </summary>
		[Description("업체주문번호")]
		public string CompanyOrderNumber { get; set; }
		/// <summary>
		/// 결제상품명
		/// </summary>
		[Description("결제상품명")]
		public string PaymentProductName { get; set; }
		/// <summary>
		/// 거래금액
		/// </summary>
		[Description("거래금액")]
		public long TransactionAmount { get; set; }
		/// <summary>
		/// 통장인자명
		/// </summary>
		[Description("통장인자명")]
		public string BankbookHolderName { get; set; }
		/// <summary>
		/// 추가공제구분
		/// </summary>
		[Description("추가공제구분")]
		public string AddDeductionClassification { get; set; }
		/// <summary>
		/// 결제인증거래상태
		/// </summary>
		[Description("결제인증거래상태")]
		public string PaymentVerificationTransactionState { get; set; }
		/// <summary>
		/// 거래번호
		/// </summary>
		[Description("거래번호")]
		public string TransactionNumber { get; set; }
		/// <summary>
		/// 거래일자
		/// </summary>
		[Description("거래일자")]
		public string TransactionDate { get; set; }
		/// <summary>
		/// 결제인증메시지
		/// </summary>
		[Description("결제인증메시지")]
		public string PaymentVerificationMessage { get; set; }
		/// <summary>
		/// 결제승인업무구분
		/// </summary>
		[Description("결제승인업무구분")]
		public string PaymentApprovalTaskClassification { get; set; }
		/// <summary>
		/// 결제승인거래상태
		/// </summary>
		[Description("결제승인거래상태")]
		public string PaymentApprovalTransactionState { get; set; }
		/// <summary>
		/// 출금은행코드
		/// </summary>
		[Description("출금은행코드")]
		public string WithdrawalBankCode { get; set; }
		/// <summary>
		/// 결제승인메시지
		/// </summary>
		[Description("결제승인메시지")]
		public string PaymentApprovalMessage { get; set; }
		/// <summary>
		/// 할인쿠폰사용여부
		/// </summary>
		[Description("할인쿠폰사용여부")]
		public string DiscountCouponUseOrNot { get; set; }
		/// <summary>
		/// TBL할인쿠폰
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("TBL할인쿠폰")]
		public List<TYPE_DiscountCoupon> TBL_DiscountCoupon { get; set; }
		/// <summary>
		/// 취소구분
		/// </summary>
		[Description("취소구분")]
		public string CancelClassification { get; set; }
		/// <summary>
		/// 취소금액
		/// </summary>
		[Description("취소금액")]
		public long CancelAmount { get; set; }
		/// <summary>
		/// 취소사유
		/// </summary>
		[Description("취소사유")]
		public string CancelReason { get; set; }
		/// <summary>
		/// 취소결과
		/// </summary>
		[Description("취소결과")]
		public string CancelResult { get; set; }
		/// <summary>
		/// 취소거래번호
		/// </summary>
		[Description("취소거래번호")]
		public string CancelTransactionNumber { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Description("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// 결제경로
		/// </summary>
		[Description("결제경로")]
		public string PaymentRoute { get; set; }
		/// <summary>
		/// USERIP
		/// </summary>
		[Description("USERIP")]
		public string USERIP { get; set; }
		/// <summary>
		/// APPNAME
		/// </summary>
		[Description("APPNAME")]
		public string APPNAME { get; set; }
		/// <summary>
		/// 결제내역CSV
		/// </summary>
		[Description("결제내역CSV")]
		public string PaymentHistory_CSV { get; set; }
		/// <summary>
		/// 고객고유번호
		/// </summary>
		[Description("고객고유번호")]
		public string CustomerUniqueNumber { get; set; }
		/// <summary>
		/// 즉시할인액
		/// </summary>
		[Description("즉시할인액")]
		public long ImmediateDiscountAmount { get; set; }
		/// <summary>
		/// 취소즉시할인액
		/// </summary>
		[Description("취소즉시할인액")]
		public long CancelImmediateDiscountAmount { get; set; }
		/// <summary>
		/// 현금영수증신청타입
		/// </summary>
		[Description("현금영수증신청타입")]
		public string CashReceiptRequestType { get; set; }
		/// <summary>
		/// 현금영수증신청정보
		/// </summary>
		[Description("현금영수증신청정보")]
		public string CashReceiptRequestInfo { get; set; }
	}

}