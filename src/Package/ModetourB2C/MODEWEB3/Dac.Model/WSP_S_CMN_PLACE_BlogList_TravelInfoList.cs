namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_PLACE_블로그리스트_여행정보리스트
/// </summary>
public class WSP_S_CMN_PLACE_BlogList_TravelInfoList
{
	public const string SP_NAME = "WSP_S_CMN_PLACE_블로그리스트_여행정보리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public int PLID { get; set; }
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
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
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
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 주소
		/// </summary>
		[Column("주소")]
		public string Address { get; set; }
		/// <summary>
		/// 블로그명
		/// </summary>
		[Column("블로그명")]
		public string BlogName { get; set; }
		/// <summary>
		/// 최소PLID
		/// </summary>
		[Column("최소PLID")]
		public int Minimum_PLID { get; set; }
		/// <summary>
		/// 블로그주소
		/// </summary>
		[Column("블로그주소")]
		public string BlogAddress { get; set; }
		/// <summary>
		/// 동의일
		/// </summary>
		[Column("동의일")]
		public DateTime AgreeDate { get; set; }
	}
}