namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_기안정보_대결자_지정_사원_MOBILE
/// </summary>
public class UP_DraftInfo_Substitute_Appointment_Employee_MOBILE
{
	public const string SP_NAME = "UP_기안정보_대결자_지정_사원_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 문서코드
		/// </summary>
		[Description("문서코드")]
		public int DocumentCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 직원번호
		/// </summary>
		[Column("직원번호")]
		public int EmployeeNumber { get; set; }
	}
}