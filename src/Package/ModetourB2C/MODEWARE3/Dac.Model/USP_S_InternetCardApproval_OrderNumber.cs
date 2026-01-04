namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_인터넷카드승인_주문번호
/// </summary>
public class USP_S_InternetCardApproval_OrderNumber
{
	public const string SP_NAME = "USP_S_인터넷카드승인_주문번호";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public long OrderNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 수납일
		/// </summary>
		[Column("수납일")]
		public DateTime ReceiptDate { get; set; }
		/// <summary>
		/// 예약번호
		/// </summary>
		[Column("예약번호")]
		public int BookingNumber { get; set; }
		/// <summary>
		/// 수납번호
		/// </summary>
		[Column("수납번호")]
		public int ReceiptNumber { get; set; }
		/// <summary>
		/// 분개번호
		/// </summary>
		[Column("분개번호")]
		public int DivertedNumber { get; set; }
		/// <summary>
		/// 수납액
		/// </summary>
		[Column("수납액")]
		public long ReceiptAmount { get; set; }
		/// <summary>
		/// 카드사
		/// </summary>
		[Column("카드사")]
		public string CardCompany { get; set; }
		/// <summary>
		/// 수납비고
		/// </summary>
		[Column("수납비고")]
		public string ReceiptNote { get; set; }
		/// <summary>
		/// 결제경로
		/// </summary>
		[Column("결제경로")]
		public string PaymentRoute { get; set; }
		/// <summary>
		/// TID
		/// </summary>
		[Column("TID")]
		public string TID { get; set; }
		/// <summary>
		/// 카드홀더
		/// </summary>
		[Column("카드홀더")]
		public string CardHolder { get; set; }
		/// <summary>
		/// 카드번호
		/// </summary>
		[Column("카드번호")]
		public string CardNumber { get; set; }
		/// <summary>
		/// 승인번호
		/// </summary>
		[Column("승인번호")]
		public string ApprovalNumber { get; set; }
		/// <summary>
		/// 할부
		/// </summary>
		[Column("할부")]
		public byte Installment { get; set; }
		/// <summary>
		/// 3자카드여부
		/// </summary>
		[Column("3자카드여부")]
		public string ThirdCardOrNot { get; set; }
		/// <summary>
		/// 상점아이디
		/// </summary>
		[Column("상점아이디")]
		public string Shop_ID { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public int Registerer { get; set; }
	}
}