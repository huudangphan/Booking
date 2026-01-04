namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_공항철도_티켓내역
/// </summary>
public class WSP_S_CMN_AirportRailway_TicketHistory
{
	public const string SP_NAME = "WSP_S_CMN_공항철도_티켓내역";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 티켓번호
		/// </summary>
		[Column("티켓번호")]
		public string TicketNumber { get; set; }
		/// <summary>
		/// 유효일자
		/// </summary>
		[Column("유효일자")]
		public string ValidDate { get; set; }
	}
}