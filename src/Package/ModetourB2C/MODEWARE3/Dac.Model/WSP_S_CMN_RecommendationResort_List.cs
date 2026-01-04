namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_추천리조트_리스트
/// </summary>
public class WSP_S_CMN_RecommendationResort_List
{
	public const string SP_NAME = "WSP_S_CMN_추천리조트_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Description("지역")]
		public string Region { get; set; }
	}

}