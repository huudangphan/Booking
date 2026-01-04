namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_네이버메타태그_예약조회_BULK
/// </summary>
public class WSP_S_NaverMetaTag_ReservationFind_BULK
{
	public const string SP_NAME = "WSP_S_네이버메타태그_예약조회_BULK";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public string PTID { get; set; }
		/// <summary>
		/// STARTDT
		/// </summary>
		[Description("STARTDT")]
		public string STARTDT { get; set; }
		/// <summary>
		/// ENDDT
		/// </summary>
		[Description("ENDDT")]
		public string ENDDT { get; set; }
		/// <summary>
		/// ORDERNO
		/// </summary>
		[Description("ORDERNO")]
		public int ORDERNO { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// NIDKEY
		/// </summary>
		[Column("NIDKEY")]
		public string NIDKEY { get; set; }
		/// <summary>
		/// BookingKey
		/// </summary>
		[Column("BookingKey")]
		public string BookingKey { get; set; }
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
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
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
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public DateTime ArrivalDate { get; set; }
		/// <summary>
		/// 출발편명
		/// </summary>
		[Column("출발편명")]
		public string DepartureFlightName { get; set; }
		/// <summary>
		/// 도착편명
		/// </summary>
		[Column("도착편명")]
		public string ArrivalFlightName { get; set; }
		/// <summary>
		/// 성인금액
		/// </summary>
		[Column("성인금액")]
		public long AdultAmount { get; set; }
		/// <summary>
		/// 성인_유류할증료
		/// </summary>
		[Column("성인_유류할증료")]
		public long Adult_FuelSurchargeFee { get; set; }
		/// <summary>
		/// 성인_제세공과금
		/// </summary>
		[Column("성인_제세공과금")]
		public long Adult_PublicFacilitiesTax { get; set; }
		/// <summary>
		/// 소아금액
		/// </summary>
		[Column("소아금액")]
		public long KidAmount { get; set; }
		/// <summary>
		/// 소아_유류할증료
		/// </summary>
		[Column("소아_유류할증료")]
		public long Kid_FuelSurchargeFee { get; set; }
		/// <summary>
		/// 소아_제세공과금
		/// </summary>
		[Column("소아_제세공과금")]
		public long Kid_PublicFacilitiesTax { get; set; }
		/// <summary>
		/// 유아금액
		/// </summary>
		[Column("유아금액")]
		public long ToddlerAmount { get; set; }
		/// <summary>
		/// ADULTCNT
		/// </summary>
		[Column("ADULTCNT")]
		public int ADULTCNT { get; set; }
		/// <summary>
		/// CHILDCNT
		/// </summary>
		[Column("CHILDCNT")]
		public int CHILDCNT { get; set; }
		/// <summary>
		/// INFANTCNT
		/// </summary>
		[Column("INFANTCNT")]
		public int INFANTCNT { get; set; }
		/// <summary>
		/// 예약자명
		/// </summary>
		[Column("예약자명")]
		public string BookerName { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 담당OP명
		/// </summary>
		[Column("담당OP명")]
		public string Responsibility_OP_Name { get; set; }
		/// <summary>
		/// 담당OP회사전화
		/// </summary>
		[Column("담당OP회사전화")]
		public string Responsibility_OP_CompanyPhone { get; set; }
		/// <summary>
		/// 미팅시간
		/// </summary>
		[Column("미팅시간")]
		public string MeetingTime { get; set; }
		/// <summary>
		/// 미팅장소
		/// </summary>
		[Column("미팅장소")]
		public string MeetingPlace { get; set; }
		/// <summary>
		/// 예약상태
		/// </summary>
		[Column("예약상태")]
		public string BookingState { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 출발확정
		/// </summary>
		[Column("출발확정")]
		public string DepartureConfirm { get; set; }
		/// <summary>
		/// 가격확정
		/// </summary>
		[Column("가격확정")]
		public string PriceConfirm { get; set; }
		/// <summary>
		/// 총여행경비
		/// </summary>
		[Column("총여행경비")]
		public long TotalTravelExpense { get; set; }
		/// <summary>
		/// 수납액
		/// </summary>
		[Column("수납액")]
		public long ReceiptAmount { get; set; }
		/// <summary>
		/// 유입경로
		/// </summary>
		[Column("유입경로")]
		public string InflowRoute { get; set; }
		/// <summary>
		/// CODE
		/// </summary>
		[Column("CODE")]
		public int CODE { get; set; }
		/// <summary>
		/// 판매종류코드
		/// </summary>
		[Column("판매종류코드")]
		public string SalesTypeCode { get; set; }
		/// <summary>
		/// 국가리스트
		/// </summary>
		[Column("국가리스트")]
		public string CountryList { get; set; }
		/// <summary>
		/// 도시리스트
		/// </summary>
		[Column("도시리스트")]
		public string CityList { get; set; }
		/// <summary>
		/// 상품타입
		/// </summary>
		[Column("상품타입")]
		public string ProductType { get; set; }
		/// <summary>
		/// 대표국가
		/// </summary>
		[Column("대표국가")]
		public string RepresentativeCountry { get; set; }
		/// <summary>
		/// 대표도시
		/// </summary>
		[Column("대표도시")]
		public string RepresentativeCity { get; set; }
		/// <summary>
		/// 항공코드1
		/// </summary>
		[Column("항공코드1")]
		public string FlightCode1 { get; set; }
		/// <summary>
		/// 결제정보
		/// </summary>
		[Column("결제정보")]
		public string PaymentInfo { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// AAU_AUTHKEY
		/// </summary>
		[Column("AAU_AUTHKEY")]
		public Guid AAU_AUTHKEY { get; set; }
	}
}