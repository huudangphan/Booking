namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_인도네시아_비자게시판보기
/// </summary>
public class WSP_S_Indonesia_VisaNoticeboardSeeing
{
	public const string SP_NAME = "WSP_S_인도네시아_비자게시판보기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 게시판구분
		/// </summary>
		[Description("게시판구분")]
		public int NoticeboardClassification { get; set; }
		/// <summary>
		/// 언어구분
		/// </summary>
		[Description("언어구분")]
		public string LanguageClassification { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 관리자여부
		/// </summary>
		[Description("관리자여부")]
		public string AdminOrNot { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 게시판구분
		/// </summary>
		[Column("게시판구분")]
		public int NoticeboardClassification { get; set; }
		/// <summary>
		/// 스텝1
		/// </summary>
		[Column("스텝1")]
		public int Step1 { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 파일1
		/// </summary>
		[Column("파일1")]
		public string File1 { get; set; }
		/// <summary>
		/// 파일2
		/// </summary>
		[Column("파일2")]
		public string File2 { get; set; }
		/// <summary>
		/// 파일3
		/// </summary>
		[Column("파일3")]
		public string File3 { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 비밀설정여부
		/// </summary>
		[Column("비밀설정여부")]
		public string PasswordSettingOrNot { get; set; }
		/// <summary>
		/// 답변여부
		/// </summary>
		[Column("답변여부")]
		public string AnswerOrNot { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 언어구분
		/// </summary>
		[Column("언어구분")]
		public string LanguageClassification { get; set; }
		/// <summary>
		/// 공지
		/// </summary>
		[Column("공지")]
		public bool Notification { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// 관리자답변
		/// </summary>
		[Column("관리자답변")]
		public string AdminAnswer { get; set; }
	}
}