namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_PARTYINFO_관심혜택
/// </summary>
public class USP_T_PARTYINFO_InterestingBenefit
{
	public const string SP_NAME = "USP_T_PARTYINFO_관심혜택";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 관심혜택
		/// </summary>
		[Description("관심혜택")]
		public string InterestingBenefit { get; set; }
	}

}