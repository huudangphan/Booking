namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_상품QA_담당자
/// </summary>
public class WSP_S_CMN_Product_QA_Manager
{
	public const string SP_NAME = "WSP_S_CMN_상품QA_담당자";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PROCODE
		/// </summary>
		[Description("PROCODE")]
		public string PROCODE { get; set; }
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

	public class Result1 : IDbResult
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
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
	}
}