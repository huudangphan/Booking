namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_결재하기_저장
/// </summary>
public class UP_Approval_Saving
{
	public const string SP_NAME = "UP_결재하기_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 문서코드
		/// </summary>
		[Description("문서코드")]
		public int DocumentCode { get; set; }
		/// <summary>
		/// 결재순서
		/// </summary>
		[Description("결재순서")]
		public int ApprovalOrder { get; set; }
		/// <summary>
		/// 서명
		/// </summary>
		[Description("서명")]
		public string Signature { get; set; }
		/// <summary>
		/// 대결자
		/// </summary>
		[Description("대결자")]
		public string Competitor { get; set; }
		/// <summary>
		/// 대결자직원번호
		/// </summary>
		[Description("대결자직원번호")]
		public int CompetitorEmployeeNumber { get; set; }
		/// <summary>
		/// 대결자직책
		/// </summary>
		[Description("대결자직책")]
		public string CompetitorDuty { get; set; }
		/// <summary>
		/// 대결자부서
		/// </summary>
		[Description("대결자부서")]
		public string CompetitorDepartment { get; set; }
		/// <summary>
		/// 결재진행
		/// </summary>
		[Description("결재진행")]
		public string ApprovalProgress { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 직원정보
		/// </summary>
		[Description("직원정보")]
		public string EmployeeInfo { get; set; }
		/// <summary>
		/// 의견
		/// </summary>
		[Description("의견")]
		public string Opinion { get; set; }
		/// <summary>
		/// 점수
		/// </summary>
		[Description("점수")]
		public byte Score { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
	}
}