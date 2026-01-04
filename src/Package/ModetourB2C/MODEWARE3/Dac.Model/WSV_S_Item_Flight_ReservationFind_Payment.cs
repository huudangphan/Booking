namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_S_아이템_항공_예약조회_결제
/// </summary>
public class WSV_S_Item_Flight_ReservationFind_Payment
{
	public const string SP_NAME = "WSV_S_아이템_항공_예약조회_결제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
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
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
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
		public int FuelSurchargeFee { get; set; }
		/// <summary>
		/// 취급수수료
		/// </summary>
		[Column("취급수수료")]
		public long HandleFee { get; set; }
		/// <summary>
		/// 총요금
		/// </summary>
		[Column("총요금")]
		public long TotalFare { get; set; }
		/// <summary>
		/// 카드금액
		/// </summary>
		[Column("카드금액")]
		public int CardAmount { get; set; }
		/// <summary>
		/// 계좌이체금액
		/// </summary>
		[Column("계좌이체금액")]
		public int AccountTransferAmount { get; set; }
		/// <summary>
		/// 입금액
		/// </summary>
		[Column("입금액")]
		public int DepositAmount { get; set; }
		/// <summary>
		/// 미입금액
		/// </summary>
		[Column("미입금액")]
		public long UnreceivedAmount { get; set; }
		/// <summary>
		/// 결제등록일
		/// </summary>
		[Column("결제등록일")]
		public DateTime PaymentRegistrationDate { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 카드금액
		/// </summary>
		[Column("카드금액")]
		public int CardAmount { get; set; }
		/// <summary>
		/// 계좌이체금액
		/// </summary>
		[Column("계좌이체금액")]
		public int AccountTransferAmount { get; set; }
		/// <summary>
		/// 입금액
		/// </summary>
		[Column("입금액")]
		public int DepositAmount { get; set; }
		/// <summary>
		/// 결제등록일
		/// </summary>
		[Column("결제등록일")]
		public DateTime PaymentRegistrationDate { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 총항공료
		/// </summary>
		[Column("총항공료")]
		public long TotalFlightFee { get; set; }
		/// <summary>
		/// 총TAX
		/// </summary>
		[Column("총TAX")]
		public long Total_TAX { get; set; }
		/// <summary>
		/// 총유류할증료
		/// </summary>
		[Column("총유류할증료")]
		public int TotalFuelSurchargeFee { get; set; }
		/// <summary>
		/// 총취급수수료
		/// </summary>
		[Column("총취급수수료")]
		public long TotalHandleFee { get; set; }
		/// <summary>
		/// 총판매가
		/// </summary>
		[Column("총판매가")]
		public long TotalSellingPrice { get; set; }
		/// <summary>
		/// 결제등록일
		/// </summary>
		[Column("결제등록일")]
		public DateTime PaymentRegistrationDate { get; set; }
		/// <summary>
		/// 휴대폰번호
		/// </summary>
		[Column("휴대폰번호")]
		public string PhoneNumber { get; set; }
	}
}