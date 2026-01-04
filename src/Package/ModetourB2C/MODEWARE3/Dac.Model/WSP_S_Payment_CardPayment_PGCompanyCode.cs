namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_결제_카드결제_PG업체코드
/// </summary>
public class WSP_S_Payment_CardPayment_PGCompanyCode
{
	public const string SP_NAME = "WSP_S_결제_카드결제_PG업체코드";

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
		/// PG업체코드
		/// </summary>
		[Column("PG업체코드")]
		public string PG_CompanyCode { get; set; }
	}
}