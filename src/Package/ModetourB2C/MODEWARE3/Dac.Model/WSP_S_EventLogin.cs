namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_이벤트로그인
/// </summary>
public class WSP_S_EventLogin
{
	public const string SP_NAME = "WSP_S_이벤트로그인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 경품품목명
		/// </summary>
		[Column("경품품목명")]
		public string GiveawayItemName { get; set; }
	}
}