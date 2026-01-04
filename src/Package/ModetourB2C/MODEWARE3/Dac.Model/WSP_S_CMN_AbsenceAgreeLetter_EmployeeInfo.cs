namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_휴직동의서_사원정보
/// </summary>
public class WSP_S_CMN_AbsenceAgreeLetter_EmployeeInfo
{
	public const string SP_NAME = "WSP_S_CMN_휴직동의서_사원정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 직위코드
		/// </summary>
		[Column("직위코드")]
		public string PositionCode { get; set; }
		/// <summary>
		/// 직위
		/// </summary>
		[Column("직위")]
		public string Position { get; set; }
		/// <summary>
		/// 결재등급코드
		/// </summary>
		[Column("결재등급코드")]
		public string ApprovalClassCode { get; set; }
		/// <summary>
		/// 결재등급
		/// </summary>
		[Column("결재등급")]
		public string ApprovalClass { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 부서코드
		/// </summary>
		[Column("부서코드")]
		public int DepartmentCode { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
	}
}