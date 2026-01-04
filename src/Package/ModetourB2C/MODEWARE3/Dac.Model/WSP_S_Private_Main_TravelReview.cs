namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_프라이빗_메인_여행리뷰
/// </summary>
public class WSP_S_Private_Main_TravelReview
{
	public const string SP_NAME = "WSP_S_프라이빗_메인_여행리뷰";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 번호
		/// </summary>
		[Description("번호")]
		public int Number { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 국가대륙
		/// </summary>
		[Column("국가대륙")]
		public string CountryContinent { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
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
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// 지역PLID
		/// </summary>
		[Column("지역PLID")]
		public int RegionPLID { get; set; }
		/// <summary>
		/// 여행지
		/// </summary>
		[Column("여행지")]
		public string TravelSpot { get; set; }
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
	}
}