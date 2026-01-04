namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_DATA_MAIN_POPUP_REG
/// </summary>
public class ACP_DATA_MAIN_POPUP_REG
{
	public const string SP_NAME = "ACP_DATA_MAIN_POPUP_REG";

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
		/// POP_IDX
		/// </summary>
		[Description("POP_IDX")]
		public int POP_IDX { get; set; }
		/// <summary>
		/// POP_SVC_WEB
		/// </summary>
		[Description("POP_SVC_WEB")]
		public string POP_SVC_WEB { get; set; }
		/// <summary>
		/// POP_SVC_MOBILE
		/// </summary>
		[Description("POP_SVC_MOBILE")]
		public string POP_SVC_MOBILE { get; set; }
		/// <summary>
		/// POP_BANNER
		/// </summary>
		[Description("POP_BANNER")]
		public string POP_BANNER { get; set; }
		/// <summary>
		/// POP_LINK
		/// </summary>
		[Description("POP_LINK")]
		public string POP_LINK { get; set; }
		/// <summary>
		/// POP_TARGET
		/// </summary>
		[Description("POP_TARGET")]
		public string POP_TARGET { get; set; }
		/// <summary>
		/// POP_SDATE
		/// </summary>
		[Description("POP_SDATE")]
		public int POP_SDATE { get; set; }
		/// <summary>
		/// POP_EDATE
		/// </summary>
		[Description("POP_EDATE")]
		public int POP_EDATE { get; set; }
		/// <summary>
		/// POP_SORT
		/// </summary>
		[Description("POP_SORT")]
		public string POP_SORT { get; set; }
		/// <summary>
		/// POP_STATUS
		/// </summary>
		[Description("POP_STATUS")]
		public string POP_STATUS { get; set; }
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
		/// POP_IDX
		/// </summary>
		[Column("POP_IDX")]
		public int POP_IDX { get; set; }
	}
}