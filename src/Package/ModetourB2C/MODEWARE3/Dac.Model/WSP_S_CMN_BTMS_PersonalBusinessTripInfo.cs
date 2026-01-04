namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_BTMS_개인출장정보
/// </summary>
public class WSP_S_CMN_BTMS_PersonalBusinessTripInfo
{
	public const string SP_NAME = "WSP_S_CMN_BTMS_개인출장정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 세부번호
		/// </summary>
		[Description("세부번호")]
		public int DetailNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 세부번호
		/// </summary>
		[Column("세부번호")]
		public int DetailNumber { get; set; }
		/// <summary>
		/// 요청구분
		/// </summary>
		[Column("요청구분")]
		public string RequestClassification { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public DateTime ArrivalDate { get; set; }
		/// <summary>
		/// 인원
		/// </summary>
		[Column("인원")]
		public int NumberOfPeople { get; set; }
		/// <summary>
		/// 신청자
		/// </summary>
		[Column("신청자")]
		public string Requester { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// 도착지
		/// </summary>
		[Column("도착지")]
		public string Arrivals { get; set; }
	}
}