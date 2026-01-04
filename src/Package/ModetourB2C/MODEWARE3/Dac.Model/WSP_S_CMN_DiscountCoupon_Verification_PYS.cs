namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_할인쿠폰_인증_PYS
/// </summary>
public class WSP_S_CMN_DiscountCoupon_Verification_PYS
{
	public const string SP_NAME = "WSP_S_CMN_할인쿠폰_인증_PYS";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 쿠폰타입
		/// </summary>
		[Description("쿠폰타입")]
		public string CouponType { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public string SerialNumber { get; set; }
		/// <summary>
		/// 결제금액
		/// </summary>
		[Description("결제금액")]
		public int PaymentAmount { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 할인적용금액
		/// </summary>
		[Column("할인적용금액")]
		public int DiscountApplyAmount { get; set; }
	}
}