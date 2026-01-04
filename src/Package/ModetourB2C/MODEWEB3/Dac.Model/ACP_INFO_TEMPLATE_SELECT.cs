namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_INFO_TEMPLATE_SELECT
/// </summary>
public class ACP_INFO_TEMPLATE_SELECT
{
	public const string SP_NAME = "ACP_INFO_TEMPLATE_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// TE_IDX
		/// </summary>
		[Description("TE_IDX")]
		public int TE_IDX { get; set; }
		/// <summary>
		/// TE_TYPE
		/// </summary>
		[Description("TE_TYPE")]
		public string TE_TYPE { get; set; }
		/// <summary>
		/// TE_STATUS
		/// </summary>
		[Description("TE_STATUS")]
		public string TE_STATUS { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// TE_IDX
		/// </summary>
		[Column("TE_IDX")]
		public int TE_IDX { get; set; }
		/// <summary>
		/// TE_TYPE
		/// </summary>
		[Column("TE_TYPE")]
		public string TE_TYPE { get; set; }
		/// <summary>
		/// TE_CODE
		/// </summary>
		[Column("TE_CODE")]
		public string TE_CODE { get; set; }
		/// <summary>
		/// TE_TITLE
		/// </summary>
		[Column("TE_TITLE")]
		public string TE_TITLE { get; set; }
		/// <summary>
		/// TE_STATUS
		/// </summary>
		[Column("TE_STATUS")]
		public string TE_STATUS { get; set; }
		/// <summary>
		/// TE_REGDATE
		/// </summary>
		[Column("TE_REGDATE")]
		public DateTime TE_REGDATE { get; set; }
		/// <summary>
		/// TE_MODDATE
		/// </summary>
		[Column("TE_MODDATE")]
		public DateTime TE_MODDATE { get; set; }
		/// <summary>
		/// TE_COUNT
		/// </summary>
		[Column("TE_COUNT")]
		public int TE_COUNT { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// TTY_IDX
		/// </summary>
		[Column("TTY_IDX")]
		public int TTY_IDX { get; set; }
		/// <summary>
		/// TE_IDX
		/// </summary>
		[Column("TE_IDX")]
		public int TE_IDX { get; set; }
		/// <summary>
		/// TTY_TYPE
		/// </summary>
		[Column("TTY_TYPE")]
		public string TTY_TYPE { get; set; }
		/// <summary>
		/// TTY_TITLE
		/// </summary>
		[Column("TTY_TITLE")]
		public string TTY_TITLE { get; set; }
		/// <summary>
		/// TTY_COUNT
		/// </summary>
		[Column("TTY_COUNT")]
		public int TTY_COUNT { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// TCO_IDX
		/// </summary>
		[Column("TCO_IDX")]
		public int TCO_IDX { get; set; }
		/// <summary>
		/// TE_IDX
		/// </summary>
		[Column("TE_IDX")]
		public int TE_IDX { get; set; }
		/// <summary>
		/// TCO_CODE
		/// </summary>
		[Column("TCO_CODE")]
		public string TCO_CODE { get; set; }
		/// <summary>
		/// TCO_MEMO
		/// </summary>
		[Column("TCO_MEMO")]
		public string TCO_MEMO { get; set; }
		/// <summary>
		/// TCO_COUNT
		/// </summary>
		[Column("TCO_COUNT")]
		public int TCO_COUNT { get; set; }
	}
}