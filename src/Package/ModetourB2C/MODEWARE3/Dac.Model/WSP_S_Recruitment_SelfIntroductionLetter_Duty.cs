namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_채용_자기소개서_직무
/// </summary>
public class WSP_S_Recruitment_SelfIntroductionLetter_Duty
{
	public const string SP_NAME = "WSP_S_채용_자기소개서_직무";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 공고일련번호
		/// </summary>
		[Description("공고일련번호")]
		public int AnnounceSerialNumber { get; set; }
		/// <summary>
		/// 직무코드명
		/// </summary>
		[Description("직무코드명")]
		public string DutyCodeName { get; set; }
		/// <summary>
		/// 입사구분코드명
		/// </summary>
		[Description("입사구분코드명")]
		public string CompanyJoiningClassificationCodeName { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 자기소개서문항일련번호
		/// </summary>
		[Column("자기소개서문항일련번호")]
		public int SelfIntroductionFormQuestionSerialNumber { get; set; }
		/// <summary>
		/// 자기소개서문항
		/// </summary>
		[Column("자기소개서문항")]
		public string SelfIntroductionFormQuestion { get; set; }
	}
}