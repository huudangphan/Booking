namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_GOOGLESHAREKEY_REG
/// </summary>
public class ACP_SITE_GOOGLESHAREKEY_REG
{
	public const string SP_NAME = "ACP_SITE_GOOGLESHAREKEY_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// GO_IDX
		/// </summary>
		[Description("GO_IDX")]
		public int GO_IDX { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Description("SI_IDX")]
		public int SI_IDX { get; set; }
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
	}
}