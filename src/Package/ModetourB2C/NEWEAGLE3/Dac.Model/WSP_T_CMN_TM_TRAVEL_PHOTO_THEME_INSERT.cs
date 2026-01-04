namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_TRAVEL_PHOTO_THEME_INSERT
/// </summary>
public class WSP_T_CMN_TM_TRAVEL_PHOTO_THEME_INSERT
{
	public const string SP_NAME = "WSP_T_CMN_TM_TRAVEL_PHOTO_THEME_INSERT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// ThemeCode
		/// </summary>
		[Description("ThemeCode")]
		public string ThemeCode { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Description("UseFlag")]
		public string UseFlag { get; set; }
		/// <summary>
		/// Img
		/// </summary>
		[Description("Img")]
		public string Img { get; set; }
	}

}