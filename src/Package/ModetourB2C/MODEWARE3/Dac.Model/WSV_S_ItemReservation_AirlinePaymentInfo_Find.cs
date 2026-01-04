namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_S_아이템예약_항공사결제정보_조회
/// </summary>
public class WSV_S_ItemReservation_AirlinePaymentInfo_Find
{
	public const string SP_NAME = "WSV_S_아이템예약_항공사결제정보_조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문아이템번호
		/// </summary>
		[Description("주문아이템번호")]
		public int OrderItemNumber { get; set; }
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
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
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
		/// 품목코드
		/// </summary>
		[Column("품목코드")]
		public string ProductListCode { get; set; }
		/// <summary>
		/// GDS코드
		/// </summary>
		[Column("GDS코드")]
		public string GDS_Code { get; set; }
		/// <summary>
		/// GDS주문번호
		/// </summary>
		[Column("GDS주문번호")]
		public string GDS_OrderNumber { get; set; }
		/// <summary>
		/// 카드번호
		/// </summary>
		[Column("카드번호")]
		public string CardNumber { get; set; }
		/// <summary>
		/// 카드사명
		/// </summary>
		[Column("카드사명")]
		public string CardCompanyName { get; set; }
		/// <summary>
		/// 카드종류
		/// </summary>
		[Column("카드종류")]
		public string CardType { get; set; }
		/// <summary>
		/// 유효기간
		/// </summary>
		[Column("유효기간")]
		public string ValidPeriod { get; set; }
		/// <summary>
		/// 승인번호
		/// </summary>
		[Column("승인번호")]
		public string ApprovalNumber { get; set; }
		/// <summary>
		/// 승인일자
		/// </summary>
		[Column("승인일자")]
		public string ApprovalDate { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 가격
		/// </summary>
		[Column("가격")]
		public int Price { get; set; }
		/// <summary>
		/// 할부
		/// </summary>
		[Column("할부")]
		public string Installment { get; set; }
		/// <summary>
		/// 카드코드
		/// </summary>
		[Column("카드코드")]
		public string CardCode { get; set; }
		/// <summary>
		/// KVPCODE
		/// </summary>
		[Column("KVPCODE")]
		public string KVPCODE { get; set; }
		/// <summary>
		/// SESSIONKEY
		/// </summary>
		[Column("SESSIONKEY")]
		public string SESSIONKEY { get; set; }
		/// <summary>
		/// ENCDATA
		/// </summary>
		[Column("ENCDATA")]
		public string ENCDATA { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 응답메시지
		/// </summary>
		[Column("응답메시지")]
		public string RespondMessage { get; set; }
		/// <summary>
		/// 항공사코드
		/// </summary>
		[Column("항공사코드")]
		public string AirlineCode { get; set; }
		/// <summary>
		/// PNR
		/// </summary>
		[Column("PNR")]
		public string PNR { get; set; }
		/// <summary>
		/// PNR2
		/// </summary>
		[Column("PNR2")]
		public string PNR2 { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
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
		/// 품목코드
		/// </summary>
		[Column("품목코드")]
		public string ProductListCode { get; set; }
		/// <summary>
		/// GDS코드
		/// </summary>
		[Column("GDS코드")]
		public string GDS_Code { get; set; }
		/// <summary>
		/// GDS주문번호
		/// </summary>
		[Column("GDS주문번호")]
		public string GDS_OrderNumber { get; set; }
		/// <summary>
		/// 카드번호
		/// </summary>
		[Column("카드번호")]
		public string CardNumber { get; set; }
		/// <summary>
		/// 카드사명
		/// </summary>
		[Column("카드사명")]
		public string CardCompanyName { get; set; }
		/// <summary>
		/// 카드종류
		/// </summary>
		[Column("카드종류")]
		public string CardType { get; set; }
		/// <summary>
		/// 유효기간
		/// </summary>
		[Column("유효기간")]
		public string ValidPeriod { get; set; }
		/// <summary>
		/// 승인번호
		/// </summary>
		[Column("승인번호")]
		public string ApprovalNumber { get; set; }
		/// <summary>
		/// 승인일자
		/// </summary>
		[Column("승인일자")]
		public string ApprovalDate { get; set; }
		/// <summary>
		/// 가격
		/// </summary>
		[Column("가격")]
		public int Price { get; set; }
		/// <summary>
		/// 할부
		/// </summary>
		[Column("할부")]
		public string Installment { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 응답메시지
		/// </summary>
		[Column("응답메시지")]
		public string RespondMessage { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 항공사코드
		/// </summary>
		[Column("항공사코드")]
		public string AirlineCode { get; set; }
	}
}