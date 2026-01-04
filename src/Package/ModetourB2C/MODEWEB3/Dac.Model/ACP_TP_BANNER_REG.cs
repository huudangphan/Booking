namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_BANNER_REG
/// </summary>
public class ACP_TP_BANNER_REG
{
	public const string SP_NAME = "ACP_TP_BANNER_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GUBUN
		/// </summary>
		[Description("GUBUN")]
		public string GUBUN { get; set; }
		/// <summary>
		/// BI_IDX
		/// </summary>
		[Description("BI_IDX")]
		public int BI_IDX { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Description("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// IMAGEURL
		/// </summary>
		[Description("IMAGEURL")]
		public string IMAGEURL { get; set; }
		/// <summary>
		/// MAIN_TITLE
		/// </summary>
		[Description("MAIN_TITLE")]
		public string MAIN_TITLE { get; set; }
		/// <summary>
		/// SUB_TITLE1
		/// </summary>
		[Description("SUB_TITLE1")]
		public string SUB_TITLE1 { get; set; }
		/// <summary>
		/// SUB_TITLE2
		/// </summary>
		[Description("SUB_TITLE2")]
		public string SUB_TITLE2 { get; set; }
		/// <summary>
		/// BG_COLOR
		/// </summary>
		[Description("BG_COLOR")]
		public string BG_COLOR { get; set; }
		/// <summary>
		/// FONT_COLOR
		/// </summary>
		[Description("FONT_COLOR")]
		public string FONT_COLOR { get; set; }
		/// <summary>
		/// START_DT
		/// </summary>
		[Description("START_DT")]
		public DateTime START_DT { get; set; }
		/// <summary>
		/// END_DT
		/// </summary>
		[Description("END_DT")]
		public DateTime END_DT { get; set; }
		/// <summary>
		/// PAY_DT
		/// </summary>
		[Description("PAY_DT")]
		public DateTime PAY_DT { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
	}

	public class Result : IDbResult
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
}