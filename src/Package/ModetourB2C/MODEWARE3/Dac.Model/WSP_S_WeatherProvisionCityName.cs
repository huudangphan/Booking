namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_날씨제공도시명
/// </summary>
public class WSP_S_WeatherProvisionCityName
{
	public const string SP_NAME = "WSP_S_날씨제공도시명";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 도시코드
		/// </summary>
		[Description("도시코드")]
		public string CityCode { get; set; }
		/// <summary>
		/// 국가코드
		/// </summary>
		[Description("국가코드")]
		public int CountryCode { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 날씨영문명
		/// </summary>
		[Column("날씨영문명")]
		public string WeatherEnglishName { get; set; }
		/// <summary>
		/// 날씨도시코드
		/// </summary>
		[Column("날씨도시코드")]
		public int WeatherCityCode { get; set; }
		/// <summary>
		/// 국가_주_구분코드
		/// </summary>
		[Column("국가_주_구분코드")]
		public string Country_State_ClassificationCode { get; set; }
		/// <summary>
		/// 국가_주_한글명
		/// </summary>
		[Column("국가_주_한글명")]
		public string Country_State_KoreanName { get; set; }
		/// <summary>
		/// 국가_대륙_구분코드
		/// </summary>
		[Column("국가_대륙_구분코드")]
		public string Country_Continent_ClassificationCode { get; set; }
		/// <summary>
		/// 국가_대륙_한글명
		/// </summary>
		[Column("국가_대륙_한글명")]
		public string Country_Continent_KoreanName { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 영문명
		/// </summary>
		[Column("영문명")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 한글명
		/// </summary>
		[Column("한글명")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 날씨영문명
		/// </summary>
		[Column("날씨영문명")]
		public string WeatherEnglishName { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 좌표
		/// </summary>
		[Column("좌표")]
		public string Coordinate { get; set; }
		/// <summary>
		/// 날씨도시코드
		/// </summary>
		[Column("날씨도시코드")]
		public string WeatherCityCode { get; set; }
		/// <summary>
		/// 국가_주_구분코드
		/// </summary>
		[Column("국가_주_구분코드")]
		public string Country_State_ClassificationCode { get; set; }
		/// <summary>
		/// 국가_주_한글명
		/// </summary>
		[Column("국가_주_한글명")]
		public string Country_State_KoreanName { get; set; }
		/// <summary>
		/// 국가_대륙_구분코드
		/// </summary>
		[Column("국가_대륙_구분코드")]
		public string Country_Continent_ClassificationCode { get; set; }
		/// <summary>
		/// 국가_대륙_한글명
		/// </summary>
		[Column("국가_대륙_한글명")]
		public string Country_Continent_KoreanName { get; set; }
	}
}