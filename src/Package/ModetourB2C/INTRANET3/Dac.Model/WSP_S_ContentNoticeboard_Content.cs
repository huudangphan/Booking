namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_컨텐츠게시판_내용
/// </summary>
public class WSP_S_ContentNoticeboard_Content
{
	public const string SP_NAME = "WSP_S_컨텐츠게시판_내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 게시판명
		/// </summary>
		[Description("게시판명")]
		public string NoticeboardName { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 게시판명
		/// </summary>
		[Column("게시판명")]
		public string NoticeboardName { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Column("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 작성자명
		/// </summary>
		[Column("작성자명")]
		public string WritterName { get; set; }
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
		/// 접수일
		/// </summary>
		[Column("접수일")]
		public string ReceiptDate { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 항목
		/// </summary>
		[Column("항목")]
		public string Item { get; set; }
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
		/// 첨부
		/// </summary>
		[Column("첨부")]
		public string Attach { get; set; }
		/// <summary>
		/// 처리결과
		/// </summary>
		[Column("처리결과")]
		public bool HandleResult { get; set; }
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
		/// <summary>
		/// 만족도
		/// </summary>
		[Column("만족도")]
		public string SatisfactionRate { get; set; }
	}

	public class Result2 : IDbResult
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
		/// 아이피
		/// </summary>
		[Column("아이피")]
		public string IP { get; set; }
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
		/// 마지막등록일
		/// </summary>
		[Column("마지막등록일")]
		public DateTime LastRegisterDate { get; set; }
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
		/// 관리자평가
		/// </summary>
		[Column("관리자평가")]
		public int AdminEvaluation { get; set; }
		/// <summary>
		/// 관리자비고
		/// </summary>
		[Column("관리자비고")]
		public string AdminNote { get; set; }
		/// <summary>
		/// 수신
		/// </summary>
		[Column("수신")]
		public string Reception { get; set; }
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
		/// 모바일작성여부
		/// </summary>
		[Column("모바일작성여부")]
		public string MobileWrittingOrNot { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 게시판명
		/// </summary>
		[Column("게시판명")]
		public string NoticeboardName { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Column("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 작성자명
		/// </summary>
		[Column("작성자명")]
		public string WritterName { get; set; }
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
		/// 접수일
		/// </summary>
		[Column("접수일")]
		public string ReceiptDate { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 항목
		/// </summary>
		[Column("항목")]
		public string Item { get; set; }
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
		/// 첨부
		/// </summary>
		[Column("첨부")]
		public string Attach { get; set; }
		/// <summary>
		/// 처리결과
		/// </summary>
		[Column("처리결과")]
		public bool HandleResult { get; set; }
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

	public class Result4 : IDbResult
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
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}
}