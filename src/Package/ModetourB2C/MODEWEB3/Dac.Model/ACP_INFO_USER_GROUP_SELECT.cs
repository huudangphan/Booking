namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_INFO_USER_GROUP_SELECT
/// </summary>
public class ACP_INFO_USER_GROUP_SELECT
{
	public const string SP_NAME = "ACP_INFO_USER_GROUP_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// AUGR_IDX
		/// </summary>
		[Description("AUGR_IDX")]
		public int AUGR_IDX { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// AUGR_TYPE
		/// </summary>
		[Description("AUGR_TYPE")]
		public string AUGR_TYPE { get; set; }
		/// <summary>
		/// AUGR_STATUS
		/// </summary>
		[Description("AUGR_STATUS")]
		public string AUGR_STATUS { get; set; }
		/// <summary>
		/// AUGR_RIGHT
		/// </summary>
		[Description("AUGR_RIGHT")]
		public string AUGR_RIGHT { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// AUGR_IDX
		/// </summary>
		[Column("AUGR_IDX")]
		public int AUGR_IDX { get; set; }
		/// <summary>
		/// AUGR_PTID
		/// </summary>
		[Column("AUGR_PTID")]
		public int AUGR_PTID { get; set; }
		/// <summary>
		/// AUGR_NAME
		/// </summary>
		[Column("AUGR_NAME")]
		public string AUGR_NAME { get; set; }
		/// <summary>
		/// AUGR_TYPE
		/// </summary>
		[Column("AUGR_TYPE")]
		public string AUGR_TYPE { get; set; }
		/// <summary>
		/// AUGR_RIGHT
		/// </summary>
		[Column("AUGR_RIGHT")]
		public string AUGR_RIGHT { get; set; }
		/// <summary>
		/// AUGR_MEMO
		/// </summary>
		[Column("AUGR_MEMO")]
		public string AUGR_MEMO { get; set; }
		/// <summary>
		/// AUGR_STATUS
		/// </summary>
		[Column("AUGR_STATUS")]
		public string AUGR_STATUS { get; set; }
		/// <summary>
		/// AUGR_REGDATE
		/// </summary>
		[Column("AUGR_REGDATE")]
		public DateTime AUGR_REGDATE { get; set; }
		/// <summary>
		/// AUGR_MODDATE
		/// </summary>
		[Column("AUGR_MODDATE")]
		public DateTime AUGR_MODDATE { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// AUGR_IDX
		/// </summary>
		[Column("AUGR_IDX")]
		public int AUGR_IDX { get; set; }
		/// <summary>
		/// AUGR_PTID
		/// </summary>
		[Column("AUGR_PTID")]
		public int AUGR_PTID { get; set; }
		/// <summary>
		/// AUGR_NAME
		/// </summary>
		[Column("AUGR_NAME")]
		public string AUGR_NAME { get; set; }
	}
}