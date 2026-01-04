namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_CTE_상품_웹지역_테마_관계
/// </summary>
public class WSP_S_CMN_CTE_Product_WebRegion_Theme_Relationship
{
	public const string SP_NAME = "WSP_S_CMN_CTE_상품_웹지역_테마_관계";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// HiddenYN
		/// </summary>
		[Description("HiddenYN")]
		public string HiddenYN { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 상위일련번호
		/// </summary>
		[Column("상위일련번호")]
		public int HighRankSerialNumber { get; set; }
		/// <summary>
		/// 명칭
		/// </summary>
		[Column("명칭")]
		public string Name { get; set; }
		/// <summary>
		/// 서브메인
		/// </summary>
		[Column("서브메인")]
		public string SubMain { get; set; }
		/// <summary>
		/// 숨김
		/// </summary>
		[Column("숨김")]
		public string Hide { get; set; }
		/// <summary>
		/// LEVEL
		/// </summary>
		[Column("LEVEL")]
		public int LEVEL { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public string SORT { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 대륙
		/// </summary>
		[Column("대륙")]
		public string Continent { get; set; }
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