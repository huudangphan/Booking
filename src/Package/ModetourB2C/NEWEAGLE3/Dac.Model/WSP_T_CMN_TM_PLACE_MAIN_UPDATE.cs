namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_PLACE_MAIN_UPDATE
/// </summary>
public class WSP_T_CMN_TM_PLACE_MAIN_UPDATE
{
	public const string SP_NAME = "WSP_T_CMN_TM_PLACE_MAIN_UPDATE";

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