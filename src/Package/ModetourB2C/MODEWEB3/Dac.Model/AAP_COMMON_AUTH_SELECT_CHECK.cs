namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// AAP_COMMON_AUTH_SELECT_CHECK
/// </summary>
public class AAP_COMMON_AUTH_SELECT_CHECK
{
	public const string SP_NAME = "AAP_COMMON_AUTH_SELECT_CHECK";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// AUTH_TYPE
		/// </summary>
		[Description("AUTH_TYPE")]
		public string AUTH_TYPE { get; set; }
		/// <summary>
		/// AUTH_DOMAIN
		/// </summary>
		[Description("AUTH_DOMAIN")]
		public string AUTH_DOMAIN { get; set; }
		/// <summary>
		/// AUTH_AUTHKEY
		/// </summary>
		[Description("AUTH_AUTHKEY")]
		public string AUTH_AUTHKEY { get; set; }
		/// <summary>
		/// AUTH_IP
		/// </summary>
		[Description("AUTH_IP")]
		public string AUTH_IP { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// EXCEPT_YN
		/// </summary>
		[Column("EXCEPT_YN")]
		public string EXCEPT_YN { get; set; }
		/// <summary>
		/// DOMAIN
		/// </summary>
		[Column("DOMAIN")]
		public string DOMAIN { get; set; }
	}

	public class Result2 : IDbResult
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
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// TRADE_PTID
		/// </summary>
		[Column("TRADE_PTID")]
		public int TRADE_PTID { get; set; }
		/// <summary>
		/// DOMAIN
		/// </summary>
		[Column("DOMAIN")]
		public string DOMAIN { get; set; }
	}

	public class Result3 : IDbResult
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
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// TRADE_PTID
		/// </summary>
		[Column("TRADE_PTID")]
		public int TRADE_PTID { get; set; }
		/// <summary>
		/// DOMAIN
		/// </summary>
		[Column("DOMAIN")]
		public string DOMAIN { get; set; }
		/// <summary>
		/// APIKEY
		/// </summary>
		[Column("APIKEY")]
		public string APIKEY { get; set; }
		/// <summary>
		/// SI_SVC
		/// </summary>
		[Column("SI_SVC")]
		public string SI_SVC { get; set; }
		/// <summary>
		/// SI_FRAME
		/// </summary>
		[Column("SI_FRAME")]
		public string SI_FRAME { get; set; }
		/// <summary>
		/// SITE_CODE
		/// </summary>
		[Column("SITE_CODE")]
		public int SITE_CODE { get; set; }
	}
}