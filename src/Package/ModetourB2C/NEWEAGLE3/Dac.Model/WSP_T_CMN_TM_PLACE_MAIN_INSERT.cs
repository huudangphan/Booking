namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_PLACE_MAIN_INSERT
/// </summary>
public class WSP_T_CMN_TM_PLACE_MAIN_INSERT
{
	public const string SP_NAME = "WSP_T_CMN_TM_PLACE_MAIN_INSERT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GubunCode
		/// </summary>
		[Description("GubunCode")]
		public string GubunCode { get; set; }
		/// <summary>
		/// SubTitle
		/// </summary>
		[Description("SubTitle")]
		public string SubTitle { get; set; }
		/// <summary>
		/// Img
		/// </summary>
		[Description("Img")]
		public string Img { get; set; }
	}

}