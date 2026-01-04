namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_팀업질의현황_질의모두톡발송
/// </summary>
public class WSP_T_TeamUpInquiryCurrentState_InquiryMODETalkSending
{
	public const string SP_NAME = "WSP_T_팀업질의현황_질의모두톡발송";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 단체변경
		/// </summary>
		[Description("단체변경")]
		public string GroupChange { get; set; }
		/// <summary>
		/// 인원추가
		/// </summary>
		[Description("인원추가")]
		public string NumberOfPeopleAdd { get; set; }
	}

}