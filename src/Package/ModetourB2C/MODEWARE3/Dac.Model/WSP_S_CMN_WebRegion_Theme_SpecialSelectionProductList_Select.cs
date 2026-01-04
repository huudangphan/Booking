namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_웹지역_테마_특선상품리스트_선택
/// </summary>
public class WSP_S_CMN_WebRegion_Theme_SpecialSelectionProductList_Select
{
	public const string SP_NAME = "WSP_S_CMN_웹지역_테마_특선상품리스트_선택";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 웹지역번호
		/// </summary>
		[Description("웹지역번호")]
		public int WebRegionNumber { get; set; }
		/// <summary>
		/// 웹테마번호
		/// </summary>
		[Description("웹테마번호")]
		public int WebThemeNumber { get; set; }
		/// <summary>
		/// 웹지역번호리스트
		/// </summary>
		[Description("웹지역번호리스트")]
		public string WebRegionNumberList { get; set; }
		/// <summary>
		/// 웹테마번호리스트
		/// </summary>
		[Description("웹테마번호리스트")]
		public string WebThemeNumberList { get; set; }
		/// <summary>
		/// 결과TYPE
		/// </summary>
		[Description("결과TYPE")]
		public string Result_TYPE { get; set; }
		/// <summary>
		/// 리스트갯수
		/// </summary>
		[Description("리스트갯수")]
		public int ListNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 웹지역_테마번호
		/// </summary>
		[Column("웹지역_테마번호")]
		public int WebRegion_ThemeNumber { get; set; }
		/// <summary>
		/// 항목번호
		/// </summary>
		[Column("항목번호")]
		public int ItemNumber { get; set; }
		/// <summary>
		/// 항목명
		/// </summary>
		[Column("항목명")]
		public string ItemName { get; set; }
		/// <summary>
		/// IDX
		/// </summary>
		[Column("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 특가명
		/// </summary>
		[Column("특가명")]
		public string SpecialPriceName { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 이미지경로
		/// </summary>
		[Column("이미지경로")]
		public string ImageRoute { get; set; }
		/// <summary>
		/// 추천아이콘
		/// </summary>
		[Column("추천아이콘")]
		public string RecommendIcon { get; set; }
		/// <summary>
		/// 간략설명
		/// </summary>
		[Column("간략설명")]
		public string BriefDescription { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// 할인율
		/// </summary>
		[Column("할인율")]
		public int DiscountRate { get; set; }
		/// <summary>
		/// SORT1
		/// </summary>
		[Column("SORT1")]
		public int SORT1 { get; set; }
		/// <summary>
		/// SORT2
		/// </summary>
		[Column("SORT2")]
		public int SORT2 { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 특전
		/// </summary>
		[Column("특전")]
		public string SpecialEvent { get; set; }
		/// <summary>
		/// 최소가격
		/// </summary>
		[Column("최소가격")]
		public long MinimumPrice { get; set; }
		/// <summary>
		/// 최대가격
		/// </summary>
		[Column("최대가격")]
		public long MaximumPrice { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 시작날짜
		/// </summary>
		[Column("시작날짜")]
		public string StartDate { get; set; }
		/// <summary>
		/// 포인트율
		/// </summary>
		[Column("포인트율")]
		public decimal PointRate { get; set; }
	}
}