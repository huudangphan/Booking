namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_고객의소리_리스트
/// </summary>
public class UP_CustomerVoice_List
{
	public const string SP_NAME = "UP_고객의소리_리스트";

	public class Parameters : BaseDbParameters
	{
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
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 진행현황
		/// </summary>
		[Column("진행현황")]
		public string ProgressCurrentState { get; set; }
		/// <summary>
		/// 상품담당자정보
		/// </summary>
		[Column("상품담당자정보")]
		public string ProductManagerInfo { get; set; }
		/// <summary>
		/// 상품참조자정보
		/// </summary>
		[Column("상품참조자정보")]
		public string ProductReferrerInfo { get; set; }
		/// <summary>
		/// 영업담당자정보
		/// </summary>
		[Column("영업담당자정보")]
		public string BusinessManagerInfo { get; set; }
		/// <summary>
		/// 영업참조자정보
		/// </summary>
		[Column("영업참조자정보")]
		public string BusinessReferrerInfo { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 상품담당자지정일
		/// </summary>
		[Column("상품담당자지정일")]
		public DateTime ProductManagerAssignmentDate { get; set; }
		/// <summary>
		/// 영업담당자지정일
		/// </summary>
		[Column("영업담당자지정일")]
		public DateTime BusinessManagerAssignmentDate { get; set; }
		/// <summary>
		/// 처리완료일
		/// </summary>
		[Column("처리완료일")]
		public DateTime HandleFinishDate { get; set; }
	}
}