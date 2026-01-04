namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_복지몰_회원
/// </summary>
public class WSP_S_WelfareMall_Member
{
	public const string SP_NAME = "WSP_S_복지몰_회원";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 회원번호
		/// </summary>
		[Column("회원번호")]
		public int MemberNumber { get; set; }
		/// <summary>
		/// 회원유형
		/// </summary>
		[Column("회원유형")]
		public string MemberType { get; set; }
		/// <summary>
		/// 임직원회원번호
		/// </summary>
		[Column("임직원회원번호")]
		public int EmployeeMemberNumber { get; set; }
		/// <summary>
		/// 회원관계
		/// </summary>
		[Column("회원관계")]
		public string MemberRelationship { get; set; }
		/// <summary>
		/// 임직원몰인증상태
		/// </summary>
		[Column("임직원몰인증상태")]
		public string EmployeeMallVerificationState { get; set; }
		/// <summary>
		/// 인증일
		/// </summary>
		[Column("인증일")]
		public DateTime VerificationDate { get; set; }
	}
}