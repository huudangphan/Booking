namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_활동사례_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_ActivityCase_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_활동사례_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 기관
		/// </summary>
		[Description("기관")]
		public string Office { get; set; }
		/// <summary>
		/// 행사명
		/// </summary>
		[Description("행사명")]
		public string EventName { get; set; }
		/// <summary>
		/// 행사내용
		/// </summary>
		[Description("행사내용")]
		public string EventContent { get; set; }
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
		/// 활동내역및느낀점
		/// </summary>
		[Description("활동내역및느낀점")]
		public string ActivityHistoryAndReview { get; set; }
	}

}