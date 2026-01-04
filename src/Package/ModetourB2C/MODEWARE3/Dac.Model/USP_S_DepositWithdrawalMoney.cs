namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_입출금
/// </summary>
public class USP_S_DepositWithdrawalMoney
{
	public const string SP_NAME = "USP_S_입출금";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// WORKINGTAG
		/// </summary>
		[Description("WORKINGTAG")]
		public string WORKINGTAG { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 주문수납내역번호
		/// </summary>
		[Column("주문수납내역번호")]
		public int OrderReceiptHistoryNumber { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 결재
		/// </summary>
		[Column("결재")]
		public string Approval { get; set; }
		/// <summary>
		/// 카드사은행
		/// </summary>
		[Column("카드사은행")]
		public string CardCompanyBank { get; set; }
		/// <summary>
		/// 입출금액
		/// </summary>
		[Column("입출금액")]
		public long InOutAmount { get; set; }
		/// <summary>
		/// 공급가액
		/// </summary>
		[Column("공급가액")]
		public long SupplyValue { get; set; }
		/// <summary>
		/// 수납비고
		/// </summary>
		[Column("수납비고")]
		public string ReceiptNote { get; set; }
		/// <summary>
		/// 현금영수증발행
		/// </summary>
		[Column("현금영수증발행")]
		public string CashReceiptPublish { get; set; }
		/// <summary>
		/// 통장번호
		/// </summary>
		[Column("통장번호")]
		public string BankbookNumber { get; set; }
		/// <summary>
		/// 분개번호
		/// </summary>
		[Column("분개번호")]
		public int DivertedNumber { get; set; }
		/// <summary>
		/// 거래번호
		/// </summary>
		[Column("거래번호")]
		public string TransactionNumber { get; set; }
		/// <summary>
		/// 승인아이디
		/// </summary>
		[Column("승인아이디")]
		public string ApprovalID { get; set; }
		/// <summary>
		/// 수납번호
		/// </summary>
		[Column("수납번호")]
		public int ReceiptNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public string RegisterDate { get; set; }
		/// <summary>
		/// 등록자번호
		/// </summary>
		[Column("등록자번호")]
		public int RegistererNumber { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public string Registerer { get; set; }
		/// <summary>
		/// VAT여부
		/// </summary>
		[Column("VAT여부")]
		public string VAT_OrNot { get; set; }
		/// <summary>
		/// 수납유형코드
		/// </summary>
		[Column("수납유형코드")]
		public string ReceiptTypeCode { get; set; }
		/// <summary>
		/// 수납입출구분코드
		/// </summary>
		[Column("수납입출구분코드")]
		public string ReceiptInOutClassificationCode { get; set; }
		/// <summary>
		/// 첨부파일명
		/// </summary>
		[Column("첨부파일명")]
		public string AttachFileName { get; set; }
		/// <summary>
		/// 첨부폴더
		/// </summary>
		[Column("첨부폴더")]
		public string AttachFolder { get; set; }
		/// <summary>
		/// 첨부활성화여부
		/// </summary>
		[Column("첨부활성화여부")]
		public string AttachActiveateOrNot { get; set; }
		/// <summary>
		/// 현금영수증대상
		/// </summary>
		[Column("현금영수증대상")]
		public string CashReceiptCandidate { get; set; }
		/// <summary>
		/// 분할
		/// </summary>
		[Column("분할")]
		public string Installment { get; set; }
		/// <summary>
		/// 현금영수증제외여부
		/// </summary>
		[Column("현금영수증제외여부")]
		public string CashReceiptExemptionOrNot { get; set; }
		/// <summary>
		/// POS결제구분
		/// </summary>
		[Column("POS결제구분")]
		public string POS_PaymentClassification { get; set; }
		/// <summary>
		/// 입금표출력가능여부
		/// </summary>
		[Column("입금표출력가능여부")]
		public string DepositTablePrintOutPossibleOrNot { get; set; }
		/// <summary>
		/// 입금표출력
		/// </summary>
		[Column("입금표출력")]
		public string DepositTablePrintOut { get; set; }
		/// <summary>
		/// POS연결번호
		/// </summary>
		[Column("POS연결번호")]
		public int POS_ConnectionNumber { get; set; }
		/// <summary>
		/// 통장해제신청여부
		/// </summary>
		[Column("통장해제신청여부")]
		public string BankbookCancelRequestOrNot { get; set; }
		/// <summary>
		/// 주문아이템번호
		/// </summary>
		[Column("주문아이템번호")]
		public int OrderItemNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 판매
		/// </summary>
		[Column("판매")]
		public long Sales { get; set; }
		/// <summary>
		/// 판매액
		/// </summary>
		[Column("판매액")]
		public long SalesAmount { get; set; }
		/// <summary>
		/// COMM
		/// </summary>
		[Column("COMM")]
		public long COMM { get; set; }
		/// <summary>
		/// 공급가액
		/// </summary>
		[Column("공급가액")]
		public long SupplyValue { get; set; }
		/// <summary>
		/// 지결서신청액
		/// </summary>
		[Column("지결서신청액")]
		public long SpendingDocumentRequestAmount { get; set; }
		/// <summary>
		/// 잔액
		/// </summary>
		[Column("잔액")]
		public long Balance { get; set; }
		/// <summary>
		/// 부가세
		/// </summary>
		[Column("부가세")]
		public long Surtax { get; set; }
		/// <summary>
		/// 세액
		/// </summary>
		[Column("세액")]
		public long TaxAmount { get; set; }
		/// <summary>
		/// 부가세미수
		/// </summary>
		[Column("부가세미수")]
		public long SurtaxUnpayed { get; set; }
		/// <summary>
		/// CHARGE
		/// </summary>
		[Column("CHARGE")]
		public long CHARGE { get; set; }
		/// <summary>
		/// 입금가
		/// </summary>
		[Column("입금가")]
		public long DepositPrice { get; set; }
		/// <summary>
		/// 수납액
		/// </summary>
		[Column("수납액")]
		public long ReceiptAmount { get; set; }
		/// <summary>
		/// 입금미수
		/// </summary>
		[Column("입금미수")]
		public long DepositUnpayed { get; set; }
		/// <summary>
		/// DISPLAY차액
		/// </summary>
		[Column("DISPLAY차액")]
		public long DISPLAY_Difference { get; set; }
		/// <summary>
		/// 손님결재예정금액
		/// </summary>
		[Column("손님결재예정금액")]
		public long GuessApprovalExpectationAmount { get; set; }
		/// <summary>
		/// 커미션선출금여부
		/// </summary>
		[Column("커미션선출금여부")]
		public string CommissionPreWithdrawalOrNot { get; set; }
		/// <summary>
		/// 티켓원천징수
		/// </summary>
		[Column("티켓원천징수")]
		public long TicketWithholdingTax { get; set; }
		/// <summary>
		/// 현금영수증발행금액
		/// </summary>
		[Column("현금영수증발행금액")]
		public long CashReceiptPublishAmount { get; set; }
		/// <summary>
		/// 출발후입금가능
		/// </summary>
		[Column("출발후입금가능")]
		public string AfterDepartureDepositPossible { get; set; }
		/// <summary>
		/// 가상계좌번호
		/// </summary>
		[Column("가상계좌번호")]
		public string VirtualAccountNumber { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 내부결제가능
		/// </summary>
		[Column("내부결제가능")]
		public string InternalPaymentPossible { get; set; }
		/// <summary>
		/// 판매부서
		/// </summary>
		[Column("판매부서")]
		public int SalesDepartment { get; set; }
		/// <summary>
		/// POS결제알림톡발송여부
		/// </summary>
		[Column("POS결제알림톡발송여부")]
		public string POS_PaymentAlarmTalkSendingOrNot { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 현금영수증발행금액
		/// </summary>
		[Column("현금영수증발행금액")]
		public long CashReceiptPublishAmount { get; set; }
		/// <summary>
		/// 현금영수증자진발급금액
		/// </summary>
		[Column("현금영수증자진발급금액")]
		public long CashReceiptVolunteerIssuanceAmount { get; set; }
		/// <summary>
		/// 현금영수증잔액
		/// </summary>
		[Column("현금영수증잔액")]
		public long CashReceiptBalance { get; set; }
		/// <summary>
		/// 현금영수증발급계획_신청금액합
		/// </summary>
		[Column("현금영수증발급계획_신청금액합")]
		public long CashReceiptIssuancePlan_RequestAmountSum { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 수납액
		/// </summary>
		[Column("수납액")]
		public long ReceiptAmount { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// 카드승인제한여부
		/// </summary>
		[Column("카드승인제한여부")]
		public string CardApprovalLimitOrNot { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public string WrittingDate { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 신청종류
		/// </summary>
		[Column("신청종류")]
		public string RequestType { get; set; }
		/// <summary>
		/// 출금종류
		/// </summary>
		[Column("출금종류")]
		public string WithdrawalType { get; set; }
		/// <summary>
		/// 금액
		/// </summary>
		[Column("금액")]
		public long Amount { get; set; }
		/// <summary>
		/// 상태
		/// </summary>
		[Column("상태")]
		public string State { get; set; }
		/// <summary>
		/// 원천징수세액
		/// </summary>
		[Column("원천징수세액")]
		public int WithholdingTaxTaxAmount { get; set; }
		/// <summary>
		/// 원천징수
		/// </summary>
		[Column("원천징수")]
		public string WithholdingTax { get; set; }
		/// <summary>
		/// 출금여부
		/// </summary>
		[Column("출금여부")]
		public string WithdrawalOrNot { get; set; }
		/// <summary>
		/// 은행
		/// </summary>
		[Column("은행")]
		public string Bank { get; set; }
		/// <summary>
		/// 계좌번호
		/// </summary>
		[Column("계좌번호")]
		public string AccountNumber { get; set; }
		/// <summary>
		/// 예금주
		/// </summary>
		[Column("예금주")]
		public string BankAccountOwner { get; set; }
		/// <summary>
		/// 지출품의서번호
		/// </summary>
		[Column("지출품의서번호")]
		public int SpendingReportNumber { get; set; }
	}

	public class Result8 : IDbResult
	{
		/// <summary>
		/// 수납번호
		/// </summary>
		[Column("수납번호")]
		public int ReceiptNumber { get; set; }
		/// <summary>
		/// 수납일
		/// </summary>
		[Column("수납일")]
		public string ReceiptDate { get; set; }
		/// <summary>
		/// 거래번호
		/// </summary>
		[Column("거래번호")]
		public string TransactionNumber { get; set; }
		/// <summary>
		/// 주민등록번호
		/// </summary>
		[Column("주민등록번호")]
		public string CitizenRegisterNumber { get; set; }
		/// <summary>
		/// 금액
		/// </summary>
		[Column("금액")]
		public long Amount { get; set; }
		/// <summary>
		/// 카드홀더
		/// </summary>
		[Column("카드홀더")]
		public string CardHolder { get; set; }
		/// <summary>
		/// 수납비고
		/// </summary>
		[Column("수납비고")]
		public string ReceiptNote { get; set; }
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
		/// 카드사
		/// </summary>
		[Column("카드사")]
		public string CardCompany { get; set; }
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
		/// 결제경로
		/// </summary>
		[Column("결제경로")]
		public string PaymentRoute { get; set; }
	}

	public class Result9 : IDbResult
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 예금주
		/// </summary>
		[Column("예금주")]
		public string BankAccountOwner { get; set; }
		/// <summary>
		/// 가상계좌번호
		/// </summary>
		[Column("가상계좌번호")]
		public string VirtualAccountNumber { get; set; }
	}

	public class Result10 : IDbResult
	{
		/// <summary>
		/// 단체결산
		/// </summary>
		[Column("단체결산")]
		public string GroupSettlement { get; set; }
	}

	public class Result11 : IDbResult
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public long OrderNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 가상계좌번호
		/// </summary>
		[Column("가상계좌번호")]
		public string VirtualAccountNumber { get; set; }
		/// <summary>
		/// 예금주
		/// </summary>
		[Column("예금주")]
		public string BankAccountOwner { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public byte Sorting { get; set; }
		/// <summary>
		/// 발급일자
		/// </summary>
		[Column("발급일자")]
		public string IssuanceDate { get; set; }
		/// <summary>
		/// 발급자
		/// </summary>
		[Column("발급자")]
		public string Issuer { get; set; }
		/// <summary>
		/// 발급경로
		/// </summary>
		[Column("발급경로")]
		public string IssuanceRoute { get; set; }
	}
}