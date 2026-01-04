namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_웹페이지
/// </summary>
public class WSP_S_WebPage
{
	public const string SP_NAME = "WSP_S_웹페이지";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// SITEID
		/// </summary>
		[Description("SITEID")]
		public int SITEID { get; set; }
		/// <summary>
		/// UPPAGENUM
		/// </summary>
		[Description("UPPAGENUM")]
		public int UPPAGENUM { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 웹페이지번호
		/// </summary>
		[Column("웹페이지번호")]
		public int WebPageNumber { get; set; }
		/// <summary>
		/// MLOC
		/// </summary>
		[Column("MLOC")]
		public string MLOC { get; set; }
		/// <summary>
		/// 깊이
		/// </summary>
		[Column("깊이")]
		public byte Depth { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public byte Sorting { get; set; }
		/// <summary>
		/// 경로명
		/// </summary>
		[Column("경로명")]
		public string RouteName { get; set; }
		/// <summary>
		/// 페이지종류코드
		/// </summary>
		[Column("페이지종류코드")]
		public string PageTypeCode { get; set; }
		/// <summary>
		/// 페이지주소
		/// </summary>
		[Column("페이지주소")]
		public string PageAddress { get; set; }
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