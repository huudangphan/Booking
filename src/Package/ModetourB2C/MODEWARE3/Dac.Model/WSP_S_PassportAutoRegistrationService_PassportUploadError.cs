namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_여권자동등록서비스_여권업로드오류
/// </summary>
public class WSP_S_PassportAutoRegistrationService_PassportUploadError
{
	public const string SP_NAME = "WSP_S_여권자동등록서비스_여권업로드오류";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 오류내용
		/// </summary>
		[Description("오류내용")]
		public string ErrorContent { get; set; }
	}

}