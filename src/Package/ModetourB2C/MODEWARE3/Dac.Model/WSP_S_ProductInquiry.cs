namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_상품문의
/// </summary>
public class WSP_S_ProductInquiry
{
	public const string SP_NAME = "WSP_S_상품문의";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 현재페이지
		/// </summary>
		[Description("현재페이지")]
		public int CurrentPage { get; set; }
		/// <summary>
		/// 페이지당글개수
		/// </summary>
		[Description("페이지당글개수")]
		public int EachPageCharactersNumber { get; set; }
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
		/// <summary>
		/// 전체페이지수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체페이지수")]
		public int EntirePageNumber { get; set; }
	}

	public class Result : IDbResult
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
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 사용
		/// </summary>
		[Column("사용")]
		public string Use { get; set; }
	}
}