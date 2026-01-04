namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// GSP_S_휴가계_상세보기_MOBILE
/// </summary>
public class GSP_S_VacationPlan_SeeDetail_MOBILE
{
	public const string SP_NAME = "GSP_S_휴가계_상세보기_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 휴가번호
		/// </summary>
		[Description("휴가번호")]
		public int VacationNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 휴가번호
		/// </summary>
		[Column("휴가번호")]
		public int VacationNumber { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Column("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Column("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 휴가일1
		/// </summary>
		[Column("휴가일1")]
		public string VacationDate1 { get; set; }
		/// <summary>
		/// 휴가일2
		/// </summary>
		[Column("휴가일2")]
		public string VacationDate2 { get; set; }
		/// <summary>
		/// 기간
		/// </summary>
		[Column("기간")]
		public decimal Period { get; set; }
		/// <summary>
		/// 사유
		/// </summary>
		[Column("사유")]
		public string Reason { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public string WrittingDate { get; set; }
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
		/// 첨부파일폴더
		/// </summary>
		[Column("첨부파일폴더")]
		public string AttachFileFolder { get; set; }
		/// <summary>
		/// 첨부파일
		/// </summary>
		[Column("첨부파일")]
		public string AttachFile { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 종류명
		/// </summary>
		[Column("종류명")]
		public string TypeName { get; set; }
		/// <summary>
		/// 월차사용여부
		/// </summary>
		[Column("월차사용여부")]
		public string MonthlyUseOrNot { get; set; }
		/// <summary>
		/// profile_image
		/// </summary>
		[Column("profile_image")]
		public string profile_image { get; set; }
		/// <summary>
		/// 출산일
		/// </summary>
		[Column("출산일")]
		public string ChildbirthDate { get; set; }
		/// <summary>
		/// 팀
		/// </summary>
		[Column("팀")]
		public string Team { get; set; }
		/// <summary>
		/// 직위명
		/// </summary>
		[Column("직위명")]
		public string PositionName { get; set; }
	}

	public class Result2 : IDbResult
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