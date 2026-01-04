namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_직원_로그인
/// </summary>
public class GSP_S_Employee_Login
{
	public const string SP_NAME = "GSP_S_직원_로그인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Description("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 관리자
		/// </summary>
		[Description("관리자")]
		public string Admin { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 사원번호
		/// </summary>
		[Column("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 결재권한
		/// </summary>
		[Column("결재권한")]
		public string ApprovalAuthority { get; set; }
		/// <summary>
		/// 결재권한2
		/// </summary>
		[Column("결재권한2")]
		public byte ApprovalAuthority2 { get; set; }
		/// <summary>
		/// 직위명
		/// </summary>
		[Column("직위명")]
		public string PositionName { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 부서코드
		/// </summary>
		[Column("부서코드")]
		public int DepartmentCode { get; set; }
		/// <summary>
		/// 결재직위명
		/// </summary>
		[Column("결재직위명")]
		public string ApprovalPositionName { get; set; }
		/// <summary>
		/// 상위부서
		/// </summary>
		[Column("상위부서")]
		public string HighRankDepartment { get; set; }
		/// <summary>
		/// PTID2
		/// </summary>
		[Column("PTID2")]
		public int PTID2 { get; set; }
		/// <summary>
		/// 임원
		/// </summary>
		[Column("임원")]
		public string Executive { get; set; }
		/// <summary>
		/// 파트명
		/// </summary>
		[Column("파트명")]
		public string PartName { get; set; }
		/// <summary>
		/// 파트코드
		/// </summary>
		[Column("파트코드")]
		public int PartCode { get; set; }
		/// <summary>
		/// 닉네임
		/// </summary>
		[Column("닉네임")]
		public string Nickname { get; set; }
		/// <summary>
		/// 사번
		/// </summary>
		[Column("사번")]
		public string EmployeeIdentifiedNumber { get; set; }
		/// <summary>
		/// 고용형태상세
		/// </summary>
		[Column("고용형태상세")]
		public string EmploymentFormatDetail { get; set; }
	}

	public class Result2 : IDbResult
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
	}
}