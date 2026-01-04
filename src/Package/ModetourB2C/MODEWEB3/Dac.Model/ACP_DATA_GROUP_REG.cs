namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_DATA_GROUP_REG
/// </summary>
public class ACP_DATA_GROUP_REG
{
	public const string SP_NAME = "ACP_DATA_GROUP_REG";

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
		/// GR_IDX
		/// </summary>
		[Description("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// GR_AUS_PTID
		/// </summary>
		[Description("GR_AUS_PTID")]
		public int GR_AUS_PTID { get; set; }
		/// <summary>
		/// GR_TYPE
		/// </summary>
		[Description("GR_TYPE")]
		public string GR_TYPE { get; set; }
		/// <summary>
		/// GR_DEFAULT
		/// </summary>
		[Description("GR_DEFAULT")]
		public string GR_DEFAULT { get; set; }
		/// <summary>
		/// REF_GR_IDX
		/// </summary>
		[Description("REF_GR_IDX")]
		public int REF_GR_IDX { get; set; }
		/// <summary>
		/// GR_TITLE
		/// </summary>
		[Description("GR_TITLE")]
		public string GR_TITLE { get; set; }
		/// <summary>
		/// MW_START
		/// </summary>
		[Description("MW_START")]
		public string MW_START { get; set; }
		/// <summary>
		/// GR_STATUS
		/// </summary>
		[Description("GR_STATUS")]
		public string GR_STATUS { get; set; }
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
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
	}
}