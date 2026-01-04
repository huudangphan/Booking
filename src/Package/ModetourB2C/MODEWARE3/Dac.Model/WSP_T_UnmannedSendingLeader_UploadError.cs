namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_무인센딩인솔자_업로드오류
/// </summary>
public class WSP_T_UnmannedSendingLeader_UploadError
{
	public const string SP_NAME = "WSP_T_무인센딩인솔자_업로드오류";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 오류내용
		/// </summary>
		[Description("오류내용")]
		public string ErrorContent { get; set; }
	}

}