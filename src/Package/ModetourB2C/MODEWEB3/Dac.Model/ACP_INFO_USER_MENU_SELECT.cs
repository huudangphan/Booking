namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_INFO_USER_MENU_SELECT
/// </summary>
public class ACP_INFO_USER_MENU_SELECT
{
	public const string SP_NAME = "ACP_INFO_USER_MENU_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
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
		/// AME_MENU
		/// </summary>
		[Column("AME_MENU")]
		public string AME_MENU { get; set; }
		/// <summary>
		/// FULLCODE
		/// </summary>
		[Column("FULLCODE")]
		public string FULLCODE { get; set; }
		/// <summary>
		/// FULLNAME
		/// </summary>
		[Column("FULLNAME")]
		public string FULLNAME { get; set; }
		/// <summary>
		/// AME_STATUS
		/// </summary>
		[Column("AME_STATUS")]
		public string AME_STATUS { get; set; }
		/// <summary>
		/// EXISTS_AME_IDX
		/// </summary>
		[Column("EXISTS_AME_IDX")]
		public int EXISTS_AME_IDX { get; set; }
	}
}