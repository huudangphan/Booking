namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_도시별_날씨WITH시차
/// </summary>
public class WSP_S_EachCity_Weather_WITH_Timezone
{
	public const string SP_NAME = "WSP_S_도시별_날씨WITH시차";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 도시리스트
		/// </summary>
		[Description("도시리스트")]
		public string CityList { get; set; }
		/// <summary>
		/// 도시코드
		/// </summary>
		[Description("도시코드")]
		public string CityCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 영문명
		/// </summary>
		[Column("영문명")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 날짜
		/// </summary>
		[Column("날짜")]
		public string Date { get; set; }
		/// <summary>
		/// 날씨이미지
		/// </summary>
		[Column("날씨이미지")]
		public short WeatherImage { get; set; }
		/// <summary>
		/// 날씨텍스트
		/// </summary>
		[Column("날씨텍스트")]
		public string WeatherText { get; set; }
		/// <summary>
		/// 최저기온
		/// </summary>
		[Column("최저기온")]
		public decimal LowestTemperature { get; set; }
		/// <summary>
		/// 최대기온
		/// </summary>
		[Column("최대기온")]
		public decimal MaximumTemperature { get; set; }
		/// <summary>
		/// 도시장소번호
		/// </summary>
		[Column("도시장소번호")]
		public int CityPlaceNumber { get; set; }
		/// <summary>
		/// 도시한글이름
		/// </summary>
		[Column("도시한글이름")]
		public string CityKoreanName { get; set; }
		/// <summary>
		/// 국가장소번호
		/// </summary>
		[Column("국가장소번호")]
		public int CountryPlaceNumber { get; set; }
		/// <summary>
		/// 국가한글이름
		/// </summary>
		[Column("국가한글이름")]
		public string CountryKoreanName { get; set; }
		/// <summary>
		/// 대륙장소번호
		/// </summary>
		[Column("대륙장소번호")]
		public int ContinentPlaceNumber { get; set; }
		/// <summary>
		/// INFOTYPE번호
		/// </summary>
		[Column("INFOTYPE번호")]
		public int INFOTYPE_Number { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
	}
}