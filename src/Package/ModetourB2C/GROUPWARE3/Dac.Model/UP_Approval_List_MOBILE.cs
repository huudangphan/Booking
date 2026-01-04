namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_결재_리스트_MOBILE
/// </summary>
public class UP_Approval_List_MOBILE
{
	public const string SP_NAME = "UP_결재_리스트_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 현재페이지
		/// </summary>
		[Description("현재페이지")]
		public int CurrentPage { get; set; }
		/// <summary>
		/// 페이지당글개수
		/// </summary>
		[Description("페이지당글개수")]
		public int EachPageCharactersNumber { get; set; }
		/// <summary>
		/// 검색기간1
		/// </summary>
		[Description("검색기간1")]
		public DateTime SearchingPeriod1 { get; set; }
		/// <summary>
		/// 검색기간2
		/// </summary>
		[Description("검색기간2")]
		public DateTime SearchingPeriod2 { get; set; }
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
		/// <summary>
		/// 전체페이지수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체페이지수")]
		public int EntirePageNumber { get; set; }
	}

	public class Result1 : IDbResult
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
		/// 문서구분명
		/// </summary>
		[Column("문서구분명")]
		public string DocumentClassificationName { get; set; }
		/// <summary>
		/// 기안일
		/// </summary>
		[Column("기안일")]
		public DateTime DraftDate { get; set; }
		/// <summary>
		/// 기안자정보
		/// </summary>
		[Column("기안자정보")]
		public string DrafterInfo { get; set; }
		/// <summary>
		/// 기안자
		/// </summary>
		[Column("기안자")]
		public int Drafter { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 첨부파일
		/// </summary>
		[Column("첨부파일")]
		public byte AttachFile { get; set; }
		/// <summary>
		/// 의견
		/// </summary>
		[Column("의견")]
		public byte Opinion { get; set; }
		/// <summary>
		/// 중요도
		/// </summary>
		[Column("중요도")]
		public string ImportanceLevel { get; set; }
		/// <summary>
		/// 양식명
		/// </summary>
		[Column("양식명")]
		public string FormName { get; set; }
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
		/// 진행현황
		/// </summary>
		[Column("진행현황")]
		public string ProgressCurrentState { get; set; }
		/// <summary>
		/// 프로필이미지
		/// </summary>
		[Column("프로필이미지")]
		public string ProfileImage { get; set; }
		/// <summary>
		/// 결재현황_결재자명
		/// </summary>
		[Column("결재현황_결재자명")]
		public string ApprovalCurrentState_ApproverName { get; set; }
		/// <summary>
		/// 결재현황_직책
		/// </summary>
		[Column("결재현황_직책")]
		public string ApprovalCurrentState_Duty { get; set; }
		/// <summary>
		/// 결재현황_결재진행
		/// </summary>
		[Column("결재현황_결재진행")]
		public string ApprovalCurrentState_ApprovalProgress { get; set; }
		/// <summary>
		/// 대결여부
		/// </summary>
		[Column("대결여부")]
		public string CompetitionOrNot { get; set; }
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
		/// 문서구분명
		/// </summary>
		[Column("문서구분명")]
		public string DocumentClassificationName { get; set; }
		/// <summary>
		/// 기안일
		/// </summary>
		[Column("기안일")]
		public DateTime DraftDate { get; set; }
		/// <summary>
		/// 기안자정보
		/// </summary>
		[Column("기안자정보")]
		public string DrafterInfo { get; set; }
		/// <summary>
		/// 기안자
		/// </summary>
		[Column("기안자")]
		public int Drafter { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 첨부파일
		/// </summary>
		[Column("첨부파일")]
		public byte AttachFile { get; set; }
		/// <summary>
		/// 의견
		/// </summary>
		[Column("의견")]
		public byte Opinion { get; set; }
		/// <summary>
		/// 중요도
		/// </summary>
		[Column("중요도")]
		public string ImportanceLevel { get; set; }
		/// <summary>
		/// 결재진행일
		/// </summary>
		[Column("결재진행일")]
		public DateTime ApprovalProgressDate { get; set; }
		/// <summary>
		/// 양식명
		/// </summary>
		[Column("양식명")]
		public string FormName { get; set; }
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
		/// 진행현황
		/// </summary>
		[Column("진행현황")]
		public string ProgressCurrentState { get; set; }
		/// <summary>
		/// 프로필이미지
		/// </summary>
		[Column("프로필이미지")]
		public string ProfileImage { get; set; }
		/// <summary>
		/// 결재현황_결재자명
		/// </summary>
		[Column("결재현황_결재자명")]
		public string ApprovalCurrentState_ApproverName { get; set; }
		/// <summary>
		/// 결재현황_직책
		/// </summary>
		[Column("결재현황_직책")]
		public string ApprovalCurrentState_Duty { get; set; }
		/// <summary>
		/// 결재현황_결재진행
		/// </summary>
		[Column("결재현황_결재진행")]
		public string ApprovalCurrentState_ApprovalProgress { get; set; }
		/// <summary>
		/// 대결여부
		/// </summary>
		[Column("대결여부")]
		public string CompetitionOrNot { get; set; }
	}

	public class Result3 : IDbResult
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
		/// 문서유형
		/// </summary>
		[Column("문서유형")]
		public string DocumentType { get; set; }
		/// <summary>
		/// 문서구분명
		/// </summary>
		[Column("문서구분명")]
		public string DocumentClassificationName { get; set; }
		/// <summary>
		/// 기안일
		/// </summary>
		[Column("기안일")]
		public DateTime DraftDate { get; set; }
		/// <summary>
		/// 기안자정보
		/// </summary>
		[Column("기안자정보")]
		public string DrafterInfo { get; set; }
		/// <summary>
		/// 기안자
		/// </summary>
		[Column("기안자")]
		public int Drafter { get; set; }
		/// <summary>
		/// 대결자
		/// </summary>
		[Column("대결자")]
		public int Competitor { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 첨부파일
		/// </summary>
		[Column("첨부파일")]
		public byte AttachFile { get; set; }
		/// <summary>
		/// 의견
		/// </summary>
		[Column("의견")]
		public byte Opinion { get; set; }
		/// <summary>
		/// 중요도
		/// </summary>
		[Column("중요도")]
		public string ImportanceLevel { get; set; }
		/// <summary>
		/// 결재방법
		/// </summary>
		[Column("결재방법")]
		public string ApprovalWay { get; set; }
		/// <summary>
		/// 결재진행일
		/// </summary>
		[Column("결재진행일")]
		public DateTime ApprovalProgressDate { get; set; }
		/// <summary>
		/// 양식명
		/// </summary>
		[Column("양식명")]
		public string FormName { get; set; }
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
		/// 진행현황
		/// </summary>
		[Column("진행현황")]
		public string ProgressCurrentState { get; set; }
		/// <summary>
		/// 프로필이미지
		/// </summary>
		[Column("프로필이미지")]
		public string ProfileImage { get; set; }
		/// <summary>
		/// 결재현황_결재자명
		/// </summary>
		[Column("결재현황_결재자명")]
		public string ApprovalCurrentState_ApproverName { get; set; }
		/// <summary>
		/// 결재현황_직책
		/// </summary>
		[Column("결재현황_직책")]
		public string ApprovalCurrentState_Duty { get; set; }
		/// <summary>
		/// 결재현황_결재진행
		/// </summary>
		[Column("결재현황_결재진행")]
		public string ApprovalCurrentState_ApprovalProgress { get; set; }
		/// <summary>
		/// 대결여부
		/// </summary>
		[Column("대결여부")]
		public string CompetitionOrNot { get; set; }
	}
}