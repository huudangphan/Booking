namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_날씨제공도시명_KWEATHER
/// </summary>
public class WSP_S_WeatherProvisionCityName_KWEATHER
{
	public const string SP_NAME = "WSP_S_날씨제공도시명_KWEATHER";

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
		/// 한글명
		/// </summary>
		[Column("한글명")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 전체명
		/// </summary>
		[Column("전체명")]
		public string EntireName { get; set; }
		/// <summary>
		/// code
		/// </summary>
		[Column("code")]
		public string code { get; set; }
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
		/// 전체명
		/// </summary>
		[Column("전체명")]
		public string EntireName { get; set; }
		/// <summary>
		/// code
		/// </summary>
		[Column("code")]
		public string code { get; set; }
	}
}