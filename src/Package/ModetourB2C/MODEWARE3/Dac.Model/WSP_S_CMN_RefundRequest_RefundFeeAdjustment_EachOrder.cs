namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_환불요청_환불수수료조정_주문별
/// </summary>
public class WSP_S_CMN_RefundRequest_RefundFeeAdjustment_EachOrder
{
	public const string SP_NAME = "WSP_S_CMN_환불요청_환불수수료조정_주문별";

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
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 수수료금액
		/// </summary>
		[Column("수수료금액")]
		public int FeeAmount { get; set; }
	}
}