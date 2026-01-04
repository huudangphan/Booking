namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_모두톡_웹발송
/// </summary>
public class WSP_T_CMN_MODETalk_WebSending
{
	public const string SP_NAME = "WSP_T_CMN_모두톡_웹발송";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 메세지타입
		/// </summary>
		[Description("메세지타입")]
		public string MessageType { get; set; }
		/// <summary>
		/// 메시지종류
		/// </summary>
		[Description("메시지종류")]
		public string MessageType2 { get; set; }
		/// <summary>
		/// 발송타입
		/// </summary>
		[Description("발송타입")]
		public string SendingType { get; set; }
		/// <summary>
		/// 발송자번호
		/// </summary>
		[Description("발송자번호")]
		public int SenderNumber { get; set; }
		/// <summary>
		/// 수신자
		/// </summary>
		[Description("수신자")]
		public string Receiver { get; set; }
		/// <summary>
		/// 메세지내용
		/// </summary>
		[Description("메세지내용")]
		public string MessageContent { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Description("등록자")]
		public int Registerer { get; set; }
	}

}