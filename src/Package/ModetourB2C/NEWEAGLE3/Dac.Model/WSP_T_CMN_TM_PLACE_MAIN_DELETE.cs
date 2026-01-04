namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_PLACE_MAIN_DELETE
/// </summary>
public class WSP_T_CMN_TM_PLACE_MAIN_DELETE
{
	public const string SP_NAME = "WSP_T_CMN_TM_PLACE_MAIN_DELETE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GubunCode
		/// </summary>
		[Description("GubunCode")]
		public string GubunCode { get; set; }
	}

}