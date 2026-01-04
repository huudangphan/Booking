namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_INFO_CREATE
/// </summary>
public class ACP_SITE_INFO_CREATE
{
	public const string SP_NAME = "ACP_SITE_INFO_CREATE";

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
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// SVC_YN
		/// </summary>
		[Column("SVC_YN")]
		public string SVC_YN { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// DOMAIN
		/// </summary>
		[Column("DOMAIN")]
		public string DOMAIN { get; set; }
		/// <summary>
		/// IP
		/// </summary>
		[Column("IP")]
		public string IP { get; set; }
		/// <summary>
		/// AUTHKEY
		/// </summary>
		[Column("AUTHKEY")]
		public Guid AUTHKEY { get; set; }
		/// <summary>
		/// TRADE_PTID
		/// </summary>
		[Column("TRADE_PTID")]
		public int TRADE_PTID { get; set; }
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
		/// SI_FRAME
		/// </summary>
		[Column("SI_FRAME")]
		public string SI_FRAME { get; set; }
		/// <summary>
		/// SI_NAME
		/// </summary>
		[Column("SI_NAME")]
		public string SI_NAME { get; set; }
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
		/// RTA_IMG
		/// </summary>
		[Column("RTA_IMG")]
		public string RTA_IMG { get; set; }
		/// <summary>
		/// TMPL_CODE
		/// </summary>
		[Column("TMPL_CODE")]
		public string TMPL_CODE { get; set; }
		/// <summary>
		/// TMPL_TYPE
		/// </summary>
		[Column("TMPL_TYPE")]
		public string TMPL_TYPE { get; set; }
		/// <summary>
		/// TMPL_COLOR
		/// </summary>
		[Column("TMPL_COLOR")]
		public string TMPL_COLOR { get; set; }
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
		/// SIN_MEMO
		/// </summary>
		[Column("SIN_MEMO")]
		public string SIN_MEMO { get; set; }
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
		/// PARTNER_NAME
		/// </summary>
		[Column("PARTNER_NAME")]
		public string PARTNER_NAME { get; set; }
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
		/// BTN_INFO
		/// </summary>
		[Column("BTN_INFO")]
		public string BTN_INFO { get; set; }
		/// <summary>
		/// FOOTER_YN
		/// </summary>
		[Column("FOOTER_YN")]
		public string FOOTER_YN { get; set; }
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
		/// SNS_USE_YN
		/// </summary>
		[Column("SNS_USE_YN")]
		public string SNS_USE_YN { get; set; }
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
		/// SI_FRAME
		/// </summary>
		[Column("SI_FRAME")]
		public string SI_FRAME { get; set; }
		/// <summary>
		/// SI_NAME
		/// </summary>
		[Column("SI_NAME")]
		public string SI_NAME { get; set; }
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
		/// RTA_IMG
		/// </summary>
		[Column("RTA_IMG")]
		public string RTA_IMG { get; set; }
		/// <summary>
		/// TMPL_CODE
		/// </summary>
		[Column("TMPL_CODE")]
		public string TMPL_CODE { get; set; }
		/// <summary>
		/// TMPL_TYPE
		/// </summary>
		[Column("TMPL_TYPE")]
		public string TMPL_TYPE { get; set; }
		/// <summary>
		/// TMPL_COLOR
		/// </summary>
		[Column("TMPL_COLOR")]
		public string TMPL_COLOR { get; set; }
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
		/// SIN_MEMO
		/// </summary>
		[Column("SIN_MEMO")]
		public string SIN_MEMO { get; set; }
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
		/// PARTNER_NAME
		/// </summary>
		[Column("PARTNER_NAME")]
		public string PARTNER_NAME { get; set; }
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
		/// BTN_INFO
		/// </summary>
		[Column("BTN_INFO")]
		public string BTN_INFO { get; set; }
		/// <summary>
		/// FOOTER_YN
		/// </summary>
		[Column("FOOTER_YN")]
		public string FOOTER_YN { get; set; }
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
		/// SNS_USE_YN
		/// </summary>
		[Column("SNS_USE_YN")]
		public string SNS_USE_YN { get; set; }
		/// <summary>
		/// COMPANY_NAME2
		/// </summary>
		[Column("COMPANY_NAME2")]
		public string COMPANY_NAME2 { get; set; }
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

	public class Result5 : IDbResult
	{
		/// <summary>
		/// SLO_IMG
		/// </summary>
		[Column("SLO_IMG")]
		public string SLO_IMG { get; set; }
		/// <summary>
		/// ROLL_CHK
		/// </summary>
		[Column("ROLL_CHK")]
		public string ROLL_CHK { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// SNS_TYPE
		/// </summary>
		[Column("SNS_TYPE")]
		public string SNS_TYPE { get; set; }
		/// <summary>
		/// SNS_TITLE
		/// </summary>
		[Column("SNS_TITLE")]
		public string SNS_TITLE { get; set; }
		/// <summary>
		/// SNS_LINK
		/// </summary>
		[Column("SNS_LINK")]
		public string SNS_LINK { get; set; }
		/// <summary>
		/// SNS_CLASS
		/// </summary>
		[Column("SNS_CLASS")]
		public string SNS_CLASS { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// SAD_TYPE
		/// </summary>
		[Column("SAD_TYPE")]
		public string SAD_TYPE { get; set; }
		/// <summary>
		/// SAD_USER_YN
		/// </summary>
		[Column("SAD_USER_YN")]
		public string SAD_USER_YN { get; set; }
		/// <summary>
		/// SAD_INCLUDE_YN
		/// </summary>
		[Column("SAD_INCLUDE_YN")]
		public string SAD_INCLUDE_YN { get; set; }
		/// <summary>
		/// SAD_POS
		/// </summary>
		[Column("SAD_POS")]
		public string SAD_POS { get; set; }
		/// <summary>
		/// SAD_FILE
		/// </summary>
		[Column("SAD_FILE")]
		public string SAD_FILE { get; set; }
		/// <summary>
		/// SAD_TAG
		/// </summary>
		[Column("SAD_TAG")]
		public string SAD_TAG { get; set; }
	}

	public class Result8 : IDbResult
	{
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
	}

	public class Result9 : IDbResult
	{
		/// <summary>
		/// SNS_TYPE
		/// </summary>
		[Column("SNS_TYPE")]
		public string SNS_TYPE { get; set; }
		/// <summary>
		/// RSH_KEY
		/// </summary>
		[Column("RSH_KEY")]
		public string RSH_KEY { get; set; }
		/// <summary>
		/// ICON_CLASS
		/// </summary>
		[Column("ICON_CLASS")]
		public string ICON_CLASS { get; set; }
	}

	public class Result10 : IDbResult
	{
		/// <summary>
		/// RSH_KEY
		/// </summary>
		[Column("RSH_KEY")]
		public string RSH_KEY { get; set; }
	}

	public class Result11 : IDbResult
	{
		/// <summary>
		/// INPUTTEXT1
		/// </summary>
		[Column("INPUTTEXT1")]
		public string INPUTTEXT1 { get; set; }
		/// <summary>
		/// INPUTTEXT2
		/// </summary>
		[Column("INPUTTEXT2")]
		public string INPUTTEXT2 { get; set; }
		/// <summary>
		/// INPUTTEXT3
		/// </summary>
		[Column("INPUTTEXT3")]
		public string INPUTTEXT3 { get; set; }
	}
}