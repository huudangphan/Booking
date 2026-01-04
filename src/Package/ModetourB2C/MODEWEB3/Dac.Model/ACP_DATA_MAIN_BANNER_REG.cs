namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_DATA_MAIN_BANNER_REG
/// </summary>
public class ACP_DATA_MAIN_BANNER_REG
{
	public const string SP_NAME = "ACP_DATA_MAIN_BANNER_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Description("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// GMA_IDX
		/// </summary>
		[Description("GMA_IDX")]
		public int GMA_IDX { get; set; }
		/// <summary>
		/// EDI_IDX
		/// </summary>
		[Description("EDI_IDX")]
		public int EDI_IDX { get; set; }
		/// <summary>
		/// GMA_SORT
		/// </summary>
		[Description("GMA_SORT")]
		public string GMA_SORT { get; set; }
		/// <summary>
		/// GMA_STATUS
		/// </summary>
		[Description("GMA_STATUS")]
		public string GMA_STATUS { get; set; }
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
		/// GMA_IDX
		/// </summary>
		[Column("GMA_IDX")]
		public int GMA_IDX { get; set; }
	}
}