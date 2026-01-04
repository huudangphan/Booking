namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_추천골프장_리스트
/// </summary>
public class WSP_S_CMN_RecommendGolfCourse_List
{
	public const string SP_NAME = "WSP_S_CMN_추천골프장_리스트";

	public class Result : IDbResult
	{
		/// <summary>
		/// 골프장번호
		/// </summary>
		[Column("골프장번호")]
		public int GolfCourseNumber { get; set; }
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
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 대륙PLID
		/// </summary>
		[Column("대륙PLID")]
		public int Continent_PLID { get; set; }
		/// <summary>
		/// 국가PLID
		/// </summary>
		[Column("국가PLID")]
		public int Country_PLID { get; set; }
		/// <summary>
		/// 도시PLID
		/// </summary>
		[Column("도시PLID")]
		public int City_PLID { get; set; }
	}
}