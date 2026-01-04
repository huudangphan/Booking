namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SVC_GROUP_TIMEDEAL_SELECT
/// </summary>
public class ACP_SVC_GROUP_TIMEDEAL_SELECT
{
	public const string SP_NAME = "ACP_SVC_GROUP_TIMEDEAL_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// UIDX
		/// </summary>
		[Description("UIDX")]
		public int UIDX { get; set; }
		/// <summary>
		/// GTD_IDX
		/// </summary>
		[Description("GTD_IDX")]
		public int GTD_IDX { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// GTD_IDX
		/// </summary>
		[Column("GTD_IDX")]
		public int GTD_IDX { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// DEALTITLE
		/// </summary>
		[Column("DEALTITLE")]
		public string DEALTITLE { get; set; }
		/// <summary>
		/// TEMPLATE
		/// </summary>
		[Column("TEMPLATE")]
		public string TEMPLATE { get; set; }
		/// <summary>
		/// TITLE_IMG
		/// </summary>
		[Column("TITLE_IMG")]
		public string TITLE_IMG { get; set; }
		/// <summary>
		/// BG_COLOR
		/// </summary>
		[Column("BG_COLOR")]
		public string BG_COLOR { get; set; }
		/// <summary>
		/// FONT_COLOR
		/// </summary>
		[Column("FONT_COLOR")]
		public string FONT_COLOR { get; set; }
		/// <summary>
		/// MAIN_TITLE
		/// </summary>
		[Column("MAIN_TITLE")]
		public string MAIN_TITLE { get; set; }
		/// <summary>
		/// SUB_TITLE
		/// </summary>
		[Column("SUB_TITLE")]
		public string SUB_TITLE { get; set; }
		/// <summary>
		/// CAT_START
		/// </summary>
		[Column("CAT_START")]
		public string CAT_START { get; set; }
		/// <summary>
		/// CAT_PROD
		/// </summary>
		[Column("CAT_PROD")]
		public string CAT_PROD { get; set; }
		/// <summary>
		/// START_DATE
		/// </summary>
		[Column("START_DATE")]
		public string START_DATE { get; set; }
		/// <summary>
		/// END_DATE
		/// </summary>
		[Column("END_DATE")]
		public string END_DATE { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// GTD_IDX
		/// </summary>
		[Column("GTD_IDX")]
		public int GTD_IDX { get; set; }
		/// <summary>
		/// GR_TITLE
		/// </summary>
		[Column("GR_TITLE")]
		public string GR_TITLE { get; set; }
		/// <summary>
		/// TEMPLATE
		/// </summary>
		[Column("TEMPLATE")]
		public string TEMPLATE { get; set; }
		/// <summary>
		/// DEALTITLE
		/// </summary>
		[Column("DEALTITLE")]
		public string DEALTITLE { get; set; }
		/// <summary>
		/// TITLE_IMG
		/// </summary>
		[Column("TITLE_IMG")]
		public string TITLE_IMG { get; set; }
		/// <summary>
		/// MAIN_TITLE
		/// </summary>
		[Column("MAIN_TITLE")]
		public string MAIN_TITLE { get; set; }
		/// <summary>
		/// CAT_PROD
		/// </summary>
		[Column("CAT_PROD")]
		public string CAT_PROD { get; set; }
		/// <summary>
		/// START_DATE
		/// </summary>
		[Column("START_DATE")]
		public DateTime START_DATE { get; set; }
		/// <summary>
		/// END_DATE
		/// </summary>
		[Column("END_DATE")]
		public DateTime END_DATE { get; set; }
		/// <summary>
		/// STATUS
		/// </summary>
		[Column("STATUS")]
		public string STATUS { get; set; }
	}
}