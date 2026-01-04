namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_수납_네이버페이
/// </summary>
public class USP_T_Receipt_NaverPay
{
	public const string SP_NAME = "USP_T_수납_네이버페이";

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
		/// paymentId
		/// </summary>
		[Description("paymentId")]
		public string paymentId { get; set; }
		/// <summary>
		/// payHistId
		/// </summary>
		[Description("payHistId")]
		public string payHistId { get; set; }
		/// <summary>
		/// merchantId
		/// </summary>
		[Description("merchantId")]
		public string merchantId { get; set; }
		/// <summary>
		/// merchantName
		/// </summary>
		[Description("merchantName")]
		public string merchantName { get; set; }
		/// <summary>
		/// merchantPayKey
		/// </summary>
		[Description("merchantPayKey")]
		public string merchantPayKey { get; set; }
		/// <summary>
		/// merchantUserKey
		/// </summary>
		[Description("merchantUserKey")]
		public string merchantUserKey { get; set; }
		/// <summary>
		/// admissionTypeCode
		/// </summary>
		[Description("admissionTypeCode")]
		public string admissionTypeCode { get; set; }
		/// <summary>
		/// admissionYmdt
		/// </summary>
		[Description("admissionYmdt")]
		public string admissionYmdt { get; set; }
		/// <summary>
		/// tradeConfirmYmdt
		/// </summary>
		[Description("tradeConfirmYmdt")]
		public string tradeConfirmYmdt { get; set; }
		/// <summary>
		/// admissionState
		/// </summary>
		[Description("admissionState")]
		public string admissionState { get; set; }
		/// <summary>
		/// totalPayAmount
		/// </summary>
		[Description("totalPayAmount")]
		public decimal totalPayAmount { get; set; }
		/// <summary>
		/// primaryPayAmount
		/// </summary>
		[Description("primaryPayAmount")]
		public decimal primaryPayAmount { get; set; }
		/// <summary>
		/// npointPayAmount
		/// </summary>
		[Description("npointPayAmount")]
		public decimal npointPayAmount { get; set; }
		/// <summary>
		/// primaryPayMeans
		/// </summary>
		[Description("primaryPayMeans")]
		public string primaryPayMeans { get; set; }
		/// <summary>
		/// cardCorpCode
		/// </summary>
		[Description("cardCorpCode")]
		public string cardCorpCode { get; set; }
		/// <summary>
		/// cardNo
		/// </summary>
		[Description("cardNo")]
		public string cardNo { get; set; }
		/// <summary>
		/// cardAuthNo
		/// </summary>
		[Description("cardAuthNo")]
		public string cardAuthNo { get; set; }
		/// <summary>
		/// cardInstCount
		/// </summary>
		[Description("cardInstCount")]
		public int cardInstCount { get; set; }
		/// <summary>
		/// bankCorpCode
		/// </summary>
		[Description("bankCorpCode")]
		public string bankCorpCode { get; set; }
		/// <summary>
		/// bankAccountNo
		/// </summary>
		[Description("bankAccountNo")]
		public string bankAccountNo { get; set; }
		/// <summary>
		/// productName
		/// </summary>
		[Description("productName")]
		public string productName { get; set; }
		/// <summary>
		/// settleExpected
		/// </summary>
		[Description("settleExpected")]
		public bool settleExpected { get; set; }
		/// <summary>
		/// settleExpectAmount
		/// </summary>
		[Description("settleExpectAmount")]
		public decimal settleExpectAmount { get; set; }
		/// <summary>
		/// payCommissionAmount
		/// </summary>
		[Description("payCommissionAmount")]
		public decimal payCommissionAmount { get; set; }
		/// <summary>
		/// extraDeduction
		/// </summary>
		[Description("extraDeduction")]
		public bool extraDeduction { get; set; }
		/// <summary>
		/// useCfmYmdt
		/// </summary>
		[Description("useCfmYmdt")]
		public string useCfmYmdt { get; set; }
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
		/// 취소결과메시지
		/// </summary>
		[Description("취소결과메시지")]
		public string CancelResultMessage { get; set; }
		/// <summary>
		/// primaryPayCancelAmount
		/// </summary>
		[Description("primaryPayCancelAmount")]
		public decimal primaryPayCancelAmount { get; set; }
		/// <summary>
		/// primaryPayRestAmount
		/// </summary>
		[Description("primaryPayRestAmount")]
		public decimal primaryPayRestAmount { get; set; }
		/// <summary>
		/// npointCancelAmount
		/// </summary>
		[Description("npointCancelAmount")]
		public decimal npointCancelAmount { get; set; }
		/// <summary>
		/// npointRestAmount
		/// </summary>
		[Description("npointRestAmount")]
		public decimal npointRestAmount { get; set; }
		/// <summary>
		/// cancelYmdt
		/// </summary>
		[Description("cancelYmdt")]
		public string cancelYmdt { get; set; }
		/// <summary>
		/// totalRestAmount
		/// </summary>
		[Description("totalRestAmount")]
		public decimal totalRestAmount { get; set; }
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
	}

}