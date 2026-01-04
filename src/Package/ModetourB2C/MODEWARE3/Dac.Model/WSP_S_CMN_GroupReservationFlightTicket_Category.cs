namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_공동구매항공권_카테고리
/// </summary>
public class WSP_S_CMN_GroupReservationFlightTicket_Category
{
	public const string SP_NAME = "WSP_S_CMN_공동구매항공권_카테고리";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// addMonth
		/// </summary>
		[Description("addMonth")]
		public int addMonth { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 출발도시
		/// </summary>
		[Column("출발도시")]
		public string DepartureCity { get; set; }
		/// <summary>
		/// 지역코드
		/// </summary>
		[Column("지역코드")]
		public string RegionCode { get; set; }
		/// <summary>
		/// 지역명
		/// </summary>
		[Column("지역명")]
		public string RegionName { get; set; }
		/// <summary>
		/// 분류_지역코드
		/// </summary>
		[Column("분류_지역코드")]
		public string Classification_RegionCode { get; set; }
		/// <summary>
		/// 분류_지역명
		/// </summary>
		[Column("분류_지역명")]
		public string Classification_RegionName { get; set; }
		/// <summary>
		/// 도착지코드
		/// </summary>
		[Column("도착지코드")]
		public string ArrivalsCode { get; set; }
		/// <summary>
		/// 도착지
		/// </summary>
		[Column("도착지")]
		public string Arrivals { get; set; }
		/// <summary>
		/// 국가명_한글
		/// </summary>
		[Column("국가명_한글")]
		public string CountryName_Korean { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
		/// <summary>
		/// 상품수
		/// </summary>
		[Column("상품수")]
		public int ProductNumber { get; set; }
		/// <summary>
		/// 최소출발일
		/// </summary>
		[Column("최소출발일")]
		public DateTime MinimumDepartureDate { get; set; }
		/// <summary>
		/// 지역번호
		/// </summary>
		[Column("지역번호")]
		public int RegionNumber { get; set; }
	}
}