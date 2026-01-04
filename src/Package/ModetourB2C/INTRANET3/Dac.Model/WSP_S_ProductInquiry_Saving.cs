namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_상품문의_저장
/// </summary>
public class WSP_S_ProductInquiry_Saving
{
	public const string SP_NAME = "WSP_S_상품문의_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
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
		/// 작성자
		/// </summary>
		[Description("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Description("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 부서
		/// </summary>
		[Description("부서")]
		public int Department { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Description("부서명")]
		public string DepartmentName { get; set; }
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
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// IP
		/// </summary>
		[Description("IP")]
		public string IP { get; set; }
		/// <summary>
		/// 담당자
		/// </summary>
		[Description("담당자")]
		public int Manager { get; set; }
		/// <summary>
		/// 담당자정보
		/// </summary>
		[Description("담당자정보")]
		public string ManagerInfo { get; set; }
		/// <summary>
		/// 답변자
		/// </summary>
		[Description("답변자")]
		public int Answerer { get; set; }
		/// <summary>
		/// 답변내용
		/// </summary>
		[Description("답변내용")]
		public string AnswerContent { get; set; }
		/// <summary>
		/// 답변메일발송
		/// </summary>
		[Description("답변메일발송")]
		public bool AnswerMailSending { get; set; }
		/// <summary>
		/// 첨부
		/// </summary>
		[Description("첨부")]
		public string Attach { get; set; }
		/// <summary>
		/// 질문유형
		/// </summary>
		[Description("질문유형")]
		public string QuestionType { get; set; }
		/// <summary>
		/// 사용자오픈
		/// </summary>
		[Description("사용자오픈")]
		public string UserOpen { get; set; }
		/// <summary>
		/// 지역PLID
		/// </summary>
		[Description("지역PLID")]
		public int RegionPLID { get; set; }
		/// <summary>
		/// 테마번호
		/// </summary>
		[Description("테마번호")]
		public int ThemeNumber { get; set; }
		/// <summary>
		/// 아이템구분
		/// </summary>
		[Description("아이템구분")]
		public string ItemClassification { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("결과")]
		public int Result { get; set; }
		/// <summary>
		/// 담당자지정자
		/// </summary>
		[Description("담당자지정자")]
		public string ManagerAssigner { get; set; }
		/// <summary>
		/// 답변자정보
		/// </summary>
		[Description("답변자정보")]
		public string AnswererInfo { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}
}