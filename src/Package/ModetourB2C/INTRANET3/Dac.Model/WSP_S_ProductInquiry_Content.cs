namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_상품문의_내용
/// </summary>
public class WSP_S_ProductInquiry_Content
{
	public const string SP_NAME = "WSP_S_상품문의_내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 검색필드
		/// </summary>
		[Description("검색필드")]
		public string SearchingField { get; set; }
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Column("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 부서
		/// </summary>
		[Column("부서")]
		public int Department { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
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
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// IP
		/// </summary>
		[Column("IP")]
		public string IP { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 담당자
		/// </summary>
		[Column("담당자")]
		public int Manager { get; set; }
		/// <summary>
		/// 담당자정보
		/// </summary>
		[Column("담당자정보")]
		public string ManagerInfo { get; set; }
		/// <summary>
		/// 담당자지정일
		/// </summary>
		[Column("담당자지정일")]
		public DateTime ManagerAssignmentDate { get; set; }
		/// <summary>
		/// 담당자지정자
		/// </summary>
		[Column("담당자지정자")]
		public string ManagerAssigner { get; set; }
		/// <summary>
		/// 답변
		/// </summary>
		[Column("답변")]
		public bool Answer { get; set; }
		/// <summary>
		/// 답변자
		/// </summary>
		[Column("답변자")]
		public int Answerer { get; set; }
		/// <summary>
		/// 답변내용
		/// </summary>
		[Column("답변내용")]
		public string AnswerContent { get; set; }
		/// <summary>
		/// 답변등록일
		/// </summary>
		[Column("답변등록일")]
		public DateTime AnswerRegisterDate { get; set; }
		/// <summary>
		/// 답변메일발송
		/// </summary>
		[Column("답변메일발송")]
		public bool AnswerMailSending { get; set; }
		/// <summary>
		/// 해피콜담당자
		/// </summary>
		[Column("해피콜담당자")]
		public int HappyCallManager { get; set; }
		/// <summary>
		/// 해피콜담당자정보
		/// </summary>
		[Column("해피콜담당자정보")]
		public string HappyCallManagerInfo { get; set; }
		/// <summary>
		/// 해피콜발송일
		/// </summary>
		[Column("해피콜발송일")]
		public DateTime HappyCallSendingDate { get; set; }
		/// <summary>
		/// 질문유형
		/// </summary>
		[Column("질문유형")]
		public string QuestionType { get; set; }
		/// <summary>
		/// 지역PLID
		/// </summary>
		[Column("지역PLID")]
		public int RegionPLID { get; set; }
		/// <summary>
		/// 테마번호
		/// </summary>
		[Column("테마번호")]
		public int ThemeNumber { get; set; }
		/// <summary>
		/// 사용자오픈
		/// </summary>
		[Column("사용자오픈")]
		public string UserOpen { get; set; }
		/// <summary>
		/// 아이템구분
		/// </summary>
		[Column("아이템구분")]
		public string ItemClassification { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 사용자오픈1
		/// </summary>
		[Column("사용자오픈1")]
		public string UserOpen1 { get; set; }
		/// <summary>
		/// 첨부
		/// </summary>
		[Column("첨부")]
		public string Attach { get; set; }
		/// <summary>
		/// 생일
		/// </summary>
		[Column("생일")]
		public DateTime Birthday { get; set; }
		/// <summary>
		/// 추가예약번호1
		/// </summary>
		[Column("추가예약번호1")]
		public int AddBookingNumber1 { get; set; }
		/// <summary>
		/// 추가예약번호2
		/// </summary>
		[Column("추가예약번호2")]
		public int AddBookingNumber2 { get; set; }
		/// <summary>
		/// 추가예약1담당자
		/// </summary>
		[Column("추가예약1담당자")]
		public int AddBooking1Manager { get; set; }
		/// <summary>
		/// 추가예약1담당자정보
		/// </summary>
		[Column("추가예약1담당자정보")]
		public string AddBooking1ManagerInfo { get; set; }
		/// <summary>
		/// 추가예약1담당자지정일
		/// </summary>
		[Column("추가예약1담당자지정일")]
		public DateTime AddBooking1ManagerAssignmentDate { get; set; }
		/// <summary>
		/// 추가예약1담당자지정자
		/// </summary>
		[Column("추가예약1담당자지정자")]
		public string AddBooking1ManagerAssigner { get; set; }
		/// <summary>
		/// 추가예약2담당자
		/// </summary>
		[Column("추가예약2담당자")]
		public int AddBooking2Manager { get; set; }
		/// <summary>
		/// 추가예약2담당자정보
		/// </summary>
		[Column("추가예약2담당자정보")]
		public string AddBooking2ManagerInfo { get; set; }
		/// <summary>
		/// 추가예약2담당자지정일
		/// </summary>
		[Column("추가예약2담당자지정일")]
		public DateTime AddBooking2ManagerAssignmentDate { get; set; }
		/// <summary>
		/// 추가예약2담당자지정자
		/// </summary>
		[Column("추가예약2담당자지정자")]
		public string AddBooking2ManagerAssigner { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 답변자정보
		/// </summary>
		[Column("답변자정보")]
		public string AnswererInfo { get; set; }
		/// <summary>
		/// 답변내용
		/// </summary>
		[Column("답변내용")]
		public string AnswerContent { get; set; }
		/// <summary>
		/// 답변등록일
		/// </summary>
		[Column("답변등록일")]
		public DateTime AnswerRegisterDate { get; set; }
	}
}