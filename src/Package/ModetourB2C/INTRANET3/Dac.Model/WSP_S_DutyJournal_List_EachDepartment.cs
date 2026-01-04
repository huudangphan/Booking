namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_업무일지_리스트_부서별
/// </summary>
public class WSP_S_DutyJournal_List_EachDepartment
{
	public const string SP_NAME = "WSP_S_업무일지_리스트_부서별";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
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

	public class Result : IDbResult
	{
		/// <summary>
		/// 일지번호
		/// </summary>
		[Column("일지번호")]
		public int JournalNumber { get; set; }
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
		/// 지시사항
		/// </summary>
		[Column("지시사항")]
		public int Commands { get; set; }
	}
}