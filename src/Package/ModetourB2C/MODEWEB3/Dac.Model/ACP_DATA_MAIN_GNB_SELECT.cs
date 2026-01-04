namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_DATA_MAIN_GNB_SELECT
/// </summary>
public class ACP_DATA_MAIN_GNB_SELECT
{
	public const string SP_NAME = "ACP_DATA_MAIN_GNB_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Description("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// GGN_IDX
		/// </summary>
		[Description("GGN_IDX")]
		public int GGN_IDX { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// GGN_IDX
		/// </summary>
		[Column("GGN_IDX")]
		public int GGN_IDX { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// RGN_IDX
		/// </summary>
		[Column("RGN_IDX")]
		public int RGN_IDX { get; set; }
		/// <summary>
		/// RGN_TYPE
		/// </summary>
		[Column("RGN_TYPE")]
		public string RGN_TYPE { get; set; }
		/// <summary>
		/// GGN_USE_WEB
		/// </summary>
		[Column("GGN_USE_WEB")]
		public string GGN_USE_WEB { get; set; }
		/// <summary>
		/// GGN_USE_MOBILE
		/// </summary>
		[Column("GGN_USE_MOBILE")]
		public string GGN_USE_MOBILE { get; set; }
		/// <summary>
		/// GGN_TITLE
		/// </summary>
		[Column("GGN_TITLE")]
		public string GGN_TITLE { get; set; }
		/// <summary>
		/// GGN_LINK
		/// </summary>
		[Column("GGN_LINK")]
		public string GGN_LINK { get; set; }
		/// <summary>
		/// GGN_STATUS
		/// </summary>
		[Column("GGN_STATUS")]
		public string GGN_STATUS { get; set; }
		/// <summary>
		/// GGN_TARGET
		/// </summary>
		[Column("GGN_TARGET")]
		public string GGN_TARGET { get; set; }
	}
}