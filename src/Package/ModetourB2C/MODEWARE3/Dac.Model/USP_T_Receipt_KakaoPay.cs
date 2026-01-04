namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_수납_카카오페이
/// </summary>
public class USP_T_Receipt_KakaoPay
{
	public const string SP_NAME = "USP_T_수납_카카오페이";

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
		/// aid
		/// </summary>
		[Description("aid")]
		public string aid { get; set; }
		/// <summary>
		/// tid
		/// </summary>
		[Description("tid")]
		public string tid { get; set; }
		/// <summary>
		/// cid
		/// </summary>
		[Description("cid")]
		public string cid { get; set; }
		/// <summary>
		/// sid
		/// </summary>
		[Description("sid")]
		public string sid { get; set; }
		/// <summary>
		/// partner_order_id
		/// </summary>
		[Description("partner_order_id")]
		public string partner_order_id { get; set; }
		/// <summary>
		/// partner_user_id
		/// </summary>
		[Description("partner_user_id")]
		public string partner_user_id { get; set; }
		/// <summary>
		/// payment_method_type
		/// </summary>
		[Description("payment_method_type")]
		public string payment_method_type { get; set; }
		/// <summary>
		/// amount
		/// </summary>
		[Description("amount")]
		public string amount { get; set; }
		/// <summary>
		/// total
		/// </summary>
		[Description("total")]
		public long total { get; set; }
		/// <summary>
		/// card_info
		/// </summary>
		[Description("card_info")]
		public string card_info { get; set; }
		/// <summary>
		/// item_name
		/// </summary>
		[Description("item_name")]
		public string item_name { get; set; }
		/// <summary>
		/// item_code
		/// </summary>
		[Description("item_code")]
		public string item_code { get; set; }
		/// <summary>
		/// quantity
		/// </summary>
		[Description("quantity")]
		public int quantity { get; set; }
		/// <summary>
		/// created_at
		/// </summary>
		[Description("created_at")]
		public DateTime created_at { get; set; }
		/// <summary>
		/// approved_at
		/// </summary>
		[Description("approved_at")]
		public DateTime approved_at { get; set; }
		/// <summary>
		/// payload
		/// </summary>
		[Description("payload")]
		public string payload { get; set; }
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
		/// 할인쿠폰타입
		/// </summary>
		[Description("할인쿠폰타입")]
		public string DiscountCouponType { get; set; }
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