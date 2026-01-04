namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_아카마이업로드오류
/// </summary>
public class WSP_T_AkamaiUploadError
{
	public const string SP_NAME = "WSP_T_아카마이업로드오류";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 오류내용
		/// </summary>
		[Description("오류내용")]
		public string ErrorContent { get; set; }
		/// <summary>
		/// 임시파일경로
		/// </summary>
		[Description("임시파일경로")]
		public string TemporaryFileRoute { get; set; }
		/// <summary>
		/// 접속경로
		/// </summary>
		[Description("접속경로")]
		public string AccessRoute { get; set; }
		/// <summary>
		/// 실제임시파일존재유무
		/// </summary>
		[Description("실제임시파일존재유무")]
		public string RealTemporaryFileExistOrNot { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
	}

}