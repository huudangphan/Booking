namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_BTMS_메인
/// </summary>
public class WSP_S_CMN_BTMS_Main
{
	public const string SP_NAME = "WSP_S_CMN_BTMS_메인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// NKANME
		/// </summary>
		[Column("NKANME")]
		public string NKANME { get; set; }
		/// <summary>
		/// CKANME
		/// </summary>
		[Column("CKANME")]
		public string CKANME { get; set; }
		/// <summary>
		/// REGDATE
		/// </summary>
		[Column("REGDATE")]
		public DateTime REGDATE { get; set; }
		/// <summary>
		/// 날씨영문명
		/// </summary>
		[Column("날씨영문명")]
		public string WeatherEnglishName { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// MoneyTitle
		/// </summary>
		[Column("MoneyTitle")]
		public string MoneyTitle { get; set; }
		/// <summary>
		/// MoneyKorTitle
		/// </summary>
		[Column("MoneyKorTitle")]
		public string MoneyKorTitle { get; set; }
		/// <summary>
		/// Unit
		/// </summary>
		[Column("Unit")]
		public int Unit { get; set; }
		/// <summary>
		/// ExchangeRate
		/// </summary>
		[Column("ExchangeRate")]
		public string ExchangeRate { get; set; }
		/// <summary>
		/// NAME
		/// </summary>
		[Column("NAME")]
		public string NAME { get; set; }
		/// <summary>
		/// WeatherImg
		/// </summary>
		[Column("WeatherImg")]
		public short WeatherImg { get; set; }
		/// <summary>
		/// WeatherText
		/// </summary>
		[Column("WeatherText")]
		public string WeatherText { get; set; }
		/// <summary>
		/// MinTemperature
		/// </summary>
		[Column("MinTemperature")]
		public decimal MinTemperature { get; set; }
		/// <summary>
		/// MaxTemperature
		/// </summary>
		[Column("MaxTemperature")]
		public decimal MaxTemperature { get; set; }
		/// <summary>
		/// WeatherDate
		/// </summary>
		[Column("WeatherDate")]
		public string WeatherDate { get; set; }
		/// <summary>
		/// 영문명
		/// </summary>
		[Column("영문명")]
		public string EnglishName { get; set; }
	}
}