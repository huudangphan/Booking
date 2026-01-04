namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_웹메인_항목리스트
/// </summary>
public class WSP_S_CMN_WebMain_ItemList
{
	public const string SP_NAME = "WSP_S_CMN_웹메인_항목리스트";

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
		/// 오픈상태
		/// </summary>
		[Description("오픈상태")]
		public string OpenState { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 항목종류
		/// </summary>
		[Column("항목종류")]
		public string ItemType { get; set; }
		/// <summary>
		/// 항목코드
		/// </summary>
		[Column("항목코드")]
		public string ItemCode { get; set; }
		/// <summary>
		/// 항목번호
		/// </summary>
		[Column("항목번호")]
		public int ItemNumber { get; set; }
		/// <summary>
		/// 항목경로
		/// </summary>
		[Column("항목경로")]
		public string ItemRoute { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 웹지역_테마번호
		/// </summary>
		[Column("웹지역_테마번호")]
		public int WebRegion_ThemeNumber { get; set; }
		/// <summary>
		/// 메인명
		/// </summary>
		[Column("메인명")]
		public string MainName { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
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
		/// 상위항목명
		/// </summary>
		[Column("상위항목명")]
		public string HighRankItemName { get; set; }
		/// <summary>
		/// 출발지명
		/// </summary>
		[Column("출발지명")]
		public string DeparturesName { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 대표테마번호
		/// </summary>
		[Column("대표테마번호")]
		public int RepresentativeThemeNumber { get; set; }
	}
}