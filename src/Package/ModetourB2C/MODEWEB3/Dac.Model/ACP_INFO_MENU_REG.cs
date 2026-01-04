namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_INFO_MENU_REG
/// </summary>
public class ACP_INFO_MENU_REG
{
	public const string SP_NAME = "ACP_INFO_MENU_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// AME_IDX
		/// </summary>
		[Description("AME_IDX")]
		public int AME_IDX { get; set; }
		/// <summary>
		/// AME_MENU
		/// </summary>
		[Description("AME_MENU")]
		public string AME_MENU { get; set; }
		/// <summary>
		/// AME_IDX_UP
		/// </summary>
		[Description("AME_IDX_UP")]
		public int AME_IDX_UP { get; set; }
		/// <summary>
		/// AME_PAGECODE
		/// </summary>
		[Description("AME_PAGECODE")]
		public string AME_PAGECODE { get; set; }
		/// <summary>
		/// AME_URL
		/// </summary>
		[Description("AME_URL")]
		public string AME_URL { get; set; }
		/// <summary>
		/// AME_STATUS
		/// </summary>
		[Description("AME_STATUS")]
		public string AME_STATUS { get; set; }
		/// <summary>
		/// STR_APA_RIGHT
		/// </summary>
		[Description("STR_APA_RIGHT")]
		public string STR_APA_RIGHT { get; set; }
	}

	public class Result1 : IDbResult
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
		/// AME_IDX
		/// </summary>
		[Column("AME_IDX")]
		public int AME_IDX { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// AME_IDX
		/// </summary>
		[Column("AME_IDX")]
		public int AME_IDX { get; set; }
		/// <summary>
		/// AME_IDX_UP
		/// </summary>
		[Column("AME_IDX_UP")]
		public int AME_IDX_UP { get; set; }
		/// <summary>
		/// LVL
		/// </summary>
		[Column("LVL")]
		public int LVL { get; set; }
		/// <summary>
		/// AME_PAGECODE
		/// </summary>
		[Column("AME_PAGECODE")]
		public string AME_PAGECODE { get; set; }
		/// <summary>
		/// AME_URL
		/// </summary>
		[Column("AME_URL")]
		public string AME_URL { get; set; }
		/// <summary>
		/// AME_STATUS
		/// </summary>
		[Column("AME_STATUS")]
		public string AME_STATUS { get; set; }
		/// <summary>
		/// AME_MENU
		/// </summary>
		[Column("AME_MENU")]
		public string AME_MENU { get; set; }
		/// <summary>
		/// FULLNAME
		/// </summary>
		[Column("FULLNAME")]
		public string FULLNAME { get; set; }
		/// <summary>
		/// RIGHT_SM
		/// </summary>
		[Column("RIGHT_SM")]
		public int RIGHT_SM { get; set; }
		/// <summary>
		/// RIGHT_PT
		/// </summary>
		[Column("RIGHT_PT")]
		public int RIGHT_PT { get; set; }
	}
}