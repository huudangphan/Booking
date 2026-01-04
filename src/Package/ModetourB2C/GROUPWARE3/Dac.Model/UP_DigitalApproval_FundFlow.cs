namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_전자결재_자금흐름
/// </summary>
public class UP_DigitalApproval_FundFlow
{
	public const string SP_NAME = "UP_전자결재_자금흐름";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 문서코드
		/// </summary>
		[Description("문서코드")]
		public int DocumentCode { get; set; }
		/// <summary>
		/// 기안문서코드
		/// </summary>
		[Description("기안문서코드")]
		public int DraftDocumentCode { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 문서코드
		/// </summary>
		[Column("문서코드")]
		public int DocumentCode { get; set; }
		/// <summary>
		/// 스텝1
		/// </summary>
		[Column("스텝1")]
		public int Step1 { get; set; }
		/// <summary>
		/// 스텝2
		/// </summary>
		[Column("스텝2")]
		public string Step2 { get; set; }
		/// <summary>
		/// 문서유형
		/// </summary>
		[Column("문서유형")]
		public string DocumentType { get; set; }
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
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 기안자정보
		/// </summary>
		[Column("기안자정보")]
		public string DrafterInfo { get; set; }
		/// <summary>
		/// 양식번호
		/// </summary>
		[Column("양식번호")]
		public short FormNumber { get; set; }
		/// <summary>
		/// 결재진행
		/// </summary>
		[Column("결재진행")]
		public string ApprovalProgress { get; set; }
		/// <summary>
		/// 결재진행일
		/// </summary>
		[Column("결재진행일")]
		public DateTime ApprovalProgressDate { get; set; }
		/// <summary>
		/// 폼문서코드
		/// </summary>
		[Column("폼문서코드")]
		public int FormDocumentCode { get; set; }
		/// <summary>
		/// 총금액
		/// </summary>
		[Column("총금액")]
		public long TotalAmount { get; set; }
		/// <summary>
		/// 총기간1
		/// </summary>
		[Column("총기간1")]
		public string TotalPeriod1 { get; set; }
		/// <summary>
		/// 총기간2
		/// </summary>
		[Column("총기간2")]
		public string TotalPeriod2 { get; set; }
		/// <summary>
		/// 지출금액
		/// </summary>
		[Column("지출금액")]
		public long SpendingAmount { get; set; }
		/// <summary>
		/// 지출일
		/// </summary>
		[Column("지출일")]
		public string SpendingDate { get; set; }
		/// <summary>
		/// 세부기안_순서
		/// </summary>
		[Column("세부기안_순서")]
		public byte DetailDraft_Order { get; set; }
		/// <summary>
		/// 세부기안_기간1
		/// </summary>
		[Column("세부기안_기간1")]
		public string DetailDraft_Period1 { get; set; }
		/// <summary>
		/// 세부기안_기간2
		/// </summary>
		[Column("세부기안_기간2")]
		public string DetailDraft_Period2 { get; set; }
		/// <summary>
		/// 세부기안_금액
		/// </summary>
		[Column("세부기안_금액")]
		public long DetailDraft_Amount { get; set; }
		/// <summary>
		/// 세부기안_주기
		/// </summary>
		[Column("세부기안_주기")]
		public string DetailDraft_Cycle { get; set; }
		/// <summary>
		/// 세부기안_횟수
		/// </summary>
		[Column("세부기안_횟수")]
		public byte DetailDraft_Times { get; set; }
		/// <summary>
		/// 기간년월
		/// </summary>
		[Column("기간년월")]
		public string PeriodYearMonth { get; set; }
		/// <summary>
		/// 부서
		/// </summary>
		[Column("부서")]
		public int Department { get; set; }
		/// <summary>
		/// 예산항목
		/// </summary>
		[Column("예산항목")]
		public string BudgetItem { get; set; }
		/// <summary>
		/// 금액
		/// </summary>
		[Column("금액")]
		public long Amount { get; set; }
	}
}