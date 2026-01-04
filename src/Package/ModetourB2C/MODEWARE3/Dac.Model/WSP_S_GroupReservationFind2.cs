namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_단체예약조회2
/// </summary>
public class WSP_S_GroupReservationFind2
{
	public const string SP_NAME = "WSP_S_단체예약조회2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Description("주민번호")]
		public string CitizenIDNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
	}
}