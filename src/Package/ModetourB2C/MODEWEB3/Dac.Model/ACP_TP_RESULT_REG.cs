namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_RESULT_REG
/// </summary>
public class ACP_TP_RESULT_REG
{
	public const string SP_NAME = "ACP_TP_RESULT_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// RE_IDX
		/// </summary>
		[Description("RE_IDX")]
		public int RE_IDX { get; set; }
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
		/// CONTENTS
		/// </summary>
		[Description("CONTENTS")]
		public string CONTENTS { get; set; }
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