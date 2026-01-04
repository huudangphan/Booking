namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_PARTYINFO_관심지역
/// </summary>
public class USP_T_PARTYINFO_InterestingRegion
{
	public const string SP_NAME = "USP_T_PARTYINFO_관심지역";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 관심지역대분류
		/// </summary>
		[Description("관심지역대분류")]
		public string InterestingRegionMajorClassification { get; set; }
	}

}