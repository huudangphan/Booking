namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_웹사이트
/// </summary>
public class WSP_T_Website
{
	public const string SP_NAME = "WSP_T_웹사이트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// URL
		/// </summary>
		[Description("URL")]
		public string URL { get; set; }
		/// <summary>
		/// 전시방식코드
		/// </summary>
		[Description("전시방식코드")]
		public string ShowingMethodCode { get; set; }
		/// <summary>
		/// 웹페이지번호
		/// </summary>
		[Description("웹페이지번호")]
		public int WebPageNumber { get; set; }
		/// <summary>
		/// 웹페이지
		/// </summary>
		[Description("웹페이지")]
		public string WebPage { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Description("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 레벨
		/// </summary>
		[Description("레벨")]
		public string Level { get; set; }
		/// <summary>
		/// 시작경로
		/// </summary>
		[Description("시작경로")]
		public string StartRoute { get; set; }
		/// <summary>
		/// 비고1
		/// </summary>
		[Description("비고1")]
		public string Note1 { get; set; }
		/// <summary>
		/// 비고2
		/// </summary>
		[Description("비고2")]
		public string Note2 { get; set; }
		/// <summary>
		/// 파일타입
		/// </summary>
		[Description("파일타입")]
		public string FileType { get; set; }
		/// <summary>
		/// 제휴
		/// </summary>
		[Description("제휴")]
		public string Affiliate { get; set; }
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