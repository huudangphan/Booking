namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_회원_아이디찾기
/// </summary>
public class WSP_S_CMN_Member_IDFinding
{
	public const string SP_NAME = "WSP_S_CMN_회원_아이디찾기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 업체번호
		/// </summary>
		[Description("업체번호")]
		public int CompanyNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 휴면회원YN
		/// </summary>
		[Column("휴면회원YN")]
		public string UnactiveMember_YN { get; set; }
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
		/// <summary>
		/// 회원번호
		/// </summary>
		[Column("회원번호")]
		public int MemberNumber { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Column("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 집전화
		/// </summary>
		[Column("집전화")]
		public string HomePhone { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
	}
}