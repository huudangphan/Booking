namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_CALNEDER_SELECT
/// </summary>
public class ASP_CALNEDER_SELECT
{
	public const string SP_NAME = "ASP_CALNEDER_SELECT";

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
		/// SPR_IDX
		/// </summary>
		[Description("SPR_IDX")]
		public int SPR_IDX { get; set; }
		/// <summary>
		/// PRO_CODE
		/// </summary>
		[Description("PRO_CODE")]
		public string PRO_CODE { get; set; }
		/// <summary>
		/// GRO_IDX
		/// </summary>
		[Description("GRO_IDX")]
		public int GRO_IDX { get; set; }
		/// <summary>
		/// KEYWORD
		/// </summary>
		[Description("KEYWORD")]
		public string KEYWORD { get; set; }
		/// <summary>
		/// CITY_KEY
		/// </summary>
		[Description("CITY_KEY")]
		public int CITY_KEY { get; set; }
		/// <summary>
		/// TRADE_PTID
		/// </summary>
		[Description("TRADE_PTID")]
		public int TRADE_PTID { get; set; }
		/// <summary>
		/// NOWDATE
		/// </summary>
		[Description("NOWDATE")]
		public string NOWDATE { get; set; }
		/// <summary>
		/// MONTH
		/// </summary>
		[Description("MONTH")]
		public int MONTH { get; set; }
		/// <summary>
		/// DLC
		/// </summary>
		[Description("DLC")]
		public string DLC { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// SDATE
		/// </summary>
		[Column("SDATE")]
		public DateTime SDATE { get; set; }
		/// <summary>
		/// SWEEK
		/// </summary>
		[Column("SWEEK")]
		public string SWEEK { get; set; }
		/// <summary>
		/// HOLIDAY_YN
		/// </summary>
		[Column("HOLIDAY_YN")]
		public string HOLIDAY_YN { get; set; }
		/// <summary>
		/// MIN_PRICE
		/// </summary>
		[Column("MIN_PRICE")]
		public long MIN_PRICE { get; set; }
		/// <summary>
		/// MAX_PRICE
		/// </summary>
		[Column("MAX_PRICE")]
		public long MAX_PRICE { get; set; }
	}
}