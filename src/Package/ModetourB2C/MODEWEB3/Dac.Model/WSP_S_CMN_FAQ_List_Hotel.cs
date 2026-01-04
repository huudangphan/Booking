namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_FAQ_리스트_호텔
/// </summary>
public class WSP_S_CMN_FAQ_List_Hotel
{
	public const string SP_NAME = "WSP_S_CMN_FAQ_리스트_호텔";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 갯수
		/// </summary>
		[Description("갯수")]
		public short Number { get; set; }
	}

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
	}
}