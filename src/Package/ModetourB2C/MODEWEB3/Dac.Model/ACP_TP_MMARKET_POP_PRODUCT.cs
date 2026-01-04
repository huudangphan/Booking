namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_MMARKET_POP_PRODUCT
/// </summary>
public class ACP_TP_MMARKET_POP_PRODUCT
{
	public const string SP_NAME = "ACP_TP_MMARKET_POP_PRODUCT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GUBUN
		/// </summary>
		[Description("GUBUN")]
		public string GUBUN { get; set; }
		/// <summary>
		/// ITEMNO
		/// </summary>
		[Description("ITEMNO")]
		public int ITEMNO { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// ITEMNO
		/// </summary>
		[Column("ITEMNO")]
		public int ITEMNO { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// IMAGEURL
		/// </summary>
		[Column("IMAGEURL")]
		public string IMAGEURL { get; set; }
		/// <summary>
		/// PRICE
		/// </summary>
		[Column("PRICE")]
		public int PRICE { get; set; }
	}
}