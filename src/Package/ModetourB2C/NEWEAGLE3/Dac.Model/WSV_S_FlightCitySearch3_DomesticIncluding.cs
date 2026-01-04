namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSV_S_항공도시검색3_국내포함
/// </summary>
public class WSV_S_FlightCitySearch3_DomesticIncluding
{
	public const string SP_NAME = "WSV_S_항공도시검색3_국내포함";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// AreaKName
		/// </summary>
		[Column("AreaKName")]
		public string AreaKName { get; set; }
		/// <summary>
		/// CountryCode
		/// </summary>
		[Column("CountryCode")]
		public string CountryCode { get; set; }
		/// <summary>
		/// CountryName
		/// </summary>
		[Column("CountryName")]
		public string CountryName { get; set; }
		/// <summary>
		/// StateName
		/// </summary>
		[Column("StateName")]
		public string StateName { get; set; }
		/// <summary>
		/// CityCode
		/// </summary>
		[Column("CityCode")]
		public string CityCode { get; set; }
		/// <summary>
		/// CityEName
		/// </summary>
		[Column("CityEName")]
		public string CityEName { get; set; }
		/// <summary>
		/// CityKName
		/// </summary>
		[Column("CityKName")]
		public string CityKName { get; set; }
		/// <summary>
		/// AirportCode
		/// </summary>
		[Column("AirportCode")]
		public string AirportCode { get; set; }
		/// <summary>
		/// AirportEName
		/// </summary>
		[Column("AirportEName")]
		public string AirportEName { get; set; }
		/// <summary>
		/// AirportKName
		/// </summary>
		[Column("AirportKName")]
		public string AirportKName { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
	}
}