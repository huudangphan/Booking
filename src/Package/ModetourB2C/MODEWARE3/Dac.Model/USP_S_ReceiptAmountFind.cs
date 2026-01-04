namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_수납액조회
/// </summary>
public class USP_S_ReceiptAmountFind
{
	public const string SP_NAME = "USP_S_수납액조회";

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
		/// 취소일
		/// </summary>
		[Column("취소일")]
		public DateTime CancelDate { get; set; }
		/// <summary>
		/// 취소자
		/// </summary>
		[Column("취소자")]
		public int CancelPerson { get; set; }
		/// <summary>
		/// 취소자이름
		/// </summary>
		[Column("취소자이름")]
		public string CancelPersonName { get; set; }
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
		/// <summary>
		/// 등록자이름
		/// </summary>
		[Column("등록자이름")]
		public string RegistererName { get; set; }
		/// <summary>
		/// 수정일
		/// </summary>
		[Column("수정일")]
		public DateTime EditionDate { get; set; }
		/// <summary>
		/// 수정자
		/// </summary>
		[Column("수정자")]
		public int Editor { get; set; }
		/// <summary>
		/// 수정자이름
		/// </summary>
		[Column("수정자이름")]
		public string EditorName { get; set; }
	}
}