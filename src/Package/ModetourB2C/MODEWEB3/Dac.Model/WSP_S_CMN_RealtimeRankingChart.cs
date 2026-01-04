namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_실시간랭킹차트
/// </summary>
public class WSP_S_CMN_RealtimeRankingChart
{
	public const string SP_NAME = "WSP_S_CMN_실시간랭킹차트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 날짜1
		/// </summary>
		[Description("날짜1")]
		public string Date1 { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 랭킹일련번호
		/// </summary>
		[Column("랭킹일련번호")]
		public int RankingSerialNumber { get; set; }
		/// <summary>
		/// 상위지역번호
		/// </summary>
		[Column("상위지역번호")]
		public int HighRankRegionNumber { get; set; }
		/// <summary>
		/// Depth2AreaName
		/// </summary>
		[Column("Depth2AreaName")]
		public string Depth2AreaName { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 순위
		/// </summary>
		[Column("순위")]
		public int Ranking { get; set; }
		/// <summary>
		/// 모객
		/// </summary>
		[Column("모객")]
		public int Audience { get; set; }
		/// <summary>
		/// 최저가
		/// </summary>
		[Column("최저가")]
		public int LowestPrice { get; set; }
		/// <summary>
		/// 반영일자
		/// </summary>
		[Column("반영일자")]
		public DateTime ReflectDate { get; set; }
		/// <summary>
		/// 이전순위
		/// </summary>
		[Column("이전순위")]
		public int PreviousRanking { get; set; }
		/// <summary>
		/// 당일회차
		/// </summary>
		[Column("당일회차")]
		public int TodayEpisode { get; set; }
	}
}