namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_상품찜_저장
/// </summary>
public class WSP_T_ProductFavorite_Saving
{
	public const string SP_NAME = "WSP_T_상품찜_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public string GroupNumber { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
	}

}