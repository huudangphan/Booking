namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_거래처별발권현황_발권일
/// </summary>
public class USP_S_EachCustomerTicketIssuanceCurrentState_TicketIssuanceDate
{
	public const string SP_NAME = "USP_S_거래처별발권현황_발권일";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 시작일
		/// </summary>
		[Description("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Description("종료일")]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 거래처
		/// </summary>
		[Description("거래처")]
		public string Customer { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 영업지점
		/// </summary>
		[Description("영업지점")]
		public int BusinessBranch { get; set; }
		/// <summary>
		/// 국내
		/// </summary>
		[Description("국내")]
		public string Domestic { get; set; }
		/// <summary>
		/// 발권지점
		/// </summary>
		[Description("발권지점")]
		public int TicketIssuanceBranch { get; set; }
		/// <summary>
		/// 티켓구분
		/// </summary>
		[Description("티켓구분")]
		public string TicketClassification { get; set; }
		/// <summary>
		/// EX티켓제외
		/// </summary>
		[Description("EX티켓제외")]
		public string EX_TicketExemption { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 발권일
		/// </summary>
		[Column("발권일")]
		public string TicketIssuanceDate { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 예약일
		/// </summary>
		[Column("예약일")]
		public DateTime BookingDate { get; set; }
		/// <summary>
		/// 티켓번호
		/// </summary>
		[Column("티켓번호")]
		public string TicketNumber { get; set; }
		/// <summary>
		/// 탑승자
		/// </summary>
		[Column("탑승자")]
		public string Passenger { get; set; }
		/// <summary>
		/// 루팅
		/// </summary>
		[Column("루팅")]
		public string Rooting { get; set; }
		/// <summary>
		/// 출발도시
		/// </summary>
		[Column("출발도시")]
		public string DepartureCity { get; set; }
		/// <summary>
		/// 발권Class
		/// </summary>
		[Column("발권Class")]
		public string Issuance_Class { get; set; }
		/// <summary>
		/// 항공료
		/// </summary>
		[Column("항공료")]
		public long FlightFee { get; set; }
		/// <summary>
		/// TAX
		/// </summary>
		[Column("TAX")]
		public long TAX { get; set; }
		/// <summary>
		/// AIRCOMM
		/// </summary>
		[Column("AIRCOMM")]
		public long AIRCOMM { get; set; }
		/// <summary>
		/// 총금액
		/// </summary>
		[Column("총금액")]
		public long TotalAmount { get; set; }
		/// <summary>
		/// 판매비고
		/// </summary>
		[Column("판매비고")]
		public string SalesNote { get; set; }
		/// <summary>
		/// Refund날짜
		/// </summary>
		[Column("Refund날짜")]
		public string Refund_Date { get; set; }
		/// <summary>
		/// 항공사
		/// </summary>
		[Column("항공사")]
		public string Airline { get; set; }
		/// <summary>
		/// Refund패널티
		/// </summary>
		[Column("Refund패널티")]
		public decimal Refund_Penalty { get; set; }
		/// <summary>
		/// 환불금액
		/// </summary>
		[Column("환불금액")]
		public long RefundAmount { get; set; }
		/// <summary>
		/// 거래처
		/// </summary>
		[Column("거래처")]
		public string Customer { get; set; }
		/// <summary>
		/// 발권자
		/// </summary>
		[Column("발권자")]
		public string Issuer { get; set; }
		/// <summary>
		/// 티켓구분
		/// </summary>
		[Column("티켓구분")]
		public string TicketClassification { get; set; }
		/// <summary>
		/// 영업지점
		/// </summary>
		[Column("영업지점")]
		public string BusinessBranch { get; set; }
		/// <summary>
		/// 요일
		/// </summary>
		[Column("요일")]
		public string Day { get; set; }
		/// <summary>
		/// tourcode
		/// </summary>
		[Column("tourcode")]
		public string tourcode { get; set; }
		/// <summary>
		/// 발권수
		/// </summary>
		[Column("발권수")]
		public int NumberOfIssuances { get; set; }
		/// <summary>
		/// UPCARD
		/// </summary>
		[Column("UPCARD")]
		public long UPCARD { get; set; }
		/// <summary>
		/// 영업담당
		/// </summary>
		[Column("영업담당")]
		public string BusinessResponsibility { get; set; }
		/// <summary>
		/// 지점
		/// </summary>
		[Column("지점")]
		public string Point { get; set; }
		/// <summary>
		/// CASH
		/// </summary>
		[Column("CASH")]
		public long CASH { get; set; }
		/// <summary>
		/// CARD
		/// </summary>
		[Column("CARD")]
		public long CARD { get; set; }
		/// <summary>
		/// GDS
		/// </summary>
		[Column("GDS")]
		public string GDS { get; set; }
		/// <summary>
		/// Q차지
		/// </summary>
		[Column("Q차지")]
		public long Q_Win { get; set; }
		/// <summary>
		/// 영업OP
		/// </summary>
		[Column("영업OP")]
		public string Business_OP { get; set; }
		/// <summary>
		/// 발권년월
		/// </summary>
		[Column("발권년월")]
		public string IssuanceYearMonth { get; set; }
		/// <summary>
		/// 거래처대분류
		/// </summary>
		[Column("거래처대분류")]
		public string CustomerMajorClassification { get; set; }
		/// <summary>
		/// 거래처중분류
		/// </summary>
		[Column("거래처중분류")]
		public string CustomerInternalClassification { get; set; }
		/// <summary>
		/// 거래처소분류
		/// </summary>
		[Column("거래처소분류")]
		public string CustomerOfficeClassification { get; set; }
		/// <summary>
		/// 담당OP소속부서
		/// </summary>
		[Column("담당OP소속부서")]
		public string ManageOPDepartment { get; set; }
		/// <summary>
		/// 상품지역
		/// </summary>
		[Column("상품지역")]
		public string ProductRegion { get; set; }
		/// <summary>
		/// 취급수수료
		/// </summary>
		[Column("취급수수료")]
		public long HandleFee { get; set; }
		/// <summary>
		/// 예약경로
		/// </summary>
		[Column("예약경로")]
		public string BookingRoute { get; set; }
		/// <summary>
		/// 카드사지원금
		/// </summary>
		[Column("카드사지원금")]
		public int CardCompanySupportAmount { get; set; }
		/// <summary>
		/// 모두투어부담_카드
		/// </summary>
		[Column("모두투어부담_카드")]
		public int ModetourBurden_Card { get; set; }
		/// <summary>
		/// 모두투어부담_기타
		/// </summary>
		[Column("모두투어부담_기타")]
		public int ModetourBurden_Other { get; set; }
		/// <summary>
		/// 프로모션
		/// </summary>
		[Column("프로모션")]
		public string Promotion { get; set; }
		/// <summary>
		/// PNR
		/// </summary>
		[Column("PNR")]
		public string PNR { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 판매명세GROSS
		/// </summary>
		[Column("판매명세GROSS")]
		public long SalesDetail_GROSS { get; set; }
		/// <summary>
		/// 판매명세유류
		/// </summary>
		[Column("판매명세유류")]
		public long SalesDetailOil { get; set; }
		/// <summary>
		/// 판매명세제세금
		/// </summary>
		[Column("판매명세제세금")]
		public int SalesDetailTax { get; set; }
		/// <summary>
		/// 선취컴
		/// </summary>
		[Column("선취컴")]
		public long FirstCommission { get; set; }
		/// <summary>
		/// 미수금
		/// </summary>
		[Column("미수금")]
		public long OutstandingAmount { get; set; }
		/// <summary>
		/// 티켓구분코드명
		/// </summary>
		[Column("티켓구분코드명")]
		public string TicketClassificationCodeName { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 자동발권
		/// </summary>
		[Column("자동발권")]
		public string AutoIssuance { get; set; }
		/// <summary>
		/// 모두닷컴
		/// </summary>
		[Column("모두닷컴")]
		public string ModetourDotCom { get; set; }
		/// <summary>
		/// UPCASH
		/// </summary>
		[Column("UPCASH")]
		public long UPCASH { get; set; }
		/// <summary>
		/// 항공사구분
		/// </summary>
		[Column("항공사구분")]
		public string AirlinesClassification { get; set; }
		/// <summary>
		/// 추가비용
		/// </summary>
		[Column("추가비용")]
		public long AddFee { get; set; }
		/// <summary>
		/// 제휴할인금액
		/// </summary>
		[Column("제휴할인금액")]
		public int AffiliatedDiscountAmount { get; set; }
		/// <summary>
		/// 리턴일
		/// </summary>
		[Column("리턴일")]
		public string ReturnDate { get; set; }
		/// <summary>
		/// BP
		/// </summary>
		[Column("BP")]
		public string BP { get; set; }
		/// <summary>
		/// 발권수수료
		/// </summary>
		[Column("발권수수료")]
		public long TicketIssuanceFee { get; set; }
		/// <summary>
		/// CLASS1
		/// </summary>
		[Column("CLASS1")]
		public string CLASS1 { get; set; }
		/// <summary>
		/// CLASS2
		/// </summary>
		[Column("CLASS2")]
		public string CLASS2 { get; set; }
		/// <summary>
		/// CLASS3
		/// </summary>
		[Column("CLASS3")]
		public string CLASS3 { get; set; }
		/// <summary>
		/// CLASS4
		/// </summary>
		[Column("CLASS4")]
		public string CLASS4 { get; set; }
		/// <summary>
		/// FB1
		/// </summary>
		[Column("FB1")]
		public string FB1 { get; set; }
		/// <summary>
		/// FB2
		/// </summary>
		[Column("FB2")]
		public string FB2 { get; set; }
		/// <summary>
		/// FB3
		/// </summary>
		[Column("FB3")]
		public string FB3 { get; set; }
		/// <summary>
		/// FB4
		/// </summary>
		[Column("FB4")]
		public string FB4 { get; set; }
		/// <summary>
		/// 항공사번호
		/// </summary>
		[Column("항공사번호")]
		public string AirlinesNumber { get; set; }
		/// <summary>
		/// IATA
		/// </summary>
		[Column("IATA")]
		public string IATA { get; set; }
		/// <summary>
		/// EMD티켓
		/// </summary>
		[Column("EMD티켓")]
		public string EMD_Ticket { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 제휴거래처
		/// </summary>
		[Column("제휴거래처")]
		public string AffiliatedCustomer { get; set; }
		/// <summary>
		/// CabinCLS1
		/// </summary>
		[Column("CabinCLS1")]
		public string CabinCLS1 { get; set; }
		/// <summary>
		/// CabinCLS2
		/// </summary>
		[Column("CabinCLS2")]
		public string CabinCLS2 { get; set; }
		/// <summary>
		/// CabinCLS3
		/// </summary>
		[Column("CabinCLS3")]
		public string CabinCLS3 { get; set; }
		/// <summary>
		/// CabinCLS4
		/// </summary>
		[Column("CabinCLS4")]
		public string CabinCLS4 { get; set; }
		/// <summary>
		/// 최종도착지
		/// </summary>
		[Column("최종도착지")]
		public string FinalArrivals { get; set; }
		/// <summary>
		/// 출발편명
		/// </summary>
		[Column("출발편명")]
		public string DepartureFlightName { get; set; }
		/// <summary>
		/// 추가판매_서비스
		/// </summary>
		[Column("추가판매_서비스")]
		public long AddSales_Service { get; set; }
		/// <summary>
		/// EX티켓
		/// </summary>
		[Column("EX티켓")]
		public string EX_Ticket { get; set; }
		/// <summary>
		/// CABINCLS
		/// </summary>
		[Column("CABINCLS")]
		public string CABINCLS { get; set; }
		/// <summary>
		/// 탑승자_한글
		/// </summary>
		[Column("탑승자_한글")]
		public string Passenger_Korean { get; set; }
		/// <summary>
		/// 아이템할인
		/// </summary>
		[Column("아이템할인")]
		public int ItemDiscount { get; set; }
		/// <summary>
		/// 운임종류
		/// </summary>
		[Column("운임종류")]
		public string ShippingCostType { get; set; }
		/// <summary>
		/// 카드승인번호
		/// </summary>
		[Column("카드승인번호")]
		public string CardApprovalNumber { get; set; }
		/// <summary>
		/// 티켓비고
		/// </summary>
		[Column("티켓비고")]
		public string TicketNote { get; set; }
		/// <summary>
		/// 출발일_상용
		/// </summary>
		[Column("출발일_상용")]
		public DateTime DepartureDate_CommonUse { get; set; }
		/// <summary>
		/// BSP
		/// </summary>
		[Column("BSP")]
		public string BSP { get; set; }
		/// <summary>
		/// 즉시여부
		/// </summary>
		[Column("즉시여부")]
		public string ImmediateOrNot { get; set; }
		/// <summary>
		/// 운영부서
		/// </summary>
		[Column("운영부서")]
		public string OperationDepartment { get; set; }
		/// <summary>
		/// 수익부서
		/// </summary>
		[Column("수익부서")]
		public string ProfitDepartment { get; set; }
		/// <summary>
		/// 출발월_상용
		/// </summary>
		[Column("출발월_상용")]
		public string DepartureMonth_CommonUse { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
	}
}