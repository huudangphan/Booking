namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// TYPE_제휴할인쿠폰
/// </summary>
public class TYPE_AffiliateDiscountCoupon
{
	/// <summary>
	/// 할인쿠폰_주문_일련번호
	/// </summary>
	[Description("할인쿠폰_주문_일련번호")]
	public int DiscountCoupon_Order_SerialNumber { get; set; }
	/// <summary>
	/// 수납번호
	/// </summary>
	[Description("수납번호")]
	public int ReceiptNumber { get; set; }
	/// <summary>
	/// 수납일
	/// </summary>
	[Description("수납일")]
	public DateTime ReceiptDate { get; set; }
	/// <summary>
	/// 수납액
	/// </summary>
	[Description("수납액")]
	public long ReceiptAmount { get; set; }
}