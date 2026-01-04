namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_모두톡발송예약
/// </summary>
public class USP_T_MODETalkSendingReservation
{
	public const string SP_NAME = "USP_T_모두톡발송예약";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 메세지타입
		/// </summary>
		[Description("메세지타입")]
		public string MessageType { get; set; }
		/// <summary>
		/// 메세지종류
		/// </summary>
		[Description("메세지종류")]
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
		/// 수신타입
		/// </summary>
		[Description("수신타입")]
		public string ReceptionType { get; set; }
		/// <summary>
		/// 수신자
		/// </summary>
		[Description("수신자")]
		public string Receiver { get; set; }
		/// <summary>
		/// 피드번호
		/// </summary>
		[Description("피드번호")]
		public int FeedNumber { get; set; }
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
		/// <summary>
		/// 예약발송일시
		/// </summary>
		[Description("예약발송일시")]
		public DateTime BookingSendingDateAndTime { get; set; }
		/// <summary>
		/// 예약발송여부
		/// </summary>
		[Description("예약발송여부")]
		public string BookingSendingOrNot { get; set; }
		/// <summary>
		/// UI메세지버튼사용여부
		/// </summary>
		[Description("UI메세지버튼사용여부")]
		public string UI_MessageButtonUseOrNot { get; set; }
		/// <summary>
		/// 챗봇결재사용
		/// </summary>
		[Description("챗봇결재사용")]
		public string ChatbotApprovalUse { get; set; }
		/// <summary>
		/// T_MSGBUTTON
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("T_MSGBUTTON")]
		public List<TYPE_ModeTalk_Send_MsgButton> T_MSGBUTTON { get; set; }
		/// <summary>
		/// 룸참여자
		/// </summary>
		[Description("룸참여자")]
		public string RoomJoiner { get; set; }
		/// <summary>
		/// NEWROOM
		/// </summary>
		[Description("NEWROOM")]
		public string NEWROOM { get; set; }
		/// <summary>
		/// 모두톡메세지번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("모두톡메세지번호")]
		public int MODETalkMessageNumber { get; set; }
	}

}