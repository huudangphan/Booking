namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_INFO_USER_MENU_REG
/// </summary>
public class ACP_INFO_USER_MENU_REG
{
	public const string SP_NAME = "ACP_INFO_USER_MENU_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// STR_MENU
		/// </summary>
		[Description("STR_MENU")]
		public string STR_MENU { get; set; }
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
	}
}