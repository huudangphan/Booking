namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_PRODUCT_REG
/// </summary>
public class ACP_TP_PRODUCT_REG
{
	public const string SP_NAME = "ACP_TP_PRODUCT_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GUBUN
		/// </summary>
		[Description("GUBUN")]
		public string GUBUN { get; set; }
		/// <summary>
		/// MAIN_IDX
		/// </summary>
		[Description("MAIN_IDX")]
		public int MAIN_IDX { get; set; }
		/// <summary>
		/// BI_IDX
		/// </summary>
		[Description("BI_IDX")]
		public int BI_IDX { get; set; }
		/// <summary>
		/// CATEGORYNAME1
		/// </summary>
		[Description("CATEGORYNAME1")]
		public string CATEGORYNAME1 { get; set; }
		/// <summary>
		/// CATEGORYNAME2
		/// </summary>
		[Description("CATEGORYNAME2")]
		public string CATEGORYNAME2 { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// PRODUCTNO1
		/// </summary>
		[Description("PRODUCTNO1")]
		public string PRODUCTNO1 { get; set; }
		/// <summary>
		/// PRODUCTNO2
		/// </summary>
		[Description("PRODUCTNO2")]
		public string PRODUCTNO2 { get; set; }
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