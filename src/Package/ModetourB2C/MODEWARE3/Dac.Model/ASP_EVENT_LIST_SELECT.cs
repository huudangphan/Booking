namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_EVENT_LIST_SELECT
/// </summary>
public class ASP_EVENT_LIST_SELECT
{
	public const string SP_NAME = "ASP_EVENT_LIST_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// EVT_IDX
		/// </summary>
		[Description("EVT_IDX")]
		public int EVT_IDX { get; set; }
		/// <summary>
		/// TRADE_PTID
		/// </summary>
		[Description("TRADE_PTID")]
		public int TRADE_PTID { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// EZO_IDX
		/// </summary>
		[Column("EZO_IDX")]
		public int EZO_IDX { get; set; }
		/// <summary>
		/// EZO_POS
		/// </summary>
		[Column("EZO_POS")]
		public string EZO_POS { get; set; }
		/// <summary>
		/// CDZ_SORT
		/// </summary>
		[Column("CDZ_SORT")]
		public int CDZ_SORT { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// EZO_IDX
		/// </summary>
		[Column("EZO_IDX")]
		public int EZO_IDX { get; set; }
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
		/// SPR_TITLE
		/// </summary>
		[Column("SPR_TITLE")]
		public string SPR_TITLE { get; set; }
		/// <summary>
		/// SPR_NAME
		/// </summary>
		[Column("SPR_NAME")]
		public string SPR_NAME { get; set; }
		/// <summary>
		/// SPR_IMG
		/// </summary>
		[Column("SPR_IMG")]
		public string SPR_IMG { get; set; }
		/// <summary>
		/// SPR_COUNTRY
		/// </summary>
		[Column("SPR_COUNTRY")]
		public string SPR_COUNTRY { get; set; }
		/// <summary>
		/// SPR_CITY
		/// </summary>
		[Column("SPR_CITY")]
		public string SPR_CITY { get; set; }
		/// <summary>
		/// SPRS_MIN_PRICE
		/// </summary>
		[Column("SPRS_MIN_PRICE")]
		public long SPRS_MIN_PRICE { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// EZO_IDX
		/// </summary>
		[Column("EZO_IDX")]
		public int EZO_IDX { get; set; }
		/// <summary>
		/// SPR_IDX
		/// </summary>
		[Column("SPR_IDX")]
		public int SPR_IDX { get; set; }
		/// <summary>
		/// SPR_SDATE
		/// </summary>
		[Column("SPR_SDATE")]
		public string SPR_SDATE { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 기획전번호
		/// </summary>
		[Column("기획전번호")]
		public int SpecialEventNumber { get; set; }
		/// <summary>
		/// 기획전명
		/// </summary>
		[Column("기획전명")]
		public string SpecialEventName { get; set; }
	}
}