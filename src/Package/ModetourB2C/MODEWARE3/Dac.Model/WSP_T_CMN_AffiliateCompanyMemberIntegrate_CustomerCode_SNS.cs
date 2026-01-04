namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_제휴사회원통합_거래처코드_SNS
/// </summary>
public class WSP_T_CMN_AffiliateCompanyMemberIntegrate_CustomerCode_SNS
{
	public const string SP_NAME = "WSP_T_CMN_제휴사회원통합_거래처코드_SNS";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// ACODE
		/// </summary>
		[Description("ACODE")]
		public string ACODE { get; set; }
		/// <summary>
		/// CHANNEL
		/// </summary>
		[Description("CHANNEL")]
		public string CHANNEL { get; set; }
		/// <summary>
		/// CHANNELID
		/// </summary>
		[Description("CHANNELID")]
		public string CHANNELID { get; set; }
		/// <summary>
		/// RESULT
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 100)]
		[Description("RESULT")]
		public string RESULT { get; set; }
		/// <summary>
		/// RESULTID
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 100)]
		[Description("RESULTID")]
		public string RESULTID { get; set; }
	}

}