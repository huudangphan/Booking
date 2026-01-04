namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_통합게시판01_내용
/// </summary>
public class UP_IntegratedNoticeboard01_Content
{
	public const string SP_NAME = "UP_통합게시판01_내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
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
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 게시판번호
		/// </summary>
		[Column("게시판번호")]
		public int NoticeboardNumber { get; set; }
		/// <summary>
		/// 스텝1
		/// </summary>
		[Column("스텝1")]
		public int Step1 { get; set; }
		/// <summary>
		/// 스텝2
		/// </summary>
		[Column("스텝2")]
		public byte Step2 { get; set; }
		/// <summary>
		/// 스텝3
		/// </summary>
		[Column("스텝3")]
		public byte Step3 { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Column("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 말머리
		/// </summary>
		[Column("말머리")]
		public string HeadOfStory { get; set; }
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
		/// 태그
		/// </summary>
		[Column("태그")]
		public string Tag { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 메모수
		/// </summary>
		[Column("메모수")]
		public short MemoCount { get; set; }
		/// <summary>
		/// 공지날짜
		/// </summary>
		[Column("공지날짜")]
		public string NotificationDate { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 부서코드
		/// </summary>
		[Column("부서코드")]
		public int DepartmentCode { get; set; }
		/// <summary>
		/// 제목태그
		/// </summary>
		[Column("제목태그")]
		public string TitleTag { get; set; }
		/// <summary>
		/// 직원조회수
		/// </summary>
		[Column("직원조회수")]
		public int EmployeeSearchNumber { get; set; }
		/// <summary>
		/// 수신
		/// </summary>
		[Column("수신")]
		public string Reception { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 폴더명
		/// </summary>
		[Column("폴더명")]
		public string FolderName { get; set; }
		/// <summary>
		/// 평가
		/// </summary>
		[Column("평가")]
		public byte Evaluation { get; set; }
		/// <summary>
		/// 담당자번호
		/// </summary>
		[Column("담당자번호")]
		public int ManagerNumber { get; set; }
		/// <summary>
		/// 담당자정보
		/// </summary>
		[Column("담당자정보")]
		public string ManagerInfo { get; set; }
		/// <summary>
		/// 만족도
		/// </summary>
		[Column("만족도")]
		public string SatisfactionRate { get; set; }
		/// <summary>
		/// 관리자비고
		/// </summary>
		[Column("관리자비고")]
		public string AdminNote { get; set; }
		/// <summary>
		/// 답변내용
		/// </summary>
		[Column("답변내용")]
		public string AnswerContent { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public byte Order { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 폴더명
		/// </summary>
		[Column("폴더명")]
		public string FolderName { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Column("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}

	public class Result4 : IDbResult
	{
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
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 말머리
		/// </summary>
		[Column("말머리")]
		public string HeadOfStory { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Column("직원번호")]
		public int EmployeeNumber { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 스텝1
		/// </summary>
		[Column("스텝1")]
		public int Step1 { get; set; }
		/// <summary>
		/// 스텝2
		/// </summary>
		[Column("스텝2")]
		public byte Step2 { get; set; }
		/// <summary>
		/// 스텝3
		/// </summary>
		[Column("스텝3")]
		public byte Step3 { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 말머리
		/// </summary>
		[Column("말머리")]
		public string HeadOfStory { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Column("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 메모수
		/// </summary>
		[Column("메모수")]
		public short MemoCount { get; set; }
		/// <summary>
		/// 공지날짜
		/// </summary>
		[Column("공지날짜")]
		public string NotificationDate { get; set; }
		/// <summary>
		/// 직원조회수
		/// </summary>
		[Column("직원조회수")]
		public int EmployeeSearchNumber { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// 찬성
		/// </summary>
		[Column("찬성")]
		public string Agree { get; set; }
		/// <summary>
		/// 참여수
		/// </summary>
		[Column("참여수")]
		public int JoiningNumber { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// 게시판명
		/// </summary>
		[Column("게시판명")]
		public string NoticeboardName { get; set; }
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
		/// 댓글자구분
		/// </summary>
		[Column("댓글자구분")]
		public string CommenterClassification { get; set; }
		/// <summary>
		/// 평가유무
		/// </summary>
		[Column("평가유무")]
		public bool EvaluationOrNot { get; set; }
		/// <summary>
		/// 찬성유무
		/// </summary>
		[Column("찬성유무")]
		public bool AgreeOrNot { get; set; }
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
		/// 공지권한
		/// </summary>
		[Column("공지권한")]
		public string NotificationAuthority { get; set; }
		/// <summary>
		/// 말머리
		/// </summary>
		[Column("말머리")]
		public string HeadOfStory { get; set; }
	}

	public class Result8 : IDbResult
	{
		/// <summary>
		/// 메모작성자명
		/// </summary>
		[Column("메모작성자명")]
		public string MemoWritterName { get; set; }
	}
}