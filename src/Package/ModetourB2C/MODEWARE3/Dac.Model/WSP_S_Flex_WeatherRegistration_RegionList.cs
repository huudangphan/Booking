namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_플렉스_날씨등록_지역리스트
/// </summary>
public class WSP_S_Flex_WeatherRegistration_RegionList
{
	public const string SP_NAME = "WSP_S_플렉스_날씨등록_지역리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// PLCODE
		/// </summary>
		[Description("PLCODE")]
		public string PLCODE { get; set; }
		/// <summary>
		/// GUBUN
		/// </summary>
		[Description("GUBUN")]
		public string GUBUN { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 한글명
		/// </summary>
		[Column("한글명")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문명
		/// </summary>
		[Column("영문명")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 날씨영문명
		/// </summary>
		[Column("날씨영문명")]
		public string WeatherEnglishName { get; set; }
		/// <summary>
		/// 지역번호
		/// </summary>
		[Column("지역번호")]
		public int RegionNumber { get; set; }
		/// <summary>
		/// 좌표
		/// </summary>
		[Column("좌표")]
		public string Coordinate { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
		/// <summary>
		/// 날씨도시코드
		/// </summary>
		[Column("날씨도시코드")]
		public string WeatherCityCode { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 한글명
		/// </summary>
		[Column("한글명")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문명
		/// </summary>
		[Column("영문명")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 날씨영문명
		/// </summary>
		[Column("날씨영문명")]
		public string WeatherEnglishName { get; set; }
		/// <summary>
		/// 지역번호
		/// </summary>
		[Column("지역번호")]
		public int RegionNumber { get; set; }
		/// <summary>
		/// 좌표
		/// </summary>
		[Column("좌표")]
		public string Coordinate { get; set; }
		/// <summary>
		/// PLCODE
		/// </summary>
		[Column("PLCODE")]
		public string PLCODE { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
		/// <summary>
		/// 날씨도시코드
		/// </summary>
		[Column("날씨도시코드")]
		public string WeatherCityCode { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 지역번호
		/// </summary>
		[Column("지역번호")]
		public int RegionNumber { get; set; }
		/// <summary>
		/// 시차
		/// </summary>
		[Column("시차")]
		public string TimeDifference { get; set; }
	}
}