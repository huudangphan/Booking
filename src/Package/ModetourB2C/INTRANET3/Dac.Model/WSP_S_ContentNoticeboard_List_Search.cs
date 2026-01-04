namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_컨텐츠게시판_리스트_검색
/// </summary>
public class WSP_S_ContentNoticeboard_List_Search
{
	public const string SP_NAME = "WSP_S_컨텐츠게시판_리스트_검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 게시판명
		/// </summary>
		[Description("게시판명")]
		public string NoticeboardName { get; set; }
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
		/// 지역
		/// </summary>
		[Description("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 항목
		/// </summary>
		[Description("항목")]
		public string Item { get; set; }
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
		/// 검색기간1
		/// </summary>
		[Description("검색기간1")]
		public DateTime SearchingPeriod1 { get; set; }
		/// <summary>
		/// 검색기간2
		/// </summary>
		[Description("검색기간2")]
		public DateTime SearchingPeriod2 { get; set; }
	}

}