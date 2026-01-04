namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_휴가_개인연차현황_MOBILE
/// </summary>
public class GSP_S_Vacation_PersonalYearlyCurrentState_MOBILE
{
	public const string SP_NAME = "GSP_S_휴가_개인연차현황_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 년도
		/// </summary>
		[Description("년도")]
		public string Year { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 년도
		/// </summary>
		[Column("년도")]
		public string Year { get; set; }
		/// <summary>
		/// 총연차
		/// </summary>
		[Column("총연차")]
		public decimal TotalYearly { get; set; }
		/// <summary>
		/// 사용연차
		/// </summary>
		[Column("사용연차")]
		public decimal UseYearly { get; set; }
		/// <summary>
		/// 잔여연차
		/// </summary>
		[Column("잔여연차")]
		public decimal BalanceYearly { get; set; }
		/// <summary>
		/// 총월차
		/// </summary>
		[Column("총월차")]
		public decimal TotalMonthly { get; set; }
		/// <summary>
		/// 사용월차
		/// </summary>
		[Column("사용월차")]
		public decimal UseMonthly { get; set; }
		/// <summary>
		/// 잔여월차
		/// </summary>
		[Column("잔여월차")]
		public decimal BalanceMonthly { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 입사일자
		/// </summary>
		[Column("입사일자")]
		public string CompanyJoiningDate { get; set; }
	}
}