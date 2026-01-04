namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_항공예약_발권
/// </summary>
public class WSV_T_FlightReservation_TicketIssuance
{
	public const string SP_NAME = "WSV_T_항공예약_발권";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 발권
		/// </summary>
		[Description("발권")]
		public string TicketIssuance { get; set; }
		/// <summary>
		/// 결제금액
		/// </summary>
		[Description("결제금액")]
		public int PaymentAmount { get; set; }
		/// <summary>
		/// 수정경로
		/// </summary>
		[Description("수정경로")]
		public string EditionRoute { get; set; }
	}

}