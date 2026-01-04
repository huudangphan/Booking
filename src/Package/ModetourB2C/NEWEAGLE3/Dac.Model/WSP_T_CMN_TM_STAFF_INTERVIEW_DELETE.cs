namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_STAFF_INTERVIEW_DELETE
/// </summary>
public class WSP_T_CMN_TM_STAFF_INTERVIEW_DELETE
{
	public const string SP_NAME = "WSP_T_CMN_TM_STAFF_INTERVIEW_DELETE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Description("Idx")]
		public int Idx { get; set; }
		/// <summary>
		/// DelFlag
		/// </summary>
		[Description("DelFlag")]
		public string DelFlag { get; set; }
	}

}