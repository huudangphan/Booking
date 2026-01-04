namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_인도네시아_비자게시판리스트
/// </summary>
public class WSP_S_Indonesia_VisaNoticeboardList
{
	public const string SP_NAME = "WSP_S_인도네시아_비자게시판리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 게시판구분
		/// </summary>
		[Description("게시판구분")]
		public int NoticeboardClassification { get; set; }
		/// <summary>
		/// 언어구분
		/// </summary>
		[Description("언어구분")]
		public string LanguageClassification { get; set; }
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
		/// 검색필드
		/// </summary>
		[Description("검색필드")]
		public string SearchingField { get; set; }
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
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
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 게시판구분
		/// </summary>
		[Column("게시판구분")]
		public int NoticeboardClassification { get; set; }
		/// <summary>
		/// 언어구분
		/// </summary>
		[Column("언어구분")]
		public string LanguageClassification { get; set; }
		/// <summary>
		/// 스텝1
		/// </summary>
		[Column("스텝1")]
		public int Step1 { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 태그
		/// </summary>
		[Column("태그")]
		public byte Tag { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 파일1
		/// </summary>
		[Column("파일1")]
		public string File1 { get; set; }
		/// <summary>
		/// 파일2
		/// </summary>
		[Column("파일2")]
		public string File2 { get; set; }
		/// <summary>
		/// 파일3
		/// </summary>
		[Column("파일3")]
		public string File3 { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 비밀설정여부
		/// </summary>
		[Column("비밀설정여부")]
		public string PasswordSettingOrNot { get; set; }
		/// <summary>
		/// 답변여부
		/// </summary>
		[Column("답변여부")]
		public string AnswerOrNot { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Column("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 등록일1
		/// </summary>
		[Column("등록일1")]
		public DateTime RegisterDate1 { get; set; }
		/// <summary>
		/// 공지
		/// </summary>
		[Column("공지")]
		public bool Notification { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// 관리자답변
		/// </summary>
		[Column("관리자답변")]
		public string AdminAnswer { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
	}
}