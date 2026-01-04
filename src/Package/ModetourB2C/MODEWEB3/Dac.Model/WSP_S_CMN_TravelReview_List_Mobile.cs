namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_여행후기_리스트_모바일
/// </summary>
public class WSP_S_CMN_TravelReview_List_Mobile
{
	public const string SP_NAME = "WSP_S_CMN_여행후기_리스트_모바일";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지역
		/// </summary>
		[Description("지역")]
		public string Region { get; set; }
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
		/// 정렬
		/// </summary>
		[Description("정렬")]
		public string Sorting { get; set; }
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// RNUM
		/// </summary>
		[Column("RNUM")]
		public long RNUM { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Column("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 글쓴이
		/// </summary>
		[Column("글쓴이")]
		public string Writer { get; set; }
		/// <summary>
		/// 만족도
		/// </summary>
		[Column("만족도")]
		public string SatisfactionRate { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
	}
}