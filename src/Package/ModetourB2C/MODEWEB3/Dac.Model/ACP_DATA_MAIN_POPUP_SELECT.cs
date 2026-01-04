namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_DATA_MAIN_POPUP_SELECT
/// </summary>
public class ACP_DATA_MAIN_POPUP_SELECT
{
	public const string SP_NAME = "ACP_DATA_MAIN_POPUP_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Description("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// POP_IDX
		/// </summary>
		[Description("POP_IDX")]
		public int POP_IDX { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// POP_IDX
		/// </summary>
		[Column("POP_IDX")]
		public int POP_IDX { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// POP_SVC
		/// </summary>
		[Column("POP_SVC")]
		public string POP_SVC { get; set; }
		/// <summary>
		/// POP_BANNER
		/// </summary>
		[Column("POP_BANNER")]
		public string POP_BANNER { get; set; }
		/// <summary>
		/// POP_LINK
		/// </summary>
		[Column("POP_LINK")]
		public string POP_LINK { get; set; }
		/// <summary>
		/// POP_TARGET
		/// </summary>
		[Column("POP_TARGET")]
		public string POP_TARGET { get; set; }
		/// <summary>
		/// POP_SDATE
		/// </summary>
		[Column("POP_SDATE")]
		public string POP_SDATE { get; set; }
		/// <summary>
		/// POP_EDATE
		/// </summary>
		[Column("POP_EDATE")]
		public string POP_EDATE { get; set; }
		/// <summary>
		/// POP_SORT
		/// </summary>
		[Column("POP_SORT")]
		public int POP_SORT { get; set; }
		/// <summary>
		/// POP_STATUS
		/// </summary>
		[Column("POP_STATUS")]
		public string POP_STATUS { get; set; }
		/// <summary>
		/// POP_REG_AUS_PTID
		/// </summary>
		[Column("POP_REG_AUS_PTID")]
		public int POP_REG_AUS_PTID { get; set; }
		/// <summary>
		/// POP_REGDATE
		/// </summary>
		[Column("POP_REGDATE")]
		public DateTime POP_REGDATE { get; set; }
		/// <summary>
		/// POP_MOD_AUS_PTID
		/// </summary>
		[Column("POP_MOD_AUS_PTID")]
		public int POP_MOD_AUS_PTID { get; set; }
		/// <summary>
		/// POP_MODDATE
		/// </summary>
		[Column("POP_MODDATE")]
		public DateTime POP_MODDATE { get; set; }
	}
}