namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_회원로그인_비밀번호찾기
/// </summary>
public class WSP_S_CMN_MemberLogin_PasswordFinding
{
	public const string SP_NAME = "WSP_S_CMN_회원로그인_비밀번호찾기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 업체번호
		/// </summary>
		[Description("업체번호")]
		public int CompanyNumber { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Description("주민번호")]
		public string CitizenIDNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
	}
}