namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_ADD_SELECT
/// </summary>
public class ACP_SITE_ADD_SELECT
{
	public const string SP_NAME = "ACP_SITE_ADD_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// FILE_TYPE
		/// </summary>
		[Description("FILE_TYPE")]
		public string FILE_TYPE { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Description("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// SAD_IDX
		/// </summary>
		[Description("SAD_IDX")]
		public int SAD_IDX { get; set; }
		/// <summary>
		/// SAD_STATUS
		/// </summary>
		[Description("SAD_STATUS")]
		public string SAD_STATUS { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// RSH_IDX
		/// </summary>
		[Column("RSH_IDX")]
		public int RSH_IDX { get; set; }
		/// <summary>
		/// SNS_TYPE
		/// </summary>
		[Column("SNS_TYPE")]
		public string SNS_TYPE { get; set; }
		/// <summary>
		/// RSH_KEY
		/// </summary>
		[Column("RSH_KEY")]
		public string RSH_KEY { get; set; }
		/// <summary>
		/// RSH_MEMO
		/// </summary>
		[Column("RSH_MEMO")]
		public string RSH_MEMO { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// SI_FRAME
		/// </summary>
		[Column("SI_FRAME")]
		public string SI_FRAME { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// SAD_IDX
		/// </summary>
		[Column("SAD_IDX")]
		public int SAD_IDX { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// SAD_TYPE
		/// </summary>
		[Column("SAD_TYPE")]
		public string SAD_TYPE { get; set; }
		/// <summary>
		/// SAD_USER_YN
		/// </summary>
		[Column("SAD_USER_YN")]
		public string SAD_USER_YN { get; set; }
		/// <summary>
		/// SAD_INCLUDE_YN
		/// </summary>
		[Column("SAD_INCLUDE_YN")]
		public string SAD_INCLUDE_YN { get; set; }
		/// <summary>
		/// SAD_POS
		/// </summary>
		[Column("SAD_POS")]
		public string SAD_POS { get; set; }
		/// <summary>
		/// SAD_FILE
		/// </summary>
		[Column("SAD_FILE")]
		public string SAD_FILE { get; set; }
		/// <summary>
		/// SAD_DEV
		/// </summary>
		[Column("SAD_DEV")]
		public string SAD_DEV { get; set; }
		/// <summary>
		/// SAD_STATUS
		/// </summary>
		[Column("SAD_STATUS")]
		public string SAD_STATUS { get; set; }
		/// <summary>
		/// SAD_REGDATE
		/// </summary>
		[Column("SAD_REGDATE")]
		public DateTime SAD_REGDATE { get; set; }
		/// <summary>
		/// SAD_TAG
		/// </summary>
		[Column("SAD_TAG")]
		public string SAD_TAG { get; set; }
		/// <summary>
		/// SAD_MEMO
		/// </summary>
		[Column("SAD_MEMO")]
		public string SAD_MEMO { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// SAD_IDX
		/// </summary>
		[Column("SAD_IDX")]
		public int SAD_IDX { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// SAD_TYPE
		/// </summary>
		[Column("SAD_TYPE")]
		public string SAD_TYPE { get; set; }
		/// <summary>
		/// SAD_USER_YN
		/// </summary>
		[Column("SAD_USER_YN")]
		public string SAD_USER_YN { get; set; }
		/// <summary>
		/// SAD_INCLUDE_YN
		/// </summary>
		[Column("SAD_INCLUDE_YN")]
		public string SAD_INCLUDE_YN { get; set; }
		/// <summary>
		/// SAD_POS
		/// </summary>
		[Column("SAD_POS")]
		public string SAD_POS { get; set; }
		/// <summary>
		/// SAD_FILE
		/// </summary>
		[Column("SAD_FILE")]
		public string SAD_FILE { get; set; }
		/// <summary>
		/// SAD_DEV
		/// </summary>
		[Column("SAD_DEV")]
		public string SAD_DEV { get; set; }
		/// <summary>
		/// SAD_STATUS
		/// </summary>
		[Column("SAD_STATUS")]
		public string SAD_STATUS { get; set; }
		/// <summary>
		/// SAD_REGDATE
		/// </summary>
		[Column("SAD_REGDATE")]
		public DateTime SAD_REGDATE { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// DOMAIN
		/// </summary>
		[Column("DOMAIN")]
		public string DOMAIN { get; set; }
		/// <summary>
		/// SAD_IDX
		/// </summary>
		[Column("SAD_IDX")]
		public int SAD_IDX { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// SAD_TYPE
		/// </summary>
		[Column("SAD_TYPE")]
		public string SAD_TYPE { get; set; }
		/// <summary>
		/// SAD_USER_YN
		/// </summary>
		[Column("SAD_USER_YN")]
		public string SAD_USER_YN { get; set; }
		/// <summary>
		/// SAD_INCLUDE_YN
		/// </summary>
		[Column("SAD_INCLUDE_YN")]
		public string SAD_INCLUDE_YN { get; set; }
		/// <summary>
		/// SAD_POS
		/// </summary>
		[Column("SAD_POS")]
		public string SAD_POS { get; set; }
		/// <summary>
		/// SAD_FILE
		/// </summary>
		[Column("SAD_FILE")]
		public string SAD_FILE { get; set; }
		/// <summary>
		/// SAD_DEV
		/// </summary>
		[Column("SAD_DEV")]
		public string SAD_DEV { get; set; }
		/// <summary>
		/// SAD_STATUS
		/// </summary>
		[Column("SAD_STATUS")]
		public string SAD_STATUS { get; set; }
		/// <summary>
		/// SAD_REGDATE
		/// </summary>
		[Column("SAD_REGDATE")]
		public DateTime SAD_REGDATE { get; set; }
	}
}