namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_무인센딩인솔자_정산삭제
/// </summary>
public class WSP_T_UnmannedSendingLeader_SettlementDelete
{
	public const string SP_NAME = "WSP_T_무인센딩인솔자_정산삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

}