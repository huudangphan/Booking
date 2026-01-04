namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_조직도_직원정보
/// </summary>
public class GSP_S_OrganizationChart_EmployeeInfo
{
	public const string SP_NAME = "GSP_S_조직도_직원정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 부서번호
		/// </summary>
		[Column("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 회사전화
		/// </summary>
		[Column("회사전화")]
		public string CompanyPhone { get; set; }
		/// <summary>
		/// 팩스
		/// </summary>
		[Column("팩스")]
		public string Fax { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 부서코드
		/// </summary>
		[Column("부서코드")]
		public int DepartmentCode { get; set; }
		/// <summary>
		/// 성명
		/// </summary>
		[Column("성명")]
		public string Name { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Column("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 직위코드
		/// </summary>
		[Column("직위코드")]
		public string PositionCode { get; set; }
		/// <summary>
		/// 직무코드
		/// </summary>
		[Column("직무코드")]
		public string DutyCode { get; set; }
		/// <summary>
		/// 결재권한
		/// </summary>
		[Column("결재권한")]
		public string ApprovalAuthority { get; set; }
		/// <summary>
		/// 담당업무
		/// </summary>
		[Column("담당업무")]
		public string ResponsibilityTask { get; set; }
		/// <summary>
		/// 임원
		/// </summary>
		[Column("임원")]
		public string Executive { get; set; }
		/// <summary>
		/// 직통번호
		/// </summary>
		[Column("직통번호")]
		public string DirectPhoneLineNumber { get; set; }
		/// <summary>
		/// 직위명
		/// </summary>
		[Column("직위명")]
		public string PositionName { get; set; }
		/// <summary>
		/// 집전화
		/// </summary>
		[Column("집전화")]
		public string HomePhone { get; set; }
		/// <summary>
		/// 회사전화
		/// </summary>
		[Column("회사전화")]
		public string CompanyPhone { get; set; }
		/// <summary>
		/// 내선
		/// </summary>
		[Column("내선")]
		public string Interphone { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 팩스
		/// </summary>
		[Column("팩스")]
		public string Fax { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 메신저
		/// </summary>
		[Column("메신저")]
		public string Messager { get; set; }
		/// <summary>
		/// 사번
		/// </summary>
		[Column("사번")]
		public string EmployeeIdentifiedNumber { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 사진조회수
		/// </summary>
		[Column("사진조회수")]
		public int PictureSearchNumber { get; set; }
	}
}