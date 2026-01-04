namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_회원실명인증2
/// </summary>
public class WSP_T_MemberRealNameVerification2
{
	public const string SP_NAME = "WSP_T_회원실명인증2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// PTKNAME
		/// </summary>
		[Description("PTKNAME")]
		public string PTKNAME { get; set; }
		/// <summary>
		/// CI
		/// </summary>
		[Description("CI")]
		public string CI { get; set; }
		/// <summary>
		/// DI
		/// </summary>
		[Description("DI")]
		public string DI { get; set; }
		/// <summary>
		/// 상태23
		/// </summary>
		[Description("상태23")]
		public string State23 { get; set; }
		/// <summary>
		/// MSG
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 10)]
		[Description("MSG")]
		public string MSG { get; set; }
	}

}