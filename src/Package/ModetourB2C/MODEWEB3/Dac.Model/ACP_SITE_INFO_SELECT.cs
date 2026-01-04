namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_INFO_SELECT
/// </summary>
public class ACP_SITE_INFO_SELECT
{
	public const string SP_NAME = "ACP_SITE_INFO_SELECT";

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
		/// AUGR_RIGHT
		/// </summary>
		[Column("AUGR_RIGHT")]
		public string AUGR_RIGHT { get; set; }
		/// <summary>
		/// AUS_RIGHT
		/// </summary>
		[Column("AUS_RIGHT")]
		public string AUS_RIGHT { get; set; }
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
		/// TE_TITLE
		/// </summary>
		[Column("TE_TITLE")]
		public string TE_TITLE { get; set; }
		/// <summary>
		/// GR_TITLE
		/// </summary>
		[Column("GR_TITLE")]
		public string GR_TITLE { get; set; }
		/// <summary>
		/// SI_TITLE
		/// </summary>
		[Column("SI_TITLE")]
		public string SI_TITLE { get; set; }
		/// <summary>
		/// TRADE_CODE
		/// </summary>
		[Column("TRADE_CODE")]
		public string TRADE_CODE { get; set; }
		/// <summary>
		/// SITE_YN
		/// </summary>
		[Column("SITE_YN")]
		public string SITE_YN { get; set; }
		/// <summary>
		/// REQUIREDLOGIN_YN
		/// </summary>
		[Column("REQUIREDLOGIN_YN")]
		public string REQUIREDLOGIN_YN { get; set; }
		/// <summary>
		/// CNT
		/// </summary>
		[Column("CNT")]
		public int CNT { get; set; }
	}

	public class Result3 : IDbResult
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
		/// TE_TITLE
		/// </summary>
		[Column("TE_TITLE")]
		public string TE_TITLE { get; set; }
		/// <summary>
		/// GR_TITLE
		/// </summary>
		[Column("GR_TITLE")]
		public string GR_TITLE { get; set; }
		/// <summary>
		/// COMPANY_NAME
		/// </summary>
		[Column("COMPANY_NAME")]
		public string COMPANY_NAME { get; set; }
		/// <summary>
		/// COMPANY_PRES
		/// </summary>
		[Column("COMPANY_PRES")]
		public string COMPANY_PRES { get; set; }
		/// <summary>
		/// COMPANY_EMAIL
		/// </summary>
		[Column("COMPANY_EMAIL")]
		public string COMPANY_EMAIL { get; set; }
		/// <summary>
		/// COMPANY_PHONE
		/// </summary>
		[Column("COMPANY_PHONE")]
		public string COMPANY_PHONE { get; set; }
		/// <summary>
		/// COMPANY_FAX
		/// </summary>
		[Column("COMPANY_FAX")]
		public string COMPANY_FAX { get; set; }
		/// <summary>
		/// COMPANY_ADDR
		/// </summary>
		[Column("COMPANY_ADDR")]
		public string COMPANY_ADDR { get; set; }
		/// <summary>
		/// COMPANY_ADDR2
		/// </summary>
		[Column("COMPANY_ADDR2")]
		public string COMPANY_ADDR2 { get; set; }
		/// <summary>
		/// COMPANY_INFO1
		/// </summary>
		[Column("COMPANY_INFO1")]
		public string COMPANY_INFO1 { get; set; }
		/// <summary>
		/// COMPANY_INFO2
		/// </summary>
		[Column("COMPANY_INFO2")]
		public string COMPANY_INFO2 { get; set; }
		/// <summary>
		/// COMPANY_INFO3
		/// </summary>
		[Column("COMPANY_INFO3")]
		public string COMPANY_INFO3 { get; set; }
		/// <summary>
		/// COMPANY_INFO4
		/// </summary>
		[Column("COMPANY_INFO4")]
		public string COMPANY_INFO4 { get; set; }
		/// <summary>
		/// COMPANY_INFO5
		/// </summary>
		[Column("COMPANY_INFO5")]
		public string COMPANY_INFO5 { get; set; }
		/// <summary>
		/// SIN_TOP_BANNER
		/// </summary>
		[Column("SIN_TOP_BANNER")]
		public string SIN_TOP_BANNER { get; set; }
		/// <summary>
		/// SIN_TOP_LINK
		/// </summary>
		[Column("SIN_TOP_LINK")]
		public string SIN_TOP_LINK { get; set; }
		/// <summary>
		/// CHANGE_WEB
		/// </summary>
		[Column("CHANGE_WEB")]
		public string CHANGE_WEB { get; set; }
		/// <summary>
		/// CHANGE_MOBILE
		/// </summary>
		[Column("CHANGE_MOBILE")]
		public string CHANGE_MOBILE { get; set; }
		/// <summary>
		/// SNS_USE_YN
		/// </summary>
		[Column("SNS_USE_YN")]
		public string SNS_USE_YN { get; set; }
		/// <summary>
		/// BTN_INFO
		/// </summary>
		[Column("BTN_INFO")]
		public string BTN_INFO { get; set; }
		/// <summary>
		/// SI_API
		/// </summary>
		[Column("SI_API")]
		public string SI_API { get; set; }
		/// <summary>
		/// SIN_MEMO
		/// </summary>
		[Column("SIN_MEMO")]
		public string SIN_MEMO { get; set; }
		/// <summary>
		/// TARGET_POPUP
		/// </summary>
		[Column("TARGET_POPUP")]
		public string TARGET_POPUP { get; set; }
		/// <summary>
		/// BIFURCATION_YN
		/// </summary>
		[Column("BIFURCATION_YN")]
		public string BIFURCATION_YN { get; set; }
		/// <summary>
		/// BASICLOGO_YN
		/// </summary>
		[Column("BASICLOGO_YN")]
		public string BASICLOGO_YN { get; set; }
		/// <summary>
		/// REQUIREDLOGIN_YN
		/// </summary>
		[Column("REQUIREDLOGIN_YN")]
		public string REQUIREDLOGIN_YN { get; set; }
		/// <summary>
		/// SI_TITLE
		/// </summary>
		[Column("SI_TITLE")]
		public string SI_TITLE { get; set; }
		/// <summary>
		/// TTY_IDX
		/// </summary>
		[Column("TTY_IDX")]
		public int TTY_IDX { get; set; }
		/// <summary>
		/// TE_IDX
		/// </summary>
		[Column("TE_IDX")]
		public int TE_IDX { get; set; }
		/// <summary>
		/// TCO_IDX
		/// </summary>
		[Column("TCO_IDX")]
		public int TCO_IDX { get; set; }
		/// <summary>
		/// MOVE_PAGE
		/// </summary>
		[Column("MOVE_PAGE")]
		public string MOVE_PAGE { get; set; }
		/// <summary>
		/// HOMESHOPPING_YN
		/// </summary>
		[Column("HOMESHOPPING_YN")]
		public string HOMESHOPPING_YN { get; set; }
		/// <summary>
		/// PAYMENTBTN_YN
		/// </summary>
		[Column("PAYMENTBTN_YN")]
		public string PAYMENTBTN_YN { get; set; }
		/// <summary>
		/// HOTEL_YN
		/// </summary>
		[Column("HOTEL_YN")]
		public string HOTEL_YN { get; set; }
		/// <summary>
		/// AIR_YN
		/// </summary>
		[Column("AIR_YN")]
		public string AIR_YN { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// SCO_IDX
		/// </summary>
		[Column("SCO_IDX")]
		public int SCO_IDX { get; set; }
		/// <summary>
		/// SCO_WEEK
		/// </summary>
		[Column("SCO_WEEK")]
		public string SCO_WEEK { get; set; }
		/// <summary>
		/// SCO_TIME
		/// </summary>
		[Column("SCO_TIME")]
		public string SCO_TIME { get; set; }
		/// <summary>
		/// SCO_TYPE
		/// </summary>
		[Column("SCO_TYPE")]
		public string SCO_TYPE { get; set; }
		/// <summary>
		/// SCO_STATUS
		/// </summary>
		[Column("SCO_STATUS")]
		public string SCO_STATUS { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// AAU_AUTHKEY
		/// </summary>
		[Column("AAU_AUTHKEY")]
		public Guid AAU_AUTHKEY { get; set; }
	}
}