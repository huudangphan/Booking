namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// WSP_현재비용예산상태
/// </summary>
public class WSP_CurrentExpenseBudgetState
{
	public const string SP_NAME = "WSP_현재비용예산상태";

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
		/// 예산사용여부
		/// </summary>
		[Column("예산사용여부")]
		public string BudgetUseOrNot { get; set; }
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
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 예산항목코드
		/// </summary>
		[Column("예산항목코드")]
		public string BudgetItemCode { get; set; }
		/// <summary>
		/// 부서
		/// </summary>
		[Column("부서")]
		public int Department { get; set; }
		/// <summary>
		/// 부서예산
		/// </summary>
		[Column("부서예산")]
		public long DepartmentBudget { get; set; }
		/// <summary>
		/// 부서전결비율
		/// </summary>
		[Column("부서전결비율")]
		public decimal DepartmentTransferPercentage { get; set; }
		/// <summary>
		/// 부서전결예산
		/// </summary>
		[Column("부서전결예산")]
		public long DepartmentTransferBudget { get; set; }
		/// <summary>
		/// 부서기안액
		/// </summary>
		[Column("부서기안액")]
		public long DepartmentDraftAmount { get; set; }
		/// <summary>
		/// 부서누적기안액
		/// </summary>
		[Column("부서누적기안액")]
		public long DepartmentAccumulateDraftAmount { get; set; }
		/// <summary>
		/// 본부예산
		/// </summary>
		[Column("본부예산")]
		public long HeadofficeBudget { get; set; }
		/// <summary>
		/// 본부전결비율
		/// </summary>
		[Column("본부전결비율")]
		public decimal HeadofficeTransferPercentage { get; set; }
		/// <summary>
		/// 본부전결예산
		/// </summary>
		[Column("본부전결예산")]
		public long HeadofficeTransferBudget { get; set; }
		/// <summary>
		/// 본부누적기안액
		/// </summary>
		[Column("본부누적기안액")]
		public long HeadofficeAccumulateDraftAmount { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 지원예정액
		/// </summary>
		[Column("지원예정액")]
		public int SupportExpectationAmount { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 입금예정년월
		/// </summary>
		[Column("입금예정년월")]
		public string DepositExpectationYearMonth { get; set; }
	}
}