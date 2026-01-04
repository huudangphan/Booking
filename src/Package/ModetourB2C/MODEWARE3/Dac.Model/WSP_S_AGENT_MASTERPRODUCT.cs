namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_AGENT_MASTERPRODUCT
/// </summary>
public class WSP_S_AGENT_MASTERPRODUCT
{
	public const string SP_NAME = "WSP_S_AGENT_MASTERPRODUCT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// SDATE
		/// </summary>
		[Description("SDATE")]
		public DateTime SDATE { get; set; }
		/// <summary>
		/// EDATE
		/// </summary>
		[Description("EDATE")]
		public DateTime EDATE { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 시작월
		/// </summary>
		[Column("시작월")]
		public int StartMonth { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// 상품분류
		/// </summary>
		[Column("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 상품분류명
		/// </summary>
		[Column("상품분류명")]
		public string ProductClassificationName { get; set; }
		/// <summary>
		/// 상품분류2
		/// </summary>
		[Column("상품분류2")]
		public string ProductClassification2 { get; set; }
		/// <summary>
		/// 상품분류명2
		/// </summary>
		[Column("상품분류명2")]
		public string ProductClassificationName2 { get; set; }
		/// <summary>
		/// 간략설명
		/// </summary>
		[Column("간략설명")]
		public string BriefDescription { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 출발공항코드
		/// </summary>
		[Column("출발공항코드")]
		public string DepartureAirportCode { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 최소출발일
		/// </summary>
		[Column("최소출발일")]
		public DateTime MinimumDepartureDate { get; set; }
		/// <summary>
		/// 최대출발일
		/// </summary>
		[Column("최대출발일")]
		public DateTime MaximumDepartureDate { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// P_PLID
		/// </summary>
		[Column("P_PLID")]
		public int P_PLID { get; set; }
		/// <summary>
		/// 대륙명
		/// </summary>
		[Column("대륙명")]
		public string ContinentName { get; set; }
		/// <summary>
		/// 국가명
		/// </summary>
		[Column("국가명")]
		public string CountryName { get; set; }
		/// <summary>
		/// 도시명
		/// </summary>
		[Column("도시명")]
		public string CityName { get; set; }
		/// <summary>
		/// 대륙코드
		/// </summary>
		[Column("대륙코드")]
		public string ContinentCode { get; set; }
		/// <summary>
		/// 국가코드
		/// </summary>
		[Column("국가코드")]
		public string CountryCode { get; set; }
		/// <summary>
		/// 도시코드
		/// </summary>
		[Column("도시코드")]
		public string CityCode { get; set; }
	}
}