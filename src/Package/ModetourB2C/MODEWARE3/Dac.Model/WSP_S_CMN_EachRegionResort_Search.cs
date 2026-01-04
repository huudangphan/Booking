namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_지역별리조트_검색
/// </summary>
public class WSP_S_CMN_EachRegionResort_Search
{
	public const string SP_NAME = "WSP_S_CMN_지역별리조트_검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// SITEID
		/// </summary>
		[Description("SITEID")]
		public int SITEID { get; set; }
		/// <summary>
		/// MLOC
		/// </summary>
		[Description("MLOC")]
		public string MLOC { get; set; }
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
		/// <summary>
		/// 현재페이지
		/// </summary>
		[Description("현재페이지")]
		public int CurrentPage { get; set; }
		/// <summary>
		/// 페이지당글개수
		/// </summary>
		[Description("페이지당글개수")]
		public int EachPageCharactersNumber { get; set; }
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
		/// <summary>
		/// 전체페이지수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체페이지수")]
		public int EntirePageNumber { get; set; }
	}

}