namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_REG
/// </summary>
public class ACP_SITE_REG
{
	public const string SP_NAME = "ACP_SITE_REG";

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
		/// CREATE_AUS_PTID
		/// </summary>
		[Description("CREATE_AUS_PTID")]
		public int CREATE_AUS_PTID { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Description("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// SI_TYPE
		/// </summary>
		[Description("SI_TYPE")]
		public string SI_TYPE { get; set; }
		/// <summary>
		/// SI_SVC
		/// </summary>
		[Description("SI_SVC")]
		public string SI_SVC { get; set; }
		/// <summary>
		/// SI_SECU
		/// </summary>
		[Description("SI_SECU")]
		public string SI_SECU { get; set; }
		/// <summary>
		/// SI_FRAME
		/// </summary>
		[Description("SI_FRAME")]
		public string SI_FRAME { get; set; }
		/// <summary>
		/// SI_NAME
		/// </summary>
		[Description("SI_NAME")]
		public string SI_NAME { get; set; }
		/// <summary>
		/// SI_DOMAIN
		/// </summary>
		[Description("SI_DOMAIN")]
		public string SI_DOMAIN { get; set; }
		/// <summary>
		/// SI_SITECODE
		/// </summary>
		[Description("SI_SITECODE")]
		public int SI_SITECODE { get; set; }
		/// <summary>
		/// TRADE_PTID
		/// </summary>
		[Description("TRADE_PTID")]
		public int TRADE_PTID { get; set; }
		/// <summary>
		/// PARTNER_PTID
		/// </summary>
		[Description("PARTNER_PTID")]
		public int PARTNER_PTID { get; set; }
		/// <summary>
		/// SI_XML
		/// </summary>
		[Description("SI_XML")]
		public string SI_XML { get; set; }
		/// <summary>
		/// RTA_IDX
		/// </summary>
		[Description("RTA_IDX")]
		public int RTA_IDX { get; set; }
		/// <summary>
		/// SI_PAYMENT
		/// </summary>
		[Description("SI_PAYMENT")]
		public string SI_PAYMENT { get; set; }
		/// <summary>
		/// SI_STATUS
		/// </summary>
		[Description("SI_STATUS")]
		public string SI_STATUS { get; set; }
		/// <summary>
		/// SI_SVC_IP
		/// </summary>
		[Description("SI_SVC_IP")]
		public string SI_SVC_IP { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// CHG_URL
		/// </summary>
		[Description("CHG_URL")]
		public string CHG_URL { get; set; }
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
		/// AUTHKEY
		/// </summary>
		[Column("AUTHKEY")]
		public Guid AUTHKEY { get; set; }
	}
}