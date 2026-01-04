namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_추천리조트국가도시_리스트
/// </summary>
public class WSP_S_CMN_RecommendResortCountryCity_List
{
	public const string SP_NAME = "WSP_S_CMN_추천리조트국가도시_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 대륙번호
		/// </summary>
		[Description("대륙번호")]
		public string ContinentNumber { get; set; }
		/// <summary>
		/// 국가번호
		/// </summary>
		[Description("국가번호")]
		public string CountryNumber { get; set; }
		/// <summary>
		/// 타입
		/// </summary>
		[Description("타입")]
		public string Type { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 지역코드
		/// </summary>
		[Column("지역코드")]
		public int RegionCode { get; set; }
		/// <summary>
		/// 지역명
		/// </summary>
		[Column("지역명")]
		public string RegionName { get; set; }
		/// <summary>
		/// 국가코드
		/// </summary>
		[Column("국가코드")]
		public int CountryCode { get; set; }
		/// <summary>
		/// 국가명
		/// </summary>
		[Column("국가명")]
		public string CountryName { get; set; }
		/// <summary>
		/// 도시코드
		/// </summary>
		[Column("도시코드")]
		public int CityCode { get; set; }
		/// <summary>
		/// 도시명
		/// </summary>
		[Column("도시명")]
		public string CityName { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 국가번호
		/// </summary>
		[Column("국가번호")]
		public int CountryNumber { get; set; }
		/// <summary>
		/// 국가명
		/// </summary>
		[Column("국가명")]
		public string CountryName { get; set; }
	}
}