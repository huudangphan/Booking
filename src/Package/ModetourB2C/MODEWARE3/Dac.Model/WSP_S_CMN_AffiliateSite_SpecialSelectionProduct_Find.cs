namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_제휴사이트_특선상품_조회
/// </summary>
public class WSP_S_CMN_AffiliateSite_SpecialSelectionProduct_Find
{
	public const string SP_NAME = "WSP_S_CMN_제휴사이트_특선상품_조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// AREANO
		/// </summary>
		[Description("AREANO")]
		public int AREANO { get; set; }
		/// <summary>
		/// LISTCNT
		/// </summary>
		[Description("LISTCNT")]
		public int LISTCNT { get; set; }
		/// <summary>
		/// STARTNUM
		/// </summary>
		[Description("STARTNUM")]
		public int STARTNUM { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Column("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
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
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 정렬순서
		/// </summary>
		[Column("정렬순서")]
		public int SortingOrder { get; set; }
	}
}