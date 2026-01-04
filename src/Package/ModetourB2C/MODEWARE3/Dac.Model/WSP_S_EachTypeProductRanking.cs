namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_유형별상품순위
/// </summary>
public class WSP_S_EachTypeProductRanking
{
	public const string SP_NAME = "WSP_S_유형별상품순위";

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 범주
		/// </summary>
		[Column("범주")]
		public string Category { get; set; }
		/// <summary>
		/// 유형
		/// </summary>
		[Column("유형")]
		public string Type { get; set; }
		/// <summary>
		/// 상품분류
		/// </summary>
		[Column("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 간략설명
		/// </summary>
		[Column("간략설명")]
		public string BriefDescription { get; set; }
		/// <summary>
		/// 상품설명
		/// </summary>
		[Column("상품설명")]
		public string ProductExplaination { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 순위
		/// </summary>
		[Column("순위")]
		public int Ranking { get; set; }
		/// <summary>
		/// 순위기준값
		/// </summary>
		[Column("순위기준값")]
		public int RankingStandardValue { get; set; }
		/// <summary>
		/// 최저가
		/// </summary>
		[Column("최저가")]
		public decimal LowestPrice { get; set; }
		/// <summary>
		/// 여행후기
		/// </summary>
		[Column("여행후기")]
		public int TravelReview { get; set; }
		/// <summary>
		/// 찜
		/// </summary>
		[Column("찜")]
		public int Favorite { get; set; }
		/// <summary>
		/// 기준일시
		/// </summary>
		[Column("기준일시")]
		public DateTime StandardDateAndTime { get; set; }
	}
}