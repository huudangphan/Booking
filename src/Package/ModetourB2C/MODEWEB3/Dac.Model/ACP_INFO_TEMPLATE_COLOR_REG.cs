namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_INFO_TEMPLATE_COLOR_REG
/// </summary>
public class ACP_INFO_TEMPLATE_COLOR_REG
{
	public const string SP_NAME = "ACP_INFO_TEMPLATE_COLOR_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// TE_IDX
		/// </summary>
		[Description("TE_IDX")]
		public int TE_IDX { get; set; }
		/// <summary>
		/// TCO_CODE
		/// </summary>
		[Description("TCO_CODE")]
		public string TCO_CODE { get; set; }
		/// <summary>
		/// TCO_MEMO
		/// </summary>
		[Description("TCO_MEMO")]
		public string TCO_MEMO { get; set; }
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
		/// <summary>
		/// TCO_IDX
		/// </summary>
		[Column("TCO_IDX")]
		public int TCO_IDX { get; set; }
	}
}