namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_PARTYINFO_관심테마
/// </summary>
public class USP_T_PARTYINFO_InterestingTheme
{
	public const string SP_NAME = "USP_T_PARTYINFO_관심테마";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 관심테마코드
		/// </summary>
		[Description("관심테마코드")]
		public string InterestingThemeCode { get; set; }
	}

}