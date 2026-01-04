namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_할인쿠폰_주문
/// </summary>
public class WSV_T_DiscountCoupon_Order
{
	public const string SP_NAME = "WSV_T_할인쿠폰_주문";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 발행구분
		/// </summary>
		[Description("발행구분")]
		public string PublishClassification { get; set; }
		/// <summary>
		/// 결제수단
		/// </summary>
		[Description("결제수단")]
		public string PaymentMethod { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 주문아이템번호
		/// </summary>
		[Description("주문아이템번호")]
		public int OrderItemNumber { get; set; }
		/// <summary>
		/// 쿠폰종류
		/// </summary>
		[Description("쿠폰종류")]
		public string CouponType { get; set; }
		/// <summary>
		/// 쿠폰발행번호
		/// </summary>
		[Description("쿠폰발행번호")]
		public string CouponPublishNumber { get; set; }
		/// <summary>
		/// 쿠폰발행사
		/// </summary>
		[Description("쿠폰발행사")]
		public string CouponPublisher { get; set; }
		/// <summary>
		/// 쿠폰번호
		/// </summary>
		[Description("쿠폰번호")]
		public string CouponNumber { get; set; }
		/// <summary>
		/// 쿠폰이름
		/// </summary>
		[Description("쿠폰이름")]
		public string CouponName { get; set; }
		/// <summary>
		/// 쿠폰할인구분
		/// </summary>
		[Description("쿠폰할인구분")]
		public string CouponDiscountClassification { get; set; }
		/// <summary>
		/// 할인금액
		/// </summary>
		[Description("할인금액")]
		public int DiscountAmount { get; set; }
		/// <summary>
		/// 할인율
		/// </summary>
		[Description("할인율")]
		public decimal DiscountRate { get; set; }
		/// <summary>
		/// 최대할인금액
		/// </summary>
		[Description("최대할인금액")]
		public int MaximumDiscountAmount { get; set; }
		/// <summary>
		/// 최소주문적용금액
		/// </summary>
		[Description("최소주문적용금액")]
		public int MinimumOrderApplyAmount { get; set; }
		/// <summary>
		/// 적용단말기
		/// </summary>
		[Description("적용단말기")]
		public string ApplyTerminal { get; set; }
		/// <summary>
		/// 중복할인가능여부
		/// </summary>
		[Description("중복할인가능여부")]
		public string DuplicatedDiscountPossibleOrNot { get; set; }
		/// <summary>
		/// 할인주체
		/// </summary>
		[Description("할인주체")]
		public string DiscountSubject { get; set; }
		/// <summary>
		/// 할인적용시작일
		/// </summary>
		[Description("할인적용시작일")]
		public DateTime DiscountApplyStartDate { get; set; }
		/// <summary>
		/// 할인적용마침일
		/// </summary>
		[Description("할인적용마침일")]
		public DateTime DiscountApplyFinishDate { get; set; }
		/// <summary>
		/// 여행사부담구분
		/// </summary>
		[Description("여행사부담구분")]
		public string TravelCompanyDebitClassification { get; set; }
		/// <summary>
		/// 여행사부담금액
		/// </summary>
		[Description("여행사부담금액")]
		public decimal TravelCompanyDebitAmount { get; set; }
		/// <summary>
		/// 카드종류
		/// </summary>
		[Description("카드종류")]
		public string CardType { get; set; }
		/// <summary>
		/// 쿠폰정보
		/// </summary>
		[Description("쿠폰정보")]
		public string CouponInfo { get; set; }
		/// <summary>
		/// 요청단말기
		/// </summary>
		[Description("요청단말기")]
		public string RequestTerminal { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Description("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// TEST여부
		/// </summary>
		[Description("TEST여부")]
		public string TEST_OrNot { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

}