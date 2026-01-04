namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_결제_패키지할인쿠폰예약정보_유효성확인
/// </summary>
public class WSP_S_Payment_PackageDiscountCouponReservationInfo_ValidityConfirm
{
	public const string SP_NAME = "WSP_S_결제_패키지할인쿠폰예약정보_유효성확인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Description("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 생일
		/// </summary>
		[Description("생일")]
		public string Birthday { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Description("성별")]
		public string Gender { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// RETURN_CODE
		/// </summary>
		[Column("RETURN_CODE")]
		public string RETURN_CODE { get; set; }
		/// <summary>
		/// RETURN_MSG
		/// </summary>
		[Column("RETURN_MSG")]
		public string RETURN_MSG { get; set; }
	}
}