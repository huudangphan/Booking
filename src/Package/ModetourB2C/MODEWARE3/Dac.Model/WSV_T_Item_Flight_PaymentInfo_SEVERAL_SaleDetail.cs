namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_아이템_항공_결제정보_SEVERAL_판매명세
/// </summary>
public class WSV_T_Item_Flight_PaymentInfo_SEVERAL_SaleDetail
{
	public const string SP_NAME = "WSV_T_아이템_항공_결제정보_SEVERAL_판매명세";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 주문아이템번호
		/// </summary>
		[Description("주문아이템번호")]
		public int OrderItemNumber { get; set; }
		/// <summary>
		/// 카드결제여부
		/// </summary>
		[Description("카드결제여부")]
		public string CardPaymentOrNot { get; set; }
		/// <summary>
		/// 계좌이체여부
		/// </summary>
		[Description("계좌이체여부")]
		public string AccountTransferOrNot { get; set; }
		/// <summary>
		/// 마일리지사용여부
		/// </summary>
		[Description("마일리지사용여부")]
		public string MileageUseOrNot { get; set; }
		/// <summary>
		/// 현금영수증사용여부
		/// </summary>
		[Description("현금영수증사용여부")]
		public string CashReceiptUseOrNot { get; set; }
		/// <summary>
		/// TBL카드결제
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("TBL카드결제")]
		public List<TYPE_Flight_PaymentInfo_Card> TBL_CardPayment { get; set; }
		/// <summary>
		/// 은행
		/// </summary>
		[Description("은행")]
		public string Bank { get; set; }
		/// <summary>
		/// 계좌번호
		/// </summary>
		[Description("계좌번호")]
		public string AccountNumber { get; set; }
		/// <summary>
		/// 예금주
		/// </summary>
		[Description("예금주")]
		public string BankAccountOwner { get; set; }
		/// <summary>
		/// 이체금액
		/// </summary>
		[Description("이체금액")]
		public int TransferAmount { get; set; }
		/// <summary>
		/// 현금영수증번호
		/// </summary>
		[Description("현금영수증번호")]
		public string CashReceiptNumber { get; set; }
		/// <summary>
		/// 할인쿠폰발급번호
		/// </summary>
		[Description("할인쿠폰발급번호")]
		public int DiscountCouponIssuanceNumber { get; set; }
		/// <summary>
		/// 할인쿠폰적용금액
		/// </summary>
		[Description("할인쿠폰적용금액")]
		public int DiscountCouponApplyAmount { get; set; }
		/// <summary>
		/// 요청자번호
		/// </summary>
		[Description("요청자번호")]
		public int RequesterNumber { get; set; }
		/// <summary>
		/// 수정경로
		/// </summary>
		[Description("수정경로")]
		public string EditionRoute { get; set; }
		/// <summary>
		/// SMS발송여부
		/// </summary>
		[Description("SMS발송여부")]
		public string SMS_SendingOrNot { get; set; }
		/// <summary>
		/// 즉시결제여부
		/// </summary>
		[Description("즉시결제여부")]
		public string ImmediatePaymentOrNot { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 4000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

}