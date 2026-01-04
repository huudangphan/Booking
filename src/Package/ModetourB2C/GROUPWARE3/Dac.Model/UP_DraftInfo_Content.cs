namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_기안정보_내용
/// </summary>
public class UP_DraftInfo_Content
{
	public const string SP_NAME = "UP_기안정보_내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 문서코드
		/// </summary>
		[Description("문서코드")]
		public int DocumentCode { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 기안문서코드
		/// </summary>
		[Column("기안문서코드")]
		public int DraftDocumentCode { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 문서번호
		/// </summary>
		[Column("문서번호")]
		public string DocumentNumber { get; set; }
		/// <summary>
		/// 기안자정보
		/// </summary>
		[Column("기안자정보")]
		public string DrafterInfo { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 총금액
		/// </summary>
		[Column("총금액")]
		public long TotalAmount { get; set; }
		/// <summary>
		/// 총기간1
		/// </summary>
		[Column("총기간1")]
		public DateTime TotalPeriod1 { get; set; }
		/// <summary>
		/// 총기간2
		/// </summary>
		[Column("총기간2")]
		public DateTime TotalPeriod2 { get; set; }
		/// <summary>
		/// 지출금액
		/// </summary>
		[Column("지출금액")]
		public long SpendingAmount { get; set; }
		/// <summary>
		/// 지출계정
		/// </summary>
		[Column("지출계정")]
		public string SpendingAccount { get; set; }
		/// <summary>
		/// 문서
		/// </summary>
		[Column("문서")]
		public string Document { get; set; }
		/// <summary>
		/// 비용전결부서
		/// </summary>
		[Column("비용전결부서")]
		public int ExpenseTransferDepartment { get; set; }
		/// <summary>
		/// 비용전결부서명
		/// </summary>
		[Column("비용전결부서명")]
		public string ExpenseTransferDepartmentName { get; set; }
		/// <summary>
		/// 예산본부
		/// </summary>
		[Column("예산본부")]
		public int BudgetHeadoffice { get; set; }
		/// <summary>
		/// 예산본부명
		/// </summary>
		[Column("예산본부명")]
		public string BudgetHeadofficeName { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public byte Order { get; set; }
		/// <summary>
		/// 기간1
		/// </summary>
		[Column("기간1")]
		public DateTime Period1 { get; set; }
		/// <summary>
		/// 기간2
		/// </summary>
		[Column("기간2")]
		public DateTime Period2 { get; set; }
		/// <summary>
		/// 금액
		/// </summary>
		[Column("금액")]
		public long Amount { get; set; }
		/// <summary>
		/// 주기
		/// </summary>
		[Column("주기")]
		public string Cycle { get; set; }
		/// <summary>
		/// 횟수
		/// </summary>
		[Column("횟수")]
		public byte Times { get; set; }
		/// <summary>
		/// 기간년월
		/// </summary>
		[Column("기간년월")]
		public string PeriodYearMonth { get; set; }
		/// <summary>
		/// 예산항목
		/// </summary>
		[Column("예산항목")]
		public string BudgetItem { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 부서
		/// </summary>
		[Column("부서")]
		public int Department { get; set; }
		/// <summary>
		/// 본부기초예산
		/// </summary>
		[Column("본부기초예산")]
		public long HeadofficeBasicBudget { get; set; }
		/// <summary>
		/// 본부전결가능잔액
		/// </summary>
		[Column("본부전결가능잔액")]
		public long HeadofficeTransferPossibleBalance { get; set; }
	}
}