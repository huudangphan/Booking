namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_STORYM_AREA_DELETE
/// </summary>
public class WSP_T_CMN_TM_STORYM_AREA_DELETE
{
	public const string SP_NAME = "WSP_T_CMN_TM_STORYM_AREA_DELETE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// AreaCode
		/// </summary>
		[Description("AreaCode")]
		public string AreaCode { get; set; }
	}

}