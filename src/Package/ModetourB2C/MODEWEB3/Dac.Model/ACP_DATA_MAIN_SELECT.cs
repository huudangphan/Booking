namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_DATA_MAIN_SELECT
/// </summary>
public class ACP_DATA_MAIN_SELECT
{
	public const string SP_NAME = "ACP_DATA_MAIN_SELECT";

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
		/// GR_IDX
		/// </summary>
		[Description("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// TAB_TYPE
		/// </summary>
		[Description("TAB_TYPE")]
		public string TAB_TYPE { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// ADA_TYPE
		/// </summary>
		[Column("ADA_TYPE")]
		public string ADA_TYPE { get; set; }
		/// <summary>
		/// ADA_KIND
		/// </summary>
		[Column("ADA_KIND")]
		public string ADA_KIND { get; set; }
		/// <summary>
		/// ADA_DEFAULT_YN
		/// </summary>
		[Column("ADA_DEFAULT_YN")]
		public string ADA_DEFAULT_YN { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// GR_TITLE
		/// </summary>
		[Column("GR_TITLE")]
		public string GR_TITLE { get; set; }
		/// <summary>
		/// LISTTAB
		/// </summary>
		[Column("LISTTAB")]
		public string LISTTAB { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// MW_MENU_PATH
		/// </summary>
		[Column("MW_MENU_PATH")]
		public string MW_MENU_PATH { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// MW_START
		/// </summary>
		[Column("MW_START")]
		public string MW_START { get; set; }
		/// <summary>
		/// MW_START_NAME
		/// </summary>
		[Column("MW_START_NAME")]
		public string MW_START_NAME { get; set; }
		/// <summary>
		/// MW_USE
		/// </summary>
		[Column("MW_USE")]
		public string MW_USE { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// AME_MENU
		/// </summary>
		[Column("AME_MENU")]
		public string AME_MENU { get; set; }
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
		/// EXISTS_AME_IDX
		/// </summary>
		[Column("EXISTS_AME_IDX")]
		public int EXISTS_AME_IDX { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// GGN_IDX
		/// </summary>
		[Column("GGN_IDX")]
		public int GGN_IDX { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// RGN_IDX
		/// </summary>
		[Column("RGN_IDX")]
		public int RGN_IDX { get; set; }
		/// <summary>
		/// GGN_USE_WEB
		/// </summary>
		[Column("GGN_USE_WEB")]
		public string GGN_USE_WEB { get; set; }
		/// <summary>
		/// GGN_USE_MOBILE
		/// </summary>
		[Column("GGN_USE_MOBILE")]
		public string GGN_USE_MOBILE { get; set; }
		/// <summary>
		/// GGN_TITLE
		/// </summary>
		[Column("GGN_TITLE")]
		public string GGN_TITLE { get; set; }
		/// <summary>
		/// GGN_LINK
		/// </summary>
		[Column("GGN_LINK")]
		public string GGN_LINK { get; set; }
		/// <summary>
		/// GGN_SORT
		/// </summary>
		[Column("GGN_SORT")]
		public int GGN_SORT { get; set; }
		/// <summary>
		/// GGN_STATUS
		/// </summary>
		[Column("GGN_STATUS")]
		public string GGN_STATUS { get; set; }
		/// <summary>
		/// GGN_REG_AUS_PTID
		/// </summary>
		[Column("GGN_REG_AUS_PTID")]
		public int GGN_REG_AUS_PTID { get; set; }
		/// <summary>
		/// GGN_REGDATE
		/// </summary>
		[Column("GGN_REGDATE")]
		public DateTime GGN_REGDATE { get; set; }
		/// <summary>
		/// GGN_MOD_AUS_PTID
		/// </summary>
		[Column("GGN_MOD_AUS_PTID")]
		public int GGN_MOD_AUS_PTID { get; set; }
		/// <summary>
		/// GGN_MODDATE
		/// </summary>
		[Column("GGN_MODDATE")]
		public DateTime GGN_MODDATE { get; set; }
		/// <summary>
		/// GGN_TARGET
		/// </summary>
		[Column("GGN_TARGET")]
		public string GGN_TARGET { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// REF_RGN_IDX
		/// </summary>
		[Column("REF_RGN_IDX")]
		public int REF_RGN_IDX { get; set; }
		/// <summary>
		/// RGN_TITLE
		/// </summary>
		[Column("RGN_TITLE")]
		public string RGN_TITLE { get; set; }
		/// <summary>
		/// RGN_LINK
		/// </summary>
		[Column("RGN_LINK")]
		public string RGN_LINK { get; set; }
	}

	public class Result8 : IDbResult
	{
		/// <summary>
		/// GMA_IDX
		/// </summary>
		[Column("GMA_IDX")]
		public int GMA_IDX { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// ADA_KIND
		/// </summary>
		[Column("ADA_KIND")]
		public string ADA_KIND { get; set; }
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
		/// MW_EIMAGE_WEB
		/// </summary>
		[Column("MW_EIMAGE_WEB")]
		public string MW_EIMAGE_WEB { get; set; }
		/// <summary>
		/// MW_EIMAGE_MOBILE
		/// </summary>
		[Column("MW_EIMAGE_MOBILE")]
		public string MW_EIMAGE_MOBILE { get; set; }
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
		/// GMA_REG_AUS_PTID
		/// </summary>
		[Column("GMA_REG_AUS_PTID")]
		public int GMA_REG_AUS_PTID { get; set; }
		/// <summary>
		/// GMA_REGDATE
		/// </summary>
		[Column("GMA_REGDATE")]
		public DateTime GMA_REGDATE { get; set; }
		/// <summary>
		/// GMA_MOD_AUS_PTID
		/// </summary>
		[Column("GMA_MOD_AUS_PTID")]
		public int GMA_MOD_AUS_PTID { get; set; }
		/// <summary>
		/// GMA_MODDATE
		/// </summary>
		[Column("GMA_MODDATE")]
		public DateTime GMA_MODDATE { get; set; }
	}

	public class Result9 : IDbResult
	{
		/// <summary>
		/// KIND_TITLE
		/// </summary>
		[Column("KIND_TITLE")]
		public string KIND_TITLE { get; set; }
		/// <summary>
		/// GMA_IDX
		/// </summary>
		[Column("GMA_IDX")]
		public int GMA_IDX { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// ADA_KIND
		/// </summary>
		[Column("ADA_KIND")]
		public string ADA_KIND { get; set; }
		/// <summary>
		/// SPR_IDX
		/// </summary>
		[Column("SPR_IDX")]
		public int SPR_IDX { get; set; }
		/// <summary>
		/// MW_ETITLE
		/// </summary>
		[Column("MW_ETITLE")]
		public string MW_ETITLE { get; set; }
		/// <summary>
		/// SPR_MIN_PRICE
		/// </summary>
		[Column("SPR_MIN_PRICE")]
		public long SPR_MIN_PRICE { get; set; }
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
		/// GMA_REG_AUS_PTID
		/// </summary>
		[Column("GMA_REG_AUS_PTID")]
		public int GMA_REG_AUS_PTID { get; set; }
		/// <summary>
		/// GMA_REGDATE
		/// </summary>
		[Column("GMA_REGDATE")]
		public DateTime GMA_REGDATE { get; set; }
		/// <summary>
		/// GMA_MOD_AUS_PTID
		/// </summary>
		[Column("GMA_MOD_AUS_PTID")]
		public int GMA_MOD_AUS_PTID { get; set; }
		/// <summary>
		/// GMA_MODDATE
		/// </summary>
		[Column("GMA_MODDATE")]
		public DateTime GMA_MODDATE { get; set; }
	}

	public class Result10 : IDbResult
	{
		/// <summary>
		/// KIND_TITLE
		/// </summary>
		[Column("KIND_TITLE")]
		public string KIND_TITLE { get; set; }
		/// <summary>
		/// GMA_IDX
		/// </summary>
		[Column("GMA_IDX")]
		public int GMA_IDX { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// ADA_KIND
		/// </summary>
		[Column("ADA_KIND")]
		public string ADA_KIND { get; set; }
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
		/// GMA_REG_AUS_PTID
		/// </summary>
		[Column("GMA_REG_AUS_PTID")]
		public int GMA_REG_AUS_PTID { get; set; }
		/// <summary>
		/// GMA_REGDATE
		/// </summary>
		[Column("GMA_REGDATE")]
		public DateTime GMA_REGDATE { get; set; }
		/// <summary>
		/// GMA_MOD_AUS_PTID
		/// </summary>
		[Column("GMA_MOD_AUS_PTID")]
		public int GMA_MOD_AUS_PTID { get; set; }
		/// <summary>
		/// GMA_MODDATE
		/// </summary>
		[Column("GMA_MODDATE")]
		public DateTime GMA_MODDATE { get; set; }
		/// <summary>
		/// ADA_DEFAULT_YN
		/// </summary>
		[Column("ADA_DEFAULT_YN")]
		public string ADA_DEFAULT_YN { get; set; }
	}

	public class Result11 : IDbResult
	{
		/// <summary>
		/// GMA_IDX
		/// </summary>
		[Column("GMA_IDX")]
		public int GMA_IDX { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// ADA_KIND
		/// </summary>
		[Column("ADA_KIND")]
		public string ADA_KIND { get; set; }
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
		/// GMA_REG_AUS_PTID
		/// </summary>
		[Column("GMA_REG_AUS_PTID")]
		public int GMA_REG_AUS_PTID { get; set; }
		/// <summary>
		/// GMA_REGDATE
		/// </summary>
		[Column("GMA_REGDATE")]
		public DateTime GMA_REGDATE { get; set; }
		/// <summary>
		/// GMA_MOD_AUS_PTID
		/// </summary>
		[Column("GMA_MOD_AUS_PTID")]
		public int GMA_MOD_AUS_PTID { get; set; }
		/// <summary>
		/// GMA_MODDATE
		/// </summary>
		[Column("GMA_MODDATE")]
		public DateTime GMA_MODDATE { get; set; }
	}

	public class Result12 : IDbResult
	{
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// GPR_TYPE
		/// </summary>
		[Column("GPR_TYPE")]
		public string GPR_TYPE { get; set; }
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
		/// GPR_STATUS
		/// </summary>
		[Column("GPR_STATUS")]
		public string GPR_STATUS { get; set; }
		/// <summary>
		/// GPR_REG_AUS_PTID
		/// </summary>
		[Column("GPR_REG_AUS_PTID")]
		public int GPR_REG_AUS_PTID { get; set; }
		/// <summary>
		/// GPR_REGDATE
		/// </summary>
		[Column("GPR_REGDATE")]
		public DateTime GPR_REGDATE { get; set; }
		/// <summary>
		/// GPR_MOD_AUS_PTID
		/// </summary>
		[Column("GPR_MOD_AUS_PTID")]
		public int GPR_MOD_AUS_PTID { get; set; }
		/// <summary>
		/// GPR_MODDATE
		/// </summary>
		[Column("GPR_MODDATE")]
		public DateTime GPR_MODDATE { get; set; }
	}

	public class Result13 : IDbResult
	{
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// MENUCODE
		/// </summary>
		[Column("MENUCODE")]
		public string MENUCODE { get; set; }
		/// <summary>
		/// FULLNAME
		/// </summary>
		[Column("FULLNAME")]
		public string FULLNAME { get; set; }
	}

	public class Result14 : IDbResult
	{
		/// <summary>
		/// POP_IDX
		/// </summary>
		[Column("POP_IDX")]
		public int POP_IDX { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// POP_SVC
		/// </summary>
		[Column("POP_SVC")]
		public string POP_SVC { get; set; }
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
		/// <summary>
		/// POP_STATUS
		/// </summary>
		[Column("POP_STATUS")]
		public string POP_STATUS { get; set; }
		/// <summary>
		/// POP_REG_AUS_PTID
		/// </summary>
		[Column("POP_REG_AUS_PTID")]
		public int POP_REG_AUS_PTID { get; set; }
		/// <summary>
		/// POP_REGDATE
		/// </summary>
		[Column("POP_REGDATE")]
		public DateTime POP_REGDATE { get; set; }
		/// <summary>
		/// POP_MOD_AUS_PTID
		/// </summary>
		[Column("POP_MOD_AUS_PTID")]
		public int POP_MOD_AUS_PTID { get; set; }
		/// <summary>
		/// POP_MODDATE
		/// </summary>
		[Column("POP_MODDATE")]
		public DateTime POP_MODDATE { get; set; }
	}
}