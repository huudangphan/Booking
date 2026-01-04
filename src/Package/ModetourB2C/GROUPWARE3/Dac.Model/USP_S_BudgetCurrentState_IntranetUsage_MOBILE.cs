namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// USP_S_예산현황_인트라넷용_MOBILE
/// </summary>
public class USP_S_BudgetCurrentState_IntranetUsage_MOBILE
{
	public const string SP_NAME = "USP_S_예산현황_인트라넷용_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 예산항목코드
		/// </summary>
		[Description("예산항목코드")]
		public string BudgetItemCode { get; set; }
		/// <summary>
		/// 년월
		/// </summary>
		[Description("년월")]
		public string YearMonth { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 부서번호
		/// </summary>
		[Column("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 기초예산
		/// </summary>
		[Column("기초예산")]
		public long BasicBudget { get; set; }
		/// <summary>
		/// 전결비율
		/// </summary>
		[Column("전결비율")]
		public decimal ArbitraryDecisionRatio { get; set; }
		/// <summary>
		/// 전결배정액
		/// </summary>
		[Column("전결배정액")]
		public long ArbitraryDecisionAssignedAmount { get; set; }
		/// <summary>
		/// 전결가능잔액
		/// </summary>
		[Column("전결가능잔액")]
		public long ArbitraryDecisionAbleRemainmingAmount { get; set; }
		/// <summary>
		/// 사용액
		/// </summary>
		[Column("사용액")]
		public long UsingAmount { get; set; }
	}
}