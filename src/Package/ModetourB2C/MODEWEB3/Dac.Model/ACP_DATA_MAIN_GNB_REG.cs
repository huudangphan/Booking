namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_DATA_MAIN_GNB_REG
/// </summary>
public class ACP_DATA_MAIN_GNB_REG
{
	public const string SP_NAME = "ACP_DATA_MAIN_GNB_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Description("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// GGN_TYPE
		/// </summary>
		[Description("GGN_TYPE")]
		public string GGN_TYPE { get; set; }
		/// <summary>
		/// GGN_IDX
		/// </summary>
		[Description("GGN_IDX")]
		public int GGN_IDX { get; set; }
		/// <summary>
		/// RGN_IDX
		/// </summary>
		[Description("RGN_IDX")]
		public int RGN_IDX { get; set; }
		/// <summary>
		/// GGN_USE_WEB
		/// </summary>
		[Description("GGN_USE_WEB")]
		public string GGN_USE_WEB { get; set; }
		/// <summary>
		/// GGN_USE_MOBILE
		/// </summary>
		[Description("GGN_USE_MOBILE")]
		public string GGN_USE_MOBILE { get; set; }
		/// <summary>
		/// GGN_TITLE
		/// </summary>
		[Description("GGN_TITLE")]
		public string GGN_TITLE { get; set; }
		/// <summary>
		/// GGN_LINK
		/// </summary>
		[Description("GGN_LINK")]
		public string GGN_LINK { get; set; }
		/// <summary>
		/// GGN_SORT
		/// </summary>
		[Description("GGN_SORT")]
		public string GGN_SORT { get; set; }
		/// <summary>
		/// GGN_TARGET
		/// </summary>
		[Description("GGN_TARGET")]
		public string GGN_TARGET { get; set; }
		/// <summary>
		/// GGN_STATUS
		/// </summary>
		[Description("GGN_STATUS")]
		public string GGN_STATUS { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// RCODE
		/// </summary>
		[Column("RCODE")]
		public string RCODE { get; set; }
		/// <summary>
		/// RMSG
		/// </summary>
		[Column("RMSG")]
		public string RMSG { get; set; }
		/// <summary>
		/// GGN_IDX
		/// </summary>
		[Column("GGN_IDX")]
		public int GGN_IDX { get; set; }
	}
}