namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_웹페이지_페이지명
/// </summary>
public class WSP_S_WebPage_PageName
{
	public const string SP_NAME = "WSP_S_웹페이지_페이지명";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// LEVEL
		/// </summary>
		[Description("LEVEL")]
		public int LEVEL { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 웹페이지번호
		/// </summary>
		[Column("웹페이지번호")]
		public int WebPageNumber { get; set; }
		/// <summary>
		/// 상위웹페이지번호
		/// </summary>
		[Column("상위웹페이지번호")]
		public int HighRankWebPageNumber { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Column("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// 페이지명
		/// </summary>
		[Column("페이지명")]
		public string PageName { get; set; }
		/// <summary>
		/// 웹페이지
		/// </summary>
		[Column("웹페이지")]
		public string WebPage { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
		/// <summary>
		/// LEVEL
		/// </summary>
		[Column("LEVEL")]
		public byte LEVEL { get; set; }
		/// <summary>
		/// 페이지종류코드
		/// </summary>
		[Column("페이지종류코드")]
		public string PageTypeCode { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public byte Sorting { get; set; }
		/// <summary>
		/// 관련경로번호
		/// </summary>
		[Column("관련경로번호")]
		public int RelatedRouteNumber { get; set; }
		/// <summary>
		/// 제휴
		/// </summary>
		[Column("제휴")]
		public string Affiliate { get; set; }
	}
}