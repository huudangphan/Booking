namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_사원검색2_MOBILE
/// </summary>
public class GSP_S_EmployeeSearch2_MOBILE
{
	public const string SP_NAME = "GSP_S_사원검색2_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 사원명
		/// </summary>
		[Description("사원명")]
		public string StaffName { get; set; }
	}

	public class Result1 : IDbResult
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
		/// profile_image
		/// </summary>
		[Column("profile_image")]
		public string profile_image { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 부서번호
		/// </summary>
		[Column("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// PTKNAME
		/// </summary>
		[Column("PTKNAME")]
		public string PTKNAME { get; set; }
		/// <summary>
		/// 코드비고
		/// </summary>
		[Column("코드비고")]
		public string CodeNote { get; set; }
		/// <summary>
		/// 코드비고2
		/// </summary>
		[Column("코드비고2")]
		public string CodeNote2 { get; set; }
	}

	public class Result3 : IDbResult
	{
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
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
	}

	public class Result4 : IDbResult
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
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// profile_image
		/// </summary>
		[Column("profile_image")]
		public string profile_image { get; set; }
	}
}