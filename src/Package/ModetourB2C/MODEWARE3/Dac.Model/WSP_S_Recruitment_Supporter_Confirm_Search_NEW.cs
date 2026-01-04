namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_채용_지원자_확인_검색_NEW
/// </summary>
public class WSP_S_Recruitment_Supporter_Confirm_Search_NEW
{
	public const string SP_NAME = "WSP_S_채용_지원자_확인_검색_NEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 채용공고ID
		/// </summary>
		[Description("채용공고ID")]
		public decimal RecruitmentAnnounce_ID { get; set; }
		/// <summary>
		/// CI
		/// </summary>
		[Description("CI")]
		public string CI { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 결과
		/// </summary>
		[Column("결과")]
		public string RESULT { get; set; }
	}
}