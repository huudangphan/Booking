namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_MMARKET_TP_SELECT
/// </summary>
public class ACP_TP_MMARKET_TP_SELECT
{
	public const string SP_NAME = "ACP_TP_MMARKET_TP_SELECT";

	public class Result : IDbResult
	{
		/// <summary>
		/// MM_IDX
		/// </summary>
		[Column("MM_IDX")]
		public int MM_IDX { get; set; }
		/// <summary>
		/// BANNER_TITLE
		/// </summary>
		[Column("BANNER_TITLE")]
		public string BANNER_TITLE { get; set; }
		/// <summary>
		/// BANNER_TYPE
		/// </summary>
		[Column("BANNER_TYPE")]
		public string BANNER_TYPE { get; set; }
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
		/// SUB_TITLE1
		/// </summary>
		[Column("SUB_TITLE1")]
		public string SUB_TITLE1 { get; set; }
		/// <summary>
		/// SUB_TITLE2
		/// </summary>
		[Column("SUB_TITLE2")]
		public string SUB_TITLE2 { get; set; }
		/// <summary>
		/// IMAGE_URL
		/// </summary>
		[Column("IMAGE_URL")]
		public string IMAGE_URL { get; set; }
		/// <summary>
		/// LINK_URL
		/// </summary>
		[Column("LINK_URL")]
		public string LINK_URL { get; set; }
		/// <summary>
		/// REGDATE
		/// </summary>
		[Column("REGDATE")]
		public DateTime REGDATE { get; set; }
		/// <summary>
		/// REG_AUS_PTID
		/// </summary>
		[Column("REG_AUS_PTID")]
		public int REG_AUS_PTID { get; set; }
		/// <summary>
		/// MOD_REGDATE
		/// </summary>
		[Column("MOD_REGDATE")]
		public DateTime MOD_REGDATE { get; set; }
		/// <summary>
		/// MOD_AUS_PTID
		/// </summary>
		[Column("MOD_AUS_PTID")]
		public int MOD_AUS_PTID { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public int SORT { get; set; }
		/// <summary>
		/// OLINK_YN
		/// </summary>
		[Column("OLINK_YN")]
		public string OLINK_YN { get; set; }
		/// <summary>
		/// LINK_TYPE
		/// </summary>
		[Column("LINK_TYPE")]
		public string LINK_TYPE { get; set; }
		/// <summary>
		/// LINK_NO
		/// </summary>
		[Column("LINK_NO")]
		public int LINK_NO { get; set; }
		/// <summary>
		/// LINK_INFO
		/// </summary>
		[Column("LINK_INFO")]
		public string LINK_INFO { get; set; }
	}
}