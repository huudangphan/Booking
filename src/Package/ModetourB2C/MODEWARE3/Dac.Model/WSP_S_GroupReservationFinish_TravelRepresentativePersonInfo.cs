namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_단체예약완료_여행대표자정보
/// </summary>
public class WSP_S_GroupReservationFinish_TravelRepresentativePersonInfo
{
	public const string SP_NAME = "WSP_S_단체예약완료_여행대표자정보";

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
		/// 여행자대표
		/// </summary>
		[Column("여행자대표")]
		public string TravelerRepresentative { get; set; }
	}
}