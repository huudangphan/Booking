namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// USP_S_철도패스_자주찾는도시
/// </summary>
public class USP_S_RailwayPASS_BookmarkCity
{
	public const string SP_NAME = "USP_S_철도패스_자주찾는도시";

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 도시명K
		/// </summary>
		[Column("도시명K")]
		public string CityName_K { get; set; }
		/// <summary>
		/// 도시명
		/// </summary>
		[Column("도시명")]
		public string CityName { get; set; }
		/// <summary>
		/// 국가명
		/// </summary>
		[Column("국가명")]
		public string CountryName { get; set; }
		/// <summary>
		/// 국가명K
		/// </summary>
		[Column("국가명K")]
		public string CountryName_K { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public string RegisterDate { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public string Registerer { get; set; }
	}
}