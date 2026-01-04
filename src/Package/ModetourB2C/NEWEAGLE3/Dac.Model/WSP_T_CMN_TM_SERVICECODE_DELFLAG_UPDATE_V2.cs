namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_SERVICECODE_DELFLAG_UPDATE_V2
/// </summary>
public class WSP_T_CMN_TM_SERVICECODE_DELFLAG_UPDATE_V2
{
	public const string SP_NAME = "WSP_T_CMN_TM_SERVICECODE_DELFLAG_UPDATE_V2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Code
		/// </summary>
		[Description("Code")]
		public string Code { get; set; }
		/// <summary>
		/// DelFlag
		/// </summary>
		[Description("DelFlag")]
		public string DelFlag { get; set; }
	}

}