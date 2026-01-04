namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_정산_통화코드
/// </summary>
public class WSP_S_UnmannedSendingLeader_Settlement_PhoneCode
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_정산_통화코드";

	public class Result : IDbResult
	{
		/// <summary>
		/// 통화명
		/// </summary>
		[Column("통화명")]
		public string CallName { get; set; }
		/// <summary>
		/// 통화코드
		/// </summary>
		[Column("통화코드")]
		public string CallCode { get; set; }
	}
}