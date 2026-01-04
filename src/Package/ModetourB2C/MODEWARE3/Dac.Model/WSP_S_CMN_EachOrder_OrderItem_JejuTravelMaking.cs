namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_주문별_주문아이템_제주여행만들기
/// </summary>
public class WSP_S_CMN_EachOrder_OrderItem_JejuTravelMaking
{
	public const string SP_NAME = "WSP_S_CMN_주문별_주문아이템_제주여행만들기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 여행경비
		/// </summary>
		[Column("여행경비")]
		public long TravelExpense { get; set; }
	}
}