namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_GREENTV_REG
/// </summary>
public class ACP_TP_GREENTV_REG
{
	public const string SP_NAME = "ACP_TP_GREENTV_REG";

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
		/// URL
		/// </summary>
		[Description("URL")]
		public string URL { get; set; }
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
		/// DATECHK
		/// </summary>
		[Description("DATECHK")]
		public bool DATECHK { get; set; }
		/// <summary>
		/// MINPRICE
		/// </summary>
		[Description("MINPRICE")]
		public int MINPRICE { get; set; }
		/// <summary>
		/// PRDTITLE
		/// </summary>
		[Description("PRDTITLE")]
		public string PRDTITLE { get; set; }
		/// <summary>
		/// DIRECTCHK
		/// </summary>
		[Description("DIRECTCHK")]
		public bool DIRECTCHK { get; set; }
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