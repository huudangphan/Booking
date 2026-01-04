namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_CONSULT_REG
/// </summary>
public class ACP_SITE_CONSULT_REG
{
	public const string SP_NAME = "ACP_SITE_CONSULT_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Description("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// SCO_IDX
		/// </summary>
		[Description("SCO_IDX")]
		public int SCO_IDX { get; set; }
		/// <summary>
		/// SCO_WEEK
		/// </summary>
		[Description("SCO_WEEK")]
		public string SCO_WEEK { get; set; }
		/// <summary>
		/// SCO_TIME
		/// </summary>
		[Description("SCO_TIME")]
		public string SCO_TIME { get; set; }
		/// <summary>
		/// SCO_MEMO
		/// </summary>
		[Description("SCO_MEMO")]
		public string SCO_MEMO { get; set; }
		/// <summary>
		/// SCO_STATUS
		/// </summary>
		[Description("SCO_STATUS")]
		public string SCO_STATUS { get; set; }
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
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// SCO_IDX
		/// </summary>
		[Column("SCO_IDX")]
		public int SCO_IDX { get; set; }
	}
}