namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_날씨영문명리스트
/// </summary>
public class WSP_S_CMN_WeatherEnglishNameList
{
	public const string SP_NAME = "WSP_S_CMN_날씨영문명리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 날씨영문명
		/// </summary>
		[Description("날씨영문명")]
		public string WeatherEnglishName { get; set; }
		/// <summary>
		/// 예상일자
		/// </summary>
		[Description("예상일자")]
		public DateTime ExpectedDate { get; set; }
	}

	public class Result : IDbResult
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
}