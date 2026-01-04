namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_MAIN_BANNER_SELECT
/// </summary>
public class ACP_SITE_MAIN_BANNER_SELECT
{
	public const string SP_NAME = "ACP_SITE_MAIN_BANNER_SELECT";

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
		/// SMB_IDX
		/// </summary>
		[Description("SMB_IDX")]
		public int SMB_IDX { get; set; }
		/// <summary>
		/// SMB_STATUS
		/// </summary>
		[Description("SMB_STATUS")]
		public string SMB_STATUS { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// SMB_IDX
		/// </summary>
		[Column("SMB_IDX")]
		public int SMB_IDX { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// EDI_IDX
		/// </summary>
		[Column("EDI_IDX")]
		public int EDI_IDX { get; set; }
		/// <summary>
		/// MW_ETITLE
		/// </summary>
		[Column("MW_ETITLE")]
		public string MW_ETITLE { get; set; }
		/// <summary>
		/// MW_EIMAGE_MOBILE
		/// </summary>
		[Column("MW_EIMAGE_MOBILE")]
		public string MW_EIMAGE_MOBILE { get; set; }
		/// <summary>
		/// SMB_SORT
		/// </summary>
		[Column("SMB_SORT")]
		public int SMB_SORT { get; set; }
		/// <summary>
		/// SMB_STATUS
		/// </summary>
		[Column("SMB_STATUS")]
		public string SMB_STATUS { get; set; }
		/// <summary>
		/// SMB_REG_AUS_PTID
		/// </summary>
		[Column("SMB_REG_AUS_PTID")]
		public int SMB_REG_AUS_PTID { get; set; }
		/// <summary>
		/// SMB_REGDATE
		/// </summary>
		[Column("SMB_REGDATE")]
		public DateTime SMB_REGDATE { get; set; }
		/// <summary>
		/// SMB_MOD_AUS_PTID
		/// </summary>
		[Column("SMB_MOD_AUS_PTID")]
		public int SMB_MOD_AUS_PTID { get; set; }
		/// <summary>
		/// SMB_MODDATE
		/// </summary>
		[Column("SMB_MODDATE")]
		public DateTime SMB_MODDATE { get; set; }
	}
}