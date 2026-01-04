namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_PLACE_INSERT
/// </summary>
public class WSP_T_CMN_TM_PLACE_INSERT
{
	public const string SP_NAME = "WSP_T_CMN_TM_PLACE_INSERT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// AreaCode
		/// </summary>
		[Description("AreaCode")]
		public string AreaCode { get; set; }
		/// <summary>
		/// GubunCode
		/// </summary>
		[Description("GubunCode")]
		public string GubunCode { get; set; }
		/// <summary>
		/// Subject
		/// </summary>
		[Description("Subject")]
		public string Subject { get; set; }
		/// <summary>
		/// FrontFlag
		/// </summary>
		[Description("FrontFlag")]
		public string FrontFlag { get; set; }
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
		/// <summary>
		/// Img2
		/// </summary>
		[Description("Img2")]
		public string Img2 { get; set; }
		/// <summary>
		/// Contents
		/// </summary>
		[Description("Contents")]
		public string Contents { get; set; }
	}

}