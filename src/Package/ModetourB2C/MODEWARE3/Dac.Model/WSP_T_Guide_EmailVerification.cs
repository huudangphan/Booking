namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_가이드_이메일인증
/// </summary>
public class WSP_T_Guide_EmailVerification
{
	public const string SP_NAME = "WSP_T_가이드_이메일인증";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 인증번호
		/// </summary>
		[Column("인증번호")]
		public int VerificationNumber { get; set; }
	}
}