namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_대결자_조회_MOBILE
/// </summary>
public class UP_Substitute_Find_MOBILE
{
	public const string SP_NAME = "UP_대결자_조회_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 직원번호
		/// </summary>
		[Column("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 부서코드
		/// </summary>
		[Column("부서코드")]
		public int DepartmentCode { get; set; }
		/// <summary>
		/// 팀
		/// </summary>
		[Column("팀")]
		public string Team { get; set; }
		/// <summary>
		/// 직위명
		/// </summary>
		[Column("직위명")]
		public string PositionName { get; set; }
		/// <summary>
		/// 프로필이미지
		/// </summary>
		[Column("프로필이미지")]
		public string ProfileImage { get; set; }
	}
}