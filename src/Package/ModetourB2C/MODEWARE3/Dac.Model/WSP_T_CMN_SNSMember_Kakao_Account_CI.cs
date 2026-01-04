namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_SNS회원_카카오_계정_CI
/// </summary>
public class WSP_T_CMN_SNSMember_Kakao_Account_CI
{
	public const string SP_NAME = "WSP_T_CMN_SNS회원_카카오_계정_CI";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// user_id
		/// </summary>
		[Description("user_id")]
		public string user_id { get; set; }
		/// <summary>
		/// CI
		/// </summary>
		[Description("CI")]
		public string CI { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

}