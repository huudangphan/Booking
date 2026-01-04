namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_채용_모집분류_NEW
/// </summary>
public class WSP_S_Recruitment_RecruitmentClassification_NEW
{
	public const string SP_NAME = "WSP_S_채용_모집분류_NEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 모집부문일련번호
		/// </summary>
		[Description("모집부문일련번호")]
		public string RecruitmentSectionSerialNumber { get; set; }
	}

}