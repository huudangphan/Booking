namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_일정표_여행경보_공지사항
/// </summary>
public class WSP_S_ScheduleTable_TravelWarning_Notifications
{
	public const string SP_NAME = "WSP_S_일정표_여행경보_공지사항";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// arr국가명
		/// </summary>
		[Description("arr국가명")]
		public string ARR_CountryName { get; set; }
		/// <summary>
		/// 페이지당글개수
		/// </summary>
		[Description("페이지당글개수")]
		public int EachPageCharactersNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public string WrittingDate { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[Column("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
		/// <summary>
		/// 전체페이지수
		/// </summary>
		[Column("전체페이지수")]
		public int EntirePageNumber { get; set; }
	}
}