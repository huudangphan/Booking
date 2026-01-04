namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_회원로그인_아이디찾기_모바일
/// </summary>
public class WSP_S_CMN_MemberLogin_IDFinding_Mobile
{
	public const string SP_NAME = "WSP_S_CMN_회원로그인_아이디찾기_모바일";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 업체번호
		/// </summary>
		[Description("업체번호")]
		public int CompanyNumber { get; set; }
		/// <summary>
		/// 회원명
		/// </summary>
		[Description("회원명")]
		public string MemberName { get; set; }
		/// <summary>
		/// 휴대전화
		/// </summary>
		[Description("휴대전화")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// DI
		/// </summary>
		[Description("DI")]
		public string DI { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 휴면회원YN
		/// </summary>
		[Column("휴면회원YN")]
		public string UnactiveMember_YN { get; set; }
		/// <summary>
		/// PTID1
		/// </summary>
		[Column("PTID1")]
		public int PTID1 { get; set; }
		/// <summary>
		/// 사이트명
		/// </summary>
		[Column("사이트명")]
		public string SiteName { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
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
		/// DI
		/// </summary>
		[Column("DI")]
		public string DI { get; set; }
	}
}