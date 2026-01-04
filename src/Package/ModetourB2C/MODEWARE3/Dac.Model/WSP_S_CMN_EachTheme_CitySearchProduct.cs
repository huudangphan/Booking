namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_테마별_도시검색상품
/// </summary>
public class WSP_S_CMN_EachTheme_CitySearchProduct
{
	public const string SP_NAME = "WSP_S_CMN_테마별_도시검색상품";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 검색도시명
		/// </summary>
		[Description("검색도시명")]
		public string SearchingCityName { get; set; }
		/// <summary>
		/// 테마명
		/// </summary>
		[Description("테마명")]
		public string ThemeName { get; set; }
		/// <summary>
		/// 출발일1
		/// </summary>
		[Description("출발일1")]
		public string DepartureDate1 { get; set; }
		/// <summary>
		/// 출발일2
		/// </summary>
		[Description("출발일2")]
		public string DepartureDate2 { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Description("정렬")]
		public string Sorting { get; set; }
	}

}