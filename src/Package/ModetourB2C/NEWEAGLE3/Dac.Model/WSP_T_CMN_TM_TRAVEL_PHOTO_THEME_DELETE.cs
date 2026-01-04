namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_TRAVEL_PHOTO_THEME_DELETE
/// </summary>
public class WSP_T_CMN_TM_TRAVEL_PHOTO_THEME_DELETE
{
	public const string SP_NAME = "WSP_T_CMN_TM_TRAVEL_PHOTO_THEME_DELETE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// ThemeCode
		/// </summary>
		[Description("ThemeCode")]
		public string ThemeCode { get; set; }
	}

}