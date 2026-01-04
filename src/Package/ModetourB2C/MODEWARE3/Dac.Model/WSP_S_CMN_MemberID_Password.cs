namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_회원아이디_비밀번호
/// </summary>
public class WSP_S_CMN_MemberID_Password
{
	public const string SP_NAME = "WSP_S_CMN_회원아이디_비밀번호";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 업체번호
		/// </summary>
		[Description("업체번호")]
		public int CompanyNumber { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Description("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// DI
		/// </summary>
		[Description("DI")]
		public string DI { get; set; }
		/// <summary>
		/// SEARCHPWD
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 100)]
		[Description("SEARCHPWD")]
		public string SEARCHPWD { get; set; }
		/// <summary>
		/// SEAREMAIL
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 100)]
		[Description("SEAREMAIL")]
		public string SEAREMAIL { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 10)]
		[Description("결과")]
		public string Result { get; set; }
	}

}