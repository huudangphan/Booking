namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_WEMODE_여행지역
/// </summary>
public class WSP_S_CMN_WEMODE_TravelRegion
{
	public const string SP_NAME = "WSP_S_CMN_WEMODE_여행지역";

	public class Result : IDbResult
	{
		/// <summary>
		/// 경로코드
		/// </summary>
		[Column("경로코드")]
		public string RouteCode { get; set; }
		/// <summary>
		/// 경로명
		/// </summary>
		[Column("경로명")]
		public string RouteName { get; set; }
		/// <summary>
		/// 웹페이지번호
		/// </summary>
		[Column("웹페이지번호")]
		public string WebPageNumber { get; set; }
	}
}