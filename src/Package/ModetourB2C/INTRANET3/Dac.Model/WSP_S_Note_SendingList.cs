namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_쪽지_발신리스트
/// </summary>
public class WSP_S_Note_SendingList
{
	public const string SP_NAME = "WSP_S_쪽지_발신리스트";

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
		/// 수신자
		/// </summary>
		[Column("수신자")]
		public int Receiver { get; set; }
		/// <summary>
		/// 수신확인
		/// </summary>
		[Column("수신확인")]
		public int ReceiveMessageCheck { get; set; }
	}
}