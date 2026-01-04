namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_MAIN_CREATE
/// </summary>
public class ACP_SITE_MAIN_CREATE
{
	public const string SP_NAME = "ACP_SITE_MAIN_CREATE";

	public class Parameters : BaseDbParameters
	{
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
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// SI_DOMAIN
		/// </summary>
		[Column("SI_DOMAIN")]
		public string SI_DOMAIN { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// GMA_IDX
		/// </summary>
		[Column("GMA_IDX")]
		public int GMA_IDX { get; set; }
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
		/// MW_EIMAGE
		/// </summary>
		[Column("MW_EIMAGE")]
		public string MW_EIMAGE { get; set; }
		/// <summary>
		/// LINK
		/// </summary>
		[Column("LINK")]
		public string LINK { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// POP_IDX
		/// </summary>
		[Column("POP_IDX")]
		public int POP_IDX { get; set; }
		/// <summary>
		/// POP_BANNER
		/// </summary>
		[Column("POP_BANNER")]
		public string POP_BANNER { get; set; }
		/// <summary>
		/// POP_LINK
		/// </summary>
		[Column("POP_LINK")]
		public string POP_LINK { get; set; }
		/// <summary>
		/// POP_TARGET
		/// </summary>
		[Column("POP_TARGET")]
		public string POP_TARGET { get; set; }
		/// <summary>
		/// POP_SDATE
		/// </summary>
		[Column("POP_SDATE")]
		public string POP_SDATE { get; set; }
		/// <summary>
		/// POP_EDATE
		/// </summary>
		[Column("POP_EDATE")]
		public string POP_EDATE { get; set; }
		/// <summary>
		/// POP_SORT
		/// </summary>
		[Column("POP_SORT")]
		public int POP_SORT { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// SGN_TITLE
		/// </summary>
		[Column("SGN_TITLE")]
		public string SGN_TITLE { get; set; }
		/// <summary>
		/// SGN_LINK
		/// </summary>
		[Column("SGN_LINK")]
		public string SGN_LINK { get; set; }
		/// <summary>
		/// SGN_SORT
		/// </summary>
		[Column("SGN_SORT")]
		public int SGN_SORT { get; set; }
		/// <summary>
		/// SGN_TARGET
		/// </summary>
		[Column("SGN_TARGET")]
		public string SGN_TARGET { get; set; }
	}
}