namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_외부기관중재사례_저장
/// </summary>
public class WSP_T_ExternalAgencyArbitrationCase_Saving
{
	public const string SP_NAME = "WSP_T_외부기관중재사례_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 작성자번호
		/// </summary>
		[Description("작성자번호")]
		public int WritterNumber { get; set; }
		/// <summary>
		/// 작성자명
		/// </summary>
		[Description("작성자명")]
		public string WritterName { get; set; }
		/// <summary>
		/// 담당자번호
		/// </summary>
		[Description("담당자번호")]
		public int ManagerNumber { get; set; }
		/// <summary>
		/// 담당자정보
		/// </summary>
		[Description("담당자정보")]
		public string ManagerInfo { get; set; }
		/// <summary>
		/// 중재기관
		/// </summary>
		[Description("중재기관")]
		public string ArbitrationOffice { get; set; }
		/// <summary>
		/// 고객명
		/// </summary>
		[Description("고객명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Description("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Description("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Description("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Description("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 신고항목
		/// </summary>
		[Description("신고항목")]
		public string ReportItem { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Description("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 첨부
		/// </summary>
		[Description("첨부")]
		public string Attach { get; set; }
		/// <summary>
		/// 처리결과
		/// </summary>
		[Description("처리결과")]
		public bool HandleResult { get; set; }
		/// <summary>
		/// 세부처리결과
		/// </summary>
		[Description("세부처리결과")]
		public string DetailHandleResult { get; set; }
	}

}