namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_MODIFY
/// </summary>
public class ACP_SITE_MODIFY
{
	public const string SP_NAME = "ACP_SITE_MODIFY";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Description("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// SI_NAME
		/// </summary>
		[Description("SI_NAME")]
		public string SI_NAME { get; set; }
		/// <summary>
		/// SI_TITLE
		/// </summary>
		[Description("SI_TITLE")]
		public string SI_TITLE { get; set; }
		/// <summary>
		/// SI_SECU
		/// </summary>
		[Description("SI_SECU")]
		public string SI_SECU { get; set; }
		/// <summary>
		/// SI_API
		/// </summary>
		[Description("SI_API")]
		public string SI_API { get; set; }
		/// <summary>
		/// CHANGE_WEB
		/// </summary>
		[Description("CHANGE_WEB")]
		public string CHANGE_WEB { get; set; }
		/// <summary>
		/// CHANGE_MOBILE
		/// </summary>
		[Description("CHANGE_MOBILE")]
		public string CHANGE_MOBILE { get; set; }
		/// <summary>
		/// TARGET_POPUP
		/// </summary>
		[Description("TARGET_POPUP")]
		public string TARGET_POPUP { get; set; }
		/// <summary>
		/// SNS_USE_YN
		/// </summary>
		[Description("SNS_USE_YN")]
		public string SNS_USE_YN { get; set; }
		/// <summary>
		/// BTN_INFO
		/// </summary>
		[Description("BTN_INFO")]
		public string BTN_INFO { get; set; }
		/// <summary>
		/// BASICLOGO_YN
		/// </summary>
		[Description("BASICLOGO_YN")]
		public string BASICLOGO_YN { get; set; }
		/// <summary>
		/// REQUIREDLOGIN_YN
		/// </summary>
		[Description("REQUIREDLOGIN_YN")]
		public string REQUIREDLOGIN_YN { get; set; }
		/// <summary>
		/// BIFURCATION_YN
		/// </summary>
		[Description("BIFURCATION_YN")]
		public string BIFURCATION_YN { get; set; }
		/// <summary>
		/// MOVE_PAGE
		/// </summary>
		[Description("MOVE_PAGE")]
		public string MOVE_PAGE { get; set; }
		/// <summary>
		/// HOMESHOPPING_YN
		/// </summary>
		[Description("HOMESHOPPING_YN")]
		public string HOMESHOPPING_YN { get; set; }
		/// <summary>
		/// PAYMENTBTN_YN
		/// </summary>
		[Description("PAYMENTBTN_YN")]
		public string PAYMENTBTN_YN { get; set; }
		/// <summary>
		/// AIR_YN
		/// </summary>
		[Description("AIR_YN")]
		public string AIR_YN { get; set; }
		/// <summary>
		/// HOTEL_YN
		/// </summary>
		[Description("HOTEL_YN")]
		public string HOTEL_YN { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
	}

}