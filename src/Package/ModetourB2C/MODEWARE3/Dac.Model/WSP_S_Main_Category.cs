namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_메인_카테고리
/// </summary>
public class WSP_S_Main_Category
{
	public const string SP_NAME = "WSP_S_메인_카테고리";

	public class Result : IDbResult
	{
		/// <summary>
		/// 웹지역번호1
		/// </summary>
		[Column("웹지역번호1")]
		public int WebRegionNumber1 { get; set; }
		/// <summary>
		/// 웹지역이름1
		/// </summary>
		[Column("웹지역이름1")]
		public string WebRegionName1 { get; set; }
		/// <summary>
		/// 웹지역번호2
		/// </summary>
		[Column("웹지역번호2")]
		public int WebRegionNumber2 { get; set; }
		/// <summary>
		/// 웹지역이름2
		/// </summary>
		[Column("웹지역이름2")]
		public string WebRegionName2 { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// 도시명_한글
		/// </summary>
		[Column("도시명_한글")]
		public string CityName_Korean { get; set; }
		/// <summary>
		/// 웹지역정렬1
		/// </summary>
		[Column("웹지역정렬1")]
		public int WebRegionSorting1 { get; set; }
		/// <summary>
		/// 웹지역정렬2
		/// </summary>
		[Column("웹지역정렬2")]
		public int WebRegionSorting2 { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 테마번호
		/// </summary>
		[Column("테마번호")]
		public int ThemeNumber { get; set; }
	}
}