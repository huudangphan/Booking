namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_회원가입인증정보
/// </summary>
public class WSP_S_CMN_MemberSignUpVerificationInfo
{
	public const string SP_NAME = "WSP_S_CMN_회원가입인증정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 인증값1
		/// </summary>
		[Column("인증값1")]
		public string VerificationValue1 { get; set; }
	}
}