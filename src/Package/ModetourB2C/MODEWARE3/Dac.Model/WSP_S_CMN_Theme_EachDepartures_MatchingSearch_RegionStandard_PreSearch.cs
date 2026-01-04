namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_테마_출발지별_맞춤검색_지역기준_사전검색
/// </summary>
public class WSP_S_CMN_Theme_EachDepartures_MatchingSearch_RegionStandard_PreSearch
{
	public const string SP_NAME = "WSP_S_CMN_테마_출발지별_맞춤검색_지역기준_사전검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 검색도시명
		/// </summary>
		[Description("검색도시명")]
		public string SearchingCityName { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일수
		/// </summary>
		[Column("일수")]
		public byte DaysNumber { get; set; }
		/// <summary>
		/// 판매가_어른
		/// </summary>
		[Column("판매가_어른")]
		public long SellingPrice_Adult { get; set; }
		/// <summary>
		/// 단체지역_대분류코드
		/// </summary>
		[Column("단체지역_대분류코드")]
		public string GroupRegion_MajorClassificationCode { get; set; }
		/// <summary>
		/// 값
		/// </summary>
		[Column("값")]
		public int Value { get; set; }
	}
}