namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_쪽지_수신리스트
/// </summary>
public class WSP_S_Note_ReceiptList
{
	public const string SP_NAME = "WSP_S_쪽지_수신리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
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
		/// 쪽지번호
		/// </summary>
		[Column("쪽지번호")]
		public int NoteNumber { get; set; }
		/// <summary>
		/// 발신자
		/// </summary>
		[Column("발신자")]
		public int MailSender { get; set; }
		/// <summary>
		/// 발신자정보
		/// </summary>
		[Column("발신자정보")]
		public string MailSenderInfo { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 발신일
		/// </summary>
		[Column("발신일")]
		public DateTime MailSendingDate { get; set; }
		/// <summary>
		/// 수신여부
		/// </summary>
		[Column("수신여부")]
		public bool ReceptionOrNot { get; set; }
		/// <summary>
		/// 수신일
		/// </summary>
		[Column("수신일")]
		public DateTime ReceptionDate { get; set; }
		/// <summary>
		/// 답변쪽지번호
		/// </summary>
		[Column("답변쪽지번호")]
		public int AnswerNoteNumber { get; set; }
		/// <summary>
		/// 답신일
		/// </summary>
		[Column("답신일")]
		public DateTime ReplyDate { get; set; }
	}
}