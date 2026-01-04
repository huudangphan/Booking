namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_회신전용메시지
/// </summary>
public class WSP_T_CMN_ReplyUsageMessage
{
	public const string SP_NAME = "WSP_T_CMN_회신전용메시지";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 수신자HP
		/// </summary>
		[Description("수신자HP")]
		public string ReceiverHP { get; set; }
		/// <summary>
		/// 수신자
		/// </summary>
		[Description("수신자")]
		public int Receiver { get; set; }
	}

}