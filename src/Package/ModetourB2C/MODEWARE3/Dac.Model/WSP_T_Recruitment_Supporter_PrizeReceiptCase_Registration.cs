namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_수강사례_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_PrizeReceiptCase_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_수강사례_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 교육기관
		/// </summary>
		[Description("교육기관")]
		public string EducationOffice { get; set; }
		/// <summary>
		/// 교육과정
		/// </summary>
		[Description("교육과정")]
		public string EducationProcess { get; set; }
		/// <summary>
		/// 주요내용
		/// </summary>
		[Description("주요내용")]
		public string MainContent { get; set; }
		/// <summary>
		/// 강사
		/// </summary>
		[Description("강사")]
		public string Instructor { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Description("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 마감일
		/// </summary>
		[Description("마감일")]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 기준점수
		/// </summary>
		[Description("기준점수")]
		public double StandardScore { get; set; }
		/// <summary>
		/// 취득점수
		/// </summary>
		[Description("취득점수")]
		public double AccquirementScore { get; set; }
	}

}