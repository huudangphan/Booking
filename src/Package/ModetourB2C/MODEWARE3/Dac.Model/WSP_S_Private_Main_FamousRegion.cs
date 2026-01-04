namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_프라이빗_메인_인기지역
/// </summary>
public class WSP_S_Private_Main_FamousRegion
{
	public const string SP_NAME = "WSP_S_프라이빗_메인_인기지역";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 요청기준일
		/// </summary>
		[Description("요청기준일")]
		public DateTime RequestStandardDate { get; set; }
		/// <summary>
		/// 부서
		/// </summary>
		[Description("부서")]
		public int Department { get; set; }
		/// <summary>
		/// 담당자
		/// </summary>
		[Description("담당자")]
		public int Manager { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 대표도시
		/// </summary>
		[Column("대표도시")]
		public string RepresentativeCity { get; set; }
		/// <summary>
		/// 대표도시카운트
		/// </summary>
		[Column("대표도시카운트")]
		public int RepresentativeCityCount { get; set; }
		/// <summary>
		/// 순위
		/// </summary>
		[Column("순위")]
		public long Ranking { get; set; }
	}
}