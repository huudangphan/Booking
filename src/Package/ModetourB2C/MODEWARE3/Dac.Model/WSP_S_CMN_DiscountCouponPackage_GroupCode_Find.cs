namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_할인쿠폰패키지_그룹코드_조회
/// </summary>
public class WSP_S_CMN_DiscountCouponPackage_GroupCode_Find
{
	public const string SP_NAME = "WSP_S_CMN_할인쿠폰패키지_그룹코드_조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 할인쿠폰번호
		/// </summary>
		[Description("할인쿠폰번호")]
		public string DiscountCouponNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 그룹코드
		/// </summary>
		[Column("그룹코드")]
		public string GroupCode { get; set; }
		/// <summary>
		/// 사용조건비고
		/// </summary>
		[Column("사용조건비고")]
		public string UseConditionNote { get; set; }
	}
}