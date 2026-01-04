namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_STORYM_TOURIST_THEME_COUNT
/// </summary>
public class WSP_S_CMN_TM_STORYM_TOURIST_THEME_COUNT
{
	public const string SP_NAME = "WSP_S_CMN_TM_STORYM_TOURIST_THEME_COUNT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// AreaCode
		/// </summary>
		[Description("AreaCode")]
		public string AreaCode { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Description("UseFlag")]
		public string UseFlag { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// TouristCode
		/// </summary>
		[Column("TouristCode")]
		public string TouristCode { get; set; }
		/// <summary>
		/// Cnt
		/// </summary>
		[Column("Cnt")]
		public int Cnt { get; set; }
	}
}