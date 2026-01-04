namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_자기소개서_직무_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_SelfIntroductionLetter_Duty_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_자기소개서_직무_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 자기소개서문항일련번호
		/// </summary>
		[Description("자기소개서문항일련번호")]
		public int SelfIntroductionFormQuestionSerialNumber { get; set; }
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 자기소개답변
		/// </summary>
		[Description("자기소개답변")]
		public string SelfIntroductionAnswer { get; set; }
	}

}