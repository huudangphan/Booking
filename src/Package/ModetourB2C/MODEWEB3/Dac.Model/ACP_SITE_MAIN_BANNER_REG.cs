namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_MAIN_BANNER_REG
/// </summary>
public class ACP_SITE_MAIN_BANNER_REG
{
	public const string SP_NAME = "ACP_SITE_MAIN_BANNER_REG";

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
		/// SMB_IDX
		/// </summary>
		[Description("SMB_IDX")]
		public int SMB_IDX { get; set; }
		/// <summary>
		/// EDI_IDX
		/// </summary>
		[Description("EDI_IDX")]
		public int EDI_IDX { get; set; }
		/// <summary>
		/// SMB_SORT
		/// </summary>
		[Description("SMB_SORT")]
		public string SMB_SORT { get; set; }
		/// <summary>
		/// SMB_STATUS
		/// </summary>
		[Description("SMB_STATUS")]
		public string SMB_STATUS { get; set; }
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
		/// SMB_IDX
		/// </summary>
		[Column("SMB_IDX")]
		public int SMB_IDX { get; set; }
	}
}