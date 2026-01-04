namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_MAIN_BEST_TRAVEL_LIST
/// </summary>
public class WSP_S_CMN_TM_MAIN_BEST_TRAVEL_LIST
{
	public const string SP_NAME = "WSP_S_CMN_TM_MAIN_BEST_TRAVEL_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// IsAdmin
		/// </summary>
		[Description("IsAdmin")]
		public string IsAdmin { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Column("Idx")]
		public int Idx { get; set; }
		/// <summary>
		/// Img
		/// </summary>
		[Column("Img")]
		public string Img { get; set; }
		/// <summary>
		/// URL
		/// </summary>
		[Column("URL")]
		public string URL { get; set; }
		/// <summary>
		/// Title
		/// </summary>
		[Column("Title")]
		public string Title { get; set; }
	}
}