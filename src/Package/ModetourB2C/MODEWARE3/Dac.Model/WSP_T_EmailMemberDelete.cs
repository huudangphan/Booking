namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_이메일회원삭제
/// </summary>
public class WSP_T_EmailMemberDelete
{
	public const string SP_NAME = "WSP_T_이메일회원삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// EMAIL
		/// </summary>
		[Description("EMAIL")]
		public string EMAIL { get; set; }
		/// <summary>
		/// RETURN
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 2)]
		[Description("RETURN")]
		public string RETURN { get; set; }
	}

}