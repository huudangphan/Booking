namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_회원가입인증정보_입력
/// </summary>
public class WSP_T_CMN_MemberSignUpVerificationInfo_Input
{
	public const string SP_NAME = "WSP_T_CMN_회원가입인증정보_입력";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 인증수단
		/// </summary>
		[Description("인증수단")]
		public string VerificationMethod { get; set; }
		/// <summary>
		/// 등록IP
		/// </summary>
		[Description("등록IP")]
		public string RegisterIP { get; set; }
		/// <summary>
		/// 도메인
		/// </summary>
		[Description("도메인")]
		public string Domain { get; set; }
		/// <summary>
		/// 페이지경로
		/// </summary>
		[Description("페이지경로")]
		public string PageRoute { get; set; }
		/// <summary>
		/// 파라미터
		/// </summary>
		[Description("파라미터")]
		public string Parameter { get; set; }
		/// <summary>
		/// 인증값1
		/// </summary>
		[Description("인증값1")]
		public string VerificationValue1 { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

}