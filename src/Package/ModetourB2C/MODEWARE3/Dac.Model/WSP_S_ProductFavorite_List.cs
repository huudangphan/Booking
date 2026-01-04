namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_상품찜_리스트
/// </summary>
public class WSP_S_ProductFavorite_List
{
	public const string SP_NAME = "WSP_S_상품찜_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
	}
}