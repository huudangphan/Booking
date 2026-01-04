namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_도시검색_상품일자2
/// </summary>
public class WSP_S_CMN_CitySearch_ProductDate2
{
	public const string SP_NAME = "WSP_S_CMN_도시검색_상품일자2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 검색도시명
		/// </summary>
		[Description("검색도시명")]
		public string SearchingCityName { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Description("출발지")]
		public string Departures { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
	}
}