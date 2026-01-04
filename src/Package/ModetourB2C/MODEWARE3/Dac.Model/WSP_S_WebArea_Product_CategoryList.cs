namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_웹구역_상품_카테고리리스트
/// </summary>
public class WSP_S_WebArea_Product_CategoryList
{
	public const string SP_NAME = "WSP_S_웹구역_상품_카테고리리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// MLOC
		/// </summary>
		[Description("MLOC")]
		public string MLOC { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 웹페이지
		/// </summary>
		[Column("웹페이지")]
		public string WebPage { get; set; }
		/// <summary>
		/// 페이지명
		/// </summary>
		[Column("페이지명")]
		public string PageName { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public byte Sorting { get; set; }
	}
}