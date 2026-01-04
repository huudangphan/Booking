namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_이메일회원조회
/// </summary>
public class WSP_S_EmailMemberFind
{
	public const string SP_NAME = "WSP_S_이메일회원조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// EMAIL
		/// </summary>
		[Description("EMAIL")]
		public string EMAIL { get; set; }
		/// <summary>
		/// MSG
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 10)]
		[Description("MSG")]
		public string MSG { get; set; }
	}

}