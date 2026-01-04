namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_TRAVEL_PHOTO_BOARD_DETAIL
/// </summary>
public class WSP_S_CMN_TM_TRAVEL_PHOTO_BOARD_DETAIL
{
	public const string SP_NAME = "WSP_S_CMN_TM_TRAVEL_PHOTO_BOARD_DETAIL";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Description("Idx")]
		public int Idx { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// idx
		/// </summary>
		[Column("idx")]
		public int idx { get; set; }
		/// <summary>
		/// ThemeCode
		/// </summary>
		[Column("ThemeCode")]
		public string ThemeCode { get; set; }
		/// <summary>
		/// Title
		/// </summary>
		[Column("Title")]
		public string Title { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Column("UseFlag")]
		public string UseFlag { get; set; }
		/// <summary>
		/// ImgList
		/// </summary>
		[Column("ImgList")]
		public string ImgList { get; set; }
	}
}