namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_RESULT_SELECT
/// </summary>
public class ACP_TP_RESULT_SELECT
{
	public const string SP_NAME = "ACP_TP_RESULT_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// RE_IDX
		/// </summary>
		[Description("RE_IDX")]
		public int RE_IDX { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// RE_IDX
		/// </summary>
		[Column("RE_IDX")]
		public int RE_IDX { get; set; }
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
		/// CONTENTS
		/// </summary>
		[Column("CONTENTS")]
		public string CONTENTS { get; set; }
		/// <summary>
		/// START_DT
		/// </summary>
		[Column("START_DT")]
		public DateTime START_DT { get; set; }
		/// <summary>
		/// PAY_DT
		/// </summary>
		[Column("PAY_DT")]
		public DateTime PAY_DT { get; set; }
		/// <summary>
		/// REGDATE
		/// </summary>
		[Column("REGDATE")]
		public DateTime REGDATE { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// RE_IDX
		/// </summary>
		[Column("RE_IDX")]
		public int RE_IDX { get; set; }
		/// <summary>
		/// REGDATE
		/// </summary>
		[Column("REGDATE")]
		public DateTime REGDATE { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// PTKNAME
		/// </summary>
		[Column("PTKNAME")]
		public string PTKNAME { get; set; }
		/// <summary>
		/// BI_IDX
		/// </summary>
		[Column("BI_IDX")]
		public int BI_IDX { get; set; }
	}
}