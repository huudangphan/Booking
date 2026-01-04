namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// WSP_S_업무일지_결재대기_MOBILE
/// </summary>
public class WSP_S_DutyJournal_ApprovalWaiting_MOBILE
{
	public const string SP_NAME = "WSP_S_업무일지_결재대기_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 탭구분
		/// </summary>
		[Description("탭구분")]
		public int TabClassification { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Description("작성일")]
		public DateTime WrittingDate { get; set; }
		/// <summary>
		/// 현재페이지
		/// </summary>
		[Description("현재페이지")]
		public int CurrentPage { get; set; }
		/// <summary>
		/// 페이지당글개수
		/// </summary>
		[Description("페이지당글개수")]
		public int EachPageCharactersNumber { get; set; }
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
		/// <summary>
		/// 전체페이지수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체페이지수")]
		public int EntirePageNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일지번호
		/// </summary>
		[Column("일지번호")]
		public int JournalNumber { get; set; }
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
		/// 결재자
		/// </summary>
		[Column("결재자")]
		public int Approver { get; set; }
		/// <summary>
		/// 내용1
		/// </summary>
		[Column("내용1")]
		public string Content1 { get; set; }
		/// <summary>
		/// profile_image
		/// </summary>
		[Column("profile_image")]
		public string profile_image { get; set; }
		/// <summary>
		/// CNT
		/// </summary>
		[Column("CNT")]
		public int CNT { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 부서번호
		/// </summary>
		[Column("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 결재대기수
		/// </summary>
		[Column("결재대기수")]
		public int NumberOfWaitingPayments { get; set; }
	}
}