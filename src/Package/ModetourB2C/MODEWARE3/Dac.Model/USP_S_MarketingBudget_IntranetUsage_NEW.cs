namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_마케팅예산_인트라넷용_NEW
/// </summary>
public class USP_S_MarketingBudget_IntranetUsage_NEW
{
	public const string SP_NAME = "USP_S_마케팅예산_인트라넷용_NEW";

	public class Parameters : BaseDbParameters
	{
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
		/// <summary>
		/// 상위PTID
		/// </summary>
		[Description("상위PTID")]
		public int HighRank_PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 분류
		/// </summary>
		[Column("분류")]
		public string Classification { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification2 { get; set; }
		/// <summary>
		/// 예산금액
		/// </summary>
		[Column("예산금액")]
		public long BudgetAmount { get; set; }
		/// <summary>
		/// 집행금액
		/// </summary>
		[Column("집행금액")]
		public long ExecutionAmount { get; set; }
		/// <summary>
		/// 예산잔액
		/// </summary>
		[Column("예산잔액")]
		public long BudgetBalance { get; set; }
	}
}