namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_온라인등급사이트
/// </summary>
public class WSP_S_CMN_OnlineRatingSite
{
	public const string SP_NAME = "WSP_S_CMN_온라인등급사이트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 사이트번호
		/// </summary>
		[Description("사이트번호")]
		public int SiteNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 사이트번호
		/// </summary>
		[Column("사이트번호")]
		public int SiteNumber { get; set; }
		/// <summary>
		/// 사이트주소
		/// </summary>
		[Column("사이트주소")]
		public string SiteAddress { get; set; }
		/// <summary>
		/// 템플릿
		/// </summary>
		[Column("템플릿")]
		public string Template { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Column("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 순위
		/// </summary>
		[Column("순위")]
		public int Ranking { get; set; }
		/// <summary>
		/// 승인여부
		/// </summary>
		[Column("승인여부")]
		public string ApprovalOrNot { get; set; }
		/// <summary>
		/// 승인등록자
		/// </summary>
		[Column("승인등록자")]
		public string ApprovalRegisterer { get; set; }
		/// <summary>
		/// 승인등록일
		/// </summary>
		[Column("승인등록일")]
		public DateTime ApprovalRegisterDate { get; set; }
		/// <summary>
		/// 권한여부
		/// </summary>
		[Column("권한여부")]
		public string AuthorityOrNot { get; set; }
		/// <summary>
		/// 항공여부
		/// </summary>
		[Column("항공여부")]
		public string FlightOrNot { get; set; }
		/// <summary>
		/// 철도여부
		/// </summary>
		[Column("철도여부")]
		public string RailwayOrNot { get; set; }
		/// <summary>
		/// 배너여부
		/// </summary>
		[Column("배너여부")]
		public string BannerOrNot { get; set; }
	}
}