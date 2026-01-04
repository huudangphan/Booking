namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_INFO_TEMPLATE_TYPE_REG
/// </summary>
public class ACP_INFO_TEMPLATE_TYPE_REG
{
	public const string SP_NAME = "ACP_INFO_TEMPLATE_TYPE_REG";

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
		/// TTY_TYPE
		/// </summary>
		[Description("TTY_TYPE")]
		public string TTY_TYPE { get; set; }
		/// <summary>
		/// TTY_TITLE
		/// </summary>
		[Description("TTY_TITLE")]
		public string TTY_TITLE { get; set; }
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
		/// TTY_IDX
		/// </summary>
		[Column("TTY_IDX")]
		public int TTY_IDX { get; set; }
	}
}