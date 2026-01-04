namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_지역별골프장01
/// </summary>
public class WSP_S_EachRegionGolfCourse01
{
	public const string SP_NAME = "WSP_S_지역별골프장01";

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 지역2
		/// </summary>
		[Column("지역2")]
		public string Region2 { get; set; }
		/// <summary>
		/// 국가번호
		/// </summary>
		[Column("국가번호")]
		public int CountryNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 지역3
		/// </summary>
		[Column("지역3")]
		public string Region3 { get; set; }
		/// <summary>
		/// 국가번호
		/// </summary>
		[Column("국가번호")]
		public int CountryNumber { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
	}
}