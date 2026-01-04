namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_영업본부메인
/// </summary>
public class WSP_S_BusinessHeadOfficeMain
{
	public const string SP_NAME = "WSP_S_영업본부메인";

	public class Result : IDbResult
	{
		/// <summary>
		/// 게시판번호
		/// </summary>
		[Column("게시판번호")]
		public int NoticeboardNumber { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 마지막등록일
		/// </summary>
		[Column("마지막등록일")]
		public DateTime LastRegisterDate { get; set; }
	}
}