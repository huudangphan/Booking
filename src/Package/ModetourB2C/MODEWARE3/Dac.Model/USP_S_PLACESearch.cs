namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_PLACE검색
/// </summary>
public class USP_S_PLACESearch
{
	public const string SP_NAME = "USP_S_PLACE검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상위PLID
		/// </summary>
		[Description("상위PLID")]
		public int HighRank_PLID { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Description("사용여부")]
		public string UseOrNot { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 한글명
		/// </summary>
		[Column("한글명")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문명
		/// </summary>
		[Column("영문명")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 레벨
		/// </summary>
		[Column("레벨")]
		public byte Level { get; set; }
		/// <summary>
		/// CHILD
		/// </summary>
		[Column("CHILD")]
		public int CHILD { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// P_PLID
		/// </summary>
		[Column("P_PLID")]
		public int P_PLID { get; set; }
		/// <summary>
		/// 선택
		/// </summary>
		[Column("선택")]
		public string Select { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
		/// <summary>
		/// 도시코드
		/// </summary>
		[Column("도시코드")]
		public string CityCode { get; set; }
		/// <summary>
		/// 컨텐츠갯수
		/// </summary>
		[Column("컨텐츠갯수")]
		public int ContentNumber { get; set; }
		/// <summary>
		/// 컨텐츠갯수_하위포함
		/// </summary>
		[Column("컨텐츠갯수_하위포함")]
		public int ContentNumber_LowRankIncluded { get; set; }
		/// <summary>
		/// 미등록컨텐츠갯수
		/// </summary>
		[Column("미등록컨텐츠갯수")]
		public int UnregisterContentNumber { get; set; }
		/// <summary>
		/// 미등록컨텐츠갯수_하위포함
		/// </summary>
		[Column("미등록컨텐츠갯수_하위포함")]
		public int UnregisterContentNumber_LowRankIncluded { get; set; }
		/// <summary>
		/// PLACE_경로
		/// </summary>
		[Column("PLACE_경로")]
		public string PLACE_Route { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
		/// <summary>
		/// 장소한글명
		/// </summary>
		[Column("장소한글명")]
		public string PlaceKoreanName { get; set; }
	}
}