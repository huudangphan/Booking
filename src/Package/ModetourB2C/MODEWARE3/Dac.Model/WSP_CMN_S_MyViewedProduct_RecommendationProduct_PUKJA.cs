namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_CMN_S_내가본상품_추천상품_PUKJA
/// </summary>
public class WSP_CMN_S_MyViewedProduct_RecommendationProduct_PUKJA
{
	public const string SP_NAME = "WSP_CMN_S_내가본상품_추천상품_PUKJA";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 판매가어른
		/// </summary>
		[Column("판매가어른")]
		public long SellingPriceAdult { get; set; }
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Column("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
		/// <summary>
		/// 이미지경로
		/// </summary>
		[Column("이미지경로")]
		public string ImageRoute { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
	}
}