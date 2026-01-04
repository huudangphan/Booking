namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_할인쿠폰_주문_저장
/// </summary>
public class WSV_T_DiscountCoupon_Order_Saving
{
	public const string SP_NAME = "WSV_T_할인쿠폰_주문_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 발행구분
		/// </summary>
		[Description("발행구분")]
		public string PublishClassification { get; set; }
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
		/// 쿠폰일련번호
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 1000)]
		[Description("쿠폰일련번호")]
		public string CouponSerialNumber { get; set; }
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

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 결제수단
		/// </summary>
		[Column("결제수단")]
		public string PaymentMethod { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 체크쿠폰번호
		/// </summary>
		[Column("체크쿠폰번호")]
		public string CheckCouponNumber { get; set; }
		/// <summary>
		/// 할인적용금액
		/// </summary>
		[Column("할인적용금액")]
		public int DiscountApplyAmount { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 사용
		/// </summary>
		[Column("사용")]
		public string Use { get; set; }
		/// <summary>
		/// 쿠폰기사용여부
		/// </summary>
		[Column("쿠폰기사용여부")]
		public string CouponForArticleOrNot { get; set; }
	}
}