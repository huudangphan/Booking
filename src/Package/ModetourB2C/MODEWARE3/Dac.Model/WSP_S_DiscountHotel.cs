namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_할인호텔
/// </summary>
public class WSP_S_DiscountHotel
{
	public const string SP_NAME = "WSP_S_할인호텔";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// LISTCOUNT
		/// </summary>
		[Description("LISTCOUNT")]
		public int LISTCOUNT { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 판매가
		/// </summary>
		[Column("판매가")]
		public int SellingPrice { get; set; }
	}
}