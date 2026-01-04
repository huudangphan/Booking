namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_거래처직원찾기
/// </summary>
public class USP_S_CustomerEmployeeFinding
{
	public const string SP_NAME = "USP_S_거래처직원찾기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 한글명
		/// </summary>
		[Description("한글명")]
		public string KoreanName { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Column("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 사원명
		/// </summary>
		[Column("사원명")]
		public string StaffName { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Column("사원번호")]
		public int StaffNumber { get; set; }
	}
}