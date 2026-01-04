namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_첨부파일_종류수정
/// </summary>
public class WSP_T_Recruitment_Supporter_AttachedFile_TypeEdit
{
	public const string SP_NAME = "WSP_T_채용_지원자_첨부파일_종류수정";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 첨부파일일련번호
		/// </summary>
		[Description("첨부파일일련번호")]
		public int AttachFileSerialNumber { get; set; }
		/// <summary>
		/// 파일종류코드번호
		/// </summary>
		[Description("파일종류코드번호")]
		public int FileTypeCodeNumber { get; set; }
		/// <summary>
		/// 파일종류코드명
		/// </summary>
		[Description("파일종류코드명")]
		public string FileTypeCodeName { get; set; }
	}

}