namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_전체게시판_비밀번호
/// </summary>
public class WSP_S_WholeNoticeboard_Password
{
	public const string SP_NAME = "WSP_S_전체게시판_비밀번호";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 게시판명
		/// </summary>
		[Description("게시판명")]
		public string NoticeboardName { get; set; }
		/// <summary>
		/// 테이블명
		/// </summary>
		[Description("테이블명")]
		public string TableName { get; set; }
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