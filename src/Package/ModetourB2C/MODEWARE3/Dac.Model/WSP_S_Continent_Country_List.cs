namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_대륙_국가_리스트
/// </summary>
public class WSP_S_Continent_Country_List
{
	public const string SP_NAME = "WSP_S_대륙_국가_리스트";

	public class Result : IDbResult
	{
		/// <summary>
		/// 대륙
		/// </summary>
		[Column("대륙")]
		public string Continent { get; set; }
		/// <summary>
		/// 대륙번호
		/// </summary>
		[Column("대륙번호")]
		public int ContinentNumber { get; set; }
		/// <summary>
		/// 국가
		/// </summary>
		[Column("국가")]
		public string Country { get; set; }
		/// <summary>
		/// 국가번호
		/// </summary>
		[Column("국가번호")]
		public int CountryNumber { get; set; }
	}
}