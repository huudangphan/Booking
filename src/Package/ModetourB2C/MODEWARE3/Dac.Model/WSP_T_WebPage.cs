namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_웹페이지
/// </summary>
public class WSP_T_WebPage
{
	public const string SP_NAME = "WSP_T_웹페이지";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// 웹페이지번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("웹페이지번호")]
		public int WebPageNumber { get; set; }
		/// <summary>
		/// 상위웹페이지번호
		/// </summary>
		[Description("상위웹페이지번호")]
		public int HighRankWebPageNumber { get; set; }
		/// <summary>
		/// 경로레벨
		/// </summary>
		[Description("경로레벨")]
		public byte RouteLevel { get; set; }
		/// <summary>
		/// 경로명
		/// </summary>
		[Description("경로명")]
		public string RouteName { get; set; }
		/// <summary>
		/// 관련경로번호
		/// </summary>
		[Description("관련경로번호")]
		public int RelatedRouteNumber { get; set; }
		/// <summary>
		/// 경로주소
		/// </summary>
		[Description("경로주소")]
		public string RouteAddress { get; set; }
		/// <summary>
		/// 경로구분
		/// </summary>
		[Description("경로구분")]
		public string RouteClassification { get; set; }
		/// <summary>
		/// ERRNO
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("ERRNO")]
		public int ERRNO { get; set; }
		/// <summary>
		/// ERRMSG
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("ERRMSG")]
		public string ERRMSG { get; set; }
	}

}