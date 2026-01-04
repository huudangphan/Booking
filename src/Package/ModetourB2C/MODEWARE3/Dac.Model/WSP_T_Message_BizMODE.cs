namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_메시지_비즈모두
/// </summary>
public class WSP_T_Message_BizMODE
{
	public const string SP_NAME = "WSP_T_메시지_비즈모두";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 메시지종류
		/// </summary>
		[Description("메시지종류")]
		public string MessageType { get; set; }
		/// <summary>
		/// 발송자
		/// </summary>
		[Description("발송자")]
		public int Sender { get; set; }
		/// <summary>
		/// 발송자명
		/// </summary>
		[Description("발송자명")]
		public string SenderName { get; set; }
		/// <summary>
		/// 발송자주소
		/// </summary>
		[Description("발송자주소")]
		public string SenderAddress { get; set; }
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
		/// 수신확인필요여부
		/// </summary>
		[Description("수신확인필요여부")]
		public string ReceptionConfirmRequiredOrNot { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 첨부파일명
		/// </summary>
		[Description("첨부파일명")]
		public string AttachFileName { get; set; }
		/// <summary>
		/// 수신자
		/// </summary>
		[Description("수신자")]
		public int Receiver { get; set; }
		/// <summary>
		/// 수신자명
		/// </summary>
		[Description("수신자명")]
		public string ReceiverName { get; set; }
		/// <summary>
		/// 수신자주소
		/// </summary>
		[Description("수신자주소")]
		public string ReceiverAddress { get; set; }
		/// <summary>
		/// 그룹수신가능여부
		/// </summary>
		[Description("그룹수신가능여부")]
		public string GroupReceptionPossibleOrNot { get; set; }
		/// <summary>
		/// 그룹번호
		/// </summary>
		[Description("그룹번호")]
		public int GroupNumber2 { get; set; }
		/// <summary>
		/// 메세지발송번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("메세지발송번호")]
		public int MessageSendingNumber { get; set; }
		/// <summary>
		/// LMS종류
		/// </summary>
		[Description("LMS종류")]
		public string LMS_Type { get; set; }
		/// <summary>
		/// 발송동의
		/// </summary>
		[Description("발송동의")]
		public string SendingAgree { get; set; }
		/// <summary>
		/// CRM여부
		/// </summary>
		[Description("CRM여부")]
		public string CRM_OrNot { get; set; }
		/// <summary>
		/// 알림톡템플릿
		/// </summary>
		[Description("알림톡템플릿")]
		public string AlarmTalkTemplate { get; set; }
	}

}