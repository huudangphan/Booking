namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_SNS_REG
/// </summary>
public class ACP_SITE_SNS_REG
{
	public const string SP_NAME = "ACP_SITE_SNS_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Description("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// SNS_TYPE
		/// </summary>
		[Description("SNS_TYPE")]
		public string SNS_TYPE { get; set; }
		/// <summary>
		/// SSN_LINK
		/// </summary>
		[Description("SSN_LINK")]
		public string SSN_LINK { get; set; }
		/// <summary>
		/// SSN_USE
		/// </summary>
		[Description("SSN_USE")]
		public string SSN_USE { get; set; }
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
	}
}