namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_제휴할인쿠폰
/// </summary>
public class USP_T_AffiliateDiscountCoupon
{
	public const string SP_NAME = "USP_T_제휴할인쿠폰";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 수납번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("수납번호")]
		public int ReceiptNumber { get; set; }
		/// <summary>
		/// 수납일
		/// </summary>
		[Description("수납일")]
		public DateTime ReceiptDate { get; set; }
		/// <summary>
		/// 수납액
		/// </summary>
		[Description("수납액")]
		public long ReceiptAmount { get; set; }
		/// <summary>
		/// 수납유형코드
		/// </summary>
		[Description("수납유형코드")]
		public string ReceiptTypeCode { get; set; }
		/// <summary>
		/// 쿠폰번호
		/// </summary>
		[Description("쿠폰번호")]
		public string CouponNumber { get; set; }
		/// <summary>
		/// 수납비고
		/// </summary>
		[Description("수납비고")]
		public string ReceiptNote { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Description("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// 할인쿠폰_주문_일련번호
		/// </summary>
		[Description("할인쿠폰_주문_일련번호")]
		public int DiscountCoupon_Order_SerialNumber { get; set; }
		/// <summary>
		/// NO_RAISERROR
		/// </summary>
		[Description("NO_RAISERROR")]
		public string NO_RAISERROR { get; set; }
		/// <summary>
		/// 취소반영RF예약번호
		/// </summary>
		[Description("취소반영RF예약번호")]
		public int CancelReflectRFBookingNumber { get; set; }
		/// <summary>
		/// 취소사유
		/// </summary>
		[Description("취소사유")]
		public string CancelReason { get; set; }
		/// <summary>
		/// TEST여부
		/// </summary>
		[Description("TEST여부")]
		public string TEST_OrNot { get; set; }
		/// <summary>
		/// 작업경로
		/// </summary>
		[Description("작업경로")]
		public string WorkingRoute { get; set; }
		/// <summary>
		/// 작업경로세부
		/// </summary>
		[Description("작업경로세부")]
		public string WorkingRouteDetail { get; set; }
	}

}