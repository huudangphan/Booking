namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_온라인등급_전체상품
/// </summary>
public class WSP_S_CMN_OnlineRating_WholeProduct
{
	public const string SP_NAME = "WSP_S_CMN_온라인등급_전체상품";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품번호
		/// </summary>
		[Description("상품번호")]
		public int ProductNumber { get; set; }
		/// <summary>
		/// 상품분류코드
		/// </summary>
		[Description("상품분류코드")]
		public string ProductClassificationCode { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 상품번호
		/// </summary>
		[Column("상품번호")]
		public int ProductNumber { get; set; }
		/// <summary>
		/// 상품분류코드
		/// </summary>
		[Column("상품분류코드")]
		public string ProductClassificationCode { get; set; }
		/// <summary>
		/// 상품분류명
		/// </summary>
		[Column("상품분류명")]
		public string ProductClassificationName { get; set; }
		/// <summary>
		/// 상품제목
		/// </summary>
		[Column("상품제목")]
		public string ProductTitle { get; set; }
		/// <summary>
		/// 상품부제목
		/// </summary>
		[Column("상품부제목")]
		public string ProductSubTitle { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 상품이미지1
		/// </summary>
		[Column("상품이미지1")]
		public string ProductImage1 { get; set; }
		/// <summary>
		/// 상품이미지2
		/// </summary>
		[Column("상품이미지2")]
		public string ProductImage2 { get; set; }
		/// <summary>
		/// 상품이미지3
		/// </summary>
		[Column("상품이미지3")]
		public string ProductImage3 { get; set; }
		/// <summary>
		/// 스타일선택여부
		/// </summary>
		[Column("스타일선택여부")]
		public string StyleSelectOrNot { get; set; }
		/// <summary>
		/// 스타일
		/// </summary>
		[Column("스타일")]
		public string Style { get; set; }
		/// <summary>
		/// 상품링크1
		/// </summary>
		[Column("상품링크1")]
		public string ProductLink1 { get; set; }
		/// <summary>
		/// 상품링크2
		/// </summary>
		[Column("상품링크2")]
		public string ProductLink2 { get; set; }
		/// <summary>
		/// 상품링크3
		/// </summary>
		[Column("상품링크3")]
		public string ProductLink3 { get; set; }
		/// <summary>
		/// 상품가격
		/// </summary>
		[Column("상품가격")]
		public int ProductPrice { get; set; }
		/// <summary>
		/// 할인율
		/// </summary>
		[Column("할인율")]
		public int DiscountRate { get; set; }
		/// <summary>
		/// 상품설명
		/// </summary>
		[Column("상품설명")]
		public string ProductExplaination { get; set; }
		/// <summary>
		/// 게시
		/// </summary>
		[Column("게시")]
		public string Post { get; set; }
		/// <summary>
		/// 게시시작일
		/// </summary>
		[Column("게시시작일")]
		public DateTime PostStartDate { get; set; }
		/// <summary>
		/// 게시만료일
		/// </summary>
		[Column("게시만료일")]
		public DateTime PostExpirationDate { get; set; }
		/// <summary>
		/// 상품출발일
		/// </summary>
		[Column("상품출발일")]
		public DateTime ProductDepartureDate { get; set; }
		/// <summary>
		/// 상품도착일
		/// </summary>
		[Column("상품도착일")]
		public DateTime ProductArrivalDate { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public string Registerer { get; set; }
		/// <summary>
		/// 등록자번호
		/// </summary>
		[Column("등록자번호")]
		public string RegistererNumber { get; set; }
		/// <summary>
		/// 지역번호
		/// </summary>
		[Column("지역번호")]
		public string RegionNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 사용수
		/// </summary>
		[Column("사용수")]
		public int UseNumber { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 상품번호
		/// </summary>
		[Column("상품번호")]
		public int ProductNumber { get; set; }
		/// <summary>
		/// 지역번호
		/// </summary>
		[Column("지역번호")]
		public string RegionNumber { get; set; }
		/// <summary>
		/// 테마번호
		/// </summary>
		[Column("테마번호")]
		public string ThemeNumber { get; set; }
		/// <summary>
		/// 상품분류코드
		/// </summary>
		[Column("상품분류코드")]
		public string ProductClassificationCode { get; set; }
		/// <summary>
		/// 상품분류명
		/// </summary>
		[Column("상품분류명")]
		public string ProductClassificationName { get; set; }
		/// <summary>
		/// 상품제목
		/// </summary>
		[Column("상품제목")]
		public string ProductTitle { get; set; }
		/// <summary>
		/// 상품부제목
		/// </summary>
		[Column("상품부제목")]
		public string ProductSubTitle { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 상품이미지1
		/// </summary>
		[Column("상품이미지1")]
		public string ProductImage1 { get; set; }
		/// <summary>
		/// 상품이미지2
		/// </summary>
		[Column("상품이미지2")]
		public string ProductImage2 { get; set; }
		/// <summary>
		/// 상품이미지3
		/// </summary>
		[Column("상품이미지3")]
		public string ProductImage3 { get; set; }
		/// <summary>
		/// 스타일선택여부
		/// </summary>
		[Column("스타일선택여부")]
		public string StyleSelectOrNot { get; set; }
		/// <summary>
		/// 스타일
		/// </summary>
		[Column("스타일")]
		public string Style { get; set; }
		/// <summary>
		/// 상품링크1
		/// </summary>
		[Column("상품링크1")]
		public string ProductLink1 { get; set; }
		/// <summary>
		/// 상품링크2
		/// </summary>
		[Column("상품링크2")]
		public string ProductLink2 { get; set; }
		/// <summary>
		/// 상품링크3
		/// </summary>
		[Column("상품링크3")]
		public string ProductLink3 { get; set; }
		/// <summary>
		/// 상품가격
		/// </summary>
		[Column("상품가격")]
		public int ProductPrice { get; set; }
		/// <summary>
		/// 할인율
		/// </summary>
		[Column("할인율")]
		public int DiscountRate { get; set; }
		/// <summary>
		/// 상품설명
		/// </summary>
		[Column("상품설명")]
		public string ProductExplaination { get; set; }
		/// <summary>
		/// 게시
		/// </summary>
		[Column("게시")]
		public string Post { get; set; }
		/// <summary>
		/// 게시시작일
		/// </summary>
		[Column("게시시작일")]
		public DateTime PostStartDate { get; set; }
		/// <summary>
		/// 게시만료일
		/// </summary>
		[Column("게시만료일")]
		public DateTime PostExpirationDate { get; set; }
		/// <summary>
		/// 상품출발일
		/// </summary>
		[Column("상품출발일")]
		public DateTime ProductDepartureDate { get; set; }
		/// <summary>
		/// 상품도착일
		/// </summary>
		[Column("상품도착일")]
		public DateTime ProductArrivalDate { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public string Registerer { get; set; }
		/// <summary>
		/// 등록자번호
		/// </summary>
		[Column("등록자번호")]
		public string RegistererNumber { get; set; }
	}
}