namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_통합게시판01_등록
/// </summary>
public class UP_IntegratedNoticeboard01_Registration
{
	public const string SP_NAME = "UP_통합게시판01_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 작업구분
		/// </summary>
		[Description("작업구분")]
		public string WorkingClassification { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 게시판번호
		/// </summary>
		[Description("게시판번호")]
		public int NoticeboardNumber { get; set; }
		/// <summary>
		/// 스텝1
		/// </summary>
		[Description("스텝1")]
		public int Step1 { get; set; }
		/// <summary>
		/// 스텝2
		/// </summary>
		[Description("스텝2")]
		public int Step2 { get; set; }
		/// <summary>
		/// 스텝3
		/// </summary>
		[Description("스텝3")]
		public int Step3 { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Description("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 말머리
		/// </summary>
		[Description("말머리")]
		public string HeadOfStory { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Description("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 첨부파일수
		/// </summary>
		[Description("첨부파일수")]
		public int AttachFileCount { get; set; }
		/// <summary>
		/// 첨부폴더명
		/// </summary>
		[Description("첨부폴더명")]
		public string AttachFolderName { get; set; }
		/// <summary>
		/// 첨부파일명
		/// </summary>
		[Description("첨부파일명")]
		public string AttachFileName { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 태그
		/// </summary>
		[Description("태그")]
		public string Tag { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Description("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 공지날짜
		/// </summary>
		[Description("공지날짜")]
		public string NotificationDate { get; set; }
		/// <summary>
		/// 부서코드
		/// </summary>
		[Description("부서코드")]
		public int DepartmentCode { get; set; }
		/// <summary>
		/// 제목태그
		/// </summary>
		[Description("제목태그")]
		public string TitleTag { get; set; }
		/// <summary>
		/// 수신
		/// </summary>
		[Description("수신")]
		public string Reception { get; set; }
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
		/// <summary>
		/// 번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("번호")]
		public int Number { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
	}
}