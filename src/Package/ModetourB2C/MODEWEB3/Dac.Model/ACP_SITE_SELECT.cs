namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_SELECT
/// </summary>
public class ACP_SITE_SELECT
{
	public const string SP_NAME = "ACP_SITE_SELECT";

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
		/// SI_IDX
		/// </summary>
		[Description("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// SI_STATUS
		/// </summary>
		[Description("SI_STATUS")]
		public string SI_STATUS { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// SI_TYPE
		/// </summary>
		[Column("SI_TYPE")]
		public string SI_TYPE { get; set; }
		/// <summary>
		/// SI_SVC
		/// </summary>
		[Column("SI_SVC")]
		public string SI_SVC { get; set; }
		/// <summary>
		/// SI_SECU
		/// </summary>
		[Column("SI_SECU")]
		public string SI_SECU { get; set; }
		/// <summary>
		/// SI_NAME
		/// </summary>
		[Column("SI_NAME")]
		public string SI_NAME { get; set; }
		/// <summary>
		/// SI_DOMAIN
		/// </summary>
		[Column("SI_DOMAIN")]
		public string SI_DOMAIN { get; set; }
		/// <summary>
		/// SI_SITECODE
		/// </summary>
		[Column("SI_SITECODE")]
		public int SI_SITECODE { get; set; }
		/// <summary>
		/// TRADE_PTID
		/// </summary>
		[Column("TRADE_PTID")]
		public int TRADE_PTID { get; set; }
		/// <summary>
		/// TRADE_NAME
		/// </summary>
		[Column("TRADE_NAME")]
		public string TRADE_NAME { get; set; }
		/// <summary>
		/// PARTNER_PTID
		/// </summary>
		[Column("PARTNER_PTID")]
		public int PARTNER_PTID { get; set; }
		/// <summary>
		/// PARTNER_NAME
		/// </summary>
		[Column("PARTNER_NAME")]
		public string PARTNER_NAME { get; set; }
		/// <summary>
		/// SI_XML
		/// </summary>
		[Column("SI_XML")]
		public string SI_XML { get; set; }
		/// <summary>
		/// SI_FRAME
		/// </summary>
		[Column("SI_FRAME")]
		public string SI_FRAME { get; set; }
		/// <summary>
		/// RTA_IDX
		/// </summary>
		[Column("RTA_IDX")]
		public int RTA_IDX { get; set; }
		/// <summary>
		/// SI_PAYMENT
		/// </summary>
		[Column("SI_PAYMENT")]
		public string SI_PAYMENT { get; set; }
		/// <summary>
		/// SI_STATUS
		/// </summary>
		[Column("SI_STATUS")]
		public string SI_STATUS { get; set; }
		/// <summary>
		/// SI_SVC_IP
		/// </summary>
		[Column("SI_SVC_IP")]
		public string SI_SVC_IP { get; set; }
		/// <summary>
		/// SI_REGDATE
		/// </summary>
		[Column("SI_REGDATE")]
		public DateTime SI_REGDATE { get; set; }
		/// <summary>
		/// SI_MODDATE
		/// </summary>
		[Column("SI_MODDATE")]
		public DateTime SI_MODDATE { get; set; }
		/// <summary>
		/// SI_TITLE
		/// </summary>
		[Column("SI_TITLE")]
		public string SI_TITLE { get; set; }
		/// <summary>
		/// AUS_NAME
		/// </summary>
		[Column("AUS_NAME")]
		public string AUS_NAME { get; set; }
		/// <summary>
		/// QA
		/// </summary>
		[Column("QA")]
		public string QA { get; set; }
		/// <summary>
		/// REAL
		/// </summary>
		[Column("REAL")]
		public string REAL { get; set; }
		/// <summary>
		/// DEL
		/// </summary>
		[Column("DEL")]
		public string DEL { get; set; }
		/// <summary>
		/// CREATE_NAME
		/// </summary>
		[Column("CREATE_NAME")]
		public string CREATE_NAME { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// SI_TYPE
		/// </summary>
		[Column("SI_TYPE")]
		public string SI_TYPE { get; set; }
		/// <summary>
		/// SI_SVC
		/// </summary>
		[Column("SI_SVC")]
		public string SI_SVC { get; set; }
		/// <summary>
		/// SI_SECU
		/// </summary>
		[Column("SI_SECU")]
		public string SI_SECU { get; set; }
		/// <summary>
		/// SI_NAME
		/// </summary>
		[Column("SI_NAME")]
		public string SI_NAME { get; set; }
		/// <summary>
		/// SI_DOMAIN
		/// </summary>
		[Column("SI_DOMAIN")]
		public string SI_DOMAIN { get; set; }
		/// <summary>
		/// SI_SITECODE
		/// </summary>
		[Column("SI_SITECODE")]
		public int SI_SITECODE { get; set; }
		/// <summary>
		/// TRADE_PTID
		/// </summary>
		[Column("TRADE_PTID")]
		public int TRADE_PTID { get; set; }
		/// <summary>
		/// TRADE_NAME
		/// </summary>
		[Column("TRADE_NAME")]
		public string TRADE_NAME { get; set; }
		/// <summary>
		/// PARTNER_PTID
		/// </summary>
		[Column("PARTNER_PTID")]
		public int PARTNER_PTID { get; set; }
		/// <summary>
		/// PARTNER_NAME
		/// </summary>
		[Column("PARTNER_NAME")]
		public string PARTNER_NAME { get; set; }
		/// <summary>
		/// SI_XML
		/// </summary>
		[Column("SI_XML")]
		public string SI_XML { get; set; }
		/// <summary>
		/// SI_FRAME
		/// </summary>
		[Column("SI_FRAME")]
		public string SI_FRAME { get; set; }
		/// <summary>
		/// SI_PAYMENT
		/// </summary>
		[Column("SI_PAYMENT")]
		public string SI_PAYMENT { get; set; }
		/// <summary>
		/// SI_STATUS
		/// </summary>
		[Column("SI_STATUS")]
		public string SI_STATUS { get; set; }
		/// <summary>
		/// SI_SVC_IP
		/// </summary>
		[Column("SI_SVC_IP")]
		public string SI_SVC_IP { get; set; }
		/// <summary>
		/// SI_REGDATE
		/// </summary>
		[Column("SI_REGDATE")]
		public DateTime SI_REGDATE { get; set; }
		/// <summary>
		/// SI_MODDATE
		/// </summary>
		[Column("SI_MODDATE")]
		public DateTime SI_MODDATE { get; set; }
		/// <summary>
		/// RTA_IDX
		/// </summary>
		[Column("RTA_IDX")]
		public int RTA_IDX { get; set; }
		/// <summary>
		/// RTA_IMG
		/// </summary>
		[Column("RTA_IMG")]
		public string RTA_IMG { get; set; }
		/// <summary>
		/// AUGR_IDX
		/// </summary>
		[Column("AUGR_IDX")]
		public int AUGR_IDX { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Column("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// AUTH_KEY
		/// </summary>
		[Column("AUTH_KEY")]
		public Guid AUTH_KEY { get; set; }
		/// <summary>
		/// GR_TITLE
		/// </summary>
		[Column("GR_TITLE")]
		public string GR_TITLE { get; set; }
		/// <summary>
		/// AUGR_MEMO
		/// </summary>
		[Column("AUGR_MEMO")]
		public string AUGR_MEMO { get; set; }
		/// <summary>
		/// AUS_NAME
		/// </summary>
		[Column("AUS_NAME")]
		public string AUS_NAME { get; set; }
		/// <summary>
		/// FOOTER_YN
		/// </summary>
		[Column("FOOTER_YN")]
		public string FOOTER_YN { get; set; }
		/// <summary>
		/// SI_TITLE
		/// </summary>
		[Column("SI_TITLE")]
		public string SI_TITLE { get; set; }
	}
}