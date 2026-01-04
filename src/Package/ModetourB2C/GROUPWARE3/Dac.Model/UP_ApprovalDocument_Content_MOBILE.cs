namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_결재문서_내용_MOBILE
/// </summary>
public class UP_ApprovalDocument_Content_MOBILE
{
	public const string SP_NAME = "UP_결재문서_내용_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 문서코드
		/// </summary>
		[Description("문서코드")]
		public int DocumentCode { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 직원정보
		/// </summary>
		[Description("직원정보")]
		public string EmployeeInfo { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 결재순서
		/// </summary>
		[Column("결재순서")]
		public byte ApprovalOrder { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Column("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 직책
		/// </summary>
		[Column("직책")]
		public string Duty { get; set; }
		/// <summary>
		/// 부서
		/// </summary>
		[Column("부서")]
		public string Department { get; set; }
		/// <summary>
		/// 결재방법
		/// </summary>
		[Column("결재방법")]
		public string ApprovalWay { get; set; }
		/// <summary>
		/// 결재선변경
		/// </summary>
		[Column("결재선변경")]
		public bool ChangeBeforeApproval { get; set; }
		/// <summary>
		/// 문서변경
		/// </summary>
		[Column("문서변경")]
		public bool DocumentChange { get; set; }
		/// <summary>
		/// 서명
		/// </summary>
		[Column("서명")]
		public string Signature { get; set; }
		/// <summary>
		/// 대결자
		/// </summary>
		[Column("대결자")]
		public string Competitor { get; set; }
		/// <summary>
		/// 대결직원번호
		/// </summary>
		[Column("대결직원번호")]
		public int CompetitionEmployeeNumber { get; set; }
		/// <summary>
		/// 대결자직책
		/// </summary>
		[Column("대결자직책")]
		public string CompetitorDuty { get; set; }
		/// <summary>
		/// 대결자부서
		/// </summary>
		[Column("대결자부서")]
		public string CompetitorDepartment { get; set; }
		/// <summary>
		/// 최초결재일
		/// </summary>
		[Column("최초결재일")]
		public DateTime FirstApprovalDate { get; set; }
		/// <summary>
		/// 최종결재일
		/// </summary>
		[Column("최종결재일")]
		public DateTime FinalApprovalDate { get; set; }
		/// <summary>
		/// 결재진행
		/// </summary>
		[Column("결재진행")]
		public string ApprovalProgress { get; set; }
		/// <summary>
		/// 점수
		/// </summary>
		[Column("점수")]
		public byte Score { get; set; }
		/// <summary>
		/// 예산합의여부
		/// </summary>
		[Column("예산합의여부")]
		public string BudgetDiscussionOrNot { get; set; }
		/// <summary>
		/// 프로필이미지
		/// </summary>
		[Column("프로필이미지")]
		public string ProfileImage { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 문서코드
		/// </summary>
		[Column("문서코드")]
		public int DocumentCode { get; set; }
		/// <summary>
		/// 문서번호
		/// </summary>
		[Column("문서번호")]
		public string DocumentNumber { get; set; }
		/// <summary>
		/// 문서구분
		/// </summary>
		[Column("문서구분")]
		public string DocumentClassification { get; set; }
		/// <summary>
		/// 기안부서
		/// </summary>
		[Column("기안부서")]
		public int DraftDepartment { get; set; }
		/// <summary>
		/// 기안부서명
		/// </summary>
		[Column("기안부서명")]
		public string DraftDepartmentName { get; set; }
		/// <summary>
		/// 기안일
		/// </summary>
		[Column("기안일")]
		public DateTime DraftDate { get; set; }
		/// <summary>
		/// 실제기안일
		/// </summary>
		[Column("실제기안일")]
		public DateTime RealDraftDate { get; set; }
		/// <summary>
		/// 기안자
		/// </summary>
		[Column("기안자")]
		public int Drafter { get; set; }
		/// <summary>
		/// 기안자정보
		/// </summary>
		[Column("기안자정보")]
		public string DrafterInfo { get; set; }
		/// <summary>
		/// 보존년한
		/// </summary>
		[Column("보존년한")]
		public string PreservationYearLimit { get; set; }
		/// <summary>
		/// 양식명
		/// </summary>
		[Column("양식명")]
		public string FormName { get; set; }
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
		/// 폼문서코드
		/// </summary>
		[Column("폼문서코드")]
		public int FormDocumentCode { get; set; }
		/// <summary>
		/// 첨부파일
		/// </summary>
		[Column("첨부파일")]
		public byte AttachFile { get; set; }
		/// <summary>
		/// 첨부문서
		/// </summary>
		[Column("첨부문서")]
		public byte AttachDocument { get; set; }
		/// <summary>
		/// 의견
		/// </summary>
		[Column("의견")]
		public byte Opinion { get; set; }
		/// <summary>
		/// 참조
		/// </summary>
		[Column("참조")]
		public byte Reference { get; set; }
		/// <summary>
		/// 문서변경
		/// </summary>
		[Column("문서변경")]
		public byte DocumentChange { get; set; }
		/// <summary>
		/// 중요도
		/// </summary>
		[Column("중요도")]
		public string ImportanceLevel { get; set; }
		/// <summary>
		/// 문서공개
		/// </summary>
		[Column("문서공개")]
		public string DocumentRelease { get; set; }
		/// <summary>
		/// 보안결재
		/// </summary>
		[Column("보안결재")]
		public string SecurityApproval { get; set; }
		/// <summary>
		/// 결재진행
		/// </summary>
		[Column("결재진행")]
		public string ApprovalProgress { get; set; }
		/// <summary>
		/// 에디터사용
		/// </summary>
		[Column("에디터사용")]
		public string EditorUse { get; set; }
		/// <summary>
		/// 근거기안사용
		/// </summary>
		[Column("근거기안사용")]
		public bool EvidenceDraftUse { get; set; }
		/// <summary>
		/// 양식번호
		/// </summary>
		[Column("양식번호")]
		public short FormNumber { get; set; }
		/// <summary>
		/// 전월예산사용유무
		/// </summary>
		[Column("전월예산사용유무")]
		public string LastMonthBudgetUseOrNot { get; set; }
		/// <summary>
		/// 프로필이미지
		/// </summary>
		[Column("프로필이미지")]
		public string ProfileImage { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 직원번호
		/// </summary>
		[Column("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 직원정보
		/// </summary>
		[Column("직원정보")]
		public string EmployeeInfo { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 문서코드
		/// </summary>
		[Column("문서코드")]
		public int DocumentCode { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public byte Order { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 파일
		/// </summary>
		[Column("파일")]
		public string File { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public byte Order { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 직원정보
		/// </summary>
		[Column("직원정보")]
		public string EmployeeInfo { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Column("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 프로필이미지
		/// </summary>
		[Column("프로필이미지")]
		public string ProfileImage { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// 카드내역정보
		/// </summary>
		[Column("카드내역정보")]
		public string CardHistoryInfo { get; set; }
	}

	public class Result8 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Column("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 직원정보
		/// </summary>
		[Column("직원정보")]
		public string EmployeeInfo { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
	}
}