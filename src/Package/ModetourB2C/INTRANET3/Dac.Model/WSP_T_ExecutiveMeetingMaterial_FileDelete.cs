namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_임원회의자료_파일삭제
/// </summary>
public class WSP_T_ExecutiveMeetingMaterial_FileDelete
{
	public const string SP_NAME = "WSP_T_임원회의자료_파일삭제";

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
		/// 순서
		/// </summary>
		[Description("순서")]
		public byte Order { get; set; }
	}

}