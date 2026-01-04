namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_게시판분류
/// </summary>
public class WSP_S_NoticeboardClassification
{
	public const string SP_NAME = "WSP_S_게시판분류";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 게시판번호
		/// </summary>
		[Description("게시판번호")]
		public int NoticeboardNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 게시판번호
		/// </summary>
		[Column("게시판번호")]
		public int NoticeboardNumber { get; set; }
		/// <summary>
		/// 게시판명
		/// </summary>
		[Column("게시판명")]
		public string NoticeboardName { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
		/// <summary>
		/// 테이블명
		/// </summary>
		[Column("테이블명")]
		public string TableName { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 답변유무
		/// </summary>
		[Column("답변유무")]
		public bool AnswerOrNot { get; set; }
		/// <summary>
		/// 댓글유무
		/// </summary>
		[Column("댓글유무")]
		public bool CommentOrNot { get; set; }
		/// <summary>
		/// 공지권한
		/// </summary>
		[Column("공지권한")]
		public string NotificationAuthority { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 비밀번호변경권한
		/// </summary>
		[Column("비밀번호변경권한")]
		public string PasswordChangeAuthority { get; set; }
		/// <summary>
		/// 말머리
		/// </summary>
		[Column("말머리")]
		public string HeadOfStory { get; set; }
		/// <summary>
		/// 작성자실명
		/// </summary>
		[Column("작성자실명")]
		public bool WritterRealName { get; set; }
		/// <summary>
		/// 댓글자실명
		/// </summary>
		[Column("댓글자실명")]
		public bool CommenterRealName { get; set; }
		/// <summary>
		/// 마지막등록일
		/// </summary>
		[Column("마지막등록일")]
		public DateTime LastRegisterDate { get; set; }
		/// <summary>
		/// 사용
		/// </summary>
		[Column("사용")]
		public bool Use { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// 관리담당
		/// </summary>
		[Column("관리담당")]
		public string ManageResponsibility { get; set; }
		/// <summary>
		/// 작성자구분
		/// </summary>
		[Column("작성자구분")]
		public string WritterClassification { get; set; }
		/// <summary>
		/// 공지권한1
		/// </summary>
		[Column("공지권한1")]
		public string NotificationAuthority1 { get; set; }
	}
}