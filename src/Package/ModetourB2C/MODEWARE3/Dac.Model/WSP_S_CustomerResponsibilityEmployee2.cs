namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_거래처담당직원2
/// </summary>
public class WSP_S_CustomerResponsibilityEmployee2
{
	public const string SP_NAME = "WSP_S_거래처담당직원2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
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