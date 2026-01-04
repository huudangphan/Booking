namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_수납상세내역
/// </summary>
public class WSP_S_CMN_ReceiptDetailHistory
{
	public const string SP_NAME = "WSP_S_CMN_수납상세내역";

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
		/// 수납번호
		/// </summary>
		[Column("수납번호")]
		public int ReceiptNumber { get; set; }
		/// <summary>
		/// 결재
		/// </summary>
		[Column("결재")]
		public string Approval { get; set; }
		/// <summary>
		/// 카드사
		/// </summary>
		[Column("카드사")]
		public string CardCompany { get; set; }
		/// <summary>
		/// 수납액
		/// </summary>
		[Column("수납액")]
		public long ReceiptAmount { get; set; }
		/// <summary>
		/// 거래번호
		/// </summary>
		[Column("거래번호")]
		public string TransactionNumber { get; set; }
		/// <summary>
		/// 공급가액
		/// </summary>
		[Column("공급가액")]
		public long SupplyValue { get; set; }
		/// <summary>
		/// 현금영수증발행
		/// </summary>
		[Column("현금영수증발행")]
		public string CashReceiptPublish { get; set; }
		/// <summary>
		/// POS통장수납번호
		/// </summary>
		[Column("POS통장수납번호")]
		public int POS_BankbookReceiptNumber { get; set; }
		/// <summary>
		/// POS연결번호
		/// </summary>
		[Column("POS연결번호")]
		public int POS_ConnectionNumber { get; set; }
		/// <summary>
		/// 분개번호
		/// </summary>
		[Column("분개번호")]
		public int DivertedNumber { get; set; }
		/// <summary>
		/// 웹노출수납유형
		/// </summary>
		[Column("웹노출수납유형")]
		public string WebDisplayReceiptType { get; set; }
		/// <summary>
		/// 수납유형한글
		/// </summary>
		[Column("수납유형한글")]
		public string ReceiptTypeKorean { get; set; }
		/// <summary>
		/// 수납유형코드
		/// </summary>
		[Column("수납유형코드")]
		public string ReceiptTypeCode { get; set; }
		/// <summary>
		/// 승인날짜
		/// </summary>
		[Column("승인날짜")]
		public DateTime ApprovalDate { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 회원번호
		/// </summary>
		[Column("회원번호")]
		public string MemberNumber { get; set; }
		/// <summary>
		/// 회원명
		/// </summary>
		[Column("회원명")]
		public string MemberName { get; set; }
		/// <summary>
		/// 카드홀더
		/// </summary>
		[Column("카드홀더")]
		public string CardHolder { get; set; }
	}
}