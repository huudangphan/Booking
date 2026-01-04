namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_무인센딩인솔자_정산영수증수정
/// </summary>
public class WSP_T_UnmannedSendingLeader_SettlementReceiptEdit
{
	public const string SP_NAME = "WSP_T_무인센딩인솔자_정산영수증수정";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 영수증파일명
		/// </summary>
		[Description("영수증파일명")]
		public string ReceiptFileName { get; set; }
	}

}