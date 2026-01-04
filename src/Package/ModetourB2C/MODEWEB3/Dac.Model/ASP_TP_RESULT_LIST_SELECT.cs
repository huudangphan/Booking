namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ASP_TP_RESULT_LIST_SELECT
/// </summary>
public class ASP_TP_RESULT_LIST_SELECT
{
	public const string SP_NAME = "ASP_TP_RESULT_LIST_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// LAST_IDX
		/// </summary>
		[Description("LAST_IDX")]
		public int LAST_IDX { get; set; }
		/// <summary>
		/// SEL_CNT
		/// </summary>
		[Description("SEL_CNT")]
		public int SEL_CNT { get; set; }
		/// <summary>
		/// PAGE
		/// </summary>
		[Description("PAGE")]
		public int PAGE { get; set; }
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
		/// BI_IDX
		/// </summary>
		[Column("BI_IDX")]
		public int BI_IDX { get; set; }
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
		/// REGDATE
		/// </summary>
		[Column("REGDATE")]
		public DateTime REGDATE { get; set; }
		/// <summary>
		/// ROWNUMBER
		/// </summary>
		[Column("ROWNUMBER")]
		public long ROWNUMBER { get; set; }
	}
}