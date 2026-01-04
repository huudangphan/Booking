namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_HR_TIP_UPDATE
/// </summary>
public class WSP_T_CMN_TM_HR_TIP_UPDATE
{
	public const string SP_NAME = "WSP_T_CMN_TM_HR_TIP_UPDATE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Description("Idx")]
		public int Idx { get; set; }
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
		/// Contents
		/// </summary>
		[Description("Contents")]
		public string Contents { get; set; }
	}

}