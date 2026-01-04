namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_OUTLOGIN_REG
/// </summary>
public class ACP_SITE_OUTLOGIN_REG
{
	public const string SP_NAME = "ACP_SITE_OUTLOGIN_REG";

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
		/// GUBUN
		/// </summary>
		[Description("GUBUN")]
		public string GUBUN { get; set; }
		/// <summary>
		/// SITENM
		/// </summary>
		[Description("SITENM")]
		public string SITENM { get; set; }
		/// <summary>
		/// SITEID
		/// </summary>
		[Description("SITEID")]
		public string SITEID { get; set; }
		/// <summary>
		/// RETURNURL
		/// </summary>
		[Description("RETURNURL")]
		public string RETURNURL { get; set; }
		/// <summary>
		/// STATUS
		/// </summary>
		[Description("STATUS")]
		public string STATUS { get; set; }
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