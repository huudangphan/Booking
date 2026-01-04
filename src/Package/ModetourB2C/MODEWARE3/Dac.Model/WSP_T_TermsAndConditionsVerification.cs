namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_이용약관인증
/// </summary>
public class WSP_T_TermsAndConditionsVerification
{
	public const string SP_NAME = "WSP_T_이용약관인증";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID2
		/// </summary>
		[Description("PTID2")]
		public string PTID2 { get; set; }
	}

}