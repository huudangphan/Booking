namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_PARTYINFO_여행경험지
/// </summary>
public class USP_T_PARTYINFO_TravelExperiencePoint
{
	public const string SP_NAME = "USP_T_PARTYINFO_여행경험지";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 여행경험지대분류
		/// </summary>
		[Description("여행경험지대분류")]
		public string TravelExperiencePointMajorClassification { get; set; }
	}

}