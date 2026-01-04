namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// 현대카드도시코드매칭
/// </summary>
public class HyundaeCardCityCodeMatching
{
	public const string SP_NAME = "현대카드도시코드매칭";

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
		/// 도시코드
		/// </summary>
		[Column("도시코드")]
		public string CityCode { get; set; }
	}
}