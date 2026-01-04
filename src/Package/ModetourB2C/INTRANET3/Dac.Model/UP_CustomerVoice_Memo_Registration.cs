namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_고객의소리_메모_등록
/// </summary>
public class UP_CustomerVoice_Memo_Registration
{
	public const string SP_NAME = "UP_고객의소리_메모_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 작업구분
		/// </summary>
		[Description("작업구분")]
		public string WorkingClassification { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Description("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Description("작성자")]
		public int Writter { get; set; }
		/// <summary>
		/// 작성자정보
		/// </summary>
		[Description("작성자정보")]
		public string WritterInfo { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 진행현황
		/// </summary>
		[Description("진행현황")]
		public string ProgressCurrentState { get; set; }
		/// <summary>
		/// 메일발송여부
		/// </summary>
		[Description("메일발송여부")]
		public bool MailSendingOrNot { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

}