namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_MAIN_SELECT
/// </summary>
public class ASP_MAIN_SELECT
{
	public const string SP_NAME = "ASP_MAIN_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// SEARCH_TEXT
		/// </summary>
		[Description("SEARCH_TEXT")]
		public string SEARCH_TEXT { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Description("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// TRADE_PTID
		/// </summary>
		[Description("TRADE_PTID")]
		public int TRADE_PTID { get; set; }
		/// <summary>
		/// START_LOCATION
		/// </summary>
		[Description("START_LOCATION")]
		public string START_LOCATION { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// MW_DEPTH
		/// </summary>
		[Column("MW_DEPTH")]
		public string MW_DEPTH { get; set; }
		/// <summary>
		/// MW_MENU_PATH
		/// </summary>
		[Column("MW_MENU_PATH")]
		public string MW_MENU_PATH { get; set; }
		/// <summary>
		/// RLE_MENU_CODE
		/// </summary>
		[Column("RLE_MENU_CODE")]
		public string RLE_MENU_CODE { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// CATEGORY
		/// </summary>
		[Column("CATEGORY")]
		public string CATEGORY { get; set; }
		/// <summary>
		/// PLACENO
		/// </summary>
		[Column("PLACENO")]
		public string PLACENO { get; set; }
	}
}