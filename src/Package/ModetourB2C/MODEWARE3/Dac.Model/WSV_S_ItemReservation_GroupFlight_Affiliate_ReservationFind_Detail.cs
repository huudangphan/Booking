namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_S_아이템예약_단체항공_제휴_예약조회_상세
/// </summary>
public class WSV_S_ItemReservation_GroupFlight_Affiliate_ReservationFind_Detail
{
	public const string SP_NAME = "WSV_S_아이템예약_단체항공_제휴_예약조회_상세";

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
		/// <summary>
		/// 요청자IP
		/// </summary>
		[Description("요청자IP")]
		public string Requester_IP { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 예약번호
		/// </summary>
		[Column("예약번호")]
		public int BookingNumber { get; set; }
		/// <summary>
		/// 재고번호
		/// </summary>
		[Column("재고번호")]
		public int StockNumber { get; set; }
		/// <summary>
		/// 예약일
		/// </summary>
		[Column("예약일")]
		public string BookingDate { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 판매가
		/// </summary>
		[Column("판매가")]
		public long SellingPrice { get; set; }
		/// <summary>
		/// 항공료
		/// </summary>
		[Column("항공료")]
		public long FlightFee { get; set; }
		/// <summary>
		/// 텍스
		/// </summary>
		[Column("텍스")]
		public long Tax { get; set; }
		/// <summary>
		/// 유류할증료
		/// </summary>
		[Column("유류할증료")]
		public long FuelSurchargeFee { get; set; }
		/// <summary>
		/// 발권수수료
		/// </summary>
		[Column("발권수수료")]
		public long TicketIssuanceFee { get; set; }
		/// <summary>
		/// 취급수수료
		/// </summary>
		[Column("취급수수료")]
		public long HandleFee { get; set; }
		/// <summary>
		/// 환불수수료
		/// </summary>
		[Column("환불수수료")]
		public long RefundFee { get; set; }
		/// <summary>
		/// 할인쿠폰금액
		/// </summary>
		[Column("할인쿠폰금액")]
		public int DiscountCouponAmount { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 취소자
		/// </summary>
		[Column("취소자")]
		public int CancelPerson { get; set; }
		/// <summary>
		/// 취소일
		/// </summary>
		[Column("취소일")]
		public string CancelDate { get; set; }
		/// <summary>
		/// 환불요청
		/// </summary>
		[Column("환불요청")]
		public string RefundRequest { get; set; }
		/// <summary>
		/// 환불완료
		/// </summary>
		[Column("환불완료")]
		public string RefundFinish { get; set; }
		/// <summary>
		/// 결제마감일
		/// </summary>
		[Column("결제마감일")]
		public string PaymentEndDate { get; set; }
		/// <summary>
		/// 발권일
		/// </summary>
		[Column("발권일")]
		public string TicketIssuanceDate { get; set; }
		/// <summary>
		/// 사이트번호
		/// </summary>
		[Column("사이트번호")]
		public int SiteNumber { get; set; }
		/// <summary>
		/// 탑승인원
		/// </summary>
		[Column("탑승인원")]
		public int NumberOfPassenger { get; set; }
		/// <summary>
		/// 예약상태
		/// </summary>
		[Column("예약상태")]
		public string BookingState { get; set; }
		/// <summary>
		/// 요금확정
		/// </summary>
		[Column("요금확정")]
		public string FareConfirm { get; set; }
		/// <summary>
		/// 취소료규정
		/// </summary>
		[Column("취소료규정")]
		public string CancelFeeRegulations { get; set; }
		/// <summary>
		/// 제휴회원번호
		/// </summary>
		[Column("제휴회원번호")]
		public string AffiliateMemberNumber { get; set; }
		/// <summary>
		/// 제휴주문번호
		/// </summary>
		[Column("제휴주문번호")]
		public string AffiliateOrderNumber { get; set; }
		/// <summary>
		/// 제휴사이트코드
		/// </summary>
		[Column("제휴사이트코드")]
		public string AffiliateSiteCode { get; set; }
		/// <summary>
		/// 유입경로
		/// </summary>
		[Column("유입경로")]
		public string InflowRoute { get; set; }
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
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 전화번호
		/// </summary>
		[Column("전화번호")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Column("생년월일")]
		public string BirthYearMonthDay { get; set; }
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
		/// 항공스케쥴
		/// </summary>
		[Column("항공스케쥴")]
		public string FlightSchedule { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 회원번호
		/// </summary>
		[Column("회원번호")]
		public int MemberNumber { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Column("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 영문성명
		/// </summary>
		[Column("영문성명")]
		public string EnglishName2 { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 구분명
		/// </summary>
		[Column("구분명")]
		public string ClassificationName { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 성별명
		/// </summary>
		[Column("성별명")]
		public string GenderName { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Column("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 총요금
		/// </summary>
		[Column("총요금")]
		public long TotalFare { get; set; }
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
		/// 유류할증료
		/// </summary>
		[Column("유류할증료")]
		public long FuelSurchargeFee { get; set; }
		/// <summary>
		/// 발권수수료
		/// </summary>
		[Column("발권수수료")]
		public long TicketIssuanceFee { get; set; }
		/// <summary>
		/// 취급수수료
		/// </summary>
		[Column("취급수수료")]
		public long HandleFee { get; set; }
		/// <summary>
		/// 환불수수료
		/// </summary>
		[Column("환불수수료")]
		public long RefundFee { get; set; }
		/// <summary>
		/// 여권번호
		/// </summary>
		[Column("여권번호")]
		public string PassportNumber { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Column("여권만료일")]
		public string PassportExpirationDate { get; set; }
		/// <summary>
		/// 여권국적코드
		/// </summary>
		[Column("여권국적코드")]
		public string PassportNationalityCode { get; set; }
		/// <summary>
		/// 여권발행국코드
		/// </summary>
		[Column("여권발행국코드")]
		public string PassportPublishCountryCode { get; set; }
		/// <summary>
		/// 여권정보등록일
		/// </summary>
		[Column("여권정보등록일")]
		public string PassportInfoRegisterDate { get; set; }
		/// <summary>
		/// 발권여부
		/// </summary>
		[Column("발권여부")]
		public string TicketIssuanceOrNot { get; set; }
		/// <summary>
		/// 발권일
		/// </summary>
		[Column("발권일")]
		public string TicketIssuanceDate { get; set; }
		/// <summary>
		/// 티켓번호
		/// </summary>
		[Column("티켓번호")]
		public string TicketNumber { get; set; }
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
		/// 판매종류코드
		/// </summary>
		[Column("판매종류코드")]
		public string SalesTypeCode { get; set; }
	}

	public class Result6 : IDbResult
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
	}

	public class Result8 : IDbResult
	{
		/// <summary>
		/// 결제수단
		/// </summary>
		[Column("결제수단")]
		public string PaymentMethod { get; set; }
		/// <summary>
		/// 쿠폰발행번호
		/// </summary>
		[Column("쿠폰발행번호")]
		public string CouponPublishNumber { get; set; }
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
		/// 취소여부
		/// </summary>
		[Column("취소여부")]
		public string CancelOrNot { get; set; }
	}

	public class Result9 : IDbResult
	{
		/// <summary>
		/// 결제수단
		/// </summary>
		[Column("결제수단")]
		public string PaymentMethod { get; set; }
		/// <summary>
		/// 체크쿠폰번호
		/// </summary>
		[Column("체크쿠폰번호")]
		public string CheckCouponNumber { get; set; }
		/// <summary>
		/// 쿠폰발행번호
		/// </summary>
		[Column("쿠폰발행번호")]
		public string CouponPublishNumber { get; set; }
		/// <summary>
		/// 쿠폰번호
		/// </summary>
		[Column("쿠폰번호")]
		public string CouponNumber { get; set; }
		/// <summary>
		/// 쿠폰종류
		/// </summary>
		[Column("쿠폰종류")]
		public string CouponType { get; set; }
		/// <summary>
		/// 수납액
		/// </summary>
		[Column("수납액")]
		public int ReceiptAmount { get; set; }
		/// <summary>
		/// 수납일
		/// </summary>
		[Column("수납일")]
		public string ReceiptDate { get; set; }
		/// <summary>
		/// 사용
		/// </summary>
		[Column("사용")]
		public string Use { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
	}
}