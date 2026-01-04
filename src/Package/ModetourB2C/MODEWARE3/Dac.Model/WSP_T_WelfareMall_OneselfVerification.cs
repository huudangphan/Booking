namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_복지몰_본인인증
/// </summary>
public class WSP_T_WelfareMall_OneselfVerification
{
	public const string SP_NAME = "WSP_T_복지몰_본인인증";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// DI
		/// </summary>
		[Description("DI")]
		public string DI { get; set; }
		/// <summary>
		/// CI
		/// </summary>
		[Description("CI")]
		public string CI { get; set; }
		/// <summary>
		/// RETURN
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 200)]
		[Description("RETURN")]
		public string RETURN { get; set; }
	}

}