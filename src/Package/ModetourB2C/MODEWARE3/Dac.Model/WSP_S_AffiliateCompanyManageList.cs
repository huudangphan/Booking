namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_제휴사관리리스트
/// </summary>
public class WSP_S_AffiliateCompanyManageList
{
	public const string SP_NAME = "WSP_S_제휴사관리리스트";

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 도메인
		/// </summary>
		[Column("도메인")]
		public string Domain { get; set; }
		/// <summary>
		/// 영업담당자
		/// </summary>
		[Column("영업담당자")]
		public string BusinessManager { get; set; }
		/// <summary>
		/// 개발담당자
		/// </summary>
		[Column("개발담당자")]
		public string DevelopmentManager { get; set; }
		/// <summary>
		/// 디자인담당자
		/// </summary>
		[Column("디자인담당자")]
		public string DesignManager { get; set; }
		/// <summary>
		/// 운영여부
		/// </summary>
		[Column("운영여부")]
		public string OperationOrNot { get; set; }
		/// <summary>
		/// 테스트서버주소
		/// </summary>
		[Column("테스트서버주소")]
		public string TestServerAddress { get; set; }
		/// <summary>
		/// 해당업체관련담당자주소
		/// </summary>
		[Column("해당업체관련담당자주소")]
		public string ThisCompanyRelatedManagerAddress { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 템플릿_메인
		/// </summary>
		[Column("템플릿_메인")]
		public string Template_Main { get; set; }
		/// <summary>
		/// 템플릿_서브
		/// </summary>
		[Column("템플릿_서브")]
		public string Template_Sub { get; set; }
		/// <summary>
		/// 업체명
		/// </summary>
		[Column("업체명")]
		public string CompanyName { get; set; }
		/// <summary>
		/// 기획자
		/// </summary>
		[Column("기획자")]
		public string Planner { get; set; }
		/// <summary>
		/// 모바일사이트사용유무
		/// </summary>
		[Column("모바일사이트사용유무")]
		public string MobileSiteUseOrNot { get; set; }
		/// <summary>
		/// 모바일URL
		/// </summary>
		[Column("모바일URL")]
		public string Mobile_URL { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Column("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
	}
}