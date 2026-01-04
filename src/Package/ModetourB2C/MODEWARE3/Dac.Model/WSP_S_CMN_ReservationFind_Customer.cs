namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_예약조회_거래처
/// </summary>
public class WSP_S_CMN_ReservationFind_Customer
{
	public const string SP_NAME = "WSP_S_CMN_예약조회_거래처";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 예약종류
		/// </summary>
		[Description("예약종류")]
		public string BookingType { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Description("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 담당자
		/// </summary>
		[Description("담당자")]
		public int Manager { get; set; }
		/// <summary>
		/// 날짜구분
		/// </summary>
		[Description("날짜구분")]
		public string DateClassification { get; set; }
		/// <summary>
		/// 날짜1
		/// </summary>
		[Description("날짜1")]
		public string Date1 { get; set; }
		/// <summary>
		/// 날짜2
		/// </summary>
		[Description("날짜2")]
		public string Date2 { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Column("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 주문일
		/// </summary>
		[Column("주문일")]
		public DateTime OrderDate { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 총여행경비
		/// </summary>
		[Column("총여행경비")]
		public long TotalTravelExpense { get; set; }
		/// <summary>
		/// 판매액
		/// </summary>
		[Column("판매액")]
		public long SalesAmount { get; set; }
		/// <summary>
		/// 커미션
		/// </summary>
		[Column("커미션")]
		public long Commission { get; set; }
		/// <summary>
		/// 부가세
		/// </summary>
		[Column("부가세")]
		public long Surtax { get; set; }
		/// <summary>
		/// 주문종류
		/// </summary>
		[Column("주문종류")]
		public string OrderType { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Column("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public DateTime ArrivalDate { get; set; }
		/// <summary>
		/// 담당자
		/// </summary>
		[Column("담당자")]
		public string Manager { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 담당자PTID
		/// </summary>
		[Column("담당자PTID")]
		public int Manager_PTID { get; set; }
		/// <summary>
		/// 역할코드
		/// </summary>
		[Column("역할코드")]
		public string RoleCode { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 예약종류
		/// </summary>
		[Column("예약종류")]
		public string BookingType { get; set; }
		/// <summary>
		/// 판매종류코드
		/// </summary>
		[Column("판매종류코드")]
		public string SalesTypeCode { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Column("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Column("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 상태4
		/// </summary>
		[Column("상태4")]
		public string State4 { get; set; }
		/// <summary>
		/// 상태5
		/// </summary>
		[Column("상태5")]
		public string State5 { get; set; }
		/// <summary>
		/// 상태6
		/// </summary>
		[Column("상태6")]
		public string State6 { get; set; }
		/// <summary>
		/// 상태7
		/// </summary>
		[Column("상태7")]
		public string State7 { get; set; }
		/// <summary>
		/// 금액1
		/// </summary>
		[Column("금액1")]
		public long Amount1 { get; set; }
		/// <summary>
		/// 금액2
		/// </summary>
		[Column("금액2")]
		public long Amount2 { get; set; }
		/// <summary>
		/// 금액3
		/// </summary>
		[Column("금액3")]
		public long Amount3 { get; set; }
		/// <summary>
		/// 판매비고
		/// </summary>
		[Column("판매비고")]
		public string SalesNote { get; set; }
		/// <summary>
		/// 취소일
		/// </summary>
		[Column("취소일")]
		public DateTime CancelDate { get; set; }
		/// <summary>
		/// 수납액
		/// </summary>
		[Column("수납액")]
		public long ReceiptAmount { get; set; }
		/// <summary>
		/// 신청금입금일
		/// </summary>
		[Column("신청금입금일")]
		public DateTime RequestMoneyDepositDate { get; set; }
		/// <summary>
		/// 박수
		/// </summary>
		[Column("박수")]
		public byte NightNumber { get; set; }
		/// <summary>
		/// 특별약관여부
		/// </summary>
		[Column("특별약관여부")]
		public string SpecialTermsOrNot { get; set; }
		/// <summary>
		/// 유류할증료
		/// </summary>
		[Column("유류할증료")]
		public long FuelSurchargeFee { get; set; }
		/// <summary>
		/// 출발확정
		/// </summary>
		[Column("출발확정")]
		public string DepartureConfirm { get; set; }
		/// <summary>
		/// 기준커미션율
		/// </summary>
		[Column("기준커미션율")]
		public decimal StandardCommisionRate { get; set; }
		/// <summary>
		/// 가격확정
		/// </summary>
		[Column("가격확정")]
		public string PriceConfirm { get; set; }
	}
}