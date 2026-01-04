namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// TYPE_마일리지샵옵션
/// </summary>
public class TYPE_MileageShopOption
{
	/// <summary>
	/// 수량
	/// </summary>
	[Description("수량")]
	public int Quantity { get; set; }
	/// <summary>
	/// 옵션명
	/// </summary>
	[Description("옵션명")]
	public string OptionName { get; set; }
}