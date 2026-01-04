namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_많이본상품_단체지역별
/// </summary>
public class WSP_S_MostViewedProduct_GroupEachRegion
{
	public const string SP_NAME = "WSP_S_많이본상품_단체지역별";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체지역명
		/// </summary>
		[Description("단체지역명")]
		public string GroupRegionName { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Description("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// 테마명
		/// </summary>
		[Description("테마명")]
		public string ThemeName { get; set; }
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
		/// 단체지역명
		/// </summary>
		[Column("단체지역명")]
		public string GroupRegionName { get; set; }
		/// <summary>
		/// 뷰수
		/// </summary>
		[Column("뷰수")]
		public int ViewerNumber { get; set; }
	}
}