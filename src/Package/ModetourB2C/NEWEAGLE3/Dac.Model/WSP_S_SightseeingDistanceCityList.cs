namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_관광거리도시리스트
/// </summary>
public class WSP_S_SightseeingDistanceCityList
{
	public const string SP_NAME = "WSP_S_관광거리도시리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 한글명
		/// </summary>
		[Description("한글명")]
		public string KoreanName { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
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
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
	}
}