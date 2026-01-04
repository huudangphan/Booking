namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_FAQ_리스트_항공
/// </summary>
public class WSP_S_CMN_FAQ_List_Flight
{
	public const string SP_NAME = "WSP_S_CMN_FAQ_리스트_항공";

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 구분명
		/// </summary>
		[Column("구분명")]
		public string ClassificationName { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 번호
		/// </summary>
		[Column("번호")]
		public long Number { get; set; }
	}
}