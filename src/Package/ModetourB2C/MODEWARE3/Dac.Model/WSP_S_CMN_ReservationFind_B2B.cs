namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_예약조회_B2B
/// </summary>
public class WSP_S_CMN_ReservationFind_B2B
{
	public const string SP_NAME = "WSP_S_CMN_예약조회_B2B";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// ORDERNO
		/// </summary>
		[Description("ORDERNO")]
		public int ORDERNO { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}
}