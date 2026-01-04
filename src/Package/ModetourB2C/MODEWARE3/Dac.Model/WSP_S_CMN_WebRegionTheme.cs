namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_웹지역테마
/// </summary>
public class WSP_S_CMN_WebRegionTheme
{
	public const string SP_NAME = "WSP_S_CMN_웹지역테마";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Gubun
		/// </summary>
		[Description("Gubun")]
		public string Gubun { get; set; }
		/// <summary>
		/// Code
		/// </summary>
		[Description("Code")]
		public int Code { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 테마번호
		/// </summary>
		[Column("테마번호")]
		public int ThemeNumber { get; set; }
		/// <summary>
		/// 상위테마번호
		/// </summary>
		[Column("상위테마번호")]
		public int HighRankThemeNumber { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// 테마명
		/// </summary>
		[Column("테마명")]
		public string ThemeName { get; set; }
		/// <summary>
		/// 서브메인
		/// </summary>
		[Column("서브메인")]
		public string SubMain { get; set; }
		/// <summary>
		/// 숨김
		/// </summary>
		[Column("숨김")]
		public string Hide { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 지역번호
		/// </summary>
		[Column("지역번호")]
		public int RegionNumber { get; set; }
		/// <summary>
		/// 상위지역번호
		/// </summary>
		[Column("상위지역번호")]
		public int HighRankRegionNumber { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// 지역명
		/// </summary>
		[Column("지역명")]
		public string RegionName { get; set; }
		/// <summary>
		/// 서브메인
		/// </summary>
		[Column("서브메인")]
		public string SubMain { get; set; }
		/// <summary>
		/// 숨김
		/// </summary>
		[Column("숨김")]
		public string Hide { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
		/// <summary>
		/// 약어
		/// </summary>
		[Column("약어")]
		public string Abbreviation { get; set; }
		/// <summary>
		/// PATH
		/// </summary>
		[Column("PATH")]
		public string PATH { get; set; }
	}
}