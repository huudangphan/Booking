namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_상품문의_리스트_MOBILE
/// </summary>
public class WSP_S_ProductInquiry_List_MOBILE
{
	public const string SP_NAME = "WSP_S_상품문의_리스트_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
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
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 담당자정보
		/// </summary>
		[Column("담당자정보")]
		public string ManagerInfo { get; set; }
		/// <summary>
		/// 답변
		/// </summary>
		[Column("답변")]
		public bool Answer { get; set; }
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
		/// 사용자오픈
		/// </summary>
		[Column("사용자오픈")]
		public string UserOpen { get; set; }
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
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 담당자지정일
		/// </summary>
		[Column("담당자지정일")]
		public DateTime ManagerAssignmentDate { get; set; }
		/// <summary>
		/// 답변등록일
		/// </summary>
		[Column("답변등록일")]
		public DateTime AnswerRegisterDate { get; set; }
		/// <summary>
		/// 담당자미지정
		/// </summary>
		[Column("담당자미지정")]
		public string ManagerUnassigned { get; set; }
		/// <summary>
		/// 예약번호직원입력여부
		/// </summary>
		[Column("예약번호직원입력여부")]
		public string BookingNumberEmployeeInputOrNot { get; set; }
		/// <summary>
		/// 답변내용
		/// </summary>
		[Column("답변내용")]
		public string AnswerContent { get; set; }
		/// <summary>
		/// 중복카운트
		/// </summary>
		[Column("중복카운트")]
		public int DuplicatedCount { get; set; }
	}
}