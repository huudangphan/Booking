namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_생체인식회원가입_중복조회
/// </summary>
public class WSP_S_CMN_BiometricsMemberSignUp_DuplicationFind
{
	public const string SP_NAME = "WSP_S_CMN_생체인식회원가입_중복조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MODE
		/// </summary>
		[Description("MODE")]
		public string MODE { get; set; }
		/// <summary>
		/// APPKEY
		/// </summary>
		[Description("APPKEY")]
		public string APPKEY { get; set; }
		/// <summary>
		/// UUID
		/// </summary>
		[Description("UUID")]
		public string UUID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// RETURN_CODE
		/// </summary>
		[Column("RETURN_CODE")]
		public int RETURN_CODE { get; set; }
		/// <summary>
		/// RETURN_MSG
		/// </summary>
		[Column("RETURN_MSG")]
		public string RETURN_MSG { get; set; }
		/// <summary>
		/// RETURN_DATA
		/// </summary>
		[Column("RETURN_DATA")]
		public string RETURN_DATA { get; set; }
	}
}