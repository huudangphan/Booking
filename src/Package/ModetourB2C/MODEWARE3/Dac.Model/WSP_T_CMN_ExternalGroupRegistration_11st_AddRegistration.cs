namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_외부단체등록_11번가_추가등록
/// </summary>
public class WSP_T_CMN_ExternalGroupRegistration_11st_AddRegistration
{
	public const string SP_NAME = "WSP_T_CMN_외부단체등록_11번가_추가등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 20)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 기존업체단체번호
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 20)]
		[Description("기존업체단체번호")]
		public string ExistingCompanyGroupNumber { get; set; }
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