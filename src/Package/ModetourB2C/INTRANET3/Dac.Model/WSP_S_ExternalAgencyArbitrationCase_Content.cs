namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_외부기관중재사례_내용
/// </summary>
public class WSP_S_ExternalAgencyArbitrationCase_Content
{
	public const string SP_NAME = "WSP_S_외부기관중재사례_내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 작성자번호
		/// </summary>
		[Column("작성자번호")]
		public int WritterNumber { get; set; }
		/// <summary>
		/// 작성자명
		/// </summary>
		[Column("작성자명")]
		public string WritterName { get; set; }
		/// <summary>
		/// 담당자번호
		/// </summary>
		[Column("담당자번호")]
		public int ManagerNumber { get; set; }
		/// <summary>
		/// 담당자정보
		/// </summary>
		[Column("담당자정보")]
		public string ManagerInfo { get; set; }
		/// <summary>
		/// 중재기관
		/// </summary>
		[Column("중재기관")]
		public string ArbitrationOffice { get; set; }
		/// <summary>
		/// 고객명
		/// </summary>
		[Column("고객명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Column("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Column("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 신고항목
		/// </summary>
		[Column("신고항목")]
		public string ReportItem { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 첨부
		/// </summary>
		[Column("첨부")]
		public string Attach { get; set; }
		/// <summary>
		/// 처리결과
		/// </summary>
		[Column("처리결과")]
		public bool HandleResult { get; set; }
		/// <summary>
		/// 세부처리결과
		/// </summary>
		[Column("세부처리결과")]
		public string DetailHandleResult { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
	}
}