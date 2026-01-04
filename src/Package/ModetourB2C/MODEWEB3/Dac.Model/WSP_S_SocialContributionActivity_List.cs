namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_사회공헌활동_리스트
/// </summary>
public class WSP_S_SocialContributionActivity_List
{
	public const string SP_NAME = "WSP_S_사회공헌활동_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public int Classification { get; set; }
		/// <summary>
		/// 원하는게시물갯수
		/// </summary>
		[Description("원하는게시물갯수")]
		public int DesiredPostNumber { get; set; }
		/// <summary>
		/// 페이지번호
		/// </summary>
		[Description("페이지번호")]
		public int PageNumber { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 전체게시물갯수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체게시물갯수")]
		public int EntirePostNumber { get; set; }
		/// <summary>
		/// 일반글게시물갯수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("일반글게시물갯수")]
		public int NormalWrittingPostNumber { get; set; }
		/// <summary>
		/// 전체페이지번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체페이지번호")]
		public int EntirePageNumber { get; set; }
		/// <summary>
		/// 해당페이지번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("해당페이지번호")]
		public int ThisPageNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public int Classification { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
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
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 형식
		/// </summary>
		[Column("형식")]
		public int Format { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// mloc
		/// </summary>
		[Column("mloc")]
		public int mloc { get; set; }
		/// <summary>
		/// 후원처
		/// </summary>
		[Column("후원처")]
		public string SupportPlace { get; set; }
		/// <summary>
		/// 후원내용
		/// </summary>
		[Column("후원내용")]
		public string SupportContent { get; set; }
		/// <summary>
		/// 후원일
		/// </summary>
		[Column("후원일")]
		public DateTime SupportDate { get; set; }
		/// <summary>
		/// 대표영상
		/// </summary>
		[Column("대표영상")]
		public string RepresentativeVideo { get; set; }
	}
}