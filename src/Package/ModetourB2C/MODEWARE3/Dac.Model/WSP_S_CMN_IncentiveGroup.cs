namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_인센티브단체
/// </summary>
public class WSP_S_CMN_IncentiveGroup
{
	public const string SP_NAME = "WSP_S_CMN_인센티브단체";

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
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 대표이미지명
		/// </summary>
		[Column("대표이미지명")]
		public string RepresentativeImageName { get; set; }
		/// <summary>
		/// 판매가_어른
		/// </summary>
		[Column("판매가_어른")]
		public long SellingPrice_Adult { get; set; }
		/// <summary>
		/// 최소출발인원
		/// </summary>
		[Column("최소출발인원")]
		public int MinimumDepartureNumberOfPeople { get; set; }
		/// <summary>
		/// 호텔등급
		/// </summary>
		[Column("호텔등급")]
		public string HotelClass { get; set; }
		/// <summary>
		/// 쇼핑횟수
		/// </summary>
		[Column("쇼핑횟수")]
		public int ShoppingTimes { get; set; }
		/// <summary>
		/// 현지필수경비_통화
		/// </summary>
		[Column("현지필수경비_통화")]
		public string LocalRequiredExpense_Call { get; set; }
		/// <summary>
		/// 현지필수경비
		/// </summary>
		[Column("현지필수경비")]
		public long LocalRequiredExpense { get; set; }
		/// <summary>
		/// 여행추천비고
		/// </summary>
		[Column("여행추천비고")]
		public string TravelRecommendNote { get; set; }
		/// <summary>
		/// 특전비고
		/// </summary>
		[Column("특전비고")]
		public string SpecialEventNote { get; set; }
	}
}