namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_INFO_REF_SELECT
/// </summary>
public class ACP_INFO_REF_SELECT
{
	public const string SP_NAME = "ACP_INFO_REF_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MENU
		/// </summary>
		[Description("MENU")]
		public string MENU { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// SITE
		/// </summary>
		[Description("SITE")]
		public string SITE { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// APA_PTID
		/// </summary>
		[Column("APA_PTID")]
		public int APA_PTID { get; set; }
		/// <summary>
		/// APA_NAME
		/// </summary>
		[Column("APA_NAME")]
		public string APA_NAME { get; set; }
		/// <summary>
		/// APA_PARTNAME_UP
		/// </summary>
		[Column("APA_PARTNAME_UP")]
		public string APA_PARTNAME_UP { get; set; }
		/// <summary>
		/// AUGR_STATUS
		/// </summary>
		[Column("AUGR_STATUS")]
		public string AUGR_STATUS { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Column("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// AUS_NAME
		/// </summary>
		[Column("AUS_NAME")]
		public string AUS_NAME { get; set; }
		/// <summary>
		/// PART_GROUP_EX
		/// </summary>
		[Column("PART_GROUP_EX")]
		public string PART_GROUP_EX { get; set; }
		/// <summary>
		/// PART_GROUP
		/// </summary>
		[Column("PART_GROUP")]
		public string PART_GROUP { get; set; }
		/// <summary>
		/// PART_NAME1
		/// </summary>
		[Column("PART_NAME1")]
		public string PART_NAME1 { get; set; }
		/// <summary>
		/// PART_NAME2
		/// </summary>
		[Column("PART_NAME2")]
		public string PART_NAME2 { get; set; }
		/// <summary>
		/// AUS_POS
		/// </summary>
		[Column("AUS_POS")]
		public string AUS_POS { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 사용
		/// </summary>
		[Column("사용")]
		public string Use { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// SI_TRADE_PTID
		/// </summary>
		[Column("SI_TRADE_PTID")]
		public int SI_TRADE_PTID { get; set; }
		/// <summary>
		/// SI_PARTNER_PTID
		/// </summary>
		[Column("SI_PARTNER_PTID")]
		public int SI_PARTNER_PTID { get; set; }
		/// <summary>
		/// SI_SVC_IP
		/// </summary>
		[Column("SI_SVC_IP")]
		public string SI_SVC_IP { get; set; }
		/// <summary>
		/// SI_XML
		/// </summary>
		[Column("SI_XML")]
		public string SI_XML { get; set; }
		/// <summary>
		/// SITEURL
		/// </summary>
		[Column("SITEURL")]
		public string SITEURL { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// SI_TRADE_PTID
		/// </summary>
		[Column("SI_TRADE_PTID")]
		public int SI_TRADE_PTID { get; set; }
		/// <summary>
		/// SI_PARTNER_PTID
		/// </summary>
		[Column("SI_PARTNER_PTID")]
		public int SI_PARTNER_PTID { get; set; }
		/// <summary>
		/// SI_SVC_IP
		/// </summary>
		[Column("SI_SVC_IP")]
		public string SI_SVC_IP { get; set; }
		/// <summary>
		/// SI_XML
		/// </summary>
		[Column("SI_XML")]
		public string SI_XML { get; set; }
		/// <summary>
		/// SITENO
		/// </summary>
		[Column("SITENO")]
		public int SITENO { get; set; }
	}
}