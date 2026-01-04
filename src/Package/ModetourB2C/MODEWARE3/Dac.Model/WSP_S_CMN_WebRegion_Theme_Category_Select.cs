namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_웹지역_테마_카테고리_선택
/// </summary>
public class WSP_S_CMN_WebRegion_Theme_Category_Select
{
	public const string SP_NAME = "WSP_S_CMN_웹지역_테마_카테고리_선택";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 웹지역번호
		/// </summary>
		[Description("웹지역번호")]
		public int WebRegionNumber { get; set; }
		/// <summary>
		/// 웹테마번호
		/// </summary>
		[Description("웹테마번호")]
		public int WebThemeNumber { get; set; }
		/// <summary>
		/// 웹지역번호리스트
		/// </summary>
		[Description("웹지역번호리스트")]
		public string WebRegionNumberList { get; set; }
		/// <summary>
		/// 웹테마번호리스트
		/// </summary>
		[Description("웹테마번호리스트")]
		public string WebThemeNumberList { get; set; }
		/// <summary>
		/// 결과TYPE
		/// </summary>
		[Description("결과TYPE")]
		public string Result_TYPE { get; set; }
		/// <summary>
		/// 숨김여부
		/// </summary>
		[Description("숨김여부")]
		public string HideOrNot { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 웹지역_테마번호
		/// </summary>
		[Column("웹지역_테마번호")]
		public int WebRegion_ThemeNumber { get; set; }
		/// <summary>
		/// 항목번호
		/// </summary>
		[Column("항목번호")]
		public int ItemNumber { get; set; }
		/// <summary>
		/// 상위항목번호
		/// </summary>
		[Column("상위항목번호")]
		public int HighRankItemNumber { get; set; }
		/// <summary>
		/// 항목명
		/// </summary>
		[Column("항목명")]
		public string ItemName { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// 상품수
		/// </summary>
		[Column("상품수")]
		public int ProductNumber { get; set; }
		/// <summary>
		/// LEVEL
		/// </summary>
		[Column("LEVEL")]
		public int LEVEL { get; set; }
		/// <summary>
		/// 서브메인
		/// </summary>
		[Column("서브메인")]
		public int SubMain { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public int SORT { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
	}
}