namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_상품코드_기간후출발단체
/// </summary>
public class WSP_S_ProductCode_PeriodAfterDepartureGroup
{
	public const string SP_NAME = "WSP_S_상품코드_기간후출발단체";

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
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
	}
}