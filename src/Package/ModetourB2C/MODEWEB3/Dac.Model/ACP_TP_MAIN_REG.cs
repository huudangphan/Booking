namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_MAIN_REG
/// </summary>
public class ACP_TP_MAIN_REG
{
	public const string SP_NAME = "ACP_TP_MAIN_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MAIN_IDX
		/// </summary>
		[Description("MAIN_IDX")]
		public int MAIN_IDX { get; set; }
		/// <summary>
		/// CATEGORYNAME
		/// </summary>
		[Description("CATEGORYNAME")]
		public string CATEGORYNAME { get; set; }
		/// <summary>
		/// PRODUCTNO
		/// </summary>
		[Description("PRODUCTNO")]
		public string PRODUCTNO { get; set; }
		/// <summary>
		/// CNT
		/// </summary>
		[Description("CNT")]
		public int CNT { get; set; }
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