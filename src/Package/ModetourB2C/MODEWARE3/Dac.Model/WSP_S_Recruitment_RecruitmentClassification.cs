namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_채용_모집분류
/// </summary>
public class WSP_S_Recruitment_RecruitmentClassification
{
	public const string SP_NAME = "WSP_S_채용_모집분류";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 모집부문일련번호
		/// </summary>
		[Description("모집부문일련번호")]
		public int RecruitmentSectionSerialNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 지역코드명
		/// </summary>
		[Column("지역코드명")]
		public string RegionCodeName { get; set; }
	}
}