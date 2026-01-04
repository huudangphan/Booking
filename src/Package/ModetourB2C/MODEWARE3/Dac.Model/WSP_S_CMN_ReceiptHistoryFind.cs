namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_수납내역조회
/// </summary>
public class WSP_S_CMN_ReceiptHistoryFind
{
	public const string SP_NAME = "WSP_S_CMN_수납내역조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 매체별수납액
		/// </summary>
		[Column("매체별수납액")]
		public long EachMediaReceiptAmount { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// 수납일
		/// </summary>
		[Column("수납일")]
		public DateTime ReceiptDate { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 주문수납내역번호
		/// </summary>
		[Column("주문수납내역번호")]
		public int OrderReceiptHistoryNumber { get; set; }
		/// <summary>
		/// 분개번호
		/// </summary>
		[Column("분개번호")]
		public int DivertedNumber { get; set; }
		/// <summary>
		/// 입출구분코드
		/// </summary>
		[Column("입출구분코드")]
		public string InOutClassificationCode { get; set; }
		/// <summary>
		/// 수납유형코드
		/// </summary>
		[Column("수납유형코드")]
		public string ReceiptTypeCode { get; set; }
		/// <summary>
		/// VAT여부
		/// </summary>
		[Column("VAT여부")]
		public string VAT_OrNot { get; set; }
		/// <summary>
		/// 수납액
		/// </summary>
		[Column("수납액")]
		public long ReceiptAmount { get; set; }
		/// <summary>
		/// 결재
		/// </summary>
		[Column("결재")]
		public string Approval { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 입출금세액
		/// </summary>
		[Column("입출금세액")]
		public long InOutMoneyTaxAmount { get; set; }
		/// <summary>
		/// 공급가액
		/// </summary>
		[Column("공급가액")]
		public long SupplyValue { get; set; }
		/// <summary>
		/// 수납번호
		/// </summary>
		[Column("수납번호")]
		public int ReceiptNumber { get; set; }
		/// <summary>
		/// 승인번호
		/// </summary>
		[Column("승인번호")]
		public string ApprovalNumber { get; set; }
		/// <summary>
		/// 카드사
		/// </summary>
		[Column("카드사")]
		public string CardCompany { get; set; }
		/// <summary>
		/// 금액
		/// </summary>
		[Column("금액")]
		public long Amount { get; set; }
		/// <summary>
		/// 성명
		/// </summary>
		[Column("성명")]
		public string Name { get; set; }
		/// <summary>
		/// 가맹점코드
		/// </summary>
		[Column("가맹점코드")]
		public string AffiliateCode { get; set; }
		/// <summary>
		/// 할부
		/// </summary>
		[Column("할부")]
		public byte Installment { get; set; }
		/// <summary>
		/// 승인날짜
		/// </summary>
		[Column("승인날짜")]
		public DateTime ApprovalDate { get; set; }
		/// <summary>
		/// 거래번호
		/// </summary>
		[Column("거래번호")]
		public string TransactionNumber { get; set; }
		/// <summary>
		/// 수납일
		/// </summary>
		[Column("수납일")]
		public DateTime ReceiptDate { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 가상계좌번호
		/// </summary>
		[Column("가상계좌번호")]
		public string VirtualAccountNumber { get; set; }
		/// <summary>
		/// 가상계좌구분
		/// </summary>
		[Column("가상계좌구분")]
		public string VirtualAccountClassification { get; set; }
		/// <summary>
		/// 가상계좌구분한글명
		/// </summary>
		[Column("가상계좌구분한글명")]
		public string VirtualAccountClassificationKoreanName { get; set; }
	}
}