namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_IIS_REG
/// </summary>
public class ACP_SITE_IIS_REG
{
	public const string SP_NAME = "ACP_SITE_IIS_REG";

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
		/// STATUS
		/// </summary>
		[Description("STATUS")]
		public string STATUS { get; set; }
		/// <summary>
		/// DOMAIN
		/// </summary>
		[Description("DOMAIN")]
		public string DOMAIN { get; set; }
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
		/// ModeTalkID
		/// </summary>
		[Column("ModeTalkID")]
		public int ModeTalkID { get; set; }
		/// <summary>
		/// GUBUN
		/// </summary>
		[Column("GUBUN")]
		public string GUBUN { get; set; }
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
		/// PARTNER_PTID
		/// </summary>
		[Column("PARTNER_PTID")]
		public int PARTNER_PTID { get; set; }
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
		/// AUS_PTID
		/// </summary>
		[Column("AUS_PTID")]
		public int AUS_PTID { get; set; }
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
		/// SI_TEST_REGDATE
		/// </summary>
		[Column("SI_TEST_REGDATE")]
		public DateTime SI_TEST_REGDATE { get; set; }
		/// <summary>
		/// SI_SVC_REGDATE
		/// </summary>
		[Column("SI_SVC_REGDATE")]
		public DateTime SI_SVC_REGDATE { get; set; }
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
		/// FOOTER_YN
		/// </summary>
		[Column("FOOTER_YN")]
		public string FOOTER_YN { get; set; }
		/// <summary>
		/// SI_API
		/// </summary>
		[Column("SI_API")]
		public string SI_API { get; set; }
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
}