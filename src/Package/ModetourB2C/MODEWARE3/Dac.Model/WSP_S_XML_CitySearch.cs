namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_XML_도시검색
/// </summary>
public class WSP_S_XML_CitySearch
{
	public const string SP_NAME = "WSP_S_XML_도시검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 검색도시명
		/// </summary>
		[Description("검색도시명")]
		public string SearchingCityName { get; set; }
		/// <summary>
		/// 출발일1
		/// </summary>
		[Description("출발일1")]
		public string DepartureDate1 { get; set; }
		/// <summary>
		/// 출발일2
		/// </summary>
		[Description("출발일2")]
		public string DepartureDate2 { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Description("출발지")]
		public string Departures { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
	}
}