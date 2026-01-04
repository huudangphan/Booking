namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_유료센딩예약
/// </summary>
public class WSP_T_CMN_FeeChargedSendingReservation
{
	public const string SP_NAME = "WSP_T_CMN_유료센딩예약";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 출발편명
		/// </summary>
		[Description("출발편명")]
		public string DepartureFlightName { get; set; }
		/// <summary>
		/// 출발시간
		/// </summary>
		[Description("출발시간")]
		public string DepartureTime { get; set; }
		/// <summary>
		/// 고객요청사항
		/// </summary>
		[Description("고객요청사항")]
		public string CustomerRequest { get; set; }
		/// <summary>
		/// 유료센딩여부
		/// </summary>
		[Description("유료센딩여부")]
		public string FeeChargedSendingOrNot { get; set; }
	}

}