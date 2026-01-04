namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_웹지역_테마_메인리스트
/// </summary>
public class WSP_S_CMN_WebRegion_Theme_MainList
{
	public const string SP_NAME = "WSP_S_CMN_웹지역_테마_메인리스트";

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 웹지역_테마번호
		/// </summary>
		[Column("웹지역_테마번호")]
		public int WebRegion_ThemeNumber { get; set; }
		/// <summary>
		/// 항목번호
		/// </summary>
		[Column("항목번호")]
		public int ItemNumber { get; set; }
		/// <summary>
		/// 항목명
		/// </summary>
		[Column("항목명")]
		public string ItemName { get; set; }
		/// <summary>
		/// 항목구분
		/// </summary>
		[Column("항목구분")]
		public string ItemClassification { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 구역번호
		/// </summary>
		[Column("구역번호")]
		public int AreaNumber { get; set; }
		/// <summary>
		/// 웹구역명
		/// </summary>
		[Column("웹구역명")]
		public string WebAreaName { get; set; }
		/// <summary>
		/// 위치
		/// </summary>
		[Column("위치")]
		public string Position { get; set; }
	}
}