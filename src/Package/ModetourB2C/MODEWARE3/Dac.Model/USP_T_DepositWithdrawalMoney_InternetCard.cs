namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_입출금_인터넷카드
/// </summary>
public class USP_T_DepositWithdrawalMoney_InternetCard
{
	public const string SP_NAME = "USP_T_입출금_인터넷카드";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 승인아이디
		/// </summary>
		[Description("승인아이디")]
		public string ApprovalID { get; set; }
		/// <summary>
		/// 카드종류
		/// </summary>
		[Description("카드종류")]
		public string CardType { get; set; }
		/// <summary>
		/// 수납번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("수납번호")]
		public int ReceiptNumber { get; set; }
		/// <summary>
		/// 주문수납내역번호
		/// </summary>
		[Description("주문수납내역번호")]
		public int OrderReceiptHistoryNumber { get; set; }
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
		/// 금액
		/// </summary>
		[Description("금액")]
		public long Amount { get; set; }
		/// <summary>
		/// 성명
		/// </summary>
		[Description("성명")]
		public string Name { get; set; }
		/// <summary>
		/// 카드번호
		/// </summary>
		[Description("카드번호")]
		public string CardNumber { get; set; }
		/// <summary>
		/// 승인번호
		/// </summary>
		[Description("승인번호")]
		public string ApprovalNumber { get; set; }
		/// <summary>
		/// 결제경로
		/// </summary>
		[Description("결제경로")]
		public string PaymentRoute { get; set; }
		/// <summary>
		/// 할부
		/// </summary>
		[Description("할부")]
		public int Installment { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Description("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 수납비고
		/// </summary>
		[Description("수납비고")]
		public string ReceiptNote { get; set; }
		/// <summary>
		/// 승인날짜
		/// </summary>
		[Description("승인날짜")]
		public DateTime ApprovalDate { get; set; }
		/// <summary>
		/// USERIP
		/// </summary>
		[Description("USERIP")]
		public string USERIP { get; set; }
		/// <summary>
		/// USERNO
		/// </summary>
		[Description("USERNO")]
		public int USERNO { get; set; }
		/// <summary>
		/// APPNAME
		/// </summary>
		[Description("APPNAME")]
		public string APPNAME { get; set; }
		/// <summary>
		/// 수기등록여부
		/// </summary>
		[Description("수기등록여부")]
		public string HandwrittingRegisterOrNot { get; set; }
		/// <summary>
		/// 부분취소가능여부
		/// </summary>
		[Description("부분취소가능여부")]
		public string DivisionCancelPossibleOrNot { get; set; }
		/// <summary>
		/// 부분취소
		/// </summary>
		[Description("부분취소")]
		public string DivisionCancel { get; set; }
		/// <summary>
		/// 부분취소요청횟수
		/// </summary>
		[Description("부분취소요청횟수")]
		public int DivisionCancelRequestTimes { get; set; }
		/// <summary>
		/// 원거래수납번호
		/// </summary>
		[Description("원거래수납번호")]
		public int OriginalTransactionReceiptNumber { get; set; }
		/// <summary>
		/// 삼자카드일련번호
		/// </summary>
		[Description("삼자카드일련번호")]
		public int ThirdPartyCardSerialNumber { get; set; }
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
		/// <summary>
		/// 주문아이템번호
		/// </summary>
		[Description("주문아이템번호")]
		public int OrderItemNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// HIS일련번호
		/// </summary>
		[Description("HIS일련번호")]
		public int HIS_SerialNumber { get; set; }
		/// <summary>
		/// 작업구분
		/// </summary>
		[Description("작업구분")]
		public string WorkingClassification { get; set; }
		/// <summary>
		/// 작업경로
		/// </summary>
		[Description("작업경로")]
		public string WorkingRoute { get; set; }
		/// <summary>
		/// 작업경로세부
		/// </summary>
		[Description("작업경로세부")]
		public string WorkingRouteDetail { get; set; }
	}

}