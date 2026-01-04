namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_관광쿠폰상세
/// </summary>
public class WSP_S_CMN_SightseeingCouponDetail
{
	public const string SP_NAME = "WSP_S_CMN_관광쿠폰상세";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 날짜
		/// </summary>
		[Description("날짜")]
		public DateTime Date { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 테마코드
		/// </summary>
		[Column("테마코드")]
		public string ThemeCode { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 위치
		/// </summary>
		[Column("위치")]
		public string Position { get; set; }
		/// <summary>
		/// 전화번호
		/// </summary>
		[Column("전화번호")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 운영시간
		/// </summary>
		[Column("운영시간")]
		public string OperationTime { get; set; }
		/// <summary>
		/// 특이사항
		/// </summary>
		[Column("특이사항")]
		public string Specific { get; set; }
		/// <summary>
		/// 성인요금
		/// </summary>
		[Column("성인요금")]
		public int AdultFare { get; set; }
		/// <summary>
		/// 성인판매가
		/// </summary>
		[Column("성인판매가")]
		public int AdultSellingPrice { get; set; }
		/// <summary>
		/// 청소년요금
		/// </summary>
		[Column("청소년요금")]
		public int AdolescentFare { get; set; }
		/// <summary>
		/// 청소년판매가
		/// </summary>
		[Column("청소년판매가")]
		public int AdolescentSellingPrice { get; set; }
		/// <summary>
		/// 소인요금
		/// </summary>
		[Column("소인요금")]
		public int ChildrenFare { get; set; }
		/// <summary>
		/// 소인판매가
		/// </summary>
		[Column("소인판매가")]
		public int ChildrenSellingPrice { get; set; }
		/// <summary>
		/// 성인할인률
		/// </summary>
		[Column("성인할인률")]
		public double AdultDiscountPercent { get; set; }
		/// <summary>
		/// 청소년할인률
		/// </summary>
		[Column("청소년할인률")]
		public double AdolescentDiscountPercent { get; set; }
		/// <summary>
		/// 소인할인률
		/// </summary>
		[Column("소인할인률")]
		public double ChildrenDiscountPercent { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 요금비고
		/// </summary>
		[Column("요금비고")]
		public string FareNote { get; set; }
		/// <summary>
		/// 상품특징
		/// </summary>
		[Column("상품특징")]
		public string ProductFeature { get; set; }
		/// <summary>
		/// 상품설명
		/// </summary>
		[Column("상품설명")]
		public string ProductExplaination { get; set; }
		/// <summary>
		/// LATITUDE
		/// </summary>
		[Column("LATITUDE")]
		public decimal LATITUDE { get; set; }
		/// <summary>
		/// LONGITUDE
		/// </summary>
		[Column("LONGITUDE")]
		public decimal LONGITUDE { get; set; }
		/// <summary>
		/// 담당자
		/// </summary>
		[Column("담당자")]
		public int Manager { get; set; }
		/// <summary>
		/// 기간별요금사용여부
		/// </summary>
		[Column("기간별요금사용여부")]
		public string EachPeriodFareUseOrNot { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 날짜FROM
		/// </summary>
		[Column("날짜FROM")]
		public DateTime Date_FROM { get; set; }
		/// <summary>
		/// 날짜TO
		/// </summary>
		[Column("날짜TO")]
		public DateTime Date_TO { get; set; }
		/// <summary>
		/// 성인요금
		/// </summary>
		[Column("성인요금")]
		public int AdultFare { get; set; }
		/// <summary>
		/// 청소년요금
		/// </summary>
		[Column("청소년요금")]
		public int AdolescentFare { get; set; }
		/// <summary>
		/// 소인요금
		/// </summary>
		[Column("소인요금")]
		public int ChildrenFare { get; set; }
		/// <summary>
		/// 성인판매가
		/// </summary>
		[Column("성인판매가")]
		public int AdultSellingPrice { get; set; }
		/// <summary>
		/// 청소년판매가
		/// </summary>
		[Column("청소년판매가")]
		public int AdolescentSellingPrice { get; set; }
		/// <summary>
		/// 소인판매가
		/// </summary>
		[Column("소인판매가")]
		public int ChildrenSellingPrice { get; set; }
		/// <summary>
		/// 성인할인률
		/// </summary>
		[Column("성인할인률")]
		public double AdultDiscountPercent { get; set; }
		/// <summary>
		/// 청소년할인률
		/// </summary>
		[Column("청소년할인률")]
		public double AdolescentDiscountPercent { get; set; }
		/// <summary>
		/// 소인할인률
		/// </summary>
		[Column("소인할인률")]
		public double ChildrenDiscountPercent { get; set; }
		/// <summary>
		/// 성인원가
		/// </summary>
		[Column("성인원가")]
		public int AdultOriginalPrice { get; set; }
		/// <summary>
		/// 청소년원가
		/// </summary>
		[Column("청소년원가")]
		public int AdolescentOriginalPrice { get; set; }
		/// <summary>
		/// 소인원가
		/// </summary>
		[Column("소인원가")]
		public int ChildrenOriginalPrice { get; set; }
		/// <summary>
		/// 전시여부
		/// </summary>
		[Column("전시여부")]
		public string ShowingOrNot { get; set; }
	}
}