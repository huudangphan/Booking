namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_TRAVEL_PHOTO_THEME_LIST
/// </summary>
public class WSP_S_CMN_TM_TRAVEL_PHOTO_THEME_LIST
{
	public const string SP_NAME = "WSP_S_CMN_TM_TRAVEL_PHOTO_THEME_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// KorName
		/// </summary>
		[Description("KorName")]
		public string KorName { get; set; }
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
		/// KorName
		/// </summary>
		[Column("KorName")]
		public string KorName { get; set; }
		/// <summary>
		/// Img1
		/// </summary>
		[Column("Img1")]
		public string Img1 { get; set; }
	}
}