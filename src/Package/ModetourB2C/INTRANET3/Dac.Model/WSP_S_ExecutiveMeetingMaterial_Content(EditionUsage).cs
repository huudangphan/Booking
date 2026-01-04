namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_임원회의자료_내용(수정용)
/// </summary>
public class WSP_S_ExecutiveMeetingMaterial_Content_EditionUsage_
{
	public const string SP_NAME = "WSP_S_임원회의자료_내용(수정용)";

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
	}

}