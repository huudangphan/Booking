namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_웹지역_테마_상품리스트
/// </summary>
public class WSP_S_CMN_WebRegion_Theme_ProductList
{
	public const string SP_NAME = "WSP_S_CMN_웹지역_테마_상품리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Description("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Description("종료일")]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 웹지역번호
		/// </summary>
		[Description("웹지역번호")]
		public string WebRegionNumber { get; set; }
		/// <summary>
		/// 웹테마번호
		/// </summary>
		[Description("웹테마번호")]
		public string WebThemeNumber { get; set; }
		/// <summary>
		/// 가격_기간조건
		/// </summary>
		[Description("가격_기간조건")]
		public string Price_PeriodCondition { get; set; }
		/// <summary>
		/// 기간고정여부
		/// </summary>
		[Description("기간고정여부")]
		public string PeriodFixedOrNot { get; set; }
	}

	public class Result1 : IDbResult
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
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
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
		/// 최소일수
		/// </summary>
		[Column("최소일수")]
		public byte MinimumDaysNumber { get; set; }
		/// <summary>
		/// 최대일수
		/// </summary>
		[Column("최대일수")]
		public byte MaximumDaysNumber { get; set; }
		/// <summary>
		/// XML생성
		/// </summary>
		[Column("XML생성")]
		public int XML_Creation { get; set; }
	}

	public class Result2 : IDbResult
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
		/// 와이드이미지
		/// </summary>
		[Column("와이드이미지")]
		public string WideImage { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
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
		/// 최소일수
		/// </summary>
		[Column("최소일수")]
		public int MinimumDaysNumber { get; set; }
		/// <summary>
		/// 최대일수
		/// </summary>
		[Column("최대일수")]
		public int MaximumDaysNumber { get; set; }
		/// <summary>
		/// XML생성
		/// </summary>
		[Column("XML생성")]
		public int XML_Creation { get; set; }
	}

	public class Result3 : IDbResult
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
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
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
		/// 최소일수
		/// </summary>
		[Column("최소일수")]
		public byte MinimumDaysNumber { get; set; }
		/// <summary>
		/// 최대일수
		/// </summary>
		[Column("최대일수")]
		public byte MaximumDaysNumber { get; set; }
	}
}