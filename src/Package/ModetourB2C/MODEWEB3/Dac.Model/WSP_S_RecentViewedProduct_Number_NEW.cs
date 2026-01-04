namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_최근본상품_갯수_NEW
/// </summary>
public class WSP_S_RecentViewedProduct_Number_NEW
{
	public const string SP_NAME = "WSP_S_최근본상품_갯수_NEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 유저ID
		/// </summary>
		[Description("유저ID")]
		public string User_ID { get; set; }
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

	public class Result1 : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
		/// <summary>
		/// 갯수
		/// </summary>
		[Column("갯수")]
		public int Number { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public int SORT { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
		/// <summary>
		/// Column2
		/// </summary>
		[Column("Column2")]
		public int Column2 { get; set; }
		/// <summary>
		/// Column3
		/// </summary>
		[Column("Column3")]
		public int Column3 { get; set; }
	}
}