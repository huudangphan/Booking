namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSV_S_출도착도시
/// </summary>
public class WSV_S_DepartureArrivalCity
{
	public const string SP_NAME = "WSV_S_출도착도시";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 출발공항코드
		/// </summary>
		[Description("출발공항코드")]
		public string DepartureAirportCode { get; set; }
		/// <summary>
		/// 도착공항코드
		/// </summary>
		[Description("도착공항코드")]
		public string ArrivalAirportCode { get; set; }
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
		/// SORT
		/// </summary>
		[Column("SORT")]
		public string SORT { get; set; }
		/// <summary>
		/// 국가코드
		/// </summary>
		[Column("국가코드")]
		public string CountryCode { get; set; }
	}
}