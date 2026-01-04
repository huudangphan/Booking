namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_국가별시차
/// </summary>
public class WSP_S_CMN_EachCountryTimezone
{
	public const string SP_NAME = "WSP_S_CMN_국가별시차";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 대륙번호
		/// </summary>
		[Description("대륙번호")]
		public int ContinentNumber { get; set; }
		/// <summary>
		/// 국가번호
		/// </summary>
		[Description("국가번호")]
		public string CountryNumber { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Description("도시번호")]
		public string CityNumber { get; set; }
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
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public string SORT { get; set; }
		/// <summary>
		/// PLID1
		/// </summary>
		[Column("PLID1")]
		public int PLID1 { get; set; }
		/// <summary>
		/// PLID2
		/// </summary>
		[Column("PLID2")]
		public int PLID2 { get; set; }
		/// <summary>
		/// PLID3
		/// </summary>
		[Column("PLID3")]
		public int PLID3 { get; set; }
	}
}