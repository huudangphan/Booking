namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_철도패스환불현황_주문번호
/// </summary>
public class USP_S_RailwayPASSRefundCurrentState_OrderNumber
{
	public const string SP_NAME = "USP_S_철도패스환불현황_주문번호";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// USERIP
		/// </summary>
		[Description("USERIP")]
		public string USERIP { get; set; }
		/// <summary>
		/// USEID
		/// </summary>
		[Description("USEID")]
		public int USEID { get; set; }
		/// <summary>
		/// APPNAME
		/// </summary>
		[Description("APPNAME")]
		public string APPNAME { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 환불신청일
		/// </summary>
		[Column("환불신청일")]
		public DateTime RefundRequestDate { get; set; }
		/// <summary>
		/// 예약번호
		/// </summary>
		[Column("예약번호")]
		public int BookingNumber { get; set; }
		/// <summary>
		/// 환불상태
		/// </summary>
		[Column("환불상태")]
		public string RefundState { get; set; }
		/// <summary>
		/// 환불구분
		/// </summary>
		[Column("환불구분")]
		public string RefundClassification { get; set; }
		/// <summary>
		/// 환불자
		/// </summary>
		[Column("환불자")]
		public string Refunder { get; set; }
		/// <summary>
		/// 휴대전화
		/// </summary>
		[Column("휴대전화")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 반송방법
		/// </summary>
		[Column("반송방법")]
		public string SendBackWay { get; set; }
		/// <summary>
		/// 취소료
		/// </summary>
		[Column("취소료")]
		public decimal CancelFee { get; set; }
		/// <summary>
		/// 취소료총액
		/// </summary>
		[Column("취소료총액")]
		public decimal CancellationFeeTotalAmount { get; set; }
		/// <summary>
		/// 환불비용
		/// </summary>
		[Column("환불비용")]
		public long RefundExpense { get; set; }
		/// <summary>
		/// 구매총액
		/// </summary>
		[Column("구매총액")]
		public long BuyTotalAmount { get; set; }
		/// <summary>
		/// 수령택배비
		/// </summary>
		[Column("수령택배비")]
		public long ReceiptDeliveryFee { get; set; }
		/// <summary>
		/// 반송택배비
		/// </summary>
		[Column("반송택배비")]
		public long SendBackDeliveryFee { get; set; }
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
		/// 요청사항
		/// </summary>
		[Column("요청사항")]
		public string Request { get; set; }
		/// <summary>
		/// 환불실패사유
		/// </summary>
		[Column("환불실패사유")]
		public string RefundFailReason { get; set; }
		/// <summary>
		/// 비고사항
		/// </summary>
		[Column("비고사항")]
		public string NoteItem { get; set; }
		/// <summary>
		/// 환불등록자
		/// </summary>
		[Column("환불등록자")]
		public string RefundRegisterer { get; set; }
		/// <summary>
		/// 환불등록일
		/// </summary>
		[Column("환불등록일")]
		public string RefundRegistrationDate { get; set; }
		/// <summary>
		/// 환불일련번호
		/// </summary>
		[Column("환불일련번호")]
		public int RefundSerialNumber { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 상품코드2
		/// </summary>
		[Column("상품코드2")]
		public string ProductCode2 { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 순번
		/// </summary>
		[Column("순번")]
		public int Order { get; set; }
		/// <summary>
		/// 인원
		/// </summary>
		[Column("인원")]
		public int NumberOfPeople { get; set; }
		/// <summary>
		/// 거래처
		/// </summary>
		[Column("거래처")]
		public string Customer { get; set; }
		/// <summary>
		/// 환불구분코드
		/// </summary>
		[Column("환불구분코드")]
		public string RefundClassificationCode { get; set; }
	}
}