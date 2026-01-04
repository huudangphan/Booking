namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// GSP_S_푸쉬_신규_리스트_MOBILE
/// </summary>
public class GSP_S_Push_New_List_MOBILE
{
	public const string SP_NAME = "GSP_S_푸쉬_신규_리스트_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// CNT
		/// </summary>
		[Column("CNT")]
		public int CNT { get; set; }
	}
}