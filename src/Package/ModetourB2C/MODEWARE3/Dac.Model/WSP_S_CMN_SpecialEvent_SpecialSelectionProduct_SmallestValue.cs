namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_기획전_특선상품_최소값
/// </summary>
public class WSP_S_CMN_SpecialEvent_SpecialSelectionProduct_SmallestValue
{
	public const string SP_NAME = "WSP_S_CMN_기획전_특선상품_최소값";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 특선번호리스트
		/// </summary>
		[Description("특선번호리스트")]
		public string SpecialSelectionNumberList { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 특선번호
		/// </summary>
		[Column("특선번호")]
		public int SpecialSelectionNumber { get; set; }
		/// <summary>
		/// 최소값
		/// </summary>
		[Column("최소값")]
		public long MinimumValue { get; set; }
	}
}