namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_ADD_REG
/// </summary>
public class ACP_SITE_ADD_REG
{
	public const string SP_NAME = "ACP_SITE_ADD_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
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
		/// SAD_TYPE
		/// </summary>
		[Description("SAD_TYPE")]
		public string SAD_TYPE { get; set; }
		/// <summary>
		/// SAD_USER_YN
		/// </summary>
		[Description("SAD_USER_YN")]
		public string SAD_USER_YN { get; set; }
		/// <summary>
		/// SAD_INCLUDE_YN
		/// </summary>
		[Description("SAD_INCLUDE_YN")]
		public string SAD_INCLUDE_YN { get; set; }
		/// <summary>
		/// SAD_POS
		/// </summary>
		[Description("SAD_POS")]
		public string SAD_POS { get; set; }
		/// <summary>
		/// SAD_FILE
		/// </summary>
		[Description("SAD_FILE")]
		public string SAD_FILE { get; set; }
		/// <summary>
		/// SAD_TAG
		/// </summary>
		[Description("SAD_TAG")]
		public string SAD_TAG { get; set; }
		/// <summary>
		/// SAD_MEMO
		/// </summary>
		[Description("SAD_MEMO")]
		public string SAD_MEMO { get; set; }
		/// <summary>
		/// SAD_SORT
		/// </summary>
		[Description("SAD_SORT")]
		public string SAD_SORT { get; set; }
		/// <summary>
		/// SAD_DEV
		/// </summary>
		[Description("SAD_DEV")]
		public string SAD_DEV { get; set; }
		/// <summary>
		/// SAD_STATUS
		/// </summary>
		[Description("SAD_STATUS")]
		public string SAD_STATUS { get; set; }
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
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// SAD_IDX
		/// </summary>
		[Column("SAD_IDX")]
		public int SAD_IDX { get; set; }
	}
}