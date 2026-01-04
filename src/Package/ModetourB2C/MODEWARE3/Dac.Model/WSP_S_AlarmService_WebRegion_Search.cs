namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_알림서비스_웹지역_검색
/// </summary>
public class WSP_S_AlarmService_WebRegion_Search
{
	public const string SP_NAME = "WSP_S_알림서비스_웹지역_검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지역명
		/// </summary>
		[Description("지역명")]
		public string RegionName { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 소분류_지역번호
		/// </summary>
		[Column("소분류_지역번호")]
		public int SubClassification_RegionNumber { get; set; }
		/// <summary>
		/// 소분류_상위지역번호
		/// </summary>
		[Column("소분류_상위지역번호")]
		public int SubClassification_HighRankRegionNumber { get; set; }
		/// <summary>
		/// 소분류_지역명
		/// </summary>
		[Column("소분류_지역명")]
		public string SubClassification_RegionName { get; set; }
	}
}