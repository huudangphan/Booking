namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_전문가_패키지_통합_검색리스트
/// </summary>
public class WSP_S_CMN_Expert_Package_Integrated_SearchList
{
	public const string SP_NAME = "WSP_S_CMN_전문가_패키지_통합_검색리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 국가번호
		/// </summary>
		[Description("국가번호")]
		public int CountryNumber { get; set; }
		/// <summary>
		/// 테마
		/// </summary>
		[Description("테마")]
		public string Theme { get; set; }
		/// <summary>
		/// 검색명
		/// </summary>
		[Description("검색명")]
		public string SearchingName { get; set; }
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
		/// <summary>
		/// 메뉴구분
		/// </summary>
		[Description("메뉴구분")]
		public string MenuClassification { get; set; }
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
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 대륙
		/// </summary>
		[Column("대륙")]
		public int Continent { get; set; }
		/// <summary>
		/// 국가
		/// </summary>
		[Column("국가")]
		public int Country { get; set; }
		/// <summary>
		/// 도시
		/// </summary>
		[Column("도시")]
		public int City { get; set; }
		/// <summary>
		/// 주
		/// </summary>
		[Column("주")]
		public int Week { get; set; }
		/// <summary>
		/// 테마
		/// </summary>
		[Column("테마")]
		public string Theme { get; set; }
		/// <summary>
		/// 메뉴구분
		/// </summary>
		[Column("메뉴구분")]
		public string MenuClassification { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 리스트이미지
		/// </summary>
		[Column("리스트이미지")]
		public string ListImage { get; set; }
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
		/// <summary>
		/// 지역2
		/// </summary>
		[Column("지역2")]
		public string Region2 { get; set; }
		/// <summary>
		/// 지역3
		/// </summary>
		[Column("지역3")]
		public string Region3 { get; set; }
		/// <summary>
		/// ptid
		/// </summary>
		[Column("ptid")]
		public int ptid { get; set; }
	}
}