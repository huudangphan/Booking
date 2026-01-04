namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_설문_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_Survey_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_설문_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 채용_공고_설문_일련번호
		/// </summary>
		[Description("채용_공고_설문_일련번호")]
		public int Recruitment_Announce_Survey_SerialNumber { get; set; }
		/// <summary>
		/// 채용_설문_디테일_일련번호
		/// </summary>
		[Description("채용_설문_디테일_일련번호")]
		public int Recruitment_Survey_Detail_SerialNumber { get; set; }
		/// <summary>
		/// 직접입력
		/// </summary>
		[Description("직접입력")]
		public string DirectInput { get; set; }
	}

}