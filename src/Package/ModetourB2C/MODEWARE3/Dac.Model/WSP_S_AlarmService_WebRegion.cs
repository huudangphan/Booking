namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_알림서비스_웹지역
/// </summary>
public class WSP_S_AlarmService_WebRegion
{
	public const string SP_NAME = "WSP_S_알림서비스_웹지역";

	public class Result : IDbResult
	{
		/// <summary>
		/// 대분류_지역번호
		/// </summary>
		[Column("대분류_지역번호")]
		public int MajorClassification_RegionNumber { get; set; }
		/// <summary>
		/// 대분류_상위지역번호
		/// </summary>
		[Column("대분류_상위지역번호")]
		public int MajorClassification_HighRankRegionNumber { get; set; }
		/// <summary>
		/// 대분류_지역명
		/// </summary>
		[Column("대분류_지역명")]
		public string MajorClassification_RegionName { get; set; }
		/// <summary>
		/// 중분류_지역번호
		/// </summary>
		[Column("중분류_지역번호")]
		public int MiddleClassification_RegionNumber { get; set; }
		/// <summary>
		/// 중분류_상위지역번호
		/// </summary>
		[Column("중분류_상위지역번호")]
		public int MiddleClassification_HighRankRegionNumber { get; set; }
		/// <summary>
		/// 중분류_지역명
		/// </summary>
		[Column("중분류_지역명")]
		public string MiddleClassification_RegionName { get; set; }
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