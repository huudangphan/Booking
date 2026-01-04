namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_웹사이트
/// </summary>
public class WSP_S_Website
{
	public const string SP_NAME = "WSP_S_웹사이트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 레벨
		/// </summary>
		[Description("레벨")]
		public string Level { get; set; }
		/// <summary>
		/// AGENTCODE
		/// </summary>
		[Description("AGENTCODE")]
		public string AGENTCODE { get; set; }
		/// <summary>
		/// SITEID
		/// </summary>
		[Description("SITEID")]
		public int SITEID { get; set; }
		/// <summary>
		/// URL
		/// </summary>
		[Description("URL")]
		public string URL { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
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
		/// 파일타입
		/// </summary>
		[Column("파일타입")]
		public string FileType { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// SITEID
		/// </summary>
		[Column("SITEID")]
		public int SITEID { get; set; }
		/// <summary>
		/// URL
		/// </summary>
		[Column("URL")]
		public string URL { get; set; }
		/// <summary>
		/// 웹사이트종류코드
		/// </summary>
		[Column("웹사이트종류코드")]
		public string WebSiteTypeCode { get; set; }
		/// <summary>
		/// 파일타입
		/// </summary>
		[Column("파일타입")]
		public string FileType { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// URL
		/// </summary>
		[Column("URL")]
		public string URL { get; set; }
		/// <summary>
		/// 사이트명
		/// </summary>
		[Column("사이트명")]
		public string SiteName { get; set; }
		/// <summary>
		/// SITEID
		/// </summary>
		[Column("SITEID")]
		public int SITEID { get; set; }
		/// <summary>
		/// 레벨
		/// </summary>
		[Column("레벨")]
		public string Level { get; set; }
		/// <summary>
		/// 시작경로
		/// </summary>
		[Column("시작경로")]
		public string StartRoute { get; set; }
		/// <summary>
		/// 시작파일
		/// </summary>
		[Column("시작파일")]
		public string StartFile { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Column("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 비고2
		/// </summary>
		[Column("비고2")]
		public string Note2 { get; set; }
		/// <summary>
		/// 웹페이지번호
		/// </summary>
		[Column("웹페이지번호")]
		public int WebPageNumber { get; set; }
		/// <summary>
		/// 파일타입
		/// </summary>
		[Column("파일타입")]
		public string FileType { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
	}
}