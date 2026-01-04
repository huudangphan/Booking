namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_T_직원정보_수정
/// </summary>
public class GSP_T_EmployeeInfo_Edit
{
	public const string SP_NAME = "GSP_T_직원정보_수정";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 회사전화
		/// </summary>
		[Description("회사전화")]
		public string CompanyPhone { get; set; }
		/// <summary>
		/// 팩스번호
		/// </summary>
		[Description("팩스번호")]
		public string FaxNumber { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 직위
		/// </summary>
		[Description("직위")]
		public string Position { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 집전화
		/// </summary>
		[Description("집전화")]
		public string HomePhone { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Description("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 메신저
		/// </summary>
		[Description("메신저")]
		public string Messager { get; set; }
		/// <summary>
		/// 내선
		/// </summary>
		[Description("내선")]
		public string Interphone { get; set; }
		/// <summary>
		/// 담당업무
		/// </summary>
		[Description("담당업무")]
		public string ResponsibilityTask { get; set; }
	}

}