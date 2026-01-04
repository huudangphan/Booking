namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_KWEATHER
/// </summary>
public class WSP_S_KWEATHER
{
	public const string SP_NAME = "WSP_S_KWEATHER";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 날씨영문명
		/// </summary>
		[Description("날씨영문명")]
		public string WeatherEnglishName { get; set; }
		/// <summary>
		/// 예상일자
		/// </summary>
		[Description("예상일자")]
		public string ExpectedDate { get; set; }
	}

	public class Result1 : IDbResult
	{
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
	}

	public class Result2 : IDbResult
	{
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
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// PLKNAME
		/// </summary>
		[Column("PLKNAME")]
		public string PLKNAME { get; set; }
	}

	public class Result3 : IDbResult
	{
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
		/// 도시PLID
		/// </summary>
		[Column("도시PLID")]
		public int City_PLID { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public string PLID { get; set; }
		/// <summary>
		/// PLID2
		/// </summary>
		[Column("PLID2")]
		public string PLID2 { get; set; }
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
	}
}