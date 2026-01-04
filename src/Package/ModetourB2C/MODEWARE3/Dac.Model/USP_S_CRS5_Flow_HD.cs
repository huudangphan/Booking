namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_CRS5_경로_HD
/// </summary>
public class USP_S_CRS5_Flow_HD
{
	public const string SP_NAME = "USP_S_CRS5_경로_HD";

	public class Result : IDbResult
	{
		/// <summary>
		/// 경로코드
		/// </summary>
		[Column("경로코드")]
		public string RouteCode { get; set; }
		/// <summary>
		/// 경로명
		/// </summary>
		[Column("경로명")]
		public string RouteName { get; set; }
		/// <summary>
		/// 상위코드
		/// </summary>
		[Column("상위코드")]
		public string HighRankCode { get; set; }
		/// <summary>
		/// CHILD
		/// </summary>
		[Column("CHILD")]
		public int CHILD { get; set; }
		/// <summary>
		/// ID
		/// </summary>
		[Column("ID")]
		public string ID { get; set; }
		/// <summary>
		/// PARENTID
		/// </summary>
		[Column("PARENTID")]
		public string PARENTID { get; set; }
		/// <summary>
		/// 웹페이지번호
		/// </summary>
		[Column("웹페이지번호")]
		public int WebPageNumber { get; set; }
	}
}