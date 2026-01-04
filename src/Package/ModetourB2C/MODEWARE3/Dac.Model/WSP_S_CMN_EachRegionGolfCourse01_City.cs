namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_지역별골프장01_도시
/// </summary>
public class WSP_S_CMN_EachRegionGolfCourse01_City
{
	public const string SP_NAME = "WSP_S_CMN_지역별골프장01_도시";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 국가번호
		/// </summary>
		[Description("국가번호")]
		public string CountryNumber { get; set; }
	}

	public class Result : IDbResult
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