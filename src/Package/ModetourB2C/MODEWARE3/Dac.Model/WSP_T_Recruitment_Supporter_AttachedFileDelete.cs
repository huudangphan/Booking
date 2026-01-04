namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_첨부파일삭제
/// </summary>
public class WSP_T_Recruitment_Supporter_AttachedFileDelete
{
	public const string SP_NAME = "WSP_T_채용_지원자_첨부파일삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Description("파일명")]
		public string FileName { get; set; }
	}

}