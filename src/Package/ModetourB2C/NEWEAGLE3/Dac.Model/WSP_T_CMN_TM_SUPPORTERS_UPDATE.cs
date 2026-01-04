namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_SUPPORTERS_UPDATE
/// </summary>
public class WSP_T_CMN_TM_SUPPORTERS_UPDATE
{
	public const string SP_NAME = "WSP_T_CMN_TM_SUPPORTERS_UPDATE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Description("Idx")]
		public int Idx { get; set; }
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
		/// Title
		/// </summary>
		[Description("Title")]
		public string Title { get; set; }
		/// <summary>
		/// Img
		/// </summary>
		[Description("Img")]
		public string Img { get; set; }
		/// <summary>
		/// URL
		/// </summary>
		[Description("URL")]
		public string URL { get; set; }
		/// <summary>
		/// Contents
		/// </summary>
		[Description("Contents")]
		public string Contents { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Description("UseFlag")]
		public string UseFlag { get; set; }
		/// <summary>
		/// DelFlag
		/// </summary>
		[Description("DelFlag")]
		public string DelFlag { get; set; }
	}

}