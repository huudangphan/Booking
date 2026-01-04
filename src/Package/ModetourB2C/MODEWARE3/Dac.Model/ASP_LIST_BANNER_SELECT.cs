namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_LIST_BANNER_SELECT
/// </summary>
public class ASP_LIST_BANNER_SELECT
{
	public const string SP_NAME = "ASP_LIST_BANNER_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// THEMA
		/// </summary>
		[Description("THEMA")]
		public int THEMA { get; set; }
		/// <summary>
		/// AREA_STR
		/// </summary>
		[Description("AREA_STR")]
		public string AREA_STR { get; set; }
		/// <summary>
		/// EXCEPT_STR
		/// </summary>
		[Description("EXCEPT_STR")]
		public string EXCEPT_STR { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// EDI_IDX
		/// </summary>
		[Column("EDI_IDX")]
		public int EDI_IDX { get; set; }
		/// <summary>
		/// EDI_TITLE
		/// </summary>
		[Column("EDI_TITLE")]
		public string EDI_TITLE { get; set; }
		/// <summary>
		/// EDI_IMG1
		/// </summary>
		[Column("EDI_IMG1")]
		public string EDI_IMG1 { get; set; }
		/// <summary>
		/// EDI_LINK
		/// </summary>
		[Column("EDI_LINK")]
		public string EDI_LINK { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// PRO_CODE
		/// </summary>
		[Column("PRO_CODE")]
		public string PRO_CODE { get; set; }
		/// <summary>
		/// SPR_IDX
		/// </summary>
		[Column("SPR_IDX")]
		public int SPR_IDX { get; set; }
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
}