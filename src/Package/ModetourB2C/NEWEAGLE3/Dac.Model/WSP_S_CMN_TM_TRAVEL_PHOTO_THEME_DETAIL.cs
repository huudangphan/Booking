namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_TRAVEL_PHOTO_THEME_DETAIL
/// </summary>
public class WSP_S_CMN_TM_TRAVEL_PHOTO_THEME_DETAIL
{
	public const string SP_NAME = "WSP_S_CMN_TM_TRAVEL_PHOTO_THEME_DETAIL";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// ThemeCode
		/// </summary>
		[Description("ThemeCode")]
		public string ThemeCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Code
		/// </summary>
		[Column("Code")]
		public string Code { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Column("UseFlag")]
		public string UseFlag { get; set; }
		/// <summary>
		/// Img
		/// </summary>
		[Column("Img")]
		public string Img { get; set; }
	}
}