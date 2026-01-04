namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_공항명
/// </summary>
public class WSP_S_AirportName
{
	public const string SP_NAME = "WSP_S_공항명";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 공항코드리스트
		/// </summary>
		[Description("공항코드리스트")]
		public string AirportCodeList { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 공항코드
		/// </summary>
		[Column("공항코드")]
		public string AirportCode { get; set; }
		/// <summary>
		/// 공항명
		/// </summary>
		[Column("공항명")]
		public string AirportName { get; set; }
		/// <summary>
		/// 공항명2
		/// </summary>
		[Column("공항명2")]
		public string AirportName2 { get; set; }
		/// <summary>
		/// 공항명_한글
		/// </summary>
		[Column("공항명_한글")]
		public string AirportName_Korean { get; set; }
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
		/// 도시명_한글
		/// </summary>
		[Column("도시명_한글")]
		public string CityName_Korean { get; set; }
		/// <summary>
		/// 국가코드
		/// </summary>
		[Column("국가코드")]
		public string CountryCode { get; set; }
		/// <summary>
		/// 지역코드
		/// </summary>
		[Column("지역코드")]
		public string RegionCode { get; set; }
	}
}