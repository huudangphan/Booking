namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_컨셉투어_상품명WITH단체번호
/// </summary>
public class WSP_S_ConceptTour_ProductName_WITH_GroupNumber
{
	public const string SP_NAME = "WSP_S_컨셉투어_상품명WITH단체번호";

	public class Result : IDbResult
	{
		/// <summary>
		/// 카테고리번호
		/// </summary>
		[Column("카테고리번호")]
		public int CategoryNumber { get; set; }
		/// <summary>
		/// 카테고리명
		/// </summary>
		[Column("카테고리명")]
		public string CategoryName { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 링크
		/// </summary>
		[Column("링크")]
		public string Link { get; set; }
	}
}