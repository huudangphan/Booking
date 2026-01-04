namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_많이본상품_웹지역별
/// </summary>
public class WSP_S_MostViewedProduct_WebEachRegion
{
	public const string SP_NAME = "WSP_S_많이본상품_웹지역별";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 웹지역번호
		/// </summary>
		[Description("웹지역번호")]
		public string WebRegionNumber { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Description("출발지")]
		public string Departures { get; set; }
	}

	public class Result : IDbResult
	{
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
		/// 지역번호
		/// </summary>
		[Column("지역번호")]
		public int RegionNumber { get; set; }
		/// <summary>
		/// 지역명
		/// </summary>
		[Column("지역명")]
		public string RegionName { get; set; }
		/// <summary>
		/// 뷰수
		/// </summary>
		[Column("뷰수")]
		public int ViewerNumber { get; set; }
		/// <summary>
		/// 순위
		/// </summary>
		[Column("순위")]
		public long Ranking { get; set; }
		/// <summary>
		/// 최저가
		/// </summary>
		[Column("최저가")]
		public long LowestPrice { get; set; }
	}
}