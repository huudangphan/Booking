namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_SO_거래처_업무보고
/// </summary>
public class WSP_SO_Customer_DutyReport
{
	public const string SP_NAME = "WSP_SO_거래처_업무보고";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 시작일
		/// </summary>
		[Description("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Description("종료일")]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 전체검색
		/// </summary>
		[Description("전체검색")]
		public string EntireSearch { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 선택
		/// </summary>
		[Column("선택")]
		public string Select { get; set; }
		/// <summary>
		/// 문서구분
		/// </summary>
		[Column("문서구분")]
		public string DocumentClassification { get; set; }
		/// <summary>
		/// 결재요청건
		/// </summary>
		[Column("결재요청건")]
		public string ApprovalRequest { get; set; }
		/// <summary>
		/// 보고일련번호
		/// </summary>
		[Column("보고일련번호")]
		public int ReportSerialNumber { get; set; }
		/// <summary>
		/// 작성자번호
		/// </summary>
		[Column("작성자번호")]
		public int WritterNumber { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 작성자부서번호
		/// </summary>
		[Column("작성자부서번호")]
		public int WritterDepartmentNumber { get; set; }
		/// <summary>
		/// 작성자부서
		/// </summary>
		[Column("작성자부서")]
		public string WritterDepartment { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public string WrittingDate { get; set; }
		/// <summary>
		/// 모객동향
		/// </summary>
		[Column("모객동향")]
		public string AudienceTrends { get; set; }
		/// <summary>
		/// 실적보고
		/// </summary>
		[Column("실적보고")]
		public string ResultReport { get; set; }
		/// <summary>
		/// 지점별동향보고
		/// </summary>
		[Column("지점별동향보고")]
		public string EachBranchTrendsReport { get; set; }
		/// <summary>
		/// 경쟁사동향
		/// </summary>
		[Column("경쟁사동향")]
		public string CompetitorTrends { get; set; }
		/// <summary>
		/// 건의사항
		/// </summary>
		[Column("건의사항")]
		public string Recommendation { get; set; }
		/// <summary>
		/// 상위자번호
		/// </summary>
		[Column("상위자번호")]
		public int HighRankerNumber { get; set; }
		/// <summary>
		/// 상위자
		/// </summary>
		[Column("상위자")]
		public string HighRanker { get; set; }
		/// <summary>
		/// 상위자부서번호
		/// </summary>
		[Column("상위자부서번호")]
		public int HighRankerDepartmentNumber { get; set; }
		/// <summary>
		/// 상위자부서
		/// </summary>
		[Column("상위자부서")]
		public string HighRankerDepartment { get; set; }
		/// <summary>
		/// 상위자확인일자
		/// </summary>
		[Column("상위자확인일자")]
		public string HighRankerConfirmDate { get; set; }
		/// <summary>
		/// 영업대결자번호
		/// </summary>
		[Column("영업대결자번호")]
		public int BusinessCompetitorNumber { get; set; }
		/// <summary>
		/// 영업대결자
		/// </summary>
		[Column("영업대결자")]
		public string BusinessCompetitor { get; set; }
		/// <summary>
		/// 대결사용
		/// </summary>
		[Column("대결사용")]
		public string CompetitionUse { get; set; }
		/// <summary>
		/// 업무보고
		/// </summary>
		[Column("업무보고")]
		public string WorkReport { get; set; }
	}
}