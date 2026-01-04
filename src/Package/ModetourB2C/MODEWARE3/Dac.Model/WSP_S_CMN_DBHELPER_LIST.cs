namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_DBHELPER_LIST
/// </summary>
public class WSP_S_CMN_DBHELPER_LIST
{
	public const string SP_NAME = "WSP_S_CMN_DBHELPER_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GroupNum
		/// </summary>
		[Description("GroupNum")]
		public string GroupNum { get; set; }
	}

}