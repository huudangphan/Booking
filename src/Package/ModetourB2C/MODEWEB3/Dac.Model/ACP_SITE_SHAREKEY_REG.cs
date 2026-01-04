namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_SHAREKEY_REG
/// </summary>
public class ACP_SITE_SHAREKEY_REG
{
	public const string SP_NAME = "ACP_SITE_SHAREKEY_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// RSH_IDX
		/// </summary>
		[Description("RSH_IDX")]
		public int RSH_IDX { get; set; }
		/// <summary>
		/// SNS_TYPE
		/// </summary>
		[Description("SNS_TYPE")]
		public string SNS_TYPE { get; set; }
		/// <summary>
		/// RSH_KEY
		/// </summary>
		[Description("RSH_KEY")]
		public string RSH_KEY { get; set; }
		/// <summary>
		/// RSH_MEMO
		/// </summary>
		[Description("RSH_MEMO")]
		public string RSH_MEMO { get; set; }
		/// <summary>
		/// RSH_ICON_CLASS
		/// </summary>
		[Description("RSH_ICON_CLASS")]
		public string RSH_ICON_CLASS { get; set; }
		/// <summary>
		/// RSH_USE
		/// </summary>
		[Description("RSH_USE")]
		public string RSH_USE { get; set; }
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
		/// RSH_IDX
		/// </summary>
		[Column("RSH_IDX")]
		public int RSH_IDX { get; set; }
	}
}