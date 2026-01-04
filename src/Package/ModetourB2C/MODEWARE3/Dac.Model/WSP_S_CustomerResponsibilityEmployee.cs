namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_거래처담당직원
/// </summary>
public class WSP_S_CustomerResponsibilityEmployee
{
	public const string SP_NAME = "WSP_S_거래처담당직원";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Description("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// PTID2
		/// </summary>
		[Column("PTID2")]
		public int PTID2 { get; set; }
	}
}