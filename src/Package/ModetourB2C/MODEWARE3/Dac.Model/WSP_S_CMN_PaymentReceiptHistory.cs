namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_결제수납이력
/// </summary>
public class WSP_S_CMN_PaymentReceiptHistory
{
	public const string SP_NAME = "WSP_S_CMN_결제수납이력";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 결제번호
		/// </summary>
		[Column("결제번호")]
		public int PaymentNumber { get; set; }
		/// <summary>
		/// 결제구분
		/// </summary>
		[Column("결제구분")]
		public string PaymentClassification { get; set; }
		/// <summary>
		/// 결제이력
		/// </summary>
		[Column("결제이력")]
		public string PaymentHistory { get; set; }
	}
}