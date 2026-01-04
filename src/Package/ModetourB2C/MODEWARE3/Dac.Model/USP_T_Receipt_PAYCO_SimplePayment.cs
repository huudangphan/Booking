namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_수납_PAYCO간편결제
/// </summary>
public class USP_T_Receipt_PAYCO_SimplePayment
{
	public const string SP_NAME = "USP_T_수납_PAYCO간편결제";

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
		/// reserveOrderNo
		/// </summary>
		[Description("reserveOrderNo")]
		public string reserveOrderNo { get; set; }
		/// <summary>
		/// orderNo
		/// </summary>
		[Description("orderNo")]
		public string orderNo { get; set; }
		/// <summary>
		/// memberName
		/// </summary>
		[Description("memberName")]
		public string memberName { get; set; }
		/// <summary>
		/// memberEmail
		/// </summary>
		[Description("memberEmail")]
		public string memberEmail { get; set; }
		/// <summary>
		/// orderChannel
		/// </summary>
		[Description("orderChannel")]
		public string orderChannel { get; set; }
		/// <summary>
		/// totalOrderAmt
		/// </summary>
		[Description("totalOrderAmt")]
		public long totalOrderAmt { get; set; }
		/// <summary>
		/// totalDeliveryFeeAmt
		/// </summary>
		[Description("totalDeliveryFeeAmt")]
		public long totalDeliveryFeeAmt { get; set; }
		/// <summary>
		/// totalRemoteAreaDeliveryFeeAmt
		/// </summary>
		[Description("totalRemoteAreaDeliveryFeeAmt")]
		public long totalRemoteAreaDeliveryFeeAmt { get; set; }
		/// <summary>
		/// totalPaymentAmt
		/// </summary>
		[Description("totalPaymentAmt")]
		public long totalPaymentAmt { get; set; }
		/// <summary>
		/// paymentCompletionYn
		/// </summary>
		[Description("paymentCompletionYn")]
		public string paymentCompletionYn { get; set; }
		/// <summary>
		/// deliveryPlace
		/// </summary>
		[Description("deliveryPlace")]
		public string deliveryPlace { get; set; }
		/// <summary>
		/// orderProducts
		/// </summary>
		[Description("orderProducts")]
		public string orderProducts { get; set; }
		/// <summary>
		/// paymentDetails
		/// </summary>
		[Description("paymentDetails")]
		public string paymentDetails { get; set; }
		/// <summary>
		/// orderCertifyKey
		/// </summary>
		[Description("orderCertifyKey")]
		public string orderCertifyKey { get; set; }
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
		/// 결제내역CSV
		/// </summary>
		[Description("결제내역CSV")]
		public string PaymentHistory_CSV { get; set; }
		/// <summary>
		/// PAYCO결제번호
		/// </summary>
		[Description("PAYCO결제번호")]
		public string PAYCO_PaymentNumber { get; set; }
	}

}