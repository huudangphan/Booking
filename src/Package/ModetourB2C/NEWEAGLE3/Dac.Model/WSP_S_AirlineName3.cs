namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_항공사명3
/// </summary>
public class WSP_S_AirlineName3
{
	public const string SP_NAME = "WSP_S_항공사명3";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 항공코드리스트
		/// </summary>
		[Description("항공코드리스트")]
		public string FlightCodeList { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 항공사코드
		/// </summary>
		[Column("항공사코드")]
		public string AirlineCode { get; set; }
		/// <summary>
		/// 항공사명
		/// </summary>
		[Column("항공사명")]
		public string AirlineName { get; set; }
		/// <summary>
		/// 항공사명_한글
		/// </summary>
		[Column("항공사명_한글")]
		public string AirlineName_Korean { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public string SORT { get; set; }
	}
}