namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_통합게시판03_리스트_말머리
/// </summary>
public class UP_IntegratedNoticeboard03_List_HeadOfStory
{
	public const string SP_NAME = "UP_통합게시판03_리스트_말머리";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 게시판번호
		/// </summary>
		[Description("게시판번호")]
		public int NoticeboardNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
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
		/// <summary>
		/// 말머리
		/// </summary>
		[Description("말머리")]
		public string HeadOfStory { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 스텝1
		/// </summary>
		[Column("스텝1")]
		public int Step1 { get; set; }
		/// <summary>
		/// 스텝2
		/// </summary>
		[Column("스텝2")]
		public byte Step2 { get; set; }
		/// <summary>
		/// 스텝3
		/// </summary>
		[Column("스텝3")]
		public byte Step3 { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 말머리
		/// </summary>
		[Column("말머리")]
		public string HeadOfStory { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Column("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 메모수
		/// </summary>
		[Column("메모수")]
		public short MemoCount { get; set; }
		/// <summary>
		/// 공지날짜
		/// </summary>
		[Column("공지날짜")]
		public string NotificationDate { get; set; }
		/// <summary>
		/// 공지
		/// </summary>
		[Column("공지")]
		public int Notification { get; set; }
		/// <summary>
		/// 마지막등록일
		/// </summary>
		[Column("마지막등록일")]
		public DateTime LastRegisterDate { get; set; }
		/// <summary>
		/// 제목태그
		/// </summary>
		[Column("제목태그")]
		public string TitleTag { get; set; }
		/// <summary>
		/// 직원조회수
		/// </summary>
		[Column("직원조회수")]
		public int EmployeeSearchNumber { get; set; }
		/// <summary>
		/// 평가_합계
		/// </summary>
		[Column("평가_합계")]
		public int Evaluation_Sum { get; set; }
		/// <summary>
		/// 평가_평균
		/// </summary>
		[Column("평가_평균")]
		public int Evaluation_Average { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 폴더명
		/// </summary>
		[Column("폴더명")]
		public string FolderName { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 게시판명
		/// </summary>
		[Column("게시판명")]
		public string NoticeboardName { get; set; }
		/// <summary>
		/// 답변유무
		/// </summary>
		[Column("답변유무")]
		public bool AnswerOrNot { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 비밀번호변경권한
		/// </summary>
		[Column("비밀번호변경권한")]
		public string PasswordChangeAuthority { get; set; }
		/// <summary>
		/// 말머리
		/// </summary>
		[Column("말머리")]
		public string HeadOfStory { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// 관리담당
		/// </summary>
		[Column("관리담당")]
		public string ManageResponsibility { get; set; }
	}
}