namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_MPLE_개인정보동의여부
/// </summary>
public class WSP_T_MPLE_PersonalInfoAgreeOrNot
{
	public const string SP_NAME = "WSP_T_MPLE_개인정보동의여부";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

}