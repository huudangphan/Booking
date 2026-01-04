namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_공동구매항공권규정
/// </summary>
public class USP_S_GroupReservationFlightTicketRegulations
{
	public const string SP_NAME = "USP_S_공동구매항공권규정";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 재고번호
		/// </summary>
		[Description("재고번호")]
		public int StockNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 규정명
		/// </summary>
		[Column("규정명")]
		public string RegulationsName { get; set; }
		/// <summary>
		/// 규정비고
		/// </summary>
		[Column("규정비고")]
		public string RegulationsNote { get; set; }
	}
}