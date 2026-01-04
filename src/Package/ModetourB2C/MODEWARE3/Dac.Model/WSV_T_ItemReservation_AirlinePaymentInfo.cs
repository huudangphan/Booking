namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_아이템예약_항공사결제정보
/// </summary>
public class WSV_T_ItemReservation_AirlinePaymentInfo
{
	public const string SP_NAME = "WSV_T_아이템예약_항공사결제정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 주문아이템번호
		/// </summary>
		[Description("주문아이템번호")]
		public int OrderItemNumber { get; set; }
		/// <summary>
		/// 품목코드
		/// </summary>
		[Description("품목코드")]
		public string ProductListCode { get; set; }
		/// <summary>
		/// GDS코드
		/// </summary>
		[Description("GDS코드")]
		public string GDS_Code { get; set; }
		/// <summary>
		/// GDS주문번호
		/// </summary>
		[Description("GDS주문번호")]
		public string GDS_OrderNumber { get; set; }
		/// <summary>
		/// 카드사명
		/// </summary>
		[Description("카드사명")]
		public string CardCompanyName { get; set; }
		/// <summary>
		/// 승인번호
		/// </summary>
		[Description("승인번호")]
		public string ApprovalNumber { get; set; }
		/// <summary>
		/// 승인일자
		/// </summary>
		[Description("승인일자")]
		public string ApprovalDate { get; set; }
		/// <summary>
		/// 가격
		/// </summary>
		[Description("가격")]
		public int Price { get; set; }
		/// <summary>
		/// 할부
		/// </summary>
		[Description("할부")]
		public string Installment { get; set; }
		/// <summary>
		/// 카드코드
		/// </summary>
		[Description("카드코드")]
		public string CardCode { get; set; }
		/// <summary>
		/// SESSIONKEY
		/// </summary>
		[Description("SESSIONKEY")]
		public string SESSIONKEY { get; set; }
		/// <summary>
		/// ENCDATA
		/// </summary>
		[Description("ENCDATA")]
		public string ENCDATA { get; set; }
		/// <summary>
		/// KVPCODE
		/// </summary>
		[Description("KVPCODE")]
		public string KVPCODE { get; set; }
		/// <summary>
		/// 주문아이템코드
		/// </summary>
		[Description("주문아이템코드")]
		public string OrderItemCode { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Description("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 응답메시지
		/// </summary>
		[Description("응답메시지")]
		public string RespondMessage { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 카드종류
		/// </summary>
		[Description("카드종류")]
		public string CardType { get; set; }
		/// <summary>
		/// 카드번호
		/// </summary>
		[Description("카드번호")]
		public string CardNumber { get; set; }
		/// <summary>
		/// 유효기간
		/// </summary>
		[Description("유효기간")]
		public string ValidPeriod { get; set; }
		/// <summary>
		/// 항공사코드
		/// </summary>
		[Description("항공사코드")]
		public string AirlineCode { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("일련번호")]
		public int SerialNumber { get; set; }
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

}