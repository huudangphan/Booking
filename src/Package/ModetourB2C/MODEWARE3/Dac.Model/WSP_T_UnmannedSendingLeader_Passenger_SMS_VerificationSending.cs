namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_무인센딩인솔자_패신저SMS인증발송
/// </summary>
public class WSP_T_UnmannedSendingLeader_Passenger_SMS_VerificationSending
{
	public const string SP_NAME = "WSP_T_무인센딩인솔자_패신저SMS인증발송";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 전송상태
		/// </summary>
		[Column("전송상태")]
		public string TransmissionStatus { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
	}
}