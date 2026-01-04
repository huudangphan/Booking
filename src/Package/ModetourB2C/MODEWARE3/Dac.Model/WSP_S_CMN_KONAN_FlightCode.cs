namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_KONAN_항공코드
/// </summary>
public class WSP_S_CMN_KONAN_FlightCode
{
	public const string SP_NAME = "WSP_S_CMN_KONAN_항공코드";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// ACODE_LIST
		/// </summary>
		[Description("ACODE_LIST")]
		public string ACODE_LIST { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 항공사명
		/// </summary>
		[Column("항공사명")]
		public string AirlineName { get; set; }
	}
}