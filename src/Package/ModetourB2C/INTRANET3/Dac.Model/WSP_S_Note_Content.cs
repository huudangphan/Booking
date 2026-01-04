namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_쪽지_내용
/// </summary>
public class WSP_S_Note_Content
{
	public const string SP_NAME = "WSP_S_쪽지_내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 발신자
		/// </summary>
		[Description("발신자")]
		public int MailSender { get; set; }
		/// <summary>
		/// 수신자
		/// </summary>
		[Description("수신자")]
		public int Receiver { get; set; }
		/// <summary>
		/// 쪽지번호
		/// </summary>
		[Description("쪽지번호")]
		public int NoteNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
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
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 발신일
		/// </summary>
		[Column("발신일")]
		public DateTime MailSendingDate { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 수신자
		/// </summary>
		[Column("수신자")]
		public int Receiver { get; set; }
		/// <summary>
		/// 수신자정보
		/// </summary>
		[Column("수신자정보")]
		public string ReceiverInfo { get; set; }
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
	}

	public class Result3 : IDbResult
	{
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
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
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
		/// 수신자정보
		/// </summary>
		[Column("수신자정보")]
		public string ReceiverInfo { get; set; }
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
	}
}