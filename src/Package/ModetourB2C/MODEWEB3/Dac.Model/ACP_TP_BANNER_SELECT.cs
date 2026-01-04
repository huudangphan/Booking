namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_BANNER_SELECT
/// </summary>
public class ACP_TP_BANNER_SELECT
{
	public const string SP_NAME = "ACP_TP_BANNER_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// BI_IDX
		/// </summary>
		[Description("BI_IDX")]
		public int BI_IDX { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// BI_IDX
		/// </summary>
		[Column("BI_IDX")]
		public int BI_IDX { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// TYPE
		/// </summary>
		[Column("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// IMAGEURL
		/// </summary>
		[Column("IMAGEURL")]
		public string IMAGEURL { get; set; }
		/// <summary>
		/// MAIN_TITLE
		/// </summary>
		[Column("MAIN_TITLE")]
		public string MAIN_TITLE { get; set; }
		/// <summary>
		/// SUB_TITLE1
		/// </summary>
		[Column("SUB_TITLE1")]
		public string SUB_TITLE1 { get; set; }
		/// <summary>
		/// SUB_TITLE2
		/// </summary>
		[Column("SUB_TITLE2")]
		public string SUB_TITLE2 { get; set; }
		/// <summary>
		/// BG_COLOR
		/// </summary>
		[Column("BG_COLOR")]
		public string BG_COLOR { get; set; }
		/// <summary>
		/// FONT_COLOR
		/// </summary>
		[Column("FONT_COLOR")]
		public string FONT_COLOR { get; set; }
		/// <summary>
		/// START_DT
		/// </summary>
		[Column("START_DT")]
		public DateTime START_DT { get; set; }
		/// <summary>
		/// END_DT
		/// </summary>
		[Column("END_DT")]
		public DateTime END_DT { get; set; }
		/// <summary>
		/// PAY_DT
		/// </summary>
		[Column("PAY_DT")]
		public DateTime PAY_DT { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// BI_IDX
		/// </summary>
		[Column("BI_IDX")]
		public int BI_IDX { get; set; }
		/// <summary>
		/// TYPE
		/// </summary>
		[Column("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// START_DT
		/// </summary>
		[Column("START_DT")]
		public DateTime START_DT { get; set; }
		/// <summary>
		/// END_DT
		/// </summary>
		[Column("END_DT")]
		public DateTime END_DT { get; set; }
		/// <summary>
		/// REGDATE
		/// </summary>
		[Column("REGDATE")]
		public DateTime REGDATE { get; set; }
	}
}