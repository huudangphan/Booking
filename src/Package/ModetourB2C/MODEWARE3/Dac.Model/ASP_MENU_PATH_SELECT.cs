namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_MENU_PATH_SELECT
/// </summary>
public class ASP_MENU_PATH_SELECT
{
	public const string SP_NAME = "ASP_MENU_PATH_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MENUCODE
		/// </summary>
		[Description("MENUCODE")]
		public string MENUCODE { get; set; }
		/// <summary>
		/// SPR_IDX
		/// </summary>
		[Description("SPR_IDX")]
		public int SPR_IDX { get; set; }
		/// <summary>
		/// PCODE
		/// </summary>
		[Description("PCODE")]
		public string PCODE { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// MW_MENU_PATH
		/// </summary>
		[Column("MW_MENU_PATH")]
		public string MW_MENU_PATH { get; set; }
		/// <summary>
		/// RLE_MENU_CODE
		/// </summary>
		[Column("RLE_MENU_CODE")]
		public string RLE_MENU_CODE { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// 상위지역번호
		/// </summary>
		[Column("상위지역번호")]
		public int HighRankRegionNumber { get; set; }
		/// <summary>
		/// 지역번호
		/// </summary>
		[Column("지역번호")]
		public int RegionNumber { get; set; }
		/// <summary>
		/// 지역명
		/// </summary>
		[Column("지역명")]
		public string RegionName { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
		/// <summary>
		/// 서브메인
		/// </summary>
		[Column("서브메인")]
		public string SubMain { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 테마번호
		/// </summary>
		[Column("테마번호")]
		public int ThemeNumber { get; set; }
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
	}
}