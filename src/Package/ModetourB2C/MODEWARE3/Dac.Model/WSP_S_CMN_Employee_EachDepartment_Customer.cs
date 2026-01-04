namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_직원_부서별_거래처
/// </summary>
public class WSP_S_CMN_Employee_EachDepartment_Customer
{
	public const string SP_NAME = "WSP_S_CMN_직원_부서별_거래처";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 직원명
		/// </summary>
		[Column("직원명")]
		public string EmployeeName { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
	}
}