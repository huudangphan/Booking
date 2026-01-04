namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_게시판리스트_검색
/// </summary>
public class WSP_S_CMN_NoticeboardList_Search
{
	public const string SP_NAME = "WSP_S_CMN_게시판리스트_검색";

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
		/// 스킨번호
		/// </summary>
		[Description("스킨번호")]
		public string SkinNumber { get; set; }
		/// <summary>
		/// 게시판형태
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("게시판형태")]
		public string NoticeboardFormat { get; set; }
		/// <summary>
		/// 타이틀
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 3000)]
		[Description("타이틀")]
		public string Title { get; set; }
		/// <summary>
		/// 하단부
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 2000)]
		[Description("하단부")]
		public string BottomPart { get; set; }
		/// <summary>
		/// 게시판폭
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 10)]
		[Description("게시판폭")]
		public string NoticeboardWidth { get; set; }
		/// <summary>
		/// 스타일
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 100)]
		[Description("스타일")]
		public string Style { get; set; }
		/// <summary>
		/// 이메일공개
		/// </summary>
		[DapperParameter(DbType.Boolean, ParameterDirection.InputOutput, 1)]
		[Description("이메일공개")]
		public bool EmailRelease { get; set; }
		/// <summary>
		/// 로그인체크
		/// </summary>
		[DapperParameter(DbType.Boolean, ParameterDirection.InputOutput, 1)]
		[Description("로그인체크")]
		public bool LoginCheck { get; set; }
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
		/// 게시판형태
		/// </summary>
		[Column("게시판형태")]
		public string NoticeboardFormat { get; set; }
		/// <summary>
		/// 타이틀
		/// </summary>
		[Column("타이틀")]
		public string Title { get; set; }
		/// <summary>
		/// 하단부
		/// </summary>
		[Column("하단부")]
		public string BottomPart { get; set; }
		/// <summary>
		/// 게시판폭
		/// </summary>
		[Column("게시판폭")]
		public string NoticeboardWidth { get; set; }
		/// <summary>
		/// 스타일
		/// </summary>
		[Column("스타일")]
		public string Style { get; set; }
		/// <summary>
		/// 이메일공개
		/// </summary>
		[Column("이메일공개")]
		public bool EmailRelease { get; set; }
	}
}