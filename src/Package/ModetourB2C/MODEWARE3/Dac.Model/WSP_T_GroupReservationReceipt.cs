namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_단체예약수납
/// </summary>
public class WSP_T_GroupReservationReceipt
{
	public const string SP_NAME = "WSP_T_단체예약수납";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문수납번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("주문수납번호")]
		public int OrderReceiptNumber { get; set; }
		/// <summary>
		/// 수납번호
		/// </summary>
		[Description("수납번호")]
		public int ReceiptNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 분개번호
		/// </summary>
		[Description("분개번호")]
		public int DivertedNumber { get; set; }
		/// <summary>
		/// 입출구분코드
		/// </summary>
		[Description("입출구분코드")]
		public string InOutClassificationCode { get; set; }
		/// <summary>
		/// 수납유형코드
		/// </summary>
		[Description("수납유형코드")]
		public string ReceiptTypeCode { get; set; }
		/// <summary>
		/// VAT여부
		/// </summary>
		[Description("VAT여부")]
		public string VAT_OrNot { get; set; }
		/// <summary>
		/// 수납액
		/// </summary>
		[Description("수납액")]
		public int ReceiptAmount { get; set; }
		/// <summary>
		/// 분할금액
		/// </summary>
		[Description("분할금액")]
		public int InstallmentAmount { get; set; }
		/// <summary>
		/// 잔액
		/// </summary>
		[Description("잔액")]
		public int Balance { get; set; }
		/// <summary>
		/// 세액
		/// </summary>
		[Description("세액")]
		public int TaxAmount { get; set; }
		/// <summary>
		/// 공급가액
		/// </summary>
		[Description("공급가액")]
		public int SupplyValue { get; set; }
		/// <summary>
		/// 권
		/// </summary>
		[Description("권")]
		public int Kwon { get; set; }
		/// <summary>
		/// 호
		/// </summary>
		[Description("호")]
		public int Ho { get; set; }
		/// <summary>
		/// 수납일
		/// </summary>
		[Description("수납일")]
		public DateTime ReceiptDate { get; set; }
		/// <summary>
		/// 수납비고
		/// </summary>
		[Description("수납비고")]
		public string ReceiptNote { get; set; }
		/// <summary>
		/// 수납계좌번호
		/// </summary>
		[Description("수납계좌번호")]
		public int ReceiptAccountNumber { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 결재
		/// </summary>
		[Description("결재")]
		public string Approval { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Description("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 취소일
		/// </summary>
		[Description("취소일")]
		public DateTime CancelDate { get; set; }
		/// <summary>
		/// 취소자
		/// </summary>
		[Description("취소자")]
		public int CancelPerson { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Description("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Description("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// 수정일
		/// </summary>
		[Description("수정일")]
		public DateTime EditionDate { get; set; }
		/// <summary>
		/// 수정자
		/// </summary>
		[Description("수정자")]
		public int Editor { get; set; }
		/// <summary>
		/// 거래번호
		/// </summary>
		[Description("거래번호")]
		public string TransactionNumber { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Description("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 성명
		/// </summary>
		[Description("성명")]
		public string Name { get; set; }
		/// <summary>
		/// 카드사번호
		/// </summary>
		[Description("카드사번호")]
		public string CardCompanyNumber { get; set; }
		/// <summary>
		/// 승인번호
		/// </summary>
		[Description("승인번호")]
		public string ApprovalNumber { get; set; }
		/// <summary>
		/// 카드사
		/// </summary>
		[Description("카드사")]
		public string CardCompany { get; set; }
		/// <summary>
		/// 가맹점코드
		/// </summary>
		[Description("가맹점코드")]
		public string AffiliateCode { get; set; }
		/// <summary>
		/// 결제경로
		/// </summary>
		[Description("결제경로")]
		public string PaymentRoute { get; set; }
		/// <summary>
		/// USERIP
		/// </summary>
		[Description("USERIP")]
		public string USERIP { get; set; }
		/// <summary>
		/// APPNAME
		/// </summary>
		[Description("APPNAME")]
		public string APPNAME { get; set; }
		/// <summary>
		/// 할부
		/// </summary>
		[Description("할부")]
		public int Installment { get; set; }
		/// <summary>
		/// 신청금입금여부
		/// </summary>
		[Description("신청금입금여부")]
		public string RequestMoneyDepositOrNot { get; set; }
		/// <summary>
		/// 할인쿠폰타입
		/// </summary>
		[Description("할인쿠폰타입")]
		public string DiscountCouponType { get; set; }
		/// <summary>
		/// 제휴할인쿠폰사용여부
		/// </summary>
		[Description("제휴할인쿠폰사용여부")]
		public string AffiliateDiscountCouponUseOrNot { get; set; }
		/// <summary>
		/// TBL제휴할인쿠폰
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("TBL제휴할인쿠폰")]
		public List<TYPE_AffiliateDiscountCoupon> TBL_AffiliateDiscountCoupon { get; set; }
		/// <summary>
		/// 할인쿠폰사용여부
		/// </summary>
		[Description("할인쿠폰사용여부")]
		public string DiscountCouponUseOrNot { get; set; }
		/// <summary>
		/// TBL할인쿠폰
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("TBL할인쿠폰")]
		public List<TYPE_DiscountCoupon> TBL_DiscountCoupon { get; set; }
	}

}