namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_단체담당자
/// </summary>
public class WSP_S_CMN_GroupManager
{
	public const string SP_NAME = "WSP_S_CMN_단체담당자";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Pcode
		/// </summary>
		[Description("Pcode")]
		public string Pcode { get; set; }
		/// <summary>
		/// Pnum
		/// </summary>
		[Description("Pnum")]
		public int Pnum { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 사원번호
		/// </summary>
		[Column("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 직원명
		/// </summary>
		[Column("직원명")]
		public string EmployeeName { get; set; }
		/// <summary>
		/// 직급
		/// </summary>
		[Column("직급")]
		public string JobPosition { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
	}
}