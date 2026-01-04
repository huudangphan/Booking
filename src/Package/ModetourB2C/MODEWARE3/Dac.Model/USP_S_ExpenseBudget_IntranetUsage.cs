namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_비용예산_인트라넷용
/// </summary>
public class USP_S_ExpenseBudget_IntranetUsage
{
	public const string SP_NAME = "USP_S_비용예산_인트라넷용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 년월
		/// </summary>
		[Description("년월")]
		public string YearMonth { get; set; }
		/// <summary>
		/// 계정분류
		/// </summary>
		[Description("계정분류")]
		public string AccountClassification { get; set; }
		/// <summary>
		/// 중분류
		/// </summary>
		[Description("중분류")]
		public string MiddleClassification { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 기안자번호
		/// </summary>
		[Description("기안자번호")]
		public int DrafterNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 본부예산
		/// </summary>
		[Column("본부예산")]
		public int HeadofficeBudget { get; set; }
		/// <summary>
		/// 본부사용액
		/// </summary>
		[Column("본부사용액")]
		public int HeadofficeUseAmount { get; set; }
		/// <summary>
		/// 본부전결가능액
		/// </summary>
		[Column("본부전결가능액")]
		public int HeadofficeTransferPossibleAmount { get; set; }
		/// <summary>
		/// 본부예산잔액
		/// </summary>
		[Column("본부예산잔액")]
		public int HeadofficeBudgetBalance { get; set; }
		/// <summary>
		/// 중분류
		/// </summary>
		[Column("중분류")]
		public string MiddleClassification { get; set; }
		/// <summary>
		/// 중분류코드
		/// </summary>
		[Column("중분류코드")]
		public string MiddleClassificationCode { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 부서예산
		/// </summary>
		[Column("부서예산")]
		public int DepartmentBudget { get; set; }
		/// <summary>
		/// 부서사용액
		/// </summary>
		[Column("부서사용액")]
		public int DepartmentUseAmount { get; set; }
		/// <summary>
		/// 부서전결가능액
		/// </summary>
		[Column("부서전결가능액")]
		public int DepartmentTransferPossibleAmount { get; set; }
		/// <summary>
		/// 부서예산잔액
		/// </summary>
		[Column("부서예산잔액")]
		public int DepartmentBudgetBalance { get; set; }
		/// <summary>
		/// 중분류
		/// </summary>
		[Column("중분류")]
		public string MiddleClassification { get; set; }
		/// <summary>
		/// 중분류코드
		/// </summary>
		[Column("중분류코드")]
		public string MiddleClassificationCode { get; set; }
	}
}