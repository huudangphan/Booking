namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_PERSONAINFO_AGREE_INSERT
/// </summary>
public class ASP_PERSONAINFO_AGREE_INSERT
{
	public const string SP_NAME = "ASP_PERSONAINFO_AGREE_INSERT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// OID
		/// </summary>
		[Description("OID")]
		public int OID { get; set; }
		/// <summary>
		/// SALES_NO
		/// </summary>
		[Description("SALES_NO")]
		public int SALES_NO { get; set; }
		/// <summary>
		/// NAME
		/// </summary>
		[Description("NAME")]
		public string NAME { get; set; }
		/// <summary>
		/// AGREE_CODE
		/// </summary>
		[Description("AGREE_CODE")]
		public string AGREE_CODE { get; set; }
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