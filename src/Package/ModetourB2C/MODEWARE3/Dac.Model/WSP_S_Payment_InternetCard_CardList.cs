namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_결제_인터넷카드_카드리스트
/// </summary>
public class WSP_S_Payment_InternetCard_CardList
{
	public const string SP_NAME = "WSP_S_결제_인터넷카드_카드리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PG업체코드
		/// </summary>
		[Description("PG업체코드")]
		public string PG_CompanyCode { get; set; }
		/// <summary>
		/// MID
		/// </summary>
		[Description("MID")]
		public string MID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 결제요청카드코드
		/// </summary>
		[Column("결제요청카드코드")]
		public string PaymentRequestCardCode { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
	}
}