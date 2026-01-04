namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_일정표_임의단체
/// </summary>
public class WSP_S_ScheduleTable_RandomGroup
{
	public const string SP_NAME = "WSP_S_일정표_임의단체";

	public class Result : IDbResult
	{
		/// <summary>
		/// 프로모션여부
		/// </summary>
		[Column("프로모션여부")]
		public string PromotionOrNot { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 판매가_어른_총액
		/// </summary>
		[Column("판매가_어른_총액")]
		public long SellingPrice_Adult_TotalAmount { get; set; }
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
		/// 단체지역명
		/// </summary>
		[Column("단체지역명")]
		public string GroupRegionName { get; set; }
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public Guid Column1 { get; set; }
	}
}