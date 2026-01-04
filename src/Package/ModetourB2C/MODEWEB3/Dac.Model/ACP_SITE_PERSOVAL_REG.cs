namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_PERSOVAL_REG
/// </summary>
public class ACP_SITE_PERSOVAL_REG
{
	public const string SP_NAME = "ACP_SITE_PERSOVAL_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// IDX
		/// </summary>
		[Description("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Description("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Description("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// FILENM
		/// </summary>
		[Description("FILENM")]
		public string FILENM { get; set; }
		/// <summary>
		/// STARTDT
		/// </summary>
		[Description("STARTDT")]
		public string STARTDT { get; set; }
		/// <summary>
		/// ENDDT
		/// </summary>
		[Description("ENDDT")]
		public string ENDDT { get; set; }
		/// <summary>
		/// MEMO
		/// </summary>
		[Description("MEMO")]
		public string MEMO { get; set; }
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