namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_인도네시아_비자게시판등록
/// </summary>
public class WSP_T_Indonesia_VisaNoticeboardRegistration
{
	public const string SP_NAME = "WSP_T_인도네시아_비자게시판등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 작업구분
		/// </summary>
		[Description("작업구분")]
		public string WorkingClassification { get; set; }
		/// <summary>
		/// 게시판구분
		/// </summary>
		[Description("게시판구분")]
		public int NoticeboardClassification { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 스텝1
		/// </summary>
		[Description("스텝1")]
		public int Step1 { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Description("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Description("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 태그
		/// </summary>
		[Description("태그")]
		public byte Tag { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 파일1
		/// </summary>
		[Description("파일1")]
		public string File1 { get; set; }
		/// <summary>
		/// 파일2
		/// </summary>
		[Description("파일2")]
		public string File2 { get; set; }
		/// <summary>
		/// 파일3
		/// </summary>
		[Description("파일3")]
		public string File3 { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 비밀설정여부
		/// </summary>
		[Description("비밀설정여부")]
		public string PasswordSettingOrNot { get; set; }
		/// <summary>
		/// 답변여부
		/// </summary>
		[Description("답변여부")]
		public string AnswerOrNot { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Description("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 언어구분
		/// </summary>
		[Description("언어구분")]
		public string LanguageClassification { get; set; }
		/// <summary>
		/// 공지
		/// </summary>
		[Description("공지")]
		public bool Notification { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 결과
		/// </summary>
		[Column("결과")]
		public string RESULT { get; set; }
	}
}