namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_BTMS_거래처직원_회원가입_중복
/// </summary>
public class WSP_S_CMN_BTMS_CustomerEmployee_MemberSignUp_Duplication
{
	public const string SP_NAME = "WSP_S_CMN_BTMS_거래처직원_회원가입_중복";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Cnt
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("Cnt")]
		public int Cnt { get; set; }
		/// <summary>
		/// UserId
		/// </summary>
		[Description("UserId")]
		public string UserId { get; set; }
	}

}