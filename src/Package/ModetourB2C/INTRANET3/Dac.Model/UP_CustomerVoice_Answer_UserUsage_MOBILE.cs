namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_고객의소리_답변_사용자용_MOBILE
/// </summary>
public class UP_CustomerVoice_Answer_UserUsage_MOBILE
{
	public const string SP_NAME = "UP_고객의소리_답변_사용자용_MOBILE";

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
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public int Writter { get; set; }
		/// <summary>
		/// 작성자정보
		/// </summary>
		[Column("작성자정보")]
		public string WritterInfo { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 진행현황
		/// </summary>
		[Column("진행현황")]
		public string ProgressCurrentState { get; set; }
		/// <summary>
		/// 메일발송여부
		/// </summary>
		[Column("메일발송여부")]
		public bool MailSendingOrNot { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}
}