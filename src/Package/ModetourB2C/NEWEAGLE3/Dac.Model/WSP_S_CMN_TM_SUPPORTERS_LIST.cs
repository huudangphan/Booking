namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_SUPPORTERS_LIST
/// </summary>
public class WSP_S_CMN_TM_SUPPORTERS_LIST
{
	public const string SP_NAME = "WSP_S_CMN_TM_SUPPORTERS_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// SupportersCode
		/// </summary>
		[Description("SupportersCode")]
		public string SupportersCode { get; set; }
		/// <summary>
		/// AreaCode
		/// </summary>
		[Description("AreaCode")]
		public string AreaCode { get; set; }
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
		/// Idx
		/// </summary>
		[Column("Idx")]
		public int Idx { get; set; }
		/// <summary>
		/// SupportersCode
		/// </summary>
		[Column("SupportersCode")]
		public string SupportersCode { get; set; }
		/// <summary>
		/// AreaCode
		/// </summary>
		[Column("AreaCode")]
		public string AreaCode { get; set; }
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
		/// Img
		/// </summary>
		[Column("Img")]
		public string Img { get; set; }
		/// <summary>
		/// URL
		/// </summary>
		[Column("URL")]
		public string URL { get; set; }
		/// <summary>
		/// Contents
		/// </summary>
		[Column("Contents")]
		public string Contents { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Column("UseFlag")]
		public string UseFlag { get; set; }
		/// <summary>
		/// AreaKorName
		/// </summary>
		[Column("AreaKorName")]
		public string AreaKorName { get; set; }
		/// <summary>
		/// ThemeKorName
		/// </summary>
		[Column("ThemeKorName")]
		public string ThemeKorName { get; set; }
		/// <summary>
		/// SupportersKorName
		/// </summary>
		[Column("SupportersKorName")]
		public string SupportersKorName { get; set; }
		/// <summary>
		/// Th
		/// </summary>
		[Column("Th")]
		public string Th { get; set; }
	}
}