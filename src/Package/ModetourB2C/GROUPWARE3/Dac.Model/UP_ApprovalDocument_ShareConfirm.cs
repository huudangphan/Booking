namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_결재문서_공개확인
/// </summary>
public class UP_ApprovalDocument_ShareConfirm
{
	public const string SP_NAME = "UP_결재문서_공개확인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 문서코드
		/// </summary>
		[Description("문서코드")]
		public int DocumentCode { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 공개여부
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("공개여부")]
		public string ReleaseOrNot { get; set; }
	}

}