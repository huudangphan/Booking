namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_단체예약수납_스크래치
/// </summary>
public class WSP_T_CMN_GroupReservationReceipt_Scratch
{
	public const string SP_NAME = "WSP_T_CMN_단체예약수납_스크래치";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 상품권번호
		/// </summary>
		[Description("상품권번호")]
		public string VoucherNumber { get; set; }
		/// <summary>
		/// 환불계좌은행코드
		/// </summary>
		[Description("환불계좌은행코드")]
		public string RefundAccountBankCode { get; set; }
		/// <summary>
		/// 환불계좌번호
		/// </summary>
		[Description("환불계좌번호")]
		public string RefundAccountNumber { get; set; }
		/// <summary>
		/// 환불계좌명
		/// </summary>
		[Description("환불계좌명")]
		public string RefundAccountName { get; set; }
		/// <summary>
		/// 환불연락처
		/// </summary>
		[Description("환불연락처")]
		public string RefundContact { get; set; }
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
		/// USERNO
		/// </summary>
		[Description("USERNO")]
		public int USERNO { get; set; }
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
	}

}