namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_웹지역_상품리스트_첫번째지역하위선택
/// </summary>
public class WSP_S_CMN_WebRegion_ProductList_FirstRegionSubSelect
{
	public const string SP_NAME = "WSP_S_CMN_웹지역_상품리스트_첫번째지역하위선택";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 출발월
		/// </summary>
		[Description("출발월")]
		public string DepartureMonth { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Description("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Description("종료일")]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 웹지역번호
		/// </summary>
		[Description("웹지역번호")]
		public string WebRegionNumber { get; set; }
		/// <summary>
		/// 웹테마번호
		/// </summary>
		[Description("웹테마번호")]
		public string WebThemeNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 전체단체수
		/// </summary>
		[Column("전체단체수")]
		public int AllNumberOfGroups { get; set; }
	}
}