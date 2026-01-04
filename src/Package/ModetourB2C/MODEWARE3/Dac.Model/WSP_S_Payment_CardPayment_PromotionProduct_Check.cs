namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_결제_카드결제_프로모션상품_체크
/// </summary>
public class WSP_S_Payment_CardPayment_PromotionProduct_Check
{
	public const string SP_NAME = "WSP_S_결제_카드결제_프로모션상품_체크";

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
		/// 대상유무
		/// </summary>
		[Column("대상유무")]
		public string CandidateOrNot { get; set; }
	}
}