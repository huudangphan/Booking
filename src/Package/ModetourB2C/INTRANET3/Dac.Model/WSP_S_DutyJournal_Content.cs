namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_업무일지_내용
/// </summary>
public class WSP_S_DutyJournal_Content
{
	public const string SP_NAME = "WSP_S_업무일지_내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일지번호
		/// </summary>
		[Description("일지번호")]
		public int JournalNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일지번호
		/// </summary>
		[Column("일지번호")]
		public int JournalNumber { get; set; }
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
		/// 작성자정보
		/// </summary>
		[Column("작성자정보")]
		public string WritterInfo { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 내용1
		/// </summary>
		[Column("내용1")]
		public string Content1 { get; set; }
		/// <summary>
		/// 내용2
		/// </summary>
		[Column("내용2")]
		public string Content2 { get; set; }
		/// <summary>
		/// 내용3
		/// </summary>
		[Column("내용3")]
		public string Content3 { get; set; }
		/// <summary>
		/// 내용4
		/// </summary>
		[Column("내용4")]
		public string Content4 { get; set; }
		/// <summary>
		/// 내용5
		/// </summary>
		[Column("내용5")]
		public string Content5 { get; set; }
		/// <summary>
		/// 내용6
		/// </summary>
		[Column("내용6")]
		public string Content6 { get; set; }
		/// <summary>
		/// 내용7
		/// </summary>
		[Column("내용7")]
		public string Content7 { get; set; }
		/// <summary>
		/// 첨부
		/// </summary>
		[Column("첨부")]
		public string Attach { get; set; }
		/// <summary>
		/// 조회
		/// </summary>
		[Column("조회")]
		public int Search { get; set; }
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
		/// 추가내용
		/// </summary>
		[Column("추가내용")]
		public string AddContent { get; set; }
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
		/// 지시사항
		/// </summary>
		[Column("지시사항")]
		public string Commands { get; set; }
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
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public byte Order { get; set; }
		/// <summary>
		/// 작성자번호
		/// </summary>
		[Column("작성자번호")]
		public int WritterNumber { get; set; }
		/// <summary>
		/// 작성자명
		/// </summary>
		[Column("작성자명")]
		public string WritterName { get; set; }
		/// <summary>
		/// 작성자직책
		/// </summary>
		[Column("작성자직책")]
		public string WritterDuty { get; set; }
		/// <summary>
		/// 지시사항
		/// </summary>
		[Column("지시사항")]
		public string Commands { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 댓글일련번호
		/// </summary>
		[Column("댓글일련번호")]
		public int CommentSerialNumber { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public byte Order { get; set; }
		/// <summary>
		/// 일지번호
		/// </summary>
		[Column("일지번호")]
		public int JournalNumber { get; set; }
		/// <summary>
		/// 작성자번호
		/// </summary>
		[Column("작성자번호")]
		public int WritterNumber { get; set; }
		/// <summary>
		/// 작성자명
		/// </summary>
		[Column("작성자명")]
		public string WritterName { get; set; }
		/// <summary>
		/// 작성자직책
		/// </summary>
		[Column("작성자직책")]
		public string WritterDuty { get; set; }
		/// <summary>
		/// 지시사항
		/// </summary>
		[Column("지시사항")]
		public string Commands { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
	}
}