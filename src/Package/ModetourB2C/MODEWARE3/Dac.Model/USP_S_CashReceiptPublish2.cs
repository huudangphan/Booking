namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_현금영수증발행2
/// </summary>
public class USP_S_CashReceiptPublish2
{
	public const string SP_NAME = "USP_S_현금영수증발행2";

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
		/// 발행일
		/// </summary>
		[Column("발행일")]
		public string PublishDate { get; set; }
		/// <summary>
		/// 구매자명
		/// </summary>
		[Column("구매자명")]
		public string BuyerName { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Column("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 승인번호
		/// </summary>
		[Column("승인번호")]
		public string ApprovalNumber { get; set; }
		/// <summary>
		/// 금액
		/// </summary>
		[Column("금액")]
		public long Amount { get; set; }
		/// <summary>
		/// 거래번호
		/// </summary>
		[Column("거래번호")]
		public string TransactionNumber { get; set; }
		/// <summary>
		/// 자진발급
		/// </summary>
		[Column("자진발급")]
		public string VolunteerIssuance { get; set; }
		/// <summary>
		/// 신청자
		/// </summary>
		[Column("신청자")]
		public string Requester { get; set; }
		/// <summary>
		/// 수납번호
		/// </summary>
		[Column("수납번호")]
		public int ReceiptNumber { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
	}
}