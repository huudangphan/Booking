namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_DATA_REF_SELECT
/// </summary>
public class ACP_DATA_REF_SELECT
{
	public const string SP_NAME = "ACP_DATA_REF_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// MENU
		/// </summary>
		[Description("MENU")]
		public string MENU { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Description("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// EDI_IDX
		/// </summary>
		[Description("EDI_IDX")]
		public int EDI_IDX { get; set; }
		/// <summary>
		/// SPR_IDX
		/// </summary>
		[Description("SPR_IDX")]
		public int SPR_IDX { get; set; }
		/// <summary>
		/// SEARCH_SDATE
		/// </summary>
		[Description("SEARCH_SDATE")]
		public string SEARCH_SDATE { get; set; }
		/// <summary>
		/// SEARCH_EDATE
		/// </summary>
		[Description("SEARCH_EDATE")]
		public string SEARCH_EDATE { get; set; }
	}

	public class Result1 : IDbResult
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
		/// <summary>
		/// GMA_SORT
		/// </summary>
		[Column("GMA_SORT")]
		public int GMA_SORT { get; set; }
		/// <summary>
		/// GMA_STATUS
		/// </summary>
		[Column("GMA_STATUS")]
		public string GMA_STATUS { get; set; }
		/// <summary>
		/// 제휴여부
		/// </summary>
		[Column("제휴여부")]
		public string AffiliateOrNot { get; set; }
	}

	public class Result2 : IDbResult
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

	public class Result3 : IDbResult
	{
		/// <summary>
		/// SPR_IDX
		/// </summary>
		[Column("SPR_IDX")]
		public int SPR_IDX { get; set; }
		/// <summary>
		/// PRO_CODE
		/// </summary>
		[Column("PRO_CODE")]
		public string PRO_CODE { get; set; }
		/// <summary>
		/// SPRS_MIN_PRICE
		/// </summary>
		[Column("SPRS_MIN_PRICE")]
		public long SPRS_MIN_PRICE { get; set; }
		/// <summary>
		/// SPR_TITLE
		/// </summary>
		[Column("SPR_TITLE")]
		public string SPR_TITLE { get; set; }
		/// <summary>
		/// SPR_IMG
		/// </summary>
		[Column("SPR_IMG")]
		public string SPR_IMG { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// SPR_IDX
		/// </summary>
		[Column("SPR_IDX")]
		public int SPR_IDX { get; set; }
		/// <summary>
		/// PR_CODE
		/// </summary>
		[Column("PR_CODE")]
		public string PR_CODE { get; set; }
		/// <summary>
		/// SPR_LIDX
		/// </summary>
		[Column("SPR_LIDX")]
		public int SPR_LIDX { get; set; }
		/// <summary>
		/// WM_START
		/// </summary>
		[Column("WM_START")]
		public string WM_START { get; set; }
		/// <summary>
		/// AREA_CODE
		/// </summary>
		[Column("AREA_CODE")]
		public int AREA_CODE { get; set; }
		/// <summary>
		/// THEME_CODE
		/// </summary>
		[Column("THEME_CODE")]
		public int THEME_CODE { get; set; }
		/// <summary>
		/// WM_START_NAME
		/// </summary>
		[Column("WM_START_NAME")]
		public string WM_START_NAME { get; set; }
		/// <summary>
		/// AREA_TITLE
		/// </summary>
		[Column("AREA_TITLE")]
		public string AREA_TITLE { get; set; }
		/// <summary>
		/// THEME_TITLE
		/// </summary>
		[Column("THEME_TITLE")]
		public string THEME_TITLE { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// AME_IDX
		/// </summary>
		[Column("AME_IDX")]
		public int AME_IDX { get; set; }
		/// <summary>
		/// AME_IDX_UP
		/// </summary>
		[Column("AME_IDX_UP")]
		public int AME_IDX_UP { get; set; }
		/// <summary>
		/// AME_MENU
		/// </summary>
		[Column("AME_MENU")]
		public string AME_MENU { get; set; }
		/// <summary>
		/// MW_START_NAME
		/// </summary>
		[Column("MW_START_NAME")]
		public string MW_START_NAME { get; set; }
		/// <summary>
		/// MW_START
		/// </summary>
		[Column("MW_START")]
		public string MW_START { get; set; }
		/// <summary>
		/// MW_TCODE
		/// </summary>
		[Column("MW_TCODE")]
		public int MW_TCODE { get; set; }
		/// <summary>
		/// MW_ACODE
		/// </summary>
		[Column("MW_ACODE")]
		public int MW_ACODE { get; set; }
		/// <summary>
		/// MENUCODE
		/// </summary>
		[Column("MENUCODE")]
		public string MENUCODE { get; set; }
		/// <summary>
		/// MENU_USE
		/// </summary>
		[Column("MENU_USE")]
		public int MENU_USE { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// SPR_IDX
		/// </summary>
		[Column("SPR_IDX")]
		public int SPR_IDX { get; set; }
		/// <summary>
		/// PRO_CODE
		/// </summary>
		[Column("PRO_CODE")]
		public string PRO_CODE { get; set; }
		/// <summary>
		/// SPR_TITLE
		/// </summary>
		[Column("SPR_TITLE")]
		public string SPR_TITLE { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// STARTDATE
		/// </summary>
		[Column("STARTDATE")]
		public DateTime STARTDATE { get; set; }
		/// <summary>
		/// ENDDATE
		/// </summary>
		[Column("ENDDATE")]
		public DateTime ENDDATE { get; set; }
		/// <summary>
		/// DISCOUNT
		/// </summary>
		[Column("DISCOUNT")]
		public int DISCOUNT { get; set; }
	}
}