namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_임원회의자료_파일저장
/// </summary>
public class WSP_T_ExecutiveMeetingMaterial_FileSaving
{
	public const string SP_NAME = "WSP_T_임원회의자료_파일저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 게시판번호
		/// </summary>
		[Description("게시판번호")]
		public int NoticeboardNumber { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 작성자정보
		/// </summary>
		[Description("작성자정보")]
		public string WritterInfo { get; set; }
		/// <summary>
		/// 파일폴더
		/// </summary>
		[Description("파일폴더")]
		public string FileFolder { get; set; }
		/// <summary>
		/// 파일
		/// </summary>
		[Description("파일")]
		public string File { get; set; }
	}

}