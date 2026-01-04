namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_PRODUCT_LIST_SELECT
/// </summary>
public class ASP_PRODUCT_LIST_SELECT
{
	public const string SP_NAME = "ASP_PRODUCT_LIST_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// THEMA
		/// </summary>
		[Description("THEMA")]
		public int THEMA { get; set; }
		/// <summary>
		/// AREA_STR
		/// </summary>
		[Description("AREA_STR")]
		public string AREA_STR { get; set; }
		/// <summary>
		/// NOWDATE
		/// </summary>
		[Description("NOWDATE")]
		public string NOWDATE { get; set; }
		/// <summary>
		/// TRADE_PTID
		/// </summary>
		[Description("TRADE_PTID")]
		public int TRADE_PTID { get; set; }
		/// <summary>
		/// NEXTYN
		/// </summary>
		[Description("NEXTYN")]
		public string NEXTYN { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// PRO_CODE
		/// </summary>
		[Column("PRO_CODE")]
		public string PRO_CODE { get; set; }
		/// <summary>
		/// PRICE
		/// </summary>
		[Column("PRICE")]
		public int PRICE { get; set; }
		/// <summary>
		/// MAX_PRICE
		/// </summary>
		[Column("MAX_PRICE")]
		public int MAX_PRICE { get; set; }
		/// <summary>
		/// PRO_NAME
		/// </summary>
		[Column("PRO_NAME")]
		public string PRO_NAME { get; set; }
		/// <summary>
		/// PRO_IMG
		/// </summary>
		[Column("PRO_IMG")]
		public string PRO_IMG { get; set; }
		/// <summary>
		/// PRO_DESC
		/// </summary>
		[Column("PRO_DESC")]
		public string PRO_DESC { get; set; }
		/// <summary>
		/// PRO_MIN_DAY
		/// </summary>
		[Column("PRO_MIN_DAY")]
		public int PRO_MIN_DAY { get; set; }
		/// <summary>
		/// PRO_MAX_DAY
		/// </summary>
		[Column("PRO_MAX_DAY")]
		public int PRO_MAX_DAY { get; set; }
	}
}