namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_이벤트경품_클럽메드제외
/// </summary>
public class WSP_S_EventGiveaway_ClubMedException
{
	public const string SP_NAME = "WSP_S_이벤트경품_클럽메드제외";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public string OrderNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 기간
		/// </summary>
		[Column("기간")]
		public string Period { get; set; }
	}
}