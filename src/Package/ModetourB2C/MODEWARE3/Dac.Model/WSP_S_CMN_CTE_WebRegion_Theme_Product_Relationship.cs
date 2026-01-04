namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_CTE_웹지역_테마_상품_관계
/// </summary>
public class WSP_S_CMN_CTE_WebRegion_Theme_Product_Relationship
{
	public const string SP_NAME = "WSP_S_CMN_CTE_웹지역_테마_상품_관계";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지역번호
		/// </summary>
		[Description("지역번호")]
		public int RegionNumber { get; set; }
		/// <summary>
		/// 테마번호
		/// </summary>
		[Description("테마번호")]
		public int ThemeNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 지역번호
		/// </summary>
		[Column("지역번호")]
		public int RegionNumber { get; set; }
		/// <summary>
		/// 테마번호
		/// </summary>
		[Column("테마번호")]
		public int ThemeNumber { get; set; }
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
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
	}
}