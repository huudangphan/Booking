namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_PARTYINFO_관심여행시기
/// </summary>
public class USP_T_PARTYINFO_InterestingTravelTime
{
	public const string SP_NAME = "USP_T_PARTYINFO_관심여행시기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 여행시기
		/// </summary>
		[Description("여행시기")]
		public string TravelTime { get; set; }
	}

}