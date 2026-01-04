namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_컨텐츠게시판_저장
/// </summary>
public class WSP_T_ContentNoticeboard_Saving
{
	public const string SP_NAME = "WSP_T_컨텐츠게시판_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 작업구분
		/// </summary>
		[Description("작업구분")]
		public string WorkingClassification { get; set; }
		/// <summary>
		/// 게시판명
		/// </summary>
		[Description("게시판명")]
		public string NoticeboardName { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
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
		/// 접수일
		/// </summary>
		[Description("접수일")]
		public string ReceiptDate { get; set; }
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
		/// 항목
		/// </summary>
		[Description("항목")]
		public string Item { get; set; }
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
	}

}