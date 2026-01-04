namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// TYPE_할인쿠폰
/// </summary>
public class TYPE_DiscountCoupon
{
	/// <summary>
	/// 발급번호
	/// </summary>
	[Description("발급번호")]
	public int IssuanceNumber { get; set; }
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