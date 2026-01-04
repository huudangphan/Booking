namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_REF_SELECT
/// </summary>
public class ACP_SITE_REF_SELECT
{
	public const string SP_NAME = "ACP_SITE_REF_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MENU
		/// </summary>
		[Description("MENU")]
		public string MENU { get; set; }
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// IDX
		/// </summary>
		[Description("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// SI_DOMAIN
		/// </summary>
		[Column("SI_DOMAIN")]
		public string SI_DOMAIN { get; set; }
		/// <summary>
		/// TRADE_PTID
		/// </summary>
		[Column("TRADE_PTID")]
		public int TRADE_PTID { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// TE_IDX
		/// </summary>
		[Column("TE_IDX")]
		public int TE_IDX { get; set; }
		/// <summary>
		/// TE_TYPE
		/// </summary>
		[Column("TE_TYPE")]
		public string TE_TYPE { get; set; }
		/// <summary>
		/// TE_CODE
		/// </summary>
		[Column("TE_CODE")]
		public string TE_CODE { get; set; }
		/// <summary>
		/// TE_TITLE
		/// </summary>
		[Column("TE_TITLE")]
		public string TE_TITLE { get; set; }
		/// <summary>
		/// TE_STATUS
		/// </summary>
		[Column("TE_STATUS")]
		public string TE_STATUS { get; set; }
		/// <summary>
		/// TE_REGDATE
		/// </summary>
		[Column("TE_REGDATE")]
		public DateTime TE_REGDATE { get; set; }
		/// <summary>
		/// TE_MODDATE
		/// </summary>
		[Column("TE_MODDATE")]
		public DateTime TE_MODDATE { get; set; }
		/// <summary>
		/// TE_COUNT
		/// </summary>
		[Column("TE_COUNT")]
		public int TE_COUNT { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// TTY_IDX
		/// </summary>
		[Column("TTY_IDX")]
		public int TTY_IDX { get; set; }
		/// <summary>
		/// TE_IDX
		/// </summary>
		[Column("TE_IDX")]
		public int TE_IDX { get; set; }
		/// <summary>
		/// TTY_TYPE
		/// </summary>
		[Column("TTY_TYPE")]
		public string TTY_TYPE { get; set; }
		/// <summary>
		/// TTY_TITLE
		/// </summary>
		[Column("TTY_TITLE")]
		public string TTY_TITLE { get; set; }
		/// <summary>
		/// TTY_COUNT
		/// </summary>
		[Column("TTY_COUNT")]
		public int TTY_COUNT { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// TCO_IDX
		/// </summary>
		[Column("TCO_IDX")]
		public int TCO_IDX { get; set; }
		/// <summary>
		/// TE_IDX
		/// </summary>
		[Column("TE_IDX")]
		public int TE_IDX { get; set; }
		/// <summary>
		/// TCO_CODE
		/// </summary>
		[Column("TCO_CODE")]
		public string TCO_CODE { get; set; }
		/// <summary>
		/// TCO_MEMO
		/// </summary>
		[Column("TCO_MEMO")]
		public string TCO_MEMO { get; set; }
		/// <summary>
		/// TCO_COUNT
		/// </summary>
		[Column("TCO_COUNT")]
		public int TCO_COUNT { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// GR_TYPE
		/// </summary>
		[Column("GR_TYPE")]
		public string GR_TYPE { get; set; }
		/// <summary>
		/// GR_DEFAULT
		/// </summary>
		[Column("GR_DEFAULT")]
		public string GR_DEFAULT { get; set; }
		/// <summary>
		/// GR_TITLE
		/// </summary>
		[Column("GR_TITLE")]
		public string GR_TITLE { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// SNS_TYPE
		/// </summary>
		[Column("SNS_TYPE")]
		public string SNS_TYPE { get; set; }
		/// <summary>
		/// RSN_MEMO
		/// </summary>
		[Column("RSN_MEMO")]
		public string RSN_MEMO { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// EDI_IDX
		/// </summary>
		[Column("EDI_IDX")]
		public int EDI_IDX { get; set; }
		/// <summary>
		/// EDI_TYPE
		/// </summary>
		[Column("EDI_TYPE")]
		public string EDI_TYPE { get; set; }
		/// <summary>
		/// EDI_TYPENM
		/// </summary>
		[Column("EDI_TYPENM")]
		public string EDI_TYPENM { get; set; }
		/// <summary>
		/// EDI_TITLE
		/// </summary>
		[Column("EDI_TITLE")]
		public string EDI_TITLE { get; set; }
		/// <summary>
		/// EDI_USE_YN
		/// </summary>
		[Column("EDI_USE_YN")]
		public string EDI_USE_YN { get; set; }
		/// <summary>
		/// EDI_SDATE
		/// </summary>
		[Column("EDI_SDATE")]
		public DateTime EDI_SDATE { get; set; }
		/// <summary>
		/// EDI_EDATE
		/// </summary>
		[Column("EDI_EDATE")]
		public DateTime EDI_EDATE { get; set; }
		/// <summary>
		/// EDI_STITLE
		/// </summary>
		[Column("EDI_STITLE")]
		public string EDI_STITLE { get; set; }
		/// <summary>
		/// EDI_DATECNT
		/// </summary>
		[Column("EDI_DATECNT")]
		public int EDI_DATECNT { get; set; }
		/// <summary>
		/// EDI_IMGFULL_YN
		/// </summary>
		[Column("EDI_IMGFULL_YN")]
		public string EDI_IMGFULL_YN { get; set; }
		/// <summary>
		/// EDI_ITEMTYPE
		/// </summary>
		[Column("EDI_ITEMTYPE")]
		public string EDI_ITEMTYPE { get; set; }
		/// <summary>
		/// EDI_MOBILE_YN
		/// </summary>
		[Column("EDI_MOBILE_YN")]
		public string EDI_MOBILE_YN { get; set; }
		/// <summary>
		/// EDI_AGENT_MOBILE_BANNER
		/// </summary>
		[Column("EDI_AGENT_MOBILE_BANNER")]
		public string EDI_AGENT_MOBILE_BANNER { get; set; }
		/// <summary>
		/// ADA_KIND
		/// </summary>
		[Column("ADA_KIND")]
		public string ADA_KIND { get; set; }
	}

	public class Result8 : IDbResult
	{
		/// <summary>
		/// RTA_IDX
		/// </summary>
		[Column("RTA_IDX")]
		public int RTA_IDX { get; set; }
		/// <summary>
		/// RTA_IMG
		/// </summary>
		[Column("RTA_IMG")]
		public string RTA_IMG { get; set; }
		/// <summary>
		/// RTA_MEMO
		/// </summary>
		[Column("RTA_MEMO")]
		public string RTA_MEMO { get; set; }
	}

	public class Result9 : IDbResult
	{
		/// <summary>
		/// RSH_IDX
		/// </summary>
		[Column("RSH_IDX")]
		public int RSH_IDX { get; set; }
		/// <summary>
		/// SNS_TYPE
		/// </summary>
		[Column("SNS_TYPE")]
		public string SNS_TYPE { get; set; }
		/// <summary>
		/// RSH_KEY
		/// </summary>
		[Column("RSH_KEY")]
		public string RSH_KEY { get; set; }
		/// <summary>
		/// RSH_MEMO
		/// </summary>
		[Column("RSH_MEMO")]
		public string RSH_MEMO { get; set; }
	}
}