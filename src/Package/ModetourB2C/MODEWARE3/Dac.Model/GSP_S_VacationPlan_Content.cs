namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_휴가계_내용
/// </summary>
public class GSP_S_VacationPlan_Content
{
	public const string SP_NAME = "GSP_S_휴가계_내용";

	public class Parameters : BaseDbParameters
	{
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
		public DateTime VacationDate1 { get; set; }
		/// <summary>
		/// 휴가일2
		/// </summary>
		[Column("휴가일2")]
		public DateTime VacationDate2 { get; set; }
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
		public DateTime WrittingDate { get; set; }
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
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 종류명
		/// </summary>
		[Column("종류명")]
		public string TypeName { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 월차사용여부
		/// </summary>
		[Column("월차사용여부")]
		public string MonthlyUseOrNot { get; set; }
		/// <summary>
		/// 배정신청서번호1
		/// </summary>
		[Column("배정신청서번호1")]
		public string AssignmentRequestFormNumber1 { get; set; }
		/// <summary>
		/// 답사기안번호1
		/// </summary>
		[Column("답사기안번호1")]
		public string AnswerLetterDraftNumber1 { get; set; }
		/// <summary>
		/// 배정신청서번호2
		/// </summary>
		[Column("배정신청서번호2")]
		public int AssignmentRequestFormNumber2 { get; set; }
		/// <summary>
		/// 답사기안번호2
		/// </summary>
		[Column("답사기안번호2")]
		public int AnswerLetterDraftNumber2 { get; set; }
		/// <summary>
		/// 출산일
		/// </summary>
		[Column("출산일")]
		public string ChildbirthDate { get; set; }
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
	}
}