namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_게시판리스트_메인
/// </summary>
public class WSP_S_CMN_NoticeboardList_Main
{
	public const string SP_NAME = "WSP_S_CMN_게시판리스트_메인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public int Classification { get; set; }
		/// <summary>
		/// 게시물수
		/// </summary>
		[Description("게시물수")]
		public int PostNumber { get; set; }
		/// <summary>
		/// 공지
		/// </summary>
		[Description("공지")]
		public string Notification { get; set; }
	}

}