namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_결제_패키지할인쿠폰_사용완료_리스트
/// </summary>
public class WSP_S_Payment_PackageDiscountCoupon_UseFinish_List
{
	public const string SP_NAME = "WSP_S_결제_패키지할인쿠폰_사용완료_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 예약번호
		/// </summary>
		[Description("예약번호")]
		public int BookingNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 사용가능
		/// </summary>
		[Column("사용가능")]
		public string UsePossible { get; set; }
		/// <summary>
		/// 발급번호
		/// </summary>
		[Column("발급번호")]
		public int IssuanceNumber { get; set; }
		/// <summary>
		/// 유효기간
		/// </summary>
		[Column("유효기간")]
		public string ValidPeriod { get; set; }
		/// <summary>
		/// 할인번호
		/// </summary>
		[Column("할인번호")]
		public int DiscountNumber { get; set; }
		/// <summary>
		/// 할인쿠폰번호
		/// </summary>
		[Column("할인쿠폰번호")]
		public string DiscountCouponNumber { get; set; }
		/// <summary>
		/// 할인쿠폰명
		/// </summary>
		[Column("할인쿠폰명")]
		public string DiscountCouponName { get; set; }
		/// <summary>
		/// 최소적용금액
		/// </summary>
		[Column("최소적용금액")]
		public int MinimumApplyingAmount { get; set; }
		/// <summary>
		/// 최대할인금액
		/// </summary>
		[Column("최대할인금액")]
		public int MaximumDiscountAmount { get; set; }
		/// <summary>
		/// 사용가능일S
		/// </summary>
		[Column("사용가능일S")]
		public DateTime UsableDate_S { get; set; }
		/// <summary>
		/// 사용가능일E
		/// </summary>
		[Column("사용가능일E")]
		public DateTime UsableDate_E { get; set; }
		/// <summary>
		/// 시작일S
		/// </summary>
		[Column("시작일S")]
		public DateTime StartDateS { get; set; }
		/// <summary>
		/// 시작일E
		/// </summary>
		[Column("시작일E")]
		public DateTime StartDateE { get; set; }
		/// <summary>
		/// 소유자
		/// </summary>
		[Column("소유자")]
		public int Owner { get; set; }
		/// <summary>
		/// 할인구분
		/// </summary>
		[Column("할인구분")]
		public string DiscountClassification { get; set; }
		/// <summary>
		/// 할인율
		/// </summary>
		[Column("할인율")]
		public decimal DiscountRate { get; set; }
		/// <summary>
		/// 마감수
		/// </summary>
		[Column("마감수")]
		public int NumberOfEnd { get; set; }
		/// <summary>
		/// 소유자명
		/// </summary>
		[Column("소유자명")]
		public string OwnerName { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
	}
}