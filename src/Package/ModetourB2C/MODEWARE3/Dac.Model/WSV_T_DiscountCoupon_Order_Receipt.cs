namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_할인쿠폰_주문_수납
/// </summary>
public class WSV_T_DiscountCoupon_Order_Receipt
{
	public const string SP_NAME = "WSV_T_할인쿠폰_주문_수납";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Description("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// 수정경로
		/// </summary>
		[Description("수정경로")]
		public string EditionRoute { get; set; }
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