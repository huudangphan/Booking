namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSV_S_국가별_도시리스트
/// </summary>
public class WSV_S_EachCountry_CityList
{
	public const string SP_NAME = "WSV_S_국가별_도시리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 국가코드
		/// </summary>
		[Description("국가코드")]
		public string CountryCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 도시코드
		/// </summary>
		[Column("도시코드")]
		public string CityCode { get; set; }
		/// <summary>
		/// 도시명
		/// </summary>
		[Column("도시명")]
		public string CityName { get; set; }
		/// <summary>
		/// 주
		/// </summary>
		[Column("주")]
		public string Week { get; set; }
	}
}