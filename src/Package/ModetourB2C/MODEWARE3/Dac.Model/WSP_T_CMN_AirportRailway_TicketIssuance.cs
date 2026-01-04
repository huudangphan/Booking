namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_공항철도_티켓발급
/// </summary>
public class WSP_T_CMN_AirportRailway_TicketIssuance
{
	public const string SP_NAME = "WSP_T_CMN_공항철도_티켓발급";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
	}

}