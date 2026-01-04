namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_접두어WITH프로모션
/// </summary>
public class WSP_S_Prefix_WITH_Promotion
{
	public const string SP_NAME = "WSP_S_접두어WITH프로모션";

	public class Result : IDbResult
	{
		/// <summary>
		/// 분류
		/// </summary>
		[Column("분류")]
		public string Classification { get; set; }
		/// <summary>
		/// 값
		/// </summary>
		[Column("값")]
		public string Value { get; set; }
	}
}