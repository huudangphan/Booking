namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_테마_출발지별_도시검색리스트
/// </summary>
public class WSP_S_CMN_Theme_EachDepartures_CitySearchList
{
	public const string SP_NAME = "WSP_S_CMN_테마_출발지별_도시검색리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 테마명
		/// </summary>
		[Description("테마명")]
		public string ThemeName { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 대륙
		/// </summary>
		[Column("대륙")]
		public string Continent { get; set; }
		/// <summary>
		/// 국가
		/// </summary>
		[Column("국가")]
		public string Country { get; set; }
		/// <summary>
		/// 도시
		/// </summary>
		[Column("도시")]
		public string City { get; set; }
		/// <summary>
		/// 시차
		/// </summary>
		[Column("시차")]
		public string TimeDifference { get; set; }
		/// <summary>
		/// 화폐
		/// </summary>
		[Column("화폐")]
		public string Currency { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
	}
}