namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_여행사진공모전
/// </summary>
public class WSP_S_TravelImageExhibition
{
	public const string SP_NAME = "WSP_S_여행사진공모전";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 공모전횟수
		/// </summary>
		[Description("공모전횟수")]
		public short ExhibitionTimes { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 대륙pid
		/// </summary>
		[Description("대륙pid")]
		public int Continent_PID { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
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

	public class Result1 : IDbResult
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Column("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// 주제
		/// </summary>
		[Column("주제")]
		public string Topic { get; set; }
		/// <summary>
		/// 축소사진
		/// </summary>
		[Column("축소사진")]
		public string DownsizePicture { get; set; }
		/// <summary>
		/// 추천수
		/// </summary>
		[Column("추천수")]
		public int RecommendNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Column("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// 주제
		/// </summary>
		[Column("주제")]
		public string Topic { get; set; }
		/// <summary>
		/// 축소사진
		/// </summary>
		[Column("축소사진")]
		public string DownsizePicture { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 주제
		/// </summary>
		[Column("주제")]
		public string Topic { get; set; }
		/// <summary>
		/// 촬영지
		/// </summary>
		[Column("촬영지")]
		public string TakingPhotoPlace { get; set; }
		/// <summary>
		/// 대륙PID
		/// </summary>
		[Column("대륙PID")]
		public int Continent_PID { get; set; }
		/// <summary>
		/// 국가PID
		/// </summary>
		[Column("국가PID")]
		public int Country_PID { get; set; }
		/// <summary>
		/// 주PID
		/// </summary>
		[Column("주PID")]
		public int State_PID { get; set; }
		/// <summary>
		/// 도시PID
		/// </summary>
		[Column("도시PID")]
		public int City_PID { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 축소사진
		/// </summary>
		[Column("축소사진")]
		public string DownsizePicture { get; set; }
		/// <summary>
		/// 원본사진
		/// </summary>
		[Column("원본사진")]
		public string OriginalPicture { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 추천수
		/// </summary>
		[Column("추천수")]
		public int RecommendNumber { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Column("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
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
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Column("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 주제
		/// </summary>
		[Column("주제")]
		public string Topic { get; set; }
		/// <summary>
		/// 축소사진
		/// </summary>
		[Column("축소사진")]
		public string DownsizePicture { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 추천수
		/// </summary>
		[Column("추천수")]
		public string RecommendNumber { get; set; }
	}
}