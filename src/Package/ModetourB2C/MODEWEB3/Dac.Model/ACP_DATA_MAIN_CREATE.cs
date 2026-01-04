namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_DATA_MAIN_CREATE
/// </summary>
public class ACP_DATA_MAIN_CREATE
{
	public const string SP_NAME = "ACP_DATA_MAIN_CREATE";

	public class Parameters : BaseDbParameters
	{
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
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
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
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// GLE_LIDX
		/// </summary>
		[Column("GLE_LIDX")]
		public int GLE_LIDX { get; set; }
		/// <summary>
		/// GLE_LIDX_UP
		/// </summary>
		[Column("GLE_LIDX_UP")]
		public int GLE_LIDX_UP { get; set; }
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
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// DEFAULT_YN
		/// </summary>
		[Column("DEFAULT_YN")]
		public string DEFAULT_YN { get; set; }
		/// <summary>
		/// GGN_IDX
		/// </summary>
		[Column("GGN_IDX")]
		public int GGN_IDX { get; set; }
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
		/// GGN_TARGET
		/// </summary>
		[Column("GGN_TARGET")]
		public string GGN_TARGET { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// DEFAULT_YN
		/// </summary>
		[Column("DEFAULT_YN")]
		public string DEFAULT_YN { get; set; }
		/// <summary>
		/// GGN_IDX
		/// </summary>
		[Column("GGN_IDX")]
		public int GGN_IDX { get; set; }
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
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// DEFAULT_YN
		/// </summary>
		[Column("DEFAULT_YN")]
		public string DEFAULT_YN { get; set; }
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
		public long GMA_SORT { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// DEFAULT_YN
		/// </summary>
		[Column("DEFAULT_YN")]
		public string DEFAULT_YN { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// MW_EIMAGE
		/// </summary>
		[Column("MW_EIMAGE")]
		public string MW_EIMAGE { get; set; }
		/// <summary>
		/// GMA_IDX
		/// </summary>
		[Column("GMA_IDX")]
		public int GMA_IDX { get; set; }
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
		public long GMA_SORT { get; set; }
		/// <summary>
		/// AREA
		/// </summary>
		[Column("AREA")]
		public string AREA { get; set; }
		/// <summary>
		/// DISCOUNT_NUM_RATE_PRICE
		/// </summary>
		[Column("DISCOUNT_NUM_RATE_PRICE")]
		public string DISCOUNT_NUM_RATE_PRICE { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// DEFAULT_YN
		/// </summary>
		[Column("DEFAULT_YN")]
		public string DEFAULT_YN { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE { get; set; }
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
	}

	public class Result8 : IDbResult
	{
		/// <summary>
		/// DEFAULT_YN
		/// </summary>
		[Column("DEFAULT_YN")]
		public string DEFAULT_YN { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// GMA_IDX
		/// </summary>
		[Column("GMA_IDX")]
		public int GMA_IDX { get; set; }
		/// <summary>
		/// SPR_IDX
		/// </summary>
		[Column("SPR_IDX")]
		public int SPR_IDX { get; set; }
		/// <summary>
		/// MW_EIMAGE
		/// </summary>
		[Column("MW_EIMAGE")]
		public string MW_EIMAGE { get; set; }
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
		/// DISCOUNT_NUM_RATE_PRICE
		/// </summary>
		[Column("DISCOUNT_NUM_RATE_PRICE")]
		public string DISCOUNT_NUM_RATE_PRICE { get; set; }
	}

	public class Result9 : IDbResult
	{
		/// <summary>
		/// DEFAULT_YN
		/// </summary>
		[Column("DEFAULT_YN")]
		public string DEFAULT_YN { get; set; }
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
		/// MW_EIMAGE
		/// </summary>
		[Column("MW_EIMAGE")]
		public string MW_EIMAGE { get; set; }
	}

	public class Result10 : IDbResult
	{
		/// <summary>
		/// DEFAULT_YN
		/// </summary>
		[Column("DEFAULT_YN")]
		public string DEFAULT_YN { get; set; }
		/// <summary>
		/// GPP_TYPE
		/// </summary>
		[Column("GPP_TYPE")]
		public string GPP_TYPE { get; set; }
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
		/// MW_TITLE
		/// </summary>
		[Column("MW_TITLE")]
		public string MW_TITLE { get; set; }
		/// <summary>
		/// MW_MENUCODE
		/// </summary>
		[Column("MW_MENUCODE")]
		public string MW_MENUCODE { get; set; }
		/// <summary>
		/// START_DATE
		/// </summary>
		[Column("START_DATE")]
		public DateTime START_DATE { get; set; }
		/// <summary>
		/// MIN_PRICE
		/// </summary>
		[Column("MIN_PRICE")]
		public long MIN_PRICE { get; set; }
		/// <summary>
		/// IMAGEURL
		/// </summary>
		[Column("IMAGEURL")]
		public string IMAGEURL { get; set; }
	}

	public class Result11 : IDbResult
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

	public class Result12 : IDbResult
	{
		/// <summary>
		/// ADA_KIND
		/// </summary>
		[Column("ADA_KIND")]
		public string ADA_KIND { get; set; }
		/// <summary>
		/// ADA_SORT
		/// </summary>
		[Column("ADA_SORT")]
		public int ADA_SORT { get; set; }
	}

	public class Result13 : IDbResult
	{
		/// <summary>
		/// LISTTAB
		/// </summary>
		[Column("LISTTAB")]
		public string LISTTAB { get; set; }
	}
}