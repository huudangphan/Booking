namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_공동구매항공권_도시별_최저가
/// </summary>
public class WSP_S_CMN_GroupReservationFlightTicket_EachCity_LowestPrice
{
	public const string SP_NAME = "WSP_S_CMN_공동구매항공권_도시별_최저가";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 출발도시
		/// </summary>
		[Description("출발도시")]
		public string DepartureCity { get; set; }
		/// <summary>
		/// 대륙코드
		/// </summary>
		[Description("대륙코드")]
		public string ContinentCode { get; set; }
		/// <summary>
		/// 도착도시
		/// </summary>
		[Description("도착도시")]
		public string ArrivalCity { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 정상요금
		/// </summary>
		[Column("정상요금")]
		public int NormalFare { get; set; }
		/// <summary>
		/// 성인요금
		/// </summary>
		[Column("성인요금")]
		public int AdultFare { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
	}
}