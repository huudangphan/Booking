namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_지역별골프장
/// </summary>
public class WSP_S_EachRegionGolfCourse
{
	public const string SP_NAME = "WSP_S_지역별골프장";

	public class Result : IDbResult
	{
		/// <summary>
		/// 골프장번호
		/// </summary>
		[Column("골프장번호")]
		public int GolfCourseNumber { get; set; }
		/// <summary>
		/// 골프장명
		/// </summary>
		[Column("골프장명")]
		public string GolfCourseName { get; set; }
		/// <summary>
		/// 지역2
		/// </summary>
		[Column("지역2")]
		public string Region2 { get; set; }
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