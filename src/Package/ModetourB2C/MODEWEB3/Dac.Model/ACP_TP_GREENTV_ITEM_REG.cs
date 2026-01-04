namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_GREENTV_ITEM_REG
/// </summary>
public class ACP_TP_GREENTV_ITEM_REG
{
	public const string SP_NAME = "ACP_TP_GREENTV_ITEM_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GUBUN
		/// </summary>
		[Description("GUBUN")]
		public string GUBUN { get; set; }
		/// <summary>
		/// GT_IDX
		/// </summary>
		[Description("GT_IDX")]
		public int GT_IDX { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Description("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// PRODUCT_NO
		/// </summary>
		[Description("PRODUCT_NO")]
		public int PRODUCT_NO { get; set; }
		/// <summary>
		/// CONTENTS
		/// </summary>
		[Description("CONTENTS")]
		public string CONTENTS { get; set; }
		/// <summary>
		/// CNT
		/// </summary>
		[Description("CNT")]
		public int CNT { get; set; }
		/// <summary>
		/// AIRCODE
		/// </summary>
		[Description("AIRCODE")]
		public string AIRCODE { get; set; }
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