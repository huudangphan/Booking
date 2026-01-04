namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_여행계약서_웹노출
/// </summary>
public class WSP_S_CMN_TravelContract_WebDisplay
{
	public const string SP_NAME = "WSP_S_CMN_여행계약서_웹노출";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 고객한글명
		/// </summary>
		[Column("고객한글명")]
		public string CustomerKoreanName { get; set; }
	}
}