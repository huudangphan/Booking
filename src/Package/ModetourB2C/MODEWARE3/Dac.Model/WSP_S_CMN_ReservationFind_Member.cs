namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_예약조회_회원
/// </summary>
public class WSP_S_CMN_ReservationFind_Member
{
	public const string SP_NAME = "WSP_S_CMN_예약조회_회원";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 날짜1
		/// </summary>
		[Description("날짜1")]
		public DateTime Date1 { get; set; }
		/// <summary>
		/// 날짜2
		/// </summary>
		[Description("날짜2")]
		public DateTime Date2 { get; set; }
		/// <summary>
		/// 날짜구분
		/// </summary>
		[Description("날짜구분")]
		public string DateClassification { get; set; }
	}

	public class Result1 : IDbResult
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
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 인원
		/// </summary>
		[Column("인원")]
		public int NumberOfPeople { get; set; }
		/// <summary>
		/// MLOC
		/// </summary>
		[Column("MLOC")]
		public string MLOC { get; set; }
		/// <summary>
		/// 총액요금
		/// </summary>
		[Column("총액요금")]
		public long TotalAmountFare { get; set; }
		/// <summary>
		/// 고객선택경비
		/// </summary>
		[Column("고객선택경비")]
		public long CustomerSelectExpense { get; set; }
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
		/// 상품분류
		/// </summary>
		[Column("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 예약상황
		/// </summary>
		[Column("예약상황")]
		public string BookingSituation { get; set; }
		/// <summary>
		/// 상품코드2
		/// </summary>
		[Column("상품코드2")]
		public string ProductCode2 { get; set; }
		/// <summary>
		/// 판매거래처
		/// </summary>
		[Column("판매거래처")]
		public int SalesCustomer { get; set; }
		/// <summary>
		/// 접두어
		/// </summary>
		[Column("접두어")]
		public string Prefix { get; set; }
		/// <summary>
		/// 접두어명
		/// </summary>
		[Column("접두어명")]
		public string PrefixName { get; set; }
		/// <summary>
		/// 웹서비스버전명
		/// </summary>
		[Column("웹서비스버전명")]
		public string WebServiceVersionName { get; set; }
		/// <summary>
		/// 발권완료여부
		/// </summary>
		[Column("발권완료여부")]
		public string TicketIssuanceFinishOrNot { get; set; }
		/// <summary>
		/// GDS코드
		/// </summary>
		[Column("GDS코드")]
		public string GDS_Code { get; set; }
		/// <summary>
		/// GDS상품코드
		/// </summary>
		[Column("GDS상품코드")]
		public string GDS_ProductCode { get; set; }
		/// <summary>
		/// 예약대행자
		/// </summary>
		[Column("예약대행자")]
		public int BookingProcurator { get; set; }
		/// <summary>
		/// 입금상태
		/// </summary>
		[Column("입금상태")]
		public string DepositState { get; set; }
		/// <summary>
		/// 환불상태
		/// </summary>
		[Column("환불상태")]
		public string RefundState { get; set; }
		/// <summary>
		/// 배송수령인
		/// </summary>
		[Column("배송수령인")]
		public string ShippingReceiver { get; set; }
		/// <summary>
		/// 택배사코드
		/// </summary>
		[Column("택배사코드")]
		public string DeliveryCompanyCode { get; set; }
		/// <summary>
		/// 운송장번호
		/// </summary>
		[Column("운송장번호")]
		public string TransportationLeaderNumber { get; set; }
		/// <summary>
		/// 수령방법
		/// </summary>
		[Column("수령방법")]
		public string ReceiptWay { get; set; }
		/// <summary>
		/// 티켓형태
		/// </summary>
		[Column("티켓형태")]
		public int TicketFormat { get; set; }
		/// <summary>
		/// 신청금입금일
		/// </summary>
		[Column("신청금입금일")]
		public DateTime RequestMoneyDepositDate { get; set; }
		/// <summary>
		/// 단체분류
		/// </summary>
		[Column("단체분류")]
		public string GroupClassification { get; set; }
		/// <summary>
		/// 발권완료여부1
		/// </summary>
		[Column("발권완료여부1")]
		public string TicketIssuanceFinishOrNot1 { get; set; }
		/// <summary>
		/// ESTA_원주문번호
		/// </summary>
		[Column("ESTA_원주문번호")]
		public int ESTA_OriginalOrderNumber { get; set; }
		/// <summary>
		/// 인센티브여부
		/// </summary>
		[Column("인센티브여부")]
		public string IncentiveOrNot { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 카드승인제한여부
		/// </summary>
		[Column("카드승인제한여부")]
		public string CardApprovalLimitOrNot { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
	}

	public class Result2 : IDbResult
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
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 인원
		/// </summary>
		[Column("인원")]
		public int NumberOfPeople { get; set; }
		/// <summary>
		/// MLOC
		/// </summary>
		[Column("MLOC")]
		public string MLOC { get; set; }
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
		/// 상품분류
		/// </summary>
		[Column("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 예약상황
		/// </summary>
		[Column("예약상황")]
		public string BookingSituation { get; set; }
		/// <summary>
		/// 상품코드2
		/// </summary>
		[Column("상품코드2")]
		public string ProductCode2 { get; set; }
		/// <summary>
		/// 판매거래처
		/// </summary>
		[Column("판매거래처")]
		public int SalesCustomer { get; set; }
		/// <summary>
		/// 접두어
		/// </summary>
		[Column("접두어")]
		public string Prefix { get; set; }
		/// <summary>
		/// 접두어명
		/// </summary>
		[Column("접두어명")]
		public string PrefixName { get; set; }
		/// <summary>
		/// 웹서비스버전명
		/// </summary>
		[Column("웹서비스버전명")]
		public string WebServiceVersionName { get; set; }
		/// <summary>
		/// 발권완료여부
		/// </summary>
		[Column("발권완료여부")]
		public string TicketIssuanceFinishOrNot { get; set; }
		/// <summary>
		/// GDS코드
		/// </summary>
		[Column("GDS코드")]
		public string GDS_Code { get; set; }
		/// <summary>
		/// GDS상품코드
		/// </summary>
		[Column("GDS상품코드")]
		public string GDS_ProductCode { get; set; }
		/// <summary>
		/// 예약대행자
		/// </summary>
		[Column("예약대행자")]
		public int BookingProcurator { get; set; }
		/// <summary>
		/// 입금상태
		/// </summary>
		[Column("입금상태")]
		public string DepositState { get; set; }
		/// <summary>
		/// 환불상태
		/// </summary>
		[Column("환불상태")]
		public string RefundState { get; set; }
		/// <summary>
		/// 배송수령인
		/// </summary>
		[Column("배송수령인")]
		public string ShippingReceiver { get; set; }
		/// <summary>
		/// 택배사코드
		/// </summary>
		[Column("택배사코드")]
		public string DeliveryCompanyCode { get; set; }
		/// <summary>
		/// 운송장번호
		/// </summary>
		[Column("운송장번호")]
		public string TransportationLeaderNumber { get; set; }
		/// <summary>
		/// 수령방법
		/// </summary>
		[Column("수령방법")]
		public string ReceiptWay { get; set; }
		/// <summary>
		/// 티켓형태
		/// </summary>
		[Column("티켓형태")]
		public int TicketFormat { get; set; }
		/// <summary>
		/// 신청금입금일
		/// </summary>
		[Column("신청금입금일")]
		public DateTime RequestMoneyDepositDate { get; set; }
		/// <summary>
		/// 단체분류
		/// </summary>
		[Column("단체분류")]
		public string GroupClassification { get; set; }
		/// <summary>
		/// 발권완료여부1
		/// </summary>
		[Column("발권완료여부1")]
		public string TicketIssuanceFinishOrNot1 { get; set; }
		/// <summary>
		/// ESTA_원주문번호
		/// </summary>
		[Column("ESTA_원주문번호")]
		public int ESTA_OriginalOrderNumber { get; set; }
		/// <summary>
		/// 인센티브여부
		/// </summary>
		[Column("인센티브여부")]
		public string IncentiveOrNot { get; set; }
	}

	public class Result3 : IDbResult
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
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 인원
		/// </summary>
		[Column("인원")]
		public int NumberOfPeople { get; set; }
		/// <summary>
		/// MLOC
		/// </summary>
		[Column("MLOC")]
		public string MLOC { get; set; }
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
		/// 상품분류
		/// </summary>
		[Column("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 예약상황
		/// </summary>
		[Column("예약상황")]
		public string BookingSituation { get; set; }
		/// <summary>
		/// 상품코드2
		/// </summary>
		[Column("상품코드2")]
		public string ProductCode2 { get; set; }
		/// <summary>
		/// 판매거래처
		/// </summary>
		[Column("판매거래처")]
		public int SalesCustomer { get; set; }
		/// <summary>
		/// 접두어
		/// </summary>
		[Column("접두어")]
		public string Prefix { get; set; }
		/// <summary>
		/// 접두어명
		/// </summary>
		[Column("접두어명")]
		public string PrefixName { get; set; }
		/// <summary>
		/// 웹서비스버전명
		/// </summary>
		[Column("웹서비스버전명")]
		public string WebServiceVersionName { get; set; }
		/// <summary>
		/// 발권완료여부
		/// </summary>
		[Column("발권완료여부")]
		public string TicketIssuanceFinishOrNot { get; set; }
		/// <summary>
		/// GDS코드
		/// </summary>
		[Column("GDS코드")]
		public string GDS_Code { get; set; }
		/// <summary>
		/// GDS상품코드
		/// </summary>
		[Column("GDS상품코드")]
		public string GDS_ProductCode { get; set; }
		/// <summary>
		/// 예약대행자
		/// </summary>
		[Column("예약대행자")]
		public int BookingProcurator { get; set; }
		/// <summary>
		/// 입금상태
		/// </summary>
		[Column("입금상태")]
		public string DepositState { get; set; }
		/// <summary>
		/// 환불상태
		/// </summary>
		[Column("환불상태")]
		public string RefundState { get; set; }
		/// <summary>
		/// 배송수령인
		/// </summary>
		[Column("배송수령인")]
		public string ShippingReceiver { get; set; }
		/// <summary>
		/// 택배사코드
		/// </summary>
		[Column("택배사코드")]
		public string DeliveryCompanyCode { get; set; }
		/// <summary>
		/// 운송장번호
		/// </summary>
		[Column("운송장번호")]
		public string TransportationLeaderNumber { get; set; }
		/// <summary>
		/// 수령방법
		/// </summary>
		[Column("수령방법")]
		public string ReceiptWay { get; set; }
		/// <summary>
		/// 티켓형태
		/// </summary>
		[Column("티켓형태")]
		public int TicketFormat { get; set; }
		/// <summary>
		/// 신청금입금일
		/// </summary>
		[Column("신청금입금일")]
		public DateTime RequestMoneyDepositDate { get; set; }
		/// <summary>
		/// 단체분류
		/// </summary>
		[Column("단체분류")]
		public string GroupClassification { get; set; }
		/// <summary>
		/// 발권완료여부1
		/// </summary>
		[Column("발권완료여부1")]
		public string TicketIssuanceFinishOrNot1 { get; set; }
		/// <summary>
		/// ESTA_원주문번호
		/// </summary>
		[Column("ESTA_원주문번호")]
		public int ESTA_OriginalOrderNumber { get; set; }
		/// <summary>
		/// 인센티브여부
		/// </summary>
		[Column("인센티브여부")]
		public string IncentiveOrNot { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
	}

	public class Result4 : IDbResult
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
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 인원
		/// </summary>
		[Column("인원")]
		public int NumberOfPeople { get; set; }
		/// <summary>
		/// MLOC
		/// </summary>
		[Column("MLOC")]
		public string MLOC { get; set; }
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
		/// 상품분류
		/// </summary>
		[Column("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 예약상황
		/// </summary>
		[Column("예약상황")]
		public string BookingSituation { get; set; }
		/// <summary>
		/// 상품코드2
		/// </summary>
		[Column("상품코드2")]
		public string ProductCode2 { get; set; }
		/// <summary>
		/// 판매거래처
		/// </summary>
		[Column("판매거래처")]
		public int SalesCustomer { get; set; }
		/// <summary>
		/// 접두어
		/// </summary>
		[Column("접두어")]
		public string Prefix { get; set; }
		/// <summary>
		/// 웹서비스버전명
		/// </summary>
		[Column("웹서비스버전명")]
		public string WebServiceVersionName { get; set; }
		/// <summary>
		/// 발권완료여부
		/// </summary>
		[Column("발권완료여부")]
		public string TicketIssuanceFinishOrNot { get; set; }
		/// <summary>
		/// GDS코드
		/// </summary>
		[Column("GDS코드")]
		public string GDS_Code { get; set; }
		/// <summary>
		/// GDS상품코드
		/// </summary>
		[Column("GDS상품코드")]
		public string GDS_ProductCode { get; set; }
		/// <summary>
		/// 예약대행자
		/// </summary>
		[Column("예약대행자")]
		public int BookingProcurator { get; set; }
		/// <summary>
		/// 입금상태
		/// </summary>
		[Column("입금상태")]
		public string DepositState { get; set; }
		/// <summary>
		/// 환불상태
		/// </summary>
		[Column("환불상태")]
		public string RefundState { get; set; }
		/// <summary>
		/// 배송수령인
		/// </summary>
		[Column("배송수령인")]
		public string ShippingReceiver { get; set; }
		/// <summary>
		/// 택배사코드
		/// </summary>
		[Column("택배사코드")]
		public string DeliveryCompanyCode { get; set; }
		/// <summary>
		/// 운송장번호
		/// </summary>
		[Column("운송장번호")]
		public string TransportationLeaderNumber { get; set; }
		/// <summary>
		/// 수령방법
		/// </summary>
		[Column("수령방법")]
		public string ReceiptWay { get; set; }
		/// <summary>
		/// 티켓형태
		/// </summary>
		[Column("티켓형태")]
		public int TicketFormat { get; set; }
		/// <summary>
		/// 신청금입금일
		/// </summary>
		[Column("신청금입금일")]
		public DateTime RequestMoneyDepositDate { get; set; }
		/// <summary>
		/// 단체분류
		/// </summary>
		[Column("단체분류")]
		public string GroupClassification { get; set; }
		/// <summary>
		/// 발권완료여부1
		/// </summary>
		[Column("발권완료여부1")]
		public string TicketIssuanceFinishOrNot1 { get; set; }
		/// <summary>
		/// ESTA_원주문번호
		/// </summary>
		[Column("ESTA_원주문번호")]
		public int ESTA_OriginalOrderNumber { get; set; }
		/// <summary>
		/// 인센티브여부
		/// </summary>
		[Column("인센티브여부")]
		public string IncentiveOrNot { get; set; }
		/// <summary>
		/// 카드승인제한여부
		/// </summary>
		[Column("카드승인제한여부")]
		public string CardApprovalLimitOrNot { get; set; }
	}

	public class Result5 : IDbResult
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
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 인원
		/// </summary>
		[Column("인원")]
		public int NumberOfPeople { get; set; }
		/// <summary>
		/// MLOC
		/// </summary>
		[Column("MLOC")]
		public string MLOC { get; set; }
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
		/// 상품분류
		/// </summary>
		[Column("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 예약상황
		/// </summary>
		[Column("예약상황")]
		public string BookingSituation { get; set; }
		/// <summary>
		/// 상품코드2
		/// </summary>
		[Column("상품코드2")]
		public string ProductCode2 { get; set; }
		/// <summary>
		/// 판매거래처
		/// </summary>
		[Column("판매거래처")]
		public int SalesCustomer { get; set; }
		/// <summary>
		/// 접두어
		/// </summary>
		[Column("접두어")]
		public string Prefix { get; set; }
		/// <summary>
		/// 접두어명
		/// </summary>
		[Column("접두어명")]
		public string PrefixName { get; set; }
		/// <summary>
		/// 웹서비스버전명
		/// </summary>
		[Column("웹서비스버전명")]
		public string WebServiceVersionName { get; set; }
		/// <summary>
		/// 발권완료여부
		/// </summary>
		[Column("발권완료여부")]
		public string TicketIssuanceFinishOrNot { get; set; }
		/// <summary>
		/// GDS코드
		/// </summary>
		[Column("GDS코드")]
		public string GDS_Code { get; set; }
		/// <summary>
		/// GDS상품코드
		/// </summary>
		[Column("GDS상품코드")]
		public string GDS_ProductCode { get; set; }
		/// <summary>
		/// 예약대행자
		/// </summary>
		[Column("예약대행자")]
		public int BookingProcurator { get; set; }
		/// <summary>
		/// 입금상태
		/// </summary>
		[Column("입금상태")]
		public string DepositState { get; set; }
		/// <summary>
		/// 환불상태
		/// </summary>
		[Column("환불상태")]
		public string RefundState { get; set; }
		/// <summary>
		/// 배송수령인
		/// </summary>
		[Column("배송수령인")]
		public string ShippingReceiver { get; set; }
		/// <summary>
		/// 택배사코드
		/// </summary>
		[Column("택배사코드")]
		public string DeliveryCompanyCode { get; set; }
		/// <summary>
		/// 운송장번호
		/// </summary>
		[Column("운송장번호")]
		public string TransportationLeaderNumber { get; set; }
		/// <summary>
		/// 수령방법
		/// </summary>
		[Column("수령방법")]
		public string ReceiptWay { get; set; }
		/// <summary>
		/// 티켓형태
		/// </summary>
		[Column("티켓형태")]
		public int TicketFormat { get; set; }
		/// <summary>
		/// 신청금입금일
		/// </summary>
		[Column("신청금입금일")]
		public DateTime RequestMoneyDepositDate { get; set; }
		/// <summary>
		/// 단체분류
		/// </summary>
		[Column("단체분류")]
		public string GroupClassification { get; set; }
		/// <summary>
		/// 발권완료여부1
		/// </summary>
		[Column("발권완료여부1")]
		public string TicketIssuanceFinishOrNot1 { get; set; }
		/// <summary>
		/// ESTA_원주문번호
		/// </summary>
		[Column("ESTA_원주문번호")]
		public int ESTA_OriginalOrderNumber { get; set; }
		/// <summary>
		/// 인센티브여부
		/// </summary>
		[Column("인센티브여부")]
		public string IncentiveOrNot { get; set; }
		/// <summary>
		/// 카드승인제한여부
		/// </summary>
		[Column("카드승인제한여부")]
		public string CardApprovalLimitOrNot { get; set; }
		/// <summary>
		/// 골프장예약번호
		/// </summary>
		[Column("골프장예약번호")]
		public string GolfCourseBookingNumber { get; set; }
		/// <summary>
		/// 결제구분
		/// </summary>
		[Column("결제구분")]
		public string PaymentClassification { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
	}

	public class Result6 : IDbResult
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
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 인원
		/// </summary>
		[Column("인원")]
		public int NumberOfPeople { get; set; }
		/// <summary>
		/// MLOC
		/// </summary>
		[Column("MLOC")]
		public string MLOC { get; set; }
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
		/// 상품분류
		/// </summary>
		[Column("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 예약상황
		/// </summary>
		[Column("예약상황")]
		public string BookingSituation { get; set; }
		/// <summary>
		/// 상품코드2
		/// </summary>
		[Column("상품코드2")]
		public string ProductCode2 { get; set; }
		/// <summary>
		/// 판매거래처
		/// </summary>
		[Column("판매거래처")]
		public int SalesCustomer { get; set; }
		/// <summary>
		/// 접두어
		/// </summary>
		[Column("접두어")]
		public string Prefix { get; set; }
		/// <summary>
		/// 접두어명
		/// </summary>
		[Column("접두어명")]
		public string PrefixName { get; set; }
		/// <summary>
		/// 웹서비스버전명
		/// </summary>
		[Column("웹서비스버전명")]
		public string WebServiceVersionName { get; set; }
		/// <summary>
		/// 발권완료여부
		/// </summary>
		[Column("발권완료여부")]
		public string TicketIssuanceFinishOrNot { get; set; }
		/// <summary>
		/// GDS코드
		/// </summary>
		[Column("GDS코드")]
		public string GDS_Code { get; set; }
		/// <summary>
		/// GDS상품코드
		/// </summary>
		[Column("GDS상품코드")]
		public string GDS_ProductCode { get; set; }
		/// <summary>
		/// 예약대행자
		/// </summary>
		[Column("예약대행자")]
		public int BookingProcurator { get; set; }
		/// <summary>
		/// 입금상태
		/// </summary>
		[Column("입금상태")]
		public string DepositState { get; set; }
		/// <summary>
		/// 환불상태
		/// </summary>
		[Column("환불상태")]
		public string RefundState { get; set; }
		/// <summary>
		/// 배송수령인
		/// </summary>
		[Column("배송수령인")]
		public string ShippingReceiver { get; set; }
		/// <summary>
		/// 택배사코드
		/// </summary>
		[Column("택배사코드")]
		public string DeliveryCompanyCode { get; set; }
		/// <summary>
		/// 운송장번호
		/// </summary>
		[Column("운송장번호")]
		public string TransportationLeaderNumber { get; set; }
		/// <summary>
		/// 수령방법
		/// </summary>
		[Column("수령방법")]
		public string ReceiptWay { get; set; }
		/// <summary>
		/// 티켓형태
		/// </summary>
		[Column("티켓형태")]
		public int TicketFormat { get; set; }
		/// <summary>
		/// 신청금입금일
		/// </summary>
		[Column("신청금입금일")]
		public DateTime RequestMoneyDepositDate { get; set; }
		/// <summary>
		/// 단체분류
		/// </summary>
		[Column("단체분류")]
		public string GroupClassification { get; set; }
		/// <summary>
		/// 발권완료여부1
		/// </summary>
		[Column("발권완료여부1")]
		public string TicketIssuanceFinishOrNot1 { get; set; }
		/// <summary>
		/// ESTA_원주문번호
		/// </summary>
		[Column("ESTA_원주문번호")]
		public int ESTA_OriginalOrderNumber { get; set; }
		/// <summary>
		/// 인센티브여부
		/// </summary>
		[Column("인센티브여부")]
		public string IncentiveOrNot { get; set; }
		/// <summary>
		/// 카드승인제한여부
		/// </summary>
		[Column("카드승인제한여부")]
		public string CardApprovalLimitOrNot { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
	}
}