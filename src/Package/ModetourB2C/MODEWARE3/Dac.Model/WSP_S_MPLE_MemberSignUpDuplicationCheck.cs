namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_MPLE_회원가입중복체크
/// </summary>
public class WSP_S_MPLE_MemberSignUpDuplicationCheck
{
	public const string SP_NAME = "WSP_S_MPLE_회원가입중복체크";

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
		/// 중복여부
		/// </summary>
		[Column("중복여부")]
		public string DuplicatedOrNot { get; set; }
	}
}