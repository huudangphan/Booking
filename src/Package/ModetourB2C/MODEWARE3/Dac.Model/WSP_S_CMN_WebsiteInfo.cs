namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_웹사이트정보
/// </summary>
public class WSP_S_CMN_WebsiteInfo
{
	public const string SP_NAME = "WSP_S_CMN_웹사이트정보";

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
		/// 비고1
		/// </summary>
		[Column("비고1")]
		public string Note1 { get; set; }
	}
}