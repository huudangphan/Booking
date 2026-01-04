namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_가이드_SMS인증
/// </summary>
public class WSP_T_Guide_SMS_Verification
{
	public const string SP_NAME = "WSP_T_가이드_SMS인증";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Description("휴대폰")]
		public string CellPhone { get; set; }
	}

}