namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_TRAVEL_PHOTO_BOARD_INSERT
/// </summary>
public class WSP_T_CMN_TM_TRAVEL_PHOTO_BOARD_INSERT
{
	public const string SP_NAME = "WSP_T_CMN_TM_TRAVEL_PHOTO_BOARD_INSERT";

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
		/// Title
		/// </summary>
		[Description("Title")]
		public string Title { get; set; }
		/// <summary>
		/// ImgList
		/// </summary>
		[Description("ImgList")]
		public string ImgList { get; set; }
	}

}