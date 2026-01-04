namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_MMARKET_BP_REG
/// </summary>
public class ACP_TP_MMARKET_BP_REG
{
	public const string SP_NAME = "ACP_TP_MMARKET_BP_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// M_IDX
		/// </summary>
		[Description("M_IDX")]
		public int M_IDX { get; set; }
		/// <summary>
		/// CATEGORY_NAME
		/// </summary>
		[Description("CATEGORY_NAME")]
		public string CATEGORY_NAME { get; set; }
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
		/// RIDX
		/// </summary>
		[Column("RIDX")]
		public int RIDX { get; set; }
	}
}