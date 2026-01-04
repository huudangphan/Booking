namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_장소리스트
/// </summary>
public class WSP_S_PlaceList
{
	public const string SP_NAME = "WSP_S_장소리스트";

	public class Result : IDbResult
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// PLCODE
		/// </summary>
		[Column("PLCODE")]
		public string PLCODE { get; set; }
		/// <summary>
		/// PLKNAME
		/// </summary>
		[Column("PLKNAME")]
		public string PLKNAME { get; set; }
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
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
	}
}