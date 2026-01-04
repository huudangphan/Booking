namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_DATA_GROUP_SELECT
/// </summary>
public class ACP_DATA_GROUP_SELECT
{
	public const string SP_NAME = "ACP_DATA_GROUP_SELECT";

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
		/// GR_IDX
		/// </summary>
		[Description("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// GR_STATUS
		/// </summary>
		[Description("GR_STATUS")]
		public string GR_STATUS { get; set; }
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
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// GR_TYPE
		/// </summary>
		[Column("GR_TYPE")]
		public string GR_TYPE { get; set; }
		/// <summary>
		/// GR_DEFAULT
		/// </summary>
		[Column("GR_DEFAULT")]
		public string GR_DEFAULT { get; set; }
		/// <summary>
		/// AUGR_IDX
		/// </summary>
		[Column("AUGR_IDX")]
		public int AUGR_IDX { get; set; }
		/// <summary>
		/// AUGR_PTID
		/// </summary>
		[Column("AUGR_PTID")]
		public int AUGR_PTID { get; set; }
		/// <summary>
		/// GR_AUGR_NAME
		/// </summary>
		[Column("GR_AUGR_NAME")]
		public string GR_AUGR_NAME { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Column("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// GR_AUS_NAME
		/// </summary>
		[Column("GR_AUS_NAME")]
		public string GR_AUS_NAME { get; set; }
		/// <summary>
		/// GR_TITLE
		/// </summary>
		[Column("GR_TITLE")]
		public string GR_TITLE { get; set; }
		/// <summary>
		/// GR_STATUS
		/// </summary>
		[Column("GR_STATUS")]
		public string GR_STATUS { get; set; }
		/// <summary>
		/// GR_CREATEDATE
		/// </summary>
		[Column("GR_CREATEDATE")]
		public DateTime GR_CREATEDATE { get; set; }
		/// <summary>
		/// GR_REGDATE
		/// </summary>
		[Column("GR_REGDATE")]
		public DateTime GR_REGDATE { get; set; }
		/// <summary>
		/// GR_MODDATE
		/// </summary>
		[Column("GR_MODDATE")]
		public DateTime GR_MODDATE { get; set; }
		/// <summary>
		/// SI_COUNT
		/// </summary>
		[Column("SI_COUNT")]
		public int SI_COUNT { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// GR_TITLE
		/// </summary>
		[Column("GR_TITLE")]
		public string GR_TITLE { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// GR_TYPE
		/// </summary>
		[Column("GR_TYPE")]
		public string GR_TYPE { get; set; }
		/// <summary>
		/// GR_DEFAULT
		/// </summary>
		[Column("GR_DEFAULT")]
		public string GR_DEFAULT { get; set; }
		/// <summary>
		/// AUGR_IDX
		/// </summary>
		[Column("AUGR_IDX")]
		public int AUGR_IDX { get; set; }
		/// <summary>
		/// GR_AUGR_NAME
		/// </summary>
		[Column("GR_AUGR_NAME")]
		public string GR_AUGR_NAME { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Column("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// GR_AUS_NAME
		/// </summary>
		[Column("GR_AUS_NAME")]
		public string GR_AUS_NAME { get; set; }
		/// <summary>
		/// MW_START
		/// </summary>
		[Column("MW_START")]
		public string MW_START { get; set; }
		/// <summary>
		/// MW_START_NAME
		/// </summary>
		[Column("MW_START_NAME")]
		public string MW_START_NAME { get; set; }
		/// <summary>
		/// GR_TITLE
		/// </summary>
		[Column("GR_TITLE")]
		public string GR_TITLE { get; set; }
		/// <summary>
		/// GR_STATUS
		/// </summary>
		[Column("GR_STATUS")]
		public string GR_STATUS { get; set; }
		/// <summary>
		/// GR_CREATEDATE
		/// </summary>
		[Column("GR_CREATEDATE")]
		public DateTime GR_CREATEDATE { get; set; }
		/// <summary>
		/// GR_REGDATE
		/// </summary>
		[Column("GR_REGDATE")]
		public DateTime GR_REGDATE { get; set; }
		/// <summary>
		/// GR_MODDATE
		/// </summary>
		[Column("GR_MODDATE")]
		public DateTime GR_MODDATE { get; set; }
		/// <summary>
		/// SI_COUNT
		/// </summary>
		[Column("SI_COUNT")]
		public int SI_COUNT { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// ADA_TYPE
		/// </summary>
		[Column("ADA_TYPE")]
		public string ADA_TYPE { get; set; }
		/// <summary>
		/// ADA_KIND
		/// </summary>
		[Column("ADA_KIND")]
		public string ADA_KIND { get; set; }
		/// <summary>
		/// ADA_DEFAULT_YN
		/// </summary>
		[Column("ADA_DEFAULT_YN")]
		public string ADA_DEFAULT_YN { get; set; }
		/// <summary>
		/// ADA_SORT
		/// </summary>
		[Column("ADA_SORT")]
		public int ADA_SORT { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
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
		/// SI_REGDATE
		/// </summary>
		[Column("SI_REGDATE")]
		public DateTime SI_REGDATE { get; set; }
		/// <summary>
		/// SI_MODDATE
		/// </summary>
		[Column("SI_MODDATE")]
		public DateTime SI_MODDATE { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
	}
}