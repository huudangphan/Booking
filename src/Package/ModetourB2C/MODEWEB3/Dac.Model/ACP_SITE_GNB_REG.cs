namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_GNB_REG
/// </summary>
public class ACP_SITE_GNB_REG
{
	public const string SP_NAME = "ACP_SITE_GNB_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Description("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// SGN_IDX
		/// </summary>
		[Description("SGN_IDX")]
		public int SGN_IDX { get; set; }
		/// <summary>
		/// SGN_TITLE
		/// </summary>
		[Description("SGN_TITLE")]
		public string SGN_TITLE { get; set; }
		/// <summary>
		/// SGN_LINK
		/// </summary>
		[Description("SGN_LINK")]
		public string SGN_LINK { get; set; }
		/// <summary>
		/// SGN_SORT
		/// </summary>
		[Description("SGN_SORT")]
		public string SGN_SORT { get; set; }
		/// <summary>
		/// SGN_STATUS
		/// </summary>
		[Description("SGN_STATUS")]
		public string SGN_STATUS { get; set; }
		/// <summary>
		/// SGN_TARGET
		/// </summary>
		[Description("SGN_TARGET")]
		public string SGN_TARGET { get; set; }
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
		/// SGN_IDX
		/// </summary>
		[Column("SGN_IDX")]
		public int SGN_IDX { get; set; }
	}
}