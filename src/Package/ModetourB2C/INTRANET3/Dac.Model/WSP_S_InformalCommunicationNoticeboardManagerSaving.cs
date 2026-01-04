namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_비공식의사소통게시판담당자저장
/// </summary>
public class WSP_S_InformalCommunicationNoticeboardManagerSaving
{
	public const string SP_NAME = "WSP_S_비공식의사소통게시판담당자저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 담당자번호
		/// </summary>
		[Description("담당자번호")]
		public int ManagerNumber { get; set; }
		/// <summary>
		/// 담당자정보
		/// </summary>
		[Description("담당자정보")]
		public string ManagerInfo { get; set; }
	}

}