namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_단체검색_프로모션_지역
/// </summary>
public class WSP_S_CMN_GroupSearch_Promotion_Region
{
	public const string SP_NAME = "WSP_S_CMN_단체검색_프로모션_지역";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 마스터번호
		/// </summary>
		[Description("마스터번호")]
		public int MasterNumber { get; set; }
		/// <summary>
		/// 지역코드
		/// </summary>
		[Description("지역코드")]
		public string RegionCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
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
		/// 단체이미지
		/// </summary>
		[Column("단체이미지")]
		public string GroupImage { get; set; }
		/// <summary>
		/// 가격
		/// </summary>
		[Column("가격")]
		public long Price { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 단체지역명
		/// </summary>
		[Column("단체지역명")]
		public string GroupRegionName { get; set; }
	}
}