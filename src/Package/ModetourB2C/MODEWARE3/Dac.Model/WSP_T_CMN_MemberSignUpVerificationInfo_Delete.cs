namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_회원가입인증정보_삭제
/// </summary>
public class WSP_T_CMN_MemberSignUpVerificationInfo_Delete
{
	public const string SP_NAME = "WSP_T_CMN_회원가입인증정보_삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

}