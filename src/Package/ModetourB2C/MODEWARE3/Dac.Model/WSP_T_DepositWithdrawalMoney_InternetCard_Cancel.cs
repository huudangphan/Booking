namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_입출금_인터넷카드_취소
/// </summary>
public class WSP_T_DepositWithdrawalMoney_InternetCard_Cancel
{
	public const string SP_NAME = "WSP_T_입출금_인터넷카드_취소";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 대상수납번호
		/// </summary>
		[Description("대상수납번호")]
		public int CandidateReceiptNumber { get; set; }
	}

}