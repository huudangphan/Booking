namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_아이템예약_해외항공_재발행_발권요청
/// </summary>
public class WSV_T_ItemReservation_OverseaFlight_RePublish_TicketIssuanceRequest
{
	public const string SP_NAME = "WSV_T_아이템예약_해외항공_재발행_발권요청";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 요청자
		/// </summary>
		[Description("요청자")]
		public int Requester { get; set; }
		/// <summary>
		/// 요청자IP
		/// </summary>
		[Description("요청자IP")]
		public string Requester_IP { get; set; }
		/// <summary>
		/// 발권요청번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("발권요청번호")]
		public int TicketIssuanceRequestNumber { get; set; }
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
		/// 발권요청번호
		/// </summary>
		[Column("발권요청번호")]
		public int TicketIssuanceRequestNumber { get; set; }
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