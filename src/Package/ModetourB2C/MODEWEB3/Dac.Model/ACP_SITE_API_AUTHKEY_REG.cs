namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_API_AUTHKEY_REG
/// </summary>
public class ACP_SITE_API_AUTHKEY_REG
{
	public const string SP_NAME = "ACP_SITE_API_AUTHKEY_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// AAU_IDX
		/// </summary>
		[Description("AAU_IDX")]
		public int AAU_IDX { get; set; }
		/// <summary>
		/// AAU_DOMAIN
		/// </summary>
		[Description("AAU_DOMAIN")]
		public string AAU_DOMAIN { get; set; }
		/// <summary>
		/// AAU_IP
		/// </summary>
		[Description("AAU_IP")]
		public string AAU_IP { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Description("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// TRADE_PTID
		/// </summary>
		[Description("TRADE_PTID")]
		public int TRADE_PTID { get; set; }
		/// <summary>
		/// AAU_STATUS
		/// </summary>
		[Description("AAU_STATUS")]
		public string AAU_STATUS { get; set; }
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
		/// <summary>
		/// DOMAIN
		/// </summary>
		[Column("DOMAIN")]
		public string DOMAIN { get; set; }
		/// <summary>
		/// AUTHKEY
		/// </summary>
		[Column("AUTHKEY")]
		public Guid AUTHKEY { get; set; }
	}
}