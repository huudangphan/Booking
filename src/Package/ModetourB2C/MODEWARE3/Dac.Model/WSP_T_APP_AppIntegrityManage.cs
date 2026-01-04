namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_APP_앱무결성관리
/// </summary>
public class WSP_T_APP_AppIntegrityManage
{
	public const string SP_NAME = "WSP_T_APP_앱무결성관리";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// APP_KEY
		/// </summary>
		[Description("APP_KEY")]
		public string APP_KEY { get; set; }
		/// <summary>
		/// APP_HASH
		/// </summary>
		[Description("APP_HASH")]
		public string APP_HASH { get; set; }
		/// <summary>
		/// APP_OS
		/// </summary>
		[Description("APP_OS")]
		public string APP_OS { get; set; }
		/// <summary>
		/// APP_VER
		/// </summary>
		[Description("APP_VER")]
		public string APP_VER { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// RETURN_CODE
		/// </summary>
		[Column("RETURN_CODE")]
		public int RETURN_CODE { get; set; }
		/// <summary>
		/// RETURN_MSG
		/// </summary>
		[Column("RETURN_MSG")]
		public string RETURN_MSG { get; set; }
	}
}