namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// GSP_S_휴가계_내용_MOBILE
/// </summary>
public class GSP_S_VacationPlan_Content_MOBILE
{
	public const string SP_NAME = "GSP_S_휴가계_내용_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 휴가번호
		/// </summary>
		[Description("휴가번호")]
		public int VacationNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 결재순서
		/// </summary>
		[Column("결재순서")]
		public byte ApprovalOrder { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Column("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 직책
		/// </summary>
		[Column("직책")]
		public string Duty { get; set; }
		/// <summary>
		/// 대결자
		/// </summary>
		[Column("대결자")]
		public string Competitor { get; set; }
		/// <summary>
		/// 대결자사원번호
		/// </summary>
		[Column("대결자사원번호")]
		public int CompetitorStaffNumber { get; set; }
		/// <summary>
		/// 대결자직책
		/// </summary>
		[Column("대결자직책")]
		public string CompetitorDuty { get; set; }
		/// <summary>
		/// 결재진행
		/// </summary>
		[Column("결재진행")]
		public string ApprovalProgress { get; set; }
		/// <summary>
		/// 결재진행일
		/// </summary>
		[Column("결재진행일")]
		public DateTime ApprovalProgressDate { get; set; }
		/// <summary>
		/// 사용대결자
		/// </summary>
		[Column("사용대결자")]
		public int UseCompetitor { get; set; }
		/// <summary>
		/// profile_image
		/// </summary>
		[Column("profile_image")]
		public string profile_image { get; set; }
		/// <summary>
		/// 팀
		/// </summary>
		[Column("팀")]
		public string Team { get; set; }
	}
}