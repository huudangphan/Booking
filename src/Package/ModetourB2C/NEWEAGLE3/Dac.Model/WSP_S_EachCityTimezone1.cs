namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_도시별시차1
/// </summary>
public class WSP_S_EachCityTimezone1
{
	public const string SP_NAME = "WSP_S_도시별시차1";

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
		/// SORT
		/// </summary>
		[Column("SORT")]
		public string SORT { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
	}
}