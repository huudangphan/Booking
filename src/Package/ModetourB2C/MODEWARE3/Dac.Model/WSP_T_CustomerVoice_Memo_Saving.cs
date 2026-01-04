namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_고객의소리_메모_저장
/// </summary>
public class WSP_T_CustomerVoice_Memo_Saving
{
	public const string SP_NAME = "WSP_T_고객의소리_메모_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 발송자
		/// </summary>
		[Description("발송자")]
		public int Sender { get; set; }
		/// <summary>
		/// 수신자
		/// </summary>
		[Description("수신자")]
		public int Receiver { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

}