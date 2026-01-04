namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_사이트별메뉴경로
/// </summary>
public class WSP_S_EachSiteMenuFlow
{
	public const string SP_NAME = "WSP_S_사이트별메뉴경로";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// MLOC
		/// </summary>
		[Description("MLOC")]
		public string MLOC { get; set; }
		/// <summary>
		/// GUBUN
		/// </summary>
		[Description("GUBUN")]
		public string GUBUN { get; set; }
		/// <summary>
		/// 제휴여부
		/// </summary>
		[Description("제휴여부")]
		public string AffiliateOrNot { get; set; }
	}

}