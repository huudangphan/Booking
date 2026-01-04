namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_기본출발일BY상품코드
/// </summary>
public class WSP_S_BasicDepartureDateBYProductCode
{
	public const string SP_NAME = "WSP_S_기본출발일BY상품코드";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
	}
}