namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// USP_S_철도패스_자주찾는구간
/// </summary>
public class USP_S_RailwayPASS_BookmarkCity2
{
	public const string SP_NAME = "USP_S_철도패스_자주찾는구간";

	public class Result : IDbResult
	{
		/// <summary>
		/// 선택
		/// </summary>
		[Column("선택")]
		public string Select { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 출발도시번호
		/// </summary>
		[Column("출발도시번호")]
		public int DepartureCityNumber { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// 도착도시번호
		/// </summary>
		[Column("도착도시번호")]
		public int ArrivalCityNumber { get; set; }
		/// <summary>
		/// 도착지
		/// </summary>
		[Column("도착지")]
		public string Arrivals { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public string RegisterDate { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public string Registerer { get; set; }
	}
}