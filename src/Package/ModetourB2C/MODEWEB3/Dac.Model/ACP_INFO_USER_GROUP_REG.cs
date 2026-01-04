namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_INFO_USER_GROUP_REG
/// </summary>
public class ACP_INFO_USER_GROUP_REG
{
	public const string SP_NAME = "ACP_INFO_USER_GROUP_REG";

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
		/// AUGR_PTID
		/// </summary>
		[Description("AUGR_PTID")]
		public int AUGR_PTID { get; set; }
		/// <summary>
		/// AUGR_TYPE
		/// </summary>
		[Description("AUGR_TYPE")]
		public string AUGR_TYPE { get; set; }
		/// <summary>
		/// AUGR_RIGHT
		/// </summary>
		[Description("AUGR_RIGHT")]
		public string AUGR_RIGHT { get; set; }
		/// <summary>
		/// AUGR_MEMO
		/// </summary>
		[Description("AUGR_MEMO")]
		public string AUGR_MEMO { get; set; }
		/// <summary>
		/// AUGR_STATUS
		/// </summary>
		[Description("AUGR_STATUS")]
		public string AUGR_STATUS { get; set; }
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
		/// AUGR_IDX
		/// </summary>
		[Column("AUGR_IDX")]
		public int AUGR_IDX { get; set; }
		/// <summary>
		/// AUGR_PTID
		/// </summary>
		[Column("AUGR_PTID")]
		public int AUGR_PTID { get; set; }
	}
}