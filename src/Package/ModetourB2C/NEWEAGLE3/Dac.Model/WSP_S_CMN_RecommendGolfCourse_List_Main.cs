namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_추천골프장_리스트_메인
/// </summary>
public class WSP_S_CMN_RecommendGolfCourse_List_Main
{
	public const string SP_NAME = "WSP_S_CMN_추천골프장_리스트_메인";

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 대륙
		/// </summary>
		[Column("대륙")]
		public string Continent { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 도시
		/// </summary>
		[Column("도시")]
		public string City { get; set; }
		/// <summary>
		/// 추천지
		/// </summary>
		[Column("추천지")]
		public string RecommendArea { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 개요
		/// </summary>
		[Column("개요")]
		public string Summary { get; set; }
		/// <summary>
		/// 사진1
		/// </summary>
		[Column("사진1")]
		public string Picture1 { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 메뉴
		/// </summary>
		[Column("메뉴")]
		public string Menu { get; set; }
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public int Region1 { get; set; }
		/// <summary>
		/// 지역2
		/// </summary>
		[Column("지역2")]
		public int Region2 { get; set; }
		/// <summary>
		/// 지역3
		/// </summary>
		[Column("지역3")]
		public int Region3 { get; set; }
	}
}