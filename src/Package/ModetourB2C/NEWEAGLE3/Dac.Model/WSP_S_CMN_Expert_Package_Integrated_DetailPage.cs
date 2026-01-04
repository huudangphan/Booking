namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_전문가_패키지_통합_상세페이지
/// </summary>
public class WSP_S_CMN_Expert_Package_Integrated_DetailPage
{
	public const string SP_NAME = "WSP_S_CMN_전문가_패키지_통합_상세페이지";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 메뉴구분
		/// </summary>
		[Description("메뉴구분")]
		public string MenuClassification { get; set; }
	}

	public class Result1 : IDbResult
	{
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
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 메뉴구분
		/// </summary>
		[Column("메뉴구분")]
		public string MenuClassification { get; set; }
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
		/// 테마
		/// </summary>
		[Column("테마")]
		public string Theme { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 간략설명
		/// </summary>
		[Column("간략설명")]
		public string BriefDescription { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 내용2
		/// </summary>
		[Column("내용2")]
		public string Content2 { get; set; }
		/// <summary>
		/// 리스트이미지
		/// </summary>
		[Column("리스트이미지")]
		public string ListImage { get; set; }
		/// <summary>
		/// 메인BG이미지
		/// </summary>
		[Column("메인BG이미지")]
		public string Main_BG_Image { get; set; }
		/// <summary>
		/// 관련상품
		/// </summary>
		[Column("관련상품")]
		public string RelatedProduct { get; set; }
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
		/// 주
		/// </summary>
		[Column("주")]
		public int Week { get; set; }
		/// <summary>
		/// 내용3
		/// </summary>
		[Column("내용3")]
		public string Content3 { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
	}
}