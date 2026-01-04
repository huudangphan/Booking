namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSV_S_아이템_해외항공_호텔도시코드조회
/// </summary>
public class WSV_S_Item_OverseaFlight_HotelCityCodeFind
{
	public const string SP_NAME = "WSV_S_아이템_해외항공_호텔도시코드조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 공항코드
		/// </summary>
		[Description("공항코드")]
		public string AirportCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// CountryCode
		/// </summary>
		[Column("CountryCode")]
		public string CountryCode { get; set; }
		/// <summary>
		/// AirCityCode
		/// </summary>
		[Column("AirCityCode")]
		public string AirCityCode { get; set; }
		/// <summary>
		/// AirportCode
		/// </summary>
		[Column("AirportCode")]
		public string AirportCode { get; set; }
		/// <summary>
		/// HotelCityCode
		/// </summary>
		[Column("HotelCityCode")]
		public int HotelCityCode { get; set; }
		/// <summary>
		/// CountryName
		/// </summary>
		[Column("CountryName")]
		public string CountryName { get; set; }
	}
}