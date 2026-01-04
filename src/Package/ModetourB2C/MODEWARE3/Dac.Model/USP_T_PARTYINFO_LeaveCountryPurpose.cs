namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_PARTYINFO_출국목적
/// </summary>
public class USP_T_PARTYINFO_LeaveCountryPurpose
{
	public const string SP_NAME = "USP_T_PARTYINFO_출국목적";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 출국목적코드
		/// </summary>
		[Description("출국목적코드")]
		public string LeaveCountryPurposeCode { get; set; }
	}

}