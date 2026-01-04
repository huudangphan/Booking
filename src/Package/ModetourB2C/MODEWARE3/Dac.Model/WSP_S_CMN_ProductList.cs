namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_상품리스트
/// </summary>
public class WSP_S_CMN_ProductList
{
	public const string SP_NAME = "WSP_S_CMN_상품리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// ACode
		/// </summary>
		[Description("ACode")]
		public int ACode { get; set; }
		/// <summary>
		/// XMLDOC
		/// </summary>
		[Description("XMLDOC")]
		public string XMLDOC { get; set; }
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
		/// 최저가격
		/// </summary>
		[Column("최저가격")]
		public string LowestPrice { get; set; }
		/// <summary>
		/// 최고가격
		/// </summary>
		[Column("최고가격")]
		public string HighestPrice { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
		/// <summary>
		/// 나열순서
		/// </summary>
		[Column("나열순서")]
		public short ListingOrder { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 국가
		/// </summary>
		[Column("국가")]
		public string Country { get; set; }
		/// <summary>
		/// 도시
		/// </summary>
		[Column("도시")]
		public string City { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 마지막일
		/// </summary>
		[Column("마지막일")]
		public string LastDate { get; set; }
	}
}