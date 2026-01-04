namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_아이템예약_해외항공_환불요청_주문
/// </summary>
public class WSV_T_ItemReservation_OverseaFlight_RefundRequest_Order
{
	public const string SP_NAME = "WSV_T_아이템예약_해외항공_환불요청_주문";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public string SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 요청자
		/// </summary>
		[Description("요청자")]
		public int Requester { get; set; }
		/// <summary>
		/// 요청단말기
		/// </summary>
		[Description("요청단말기")]
		public string RequestTerminal { get; set; }
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

	public class Result : IDbResult
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[Column("결과")]
		public string RESULT { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[Column("에러메시지")]
		public string ErrorMessage { get; set; }
	}
}