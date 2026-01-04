namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_INFO_TEMPLATE_REG
/// </summary>
public class ACP_INFO_TEMPLATE_REG
{
	public const string SP_NAME = "ACP_INFO_TEMPLATE_REG";

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
		/// TE_TYPE
		/// </summary>
		[Description("TE_TYPE")]
		public string TE_TYPE { get; set; }
		/// <summary>
		/// TE_CODE
		/// </summary>
		[Description("TE_CODE")]
		public string TE_CODE { get; set; }
		/// <summary>
		/// TE_TITLE
		/// </summary>
		[Description("TE_TITLE")]
		public string TE_TITLE { get; set; }
		/// <summary>
		/// TE_STATUS
		/// </summary>
		[Description("TE_STATUS")]
		public string TE_STATUS { get; set; }
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
		/// TE_IDX
		/// </summary>
		[Column("TE_IDX")]
		public int TE_IDX { get; set; }
	}
}