namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_가이드_이메일인증체크
/// </summary>
public class WSP_T_Guide_EmailVerificationCheck
{
	public const string SP_NAME = "WSP_T_가이드_이메일인증체크";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 승인인증번호
		/// </summary>
		[Description("승인인증번호")]
		public int ApprovalVerificationNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
	}
}