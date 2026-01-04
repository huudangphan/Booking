namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_S_아이템_호텔_예약조회_상세
/// </summary>
public class WSV_S_Item_Hotel_ReservationFind_Detail
{
	public const string SP_NAME = "WSV_S_아이템_호텔_예약조회_상세";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 예약자번호
		/// </summary>
		[Description("예약자번호")]
		public int BookerNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 예약번호
		/// </summary>
		[Column("예약번호")]
		public int BookingNumber { get; set; }
		/// <summary>
		/// 예약일
		/// </summary>
		[Column("예약일")]
		public DateTime BookingDate { get; set; }
		/// <summary>
		/// 전체요금
		/// </summary>
		[Column("전체요금")]
		public long EntireFare { get; set; }
		/// <summary>
		/// GROSS
		/// </summary>
		[Column("GROSS")]
		public long GROSS { get; set; }
		/// <summary>
		/// COMM
		/// </summary>
		[Column("COMM")]
		public long COMM { get; set; }
		/// <summary>
		/// VAT
		/// </summary>
		[Column("VAT")]
		public long VAT { get; set; }
		/// <summary>
		/// CHARGE
		/// </summary>
		[Column("CHARGE")]
		public long CHARGE { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
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
		/// 할인금액
		/// </summary>
		[Column("할인금액")]
		public long DiscountAmount { get; set; }
		/// <summary>
		/// 수수료
		/// </summary>
		[Column("수수료")]
		public long Fee { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 예약자번호
		/// </summary>
		[Column("예약자번호")]
		public int BookerNumber { get; set; }
		/// <summary>
		/// 예약자명
		/// </summary>
		[Column("예약자명")]
		public string BookerName { get; set; }
		/// <summary>
		/// 예약자영문명
		/// </summary>
		[Column("예약자영문명")]
		public string BookerEnglishName { get; set; }
		/// <summary>
		/// 집전화
		/// </summary>
		[Column("집전화")]
		public string HomePhone { get; set; }
		/// <summary>
		/// 회사전화
		/// </summary>
		[Column("회사전화")]
		public string CompanyPhone { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Column("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 거래처직원명
		/// </summary>
		[Column("거래처직원명")]
		public string CustomerEmployeeName { get; set; }
		/// <summary>
		/// 회사전화
		/// </summary>
		[Column("회사전화")]
		public string CompanyPhone { get; set; }
		/// <summary>
		/// 팩스
		/// </summary>
		[Column("팩스")]
		public string Fax { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 회사주소
		/// </summary>
		[Column("회사주소")]
		public string CompanyAddress { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 주문아이템번호
		/// </summary>
		[Column("주문아이템번호")]
		public int OrderItemNumber { get; set; }
		/// <summary>
		/// 주문아이템코드
		/// </summary>
		[Column("주문아이템코드")]
		public string OrderItemCode { get; set; }
		/// <summary>
		/// MD주문번호
		/// </summary>
		[Column("MD주문번호")]
		public int MD_OrderNumber { get; set; }
		/// <summary>
		/// GDS주문번호
		/// </summary>
		[Column("GDS주문번호")]
		public string GDS_OrderNumber { get; set; }
		/// <summary>
		/// GDS코드
		/// </summary>
		[Column("GDS코드")]
		public string GDS_Code { get; set; }
		/// <summary>
		/// GDS서버ID
		/// </summary>
		[Column("GDS서버ID")]
		public string GDS_Server_ID { get; set; }
		/// <summary>
		/// 품목코드
		/// </summary>
		[Column("품목코드")]
		public string ProductListCode { get; set; }
		/// <summary>
		/// GDS상품코드
		/// </summary>
		[Column("GDS상품코드")]
		public string GDS_ProductCode { get; set; }
		/// <summary>
		/// GDS상품명
		/// </summary>
		[Column("GDS상품명")]
		public string GDS_ProductName { get; set; }
		/// <summary>
		/// 서비스S
		/// </summary>
		[Column("서비스S")]
		public DateTime Service_S { get; set; }
		/// <summary>
		/// 서비스E
		/// </summary>
		[Column("서비스E")]
		public DateTime Service_E { get; set; }
		/// <summary>
		/// 지점S
		/// </summary>
		[Column("지점S")]
		public string BranchS { get; set; }
		/// <summary>
		/// 지점명S
		/// </summary>
		[Column("지점명S")]
		public string BranchName_S { get; set; }
		/// <summary>
		/// 요금
		/// </summary>
		[Column("요금")]
		public int Fare { get; set; }
		/// <summary>
		/// 수량
		/// </summary>
		[Column("수량")]
		public int Quantity { get; set; }
		/// <summary>
		/// 통화코드
		/// </summary>
		[Column("통화코드")]
		public string CallCode { get; set; }
		/// <summary>
		/// 환율
		/// </summary>
		[Column("환율")]
		public decimal ExchangeRate { get; set; }
		/// <summary>
		/// 예약일
		/// </summary>
		[Column("예약일")]
		public DateTime BookingDate { get; set; }
		/// <summary>
		/// 수정일
		/// </summary>
		[Column("수정일")]
		public DateTime EditionDate { get; set; }
		/// <summary>
		/// 최종수정자
		/// </summary>
		[Column("최종수정자")]
		public int FinalEditor { get; set; }
		/// <summary>
		/// 예약자요청사항
		/// </summary>
		[Column("예약자요청사항")]
		public string BookerRequest { get; set; }
		/// <summary>
		/// 결재방식
		/// </summary>
		[Column("결재방식")]
		public string ApprovalMethod { get; set; }
		/// <summary>
		/// 환불요청여부
		/// </summary>
		[Column("환불요청여부")]
		public string RefundRequestOrNot { get; set; }
		/// <summary>
		/// 예약상황
		/// </summary>
		[Column("예약상황")]
		public string BookingSituation { get; set; }
		/// <summary>
		/// 취소여부
		/// </summary>
		[Column("취소여부")]
		public string CancelOrNot { get; set; }
		/// <summary>
		/// 취소일
		/// </summary>
		[Column("취소일")]
		public DateTime CancelDate { get; set; }
		/// <summary>
		/// 예약XML
		/// </summary>
		[Column("예약XML")]
		public string Booking_XML { get; set; }
		/// <summary>
		/// 요금XML
		/// </summary>
		[Column("요금XML")]
		public string Fare_XML { get; set; }
		/// <summary>
		/// 고객XML
		/// </summary>
		[Column("고객XML")]
		public string Customer_XML { get; set; }
		/// <summary>
		/// 상품XML
		/// </summary>
		[Column("상품XML")]
		public string Product_XML { get; set; }
		/// <summary>
		/// 규정XML
		/// </summary>
		[Column("규정XML")]
		public string Regulations_XML { get; set; }
		/// <summary>
		/// MODEXML
		/// </summary>
		[Column("MODEXML")]
		public string MODEXML { get; set; }
		/// <summary>
		/// 환율적용방식
		/// </summary>
		[Column("환율적용방식")]
		public string ExchangeRateApplyMethod { get; set; }
		/// <summary>
		/// TL
		/// </summary>
		[Column("TL")]
		public DateTime TL { get; set; }
		/// <summary>
		/// 유의사항
		/// </summary>
		[Column("유의사항")]
		public string Notice { get; set; }
		/// <summary>
		/// 웹서비스버전명
		/// </summary>
		[Column("웹서비스버전명")]
		public string WebServiceVersionName { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Column("웹사이트번호")]
		public int WebSiteNumber { get; set; }
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
		/// 수납액
		/// </summary>
		[Column("수납액")]
		public long ReceiptAmount { get; set; }
		/// <summary>
		/// 수납일
		/// </summary>
		[Column("수납일")]
		public string ReceiptDate { get; set; }
		/// <summary>
		/// 할부
		/// </summary>
		[Column("할부")]
		public byte Installment { get; set; }
		/// <summary>
		/// 카드사명
		/// </summary>
		[Column("카드사명")]
		public string CardCompanyName { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// 수납액
		/// </summary>
		[Column("수납액")]
		public long ReceiptAmount { get; set; }
		/// <summary>
		/// 수납일
		/// </summary>
		[Column("수납일")]
		public string ReceiptDate { get; set; }
		/// <summary>
		/// 송금자
		/// </summary>
		[Column("송금자")]
		public string MoneySender { get; set; }
		/// <summary>
		/// 은행명
		/// </summary>
		[Column("은행명")]
		public string BankName { get; set; }
	}

	public class Result8 : IDbResult
	{
		/// <summary>
		/// 은행명
		/// </summary>
		[Column("은행명")]
		public string BankName { get; set; }
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
	}

	public class Result9 : IDbResult
	{
		/// <summary>
		/// 숙박객정보
		/// </summary>
		[Column("숙박객정보")]
		public string LogmentGuessInfo { get; set; }
	}
}