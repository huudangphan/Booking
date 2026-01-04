namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_인센티브마스터_예약분배
/// </summary>
public class WSP_S_IncentiveMaster_ReservationDevision
{
	public const string SP_NAME = "WSP_S_인센티브마스터_예약분배";

	public class Result : IDbResult
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public string CustomerNumber { get; set; }
	}
}