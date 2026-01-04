namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_제휴사_관리
/// </summary>
public class WSP_T_AffiliateCompany_Manage
{
	public const string SP_NAME = "WSP_T_제휴사_관리";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 모드
		/// </summary>
		[Description("모드")]
		public string Mode { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 업체명
		/// </summary>
		[Description("업체명")]
		public string CompanyName { get; set; }
		/// <summary>
		/// 도메인
		/// </summary>
		[Description("도메인")]
		public string Domain { get; set; }
		/// <summary>
		/// 템플릿_메인
		/// </summary>
		[Description("템플릿_메인")]
		public string Template_Main { get; set; }
		/// <summary>
		/// 템플릿_서브
		/// </summary>
		[Description("템플릿_서브")]
		public string Template_Sub { get; set; }
		/// <summary>
		/// 개발담당자
		/// </summary>
		[Description("개발담당자")]
		public string DevelopmentManager { get; set; }
		/// <summary>
		/// 디자인담당자
		/// </summary>
		[Description("디자인담당자")]
		public string DesignManager { get; set; }
		/// <summary>
		/// 영업담당자
		/// </summary>
		[Description("영업담당자")]
		public string BusinessManager { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 테스트서버주소
		/// </summary>
		[Description("테스트서버주소")]
		public string TestServerAddress { get; set; }
		/// <summary>
		/// 운영여부
		/// </summary>
		[Description("운영여부")]
		public string OperationOrNot { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Description("비고")]
		public string Note { get; set; }
	}

}