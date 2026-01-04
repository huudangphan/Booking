namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_회사소개_자료게시판리스트
/// </summary>
public class WSP_S_CompanyIntroduction_MaterialNoticeboardList
{
	public const string SP_NAME = "WSP_S_회사소개_자료게시판리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public int Classification { get; set; }
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
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 파일
		/// </summary>
		[Column("파일")]
		public string File { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 제목_영문
		/// </summary>
		[Column("제목_영문")]
		public string Title_English { get; set; }
		/// <summary>
		/// 내용_영문
		/// </summary>
		[Column("내용_영문")]
		public string Content_English { get; set; }
		/// <summary>
		/// 파일_영문
		/// </summary>
		[Column("파일_영문")]
		public string File_English { get; set; }
		/// <summary>
		/// 파일뷰_영문
		/// </summary>
		[Column("파일뷰_영문")]
		public bool FileView_English { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
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
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 제목_영문
		/// </summary>
		[Column("제목_영문")]
		public string Title_English { get; set; }
		/// <summary>
		/// 내용_영문
		/// </summary>
		[Column("내용_영문")]
		public string Content_English { get; set; }
		/// <summary>
		/// 파일_영문
		/// </summary>
		[Column("파일_영문")]
		public string File_English { get; set; }
		/// <summary>
		/// 파일뷰_영문
		/// </summary>
		[Column("파일뷰_영문")]
		public bool FileView_English { get; set; }
	}
}