namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_할인쿠폰_문자발송여부체크
/// </summary>
public class WSP_S_CMN_DiscountCoupon_MessageSendingOrNotCheck
{
	public const string SP_NAME = "WSP_S_CMN_할인쿠폰_문자발송여부체크";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 수신자PTID
		/// </summary>
		[Description("수신자PTID")]
		public int Receiver_PTID { get; set; }
		/// <summary>
		/// 메시지번호
		/// </summary>
		[Description("메시지번호")]
		public int MessageNumber { get; set; }
	}

}