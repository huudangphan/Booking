namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_영행백과_국가별여행정보
/// </summary>
public class WSP_S_CMN_TravelDictionary_EachCountryTravelInfo
{
	public const string SP_NAME = "WSP_S_CMN_영행백과_국가별여행정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PLCODE
		/// </summary>
		[Description("PLCODE")]
		public string PLCODE { get; set; }
		/// <summary>
		/// p_plid
		/// </summary>
		[Description("p_plid")]
		public int p_plid { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// PLCODE
		/// </summary>
		[Column("PLCODE")]
		public string PLCODE { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// PLCODE
		/// </summary>
		[Column("PLCODE")]
		public string PLCODE { get; set; }
		/// <summary>
		/// PLKNAME
		/// </summary>
		[Column("PLKNAME")]
		public string PLKNAME { get; set; }
	}
}