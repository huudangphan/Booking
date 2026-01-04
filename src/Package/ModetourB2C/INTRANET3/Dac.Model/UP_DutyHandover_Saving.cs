namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_업무인수인계_저장
/// </summary>
public class UP_DutyHandover_Saving
{
	public const string SP_NAME = "UP_업무인수인계_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 부서코드
		/// </summary>
		[Description("부서코드")]
		public int DepartmentCode { get; set; }
		/// <summary>
		/// 부서구분
		/// </summary>
		[Description("부서구분")]
		public string DepartmentClassification { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Description("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 인수자
		/// </summary>
		[Description("인수자")]
		public string Receiver { get; set; }
		/// <summary>
		/// 출장일1
		/// </summary>
		[Description("출장일1")]
		public string BusinessTripDate1 { get; set; }
		/// <summary>
		/// 출장일2
		/// </summary>
		[Description("출장일2")]
		public string BusinessTripDate2 { get; set; }
		/// <summary>
		/// 사유
		/// </summary>
		[Description("사유")]
		public string Reason { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 집전화
		/// </summary>
		[Description("집전화")]
		public string HomePhone { get; set; }
		/// <summary>
		/// 핸펀
		/// </summary>
		[Description("핸펀")]
		public string Cellphone { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 100)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 결과1
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과1")]
		public string Result1 { get; set; }
	}

}