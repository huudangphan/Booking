namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_MMARKET_POP_SELECT
/// </summary>
public class ACP_TP_MMARKET_POP_SELECT
{
	public const string SP_NAME = "ACP_TP_MMARKET_POP_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// ITEMNO
		/// </summary>
		[Description("ITEMNO")]
		public int ITEMNO { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// CATEGORY_NAME
		/// </summary>
		[Column("CATEGORY_NAME")]
		public string CATEGORY_NAME { get; set; }
		/// <summary>
		/// D_IDX
		/// </summary>
		[Column("D_IDX")]
		public int D_IDX { get; set; }
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
		/// INFO
		/// </summary>
		[Column("INFO")]
		public string INFO { get; set; }
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
		/// PRICE
		/// </summary>
		[Column("PRICE")]
		public long PRICE { get; set; }
	}
}