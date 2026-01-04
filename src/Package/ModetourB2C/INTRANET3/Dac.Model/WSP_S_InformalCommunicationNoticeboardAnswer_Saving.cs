namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_비공식의사소통게시판답변_저장
/// </summary>
public class WSP_S_InformalCommunicationNoticeboardAnswer_Saving
{
	public const string SP_NAME = "WSP_S_비공식의사소통게시판답변_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 부모일련번호
		/// </summary>
		[Description("부모일련번호")]
		public int ParentsSerialNumber { get; set; }
		/// <summary>
		/// 답변내용
		/// </summary>
		[Description("답변내용")]
		public string AnswerContent { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
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
		/// 답변내용
		/// </summary>
		[Column("답변내용")]
		public string AnswerContent { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
	}
}