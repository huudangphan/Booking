namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ASP_TOUR_REVIEW
/// </summary>
public class ASP_TOUR_REVIEW
{
	public const string SP_NAME = "ASP_TOUR_REVIEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PRO_CODE
		/// </summary>
		[Description("PRO_CODE")]
		public string PRO_CODE { get; set; }
		/// <summary>
		/// GRO_IDX
		/// </summary>
		[Description("GRO_IDX")]
		public int GRO_IDX { get; set; }
		/// <summary>
		/// LAST_IDX
		/// </summary>
		[Description("LAST_IDX")]
		public int LAST_IDX { get; set; }
		/// <summary>
		/// SEL_CNT
		/// </summary>
		[Description("SEL_CNT")]
		public int SEL_CNT { get; set; }
		/// <summary>
		/// PAGE
		/// </summary>
		[Description("PAGE")]
		public int PAGE { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// TOTAL_COUNT
		/// </summary>
		[Column("TOTAL_COUNT")]
		public int TOTAL_COUNT { get; set; }
		/// <summary>
		/// END_IDX
		/// </summary>
		[Column("END_IDX")]
		public int END_IDX { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 글쓴이
		/// </summary>
		[Column("글쓴이")]
		public string Writer { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 만족도
		/// </summary>
		[Column("만족도")]
		public string SatisfactionRate { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 오픈
		/// </summary>
		[Column("오픈")]
		public string Open { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 항공사명
		/// </summary>
		[Column("항공사명")]
		public string AirlineName { get; set; }
		/// <summary>
		/// 대표호텔
		/// </summary>
		[Column("대표호텔")]
		public string RepresentativeHotel { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// TOTAL_COUNT
		/// </summary>
		[Column("TOTAL_COUNT")]
		public int TOTAL_COUNT { get; set; }
		/// <summary>
		/// END_IDX
		/// </summary>
		[Column("END_IDX")]
		public int END_IDX { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 글쓴이
		/// </summary>
		[Column("글쓴이")]
		public string Writer { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 만족도
		/// </summary>
		[Column("만족도")]
		public string SatisfactionRate { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 오픈
		/// </summary>
		[Column("오픈")]
		public string Open { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 항공사명
		/// </summary>
		[Column("항공사명")]
		public string AirlineName { get; set; }
		/// <summary>
		/// 대표호텔
		/// </summary>
		[Column("대표호텔")]
		public string RepresentativeHotel { get; set; }
		/// <summary>
		/// ROWNUMBER
		/// </summary>
		[Column("ROWNUMBER")]
		public long ROWNUMBER { get; set; }
	}
}