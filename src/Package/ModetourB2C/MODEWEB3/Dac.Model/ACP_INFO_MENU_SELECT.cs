namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_INFO_MENU_SELECT
/// </summary>
public class ACP_INFO_MENU_SELECT
{
	public const string SP_NAME = "ACP_INFO_MENU_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// RIGHT
		/// </summary>
		[Description("RIGHT")]
		public string RIGHT { get; set; }
	}

	public class Result : IDbResult
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
		/// AME_SORT
		/// </summary>
		[Column("AME_SORT")]
		public int AME_SORT { get; set; }
		/// <summary>
		/// DEPTH
		/// </summary>
		[Column("DEPTH")]
		public string DEPTH { get; set; }
		/// <summary>
		/// AME_TITLE
		/// </summary>
		[Column("AME_TITLE")]
		public string AME_TITLE { get; set; }
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