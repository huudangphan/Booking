namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_INFO_REG
/// </summary>
public class ACP_SITE_INFO_REG
{
	public const string SP_NAME = "ACP_SITE_INFO_REG";

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
		/// TE_IDX
		/// </summary>
		[Description("TE_IDX")]
		public int TE_IDX { get; set; }
		/// <summary>
		/// TTY_IDX
		/// </summary>
		[Description("TTY_IDX")]
		public int TTY_IDX { get; set; }
		/// <summary>
		/// TCO_IDX
		/// </summary>
		[Description("TCO_IDX")]
		public int TCO_IDX { get; set; }
		/// <summary>
		/// MW_START
		/// </summary>
		[Description("MW_START")]
		public string MW_START { get; set; }
		/// <summary>
		/// SIN_TOP_BANNER
		/// </summary>
		[Description("SIN_TOP_BANNER")]
		public string SIN_TOP_BANNER { get; set; }
		/// <summary>
		/// SIN_TOP_LINK
		/// </summary>
		[Description("SIN_TOP_LINK")]
		public string SIN_TOP_LINK { get; set; }
		/// <summary>
		/// SIN_MEMO
		/// </summary>
		[Description("SIN_MEMO")]
		public string SIN_MEMO { get; set; }
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
	}
}