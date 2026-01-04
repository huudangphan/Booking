namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SVC_GROUP_TIMEDEAL_REG
/// </summary>
public class ACP_SVC_GROUP_TIMEDEAL_REG
{
	public const string SP_NAME = "ACP_SVC_GROUP_TIMEDEAL_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// GTD_IDX
		/// </summary>
		[Description("GTD_IDX")]
		public int GTD_IDX { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Description("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// DEALTITLE
		/// </summary>
		[Description("DEALTITLE")]
		public string DEALTITLE { get; set; }
		/// <summary>
		/// TEMPLATE
		/// </summary>
		[Description("TEMPLATE")]
		public string TEMPLATE { get; set; }
		/// <summary>
		/// TITLE_IMG
		/// </summary>
		[Description("TITLE_IMG")]
		public string TITLE_IMG { get; set; }
		/// <summary>
		/// BG_COLOR
		/// </summary>
		[Description("BG_COLOR")]
		public string BG_COLOR { get; set; }
		/// <summary>
		/// FONT_COLOR
		/// </summary>
		[Description("FONT_COLOR")]
		public string FONT_COLOR { get; set; }
		/// <summary>
		/// MAIN_TITLE
		/// </summary>
		[Description("MAIN_TITLE")]
		public string MAIN_TITLE { get; set; }
		/// <summary>
		/// SUB_TITLE
		/// </summary>
		[Description("SUB_TITLE")]
		public string SUB_TITLE { get; set; }
		/// <summary>
		/// CAT_START
		/// </summary>
		[Description("CAT_START")]
		public string CAT_START { get; set; }
		/// <summary>
		/// CAT_PROD
		/// </summary>
		[Description("CAT_PROD")]
		public string CAT_PROD { get; set; }
		/// <summary>
		/// START_DATE
		/// </summary>
		[Description("START_DATE")]
		public DateTime START_DATE { get; set; }
		/// <summary>
		/// END_DATE
		/// </summary>
		[Description("END_DATE")]
		public DateTime END_DATE { get; set; }
		/// <summary>
		/// STATUS
		/// </summary>
		[Description("STATUS")]
		public string STATUS { get; set; }
		/// <summary>
		/// REG_AUS_PTID
		/// </summary>
		[Description("REG_AUS_PTID")]
		public int REG_AUS_PTID { get; set; }
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
	}
}