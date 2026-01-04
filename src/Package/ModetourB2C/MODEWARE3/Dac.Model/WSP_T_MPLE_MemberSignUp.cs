namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_MPLE_회원가입
/// </summary>
public class WSP_T_MPLE_MemberSignUp
{
	public const string SP_NAME = "WSP_T_MPLE_회원가입";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 한글명
		/// </summary>
		[Description("한글명")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Description("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Description("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 국가번호
		/// </summary>
		[Description("국가번호")]
		public string CountryNumber { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Description("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Description("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Description("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 랜드사번호
		/// </summary>
		[Description("랜드사번호")]
		public int LandCompanyNumber { get; set; }
		/// <summary>
		/// CI
		/// </summary>
		[Description("CI")]
		public string CI { get; set; }
		/// <summary>
		/// DI
		/// </summary>
		[Description("DI")]
		public string DI { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// RETURN_CODE
		/// </summary>
		[Column("RETURN_CODE")]
		public int RETURN_CODE { get; set; }
		/// <summary>
		/// RETURN_MSG
		/// </summary>
		[Column("RETURN_MSG")]
		public string RETURN_MSG { get; set; }
	}
}