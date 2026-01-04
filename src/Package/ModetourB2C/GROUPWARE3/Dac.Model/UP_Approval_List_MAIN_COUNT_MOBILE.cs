namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_결재_리스트_MAIN_COUNT_MOBILE
/// </summary>
public class UP_Approval_List_MAIN_COUNT_MOBILE
{
	public const string SP_NAME = "UP_결재_리스트_MAIN_COUNT_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 검색기간1
		/// </summary>
		[Description("검색기간1")]
		public string SearchingPeriod1 { get; set; }
		/// <summary>
		/// 검색기간2
		/// </summary>
		[Description("검색기간2")]
		public string SearchingPeriod2 { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Cnt
		/// </summary>
		[Column("Cnt")]
		public int Cnt { get; set; }
	}
}