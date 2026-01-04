namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_MT_NEWS_INSERT
/// </summary>
public class WSP_T_CMN_TM_MT_NEWS_INSERT
{
	public const string SP_NAME = "WSP_T_CMN_TM_MT_NEWS_INSERT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Code
		/// </summary>
		[Description("Code")]
		public string Code { get; set; }
		/// <summary>
		/// Title
		/// </summary>
		[Description("Title")]
		public string Title { get; set; }
		/// <summary>
		/// RepFlag
		/// </summary>
		[Description("RepFlag")]
		public string RepFlag { get; set; }
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
		/// <summary>
		/// Img
		/// </summary>
		[Description("Img")]
		public string Img { get; set; }
		/// <summary>
		/// Contents
		/// </summary>
		[Description("Contents")]
		public string Contents { get; set; }
	}

}