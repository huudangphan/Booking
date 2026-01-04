namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_BTMS_모두톡
/// </summary>
public class WSP_T_CMN_BTMS_MODETalk
{
	public const string SP_NAME = "WSP_T_CMN_BTMS_모두톡";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 요청자
		/// </summary>
		[Description("요청자")]
		public int Requester { get; set; }
		/// <summary>
		/// 요청구분
		/// </summary>
		[Description("요청구분")]
		public string RequestClassification { get; set; }
		/// <summary>
		/// 메시지종류
		/// </summary>
		[Description("메시지종류")]
		public string MessageType { get; set; }
		/// <summary>
		/// 메세지내용
		/// </summary>
		[Description("메세지내용")]
		public string MessageContent { get; set; }
		/// <summary>
		/// 세부번호
		/// </summary>
		[Description("세부번호")]
		public int DetailNumber { get; set; }
	}

}