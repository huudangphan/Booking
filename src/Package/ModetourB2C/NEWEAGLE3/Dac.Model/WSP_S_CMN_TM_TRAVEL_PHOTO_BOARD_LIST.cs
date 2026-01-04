namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_TRAVEL_PHOTO_BOARD_LIST
/// </summary>
public class WSP_S_CMN_TM_TRAVEL_PHOTO_BOARD_LIST
{
	public const string SP_NAME = "WSP_S_CMN_TM_TRAVEL_PHOTO_BOARD_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// ThemeCode
		/// </summary>
		[Description("ThemeCode")]
		public string ThemeCode { get; set; }
		/// <summary>
		/// ThemeUseFlag
		/// </summary>
		[Description("ThemeUseFlag")]
		public string ThemeUseFlag { get; set; }
		/// <summary>
		/// BoardUseFlag
		/// </summary>
		[Description("BoardUseFlag")]
		public string BoardUseFlag { get; set; }
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

	public class Result : IDbResult
	{
		/// <summary>
		/// idx
		/// </summary>
		[Column("idx")]
		public int idx { get; set; }
		/// <summary>
		/// ThemeCode
		/// </summary>
		[Column("ThemeCode")]
		public string ThemeCode { get; set; }
		/// <summary>
		/// Title
		/// </summary>
		[Column("Title")]
		public string Title { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Column("UseFlag")]
		public string UseFlag { get; set; }
		/// <summary>
		/// ImgList
		/// </summary>
		[Column("ImgList")]
		public string ImgList { get; set; }
	}
}