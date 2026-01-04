namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_INFO_USER_REG
/// </summary>
public class ACP_INFO_USER_REG
{
	public const string SP_NAME = "ACP_INFO_USER_REG";

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
		/// AUS_PTID_UP
		/// </summary>
		[Description("AUS_PTID_UP")]
		public int AUS_PTID_UP { get; set; }
		/// <summary>
		/// AUS_RIGHT
		/// </summary>
		[Description("AUS_RIGHT")]
		public string AUS_RIGHT { get; set; }
		/// <summary>
		/// AUS_STATUS
		/// </summary>
		[Description("AUS_STATUS")]
		public string AUS_STATUS { get; set; }
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
		/// AUS_PTID
		/// </summary>
		[Column("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}
}