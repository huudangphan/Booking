namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_통합게시판_첨부파일조회_MOBILE
/// </summary>
public class UP_IntegratedNoticeboard_AttachedFileFind_MOBILE
{
	public const string SP_NAME = "UP_통합게시판_첨부파일조회_MOBILE";

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
		public int Order { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Description("파일명")]
		public string FileName { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 첨부파일명
		/// </summary>
		[Column("첨부파일명")]
		public string AttachFileName { get; set; }
	}
}