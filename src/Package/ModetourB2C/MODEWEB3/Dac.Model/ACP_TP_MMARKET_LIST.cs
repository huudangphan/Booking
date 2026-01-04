namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_MMARKET_LIST
/// </summary>
public class ACP_TP_MMARKET_LIST
{
	public const string SP_NAME = "ACP_TP_MMARKET_LIST";

	public class Result1 : IDbResult
	{
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
		/// BANNER_TYPE
		/// </summary>
		[Column("BANNER_TYPE")]
		public string BANNER_TYPE { get; set; }
		/// <summary>
		/// LINK_URL
		/// </summary>
		[Column("LINK_URL")]
		public string LINK_URL { get; set; }
		/// <summary>
		/// SORT_ORDER
		/// </summary>
		[Column("SORT_ORDER")]
		public int SORT_ORDER { get; set; }
		/// <summary>
		/// IMAGE_URL
		/// </summary>
		[Column("IMAGE_URL")]
		public string IMAGE_URL { get; set; }
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
		/// OLINK_YN
		/// </summary>
		[Column("OLINK_YN")]
		public string OLINK_YN { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// CATEGORY_NAME
		/// </summary>
		[Column("CATEGORY_NAME")]
		public string CATEGORY_NAME { get; set; }
		/// <summary>
		/// M_IDX
		/// </summary>
		[Column("M_IDX")]
		public int M_IDX { get; set; }
		/// <summary>
		/// BANNER_ATTR
		/// </summary>
		[Column("BANNER_ATTR")]
		public string BANNER_ATTR { get; set; }
		/// <summary>
		/// PRODUCT_NO
		/// </summary>
		[Column("PRODUCT_NO")]
		public string PRODUCT_NO { get; set; }
		/// <summary>
		/// IMAGEURL
		/// </summary>
		[Column("IMAGEURL")]
		public string IMAGEURL { get; set; }
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
		/// SUB_TITLE
		/// </summary>
		[Column("SUB_TITLE")]
		public string SUB_TITLE { get; set; }
		/// <summary>
		/// MAIN_TITLE1
		/// </summary>
		[Column("MAIN_TITLE1")]
		public string MAIN_TITLE1 { get; set; }
		/// <summary>
		/// MAIN_TITLE2
		/// </summary>
		[Column("MAIN_TITLE2")]
		public string MAIN_TITLE2 { get; set; }
		/// <summary>
		/// SOORDER
		/// </summary>
		[Column("SOORDER")]
		public int SOORDER { get; set; }
	}
}