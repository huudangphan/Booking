namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_인센티브_관리자메뉴
/// </summary>
public class WSP_S_Incentive_AdminMenu
{
	public const string SP_NAME = "WSP_S_인센티브_관리자메뉴";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// SITENO
		/// </summary>
		[Description("SITENO")]
		public int SITENO { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Column("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// SITENO
		/// </summary>
		[Column("SITENO")]
		public int SITENO { get; set; }
		/// <summary>
		/// MENUTITLE
		/// </summary>
		[Column("MENUTITLE")]
		public string MENUTITLE { get; set; }
	}
}