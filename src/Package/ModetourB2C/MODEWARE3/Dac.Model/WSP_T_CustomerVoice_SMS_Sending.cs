namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_고객의소리_SMS발송
/// </summary>
public class WSP_T_CustomerVoice_SMS_Sending
{
	public const string SP_NAME = "WSP_T_고객의소리_SMS발송";

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
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public string SerialNumber { get; set; }
	}

}