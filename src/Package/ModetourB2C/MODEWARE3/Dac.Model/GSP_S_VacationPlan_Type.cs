namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_휴가계_종류
/// </summary>
public class GSP_S_VacationPlan_Type
{
	public const string SP_NAME = "GSP_S_휴가계_종류";

	public class Result : IDbResult
	{
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Column("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Column("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 사용가능최대일수
		/// </summary>
		[Column("사용가능최대일수")]
		public string UsePossibleMaximumDaysNumber { get; set; }
		/// <summary>
		/// 상태4
		/// </summary>
		[Column("상태4")]
		public string State4 { get; set; }
		/// <summary>
		/// 상태5
		/// </summary>
		[Column("상태5")]
		public string State5 { get; set; }
		/// <summary>
		/// 상태6
		/// </summary>
		[Column("상태6")]
		public string State6 { get; set; }
		/// <summary>
		/// 상태7
		/// </summary>
		[Column("상태7")]
		public string State7 { get; set; }
		/// <summary>
		/// 상태8
		/// </summary>
		[Column("상태8")]
		public string State8 { get; set; }
		/// <summary>
		/// 상태9
		/// </summary>
		[Column("상태9")]
		public string State9 { get; set; }
		/// <summary>
		/// 상태10
		/// </summary>
		[Column("상태10")]
		public string State10 { get; set; }
		/// <summary>
		/// 상태11
		/// </summary>
		[Column("상태11")]
		public string State11 { get; set; }
		/// <summary>
		/// 상태13
		/// </summary>
		[Column("상태13")]
		public string State13 { get; set; }
		/// <summary>
		/// 상태14
		/// </summary>
		[Column("상태14")]
		public string State14 { get; set; }
		/// <summary>
		/// 상태15
		/// </summary>
		[Column("상태15")]
		public string State15 { get; set; }
	}
}