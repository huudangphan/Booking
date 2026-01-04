namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_BATCH_REF_MAIN_CREATE
/// </summary>
public class ACP_BATCH_REF_MAIN_CREATE
{
	public const string SP_NAME = "ACP_BATCH_REF_MAIN_CREATE";

	public class Result1 : IDbResult
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
		/// LINK
		/// </summary>
		[Column("LINK")]
		public string LINK { get; set; }
	}

	public class Result2 : IDbResult
	{
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
		/// SPR_MIN_PRICE
		/// </summary>
		[Column("SPR_MIN_PRICE")]
		public long SPR_MIN_PRICE { get; set; }
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

	public class Result3 : IDbResult
	{
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
		/// <summary>
		/// LINK
		/// </summary>
		[Column("LINK")]
		public string LINK { get; set; }
	}

	public class Result4 : IDbResult
	{
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

	public class Result5 : IDbResult
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
}