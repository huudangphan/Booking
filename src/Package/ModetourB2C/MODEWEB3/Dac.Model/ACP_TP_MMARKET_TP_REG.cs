namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_MMARKET_TP_REG
/// </summary>
public class ACP_TP_MMARKET_TP_REG
{
	public const string SP_NAME = "ACP_TP_MMARKET_TP_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MODE
		/// </summary>
		[Description("MODE")]
		public string MODE { get; set; }
		/// <summary>
		/// MM_IDX
		/// </summary>
		[Description("MM_IDX")]
		public int MM_IDX { get; set; }
		/// <summary>
		/// BANNER_TITLE
		/// </summary>
		[Description("BANNER_TITLE")]
		public string BANNER_TITLE { get; set; }
		/// <summary>
		/// BANNER_TYPE
		/// </summary>
		[Description("BANNER_TYPE")]
		public string BANNER_TYPE { get; set; }
		/// <summary>
		/// IMAGEURL
		/// </summary>
		[Description("IMAGEURL")]
		public string IMAGEURL { get; set; }
		/// <summary>
		/// MAIN_TITLE
		/// </summary>
		[Description("MAIN_TITLE")]
		public string MAIN_TITLE { get; set; }
		/// <summary>
		/// SUB_TITLE1
		/// </summary>
		[Description("SUB_TITLE1")]
		public string SUB_TITLE1 { get; set; }
		/// <summary>
		/// SUB_TITLE2
		/// </summary>
		[Description("SUB_TITLE2")]
		public string SUB_TITLE2 { get; set; }
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
		/// LINK_URL
		/// </summary>
		[Description("LINK_URL")]
		public string LINK_URL { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Description("SORT")]
		public int SORT { get; set; }
		/// <summary>
		/// OLINK
		/// </summary>
		[Description("OLINK")]
		public string OLINK { get; set; }
		/// <summary>
		/// LINK_TYPE
		/// </summary>
		[Description("LINK_TYPE")]
		public string LINK_TYPE { get; set; }
		/// <summary>
		/// LINK_NO
		/// </summary>
		[Description("LINK_NO")]
		public int LINK_NO { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
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