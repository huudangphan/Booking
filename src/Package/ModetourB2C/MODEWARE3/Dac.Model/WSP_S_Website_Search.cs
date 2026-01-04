namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_웹사이트_검색
/// </summary>
public class WSP_S_Website_Search
{
	public const string SP_NAME = "WSP_S_웹사이트_검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사이트번호
		/// </summary>
		[Description("사이트번호")]
		public int SiteNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Column("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// 웹사이트
		/// </summary>
		[Column("웹사이트")]
		public string WebSite { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 전시방식코드
		/// </summary>
		[Column("전시방식코드")]
		public string ShowingMethodCode { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}
}