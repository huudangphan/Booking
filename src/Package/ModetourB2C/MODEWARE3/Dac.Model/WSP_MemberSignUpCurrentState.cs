namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_회원가입현황
/// </summary>
public class WSP_MemberSignUpCurrentState
{
	public const string SP_NAME = "WSP_회원가입현황";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 시작
		/// </summary>
		[Description("시작")]
		public string Start { get; set; }
		/// <summary>
		/// 끝
		/// </summary>
		[Description("끝")]
		public string End { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public string RegisterDate { get; set; }
		/// <summary>
		/// 회원가입_모바일웹카운트
		/// </summary>
		[Column("회원가입_모바일웹카운트")]
		public int MemberSignUp_MobileWebCount { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public string RegisterDate { get; set; }
		/// <summary>
		/// 회원가입_모바일어플카운트
		/// </summary>
		[Column("회원가입_모바일어플카운트")]
		public int MemberSignUp_MobileApplicationCount { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public string RegisterDate { get; set; }
		/// <summary>
		/// 회원가입_간편회원_모두웨어
		/// </summary>
		[Column("회원가입_간편회원_모두웨어")]
		public int MemberSignUp_SimpleMember_ModeWare { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public string RegisterDate { get; set; }
		/// <summary>
		/// 회원가입_간편회원_CRS
		/// </summary>
		[Column("회원가입_간편회원_CRS")]
		public int MemberSignUp_SimpleMember_CRS { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public string RegisterDate { get; set; }
		/// <summary>
		/// 회원가입_PC카운트
		/// </summary>
		[Column("회원가입_PC카운트")]
		public int MemberSignUp_PC_Count { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// 탈퇴일
		/// </summary>
		[Column("탈퇴일")]
		public string CancelDate { get; set; }
		/// <summary>
		/// 회원탈퇴카운트
		/// </summary>
		[Column("회원탈퇴카운트")]
		public int MemberCancelCount { get; set; }
	}
}