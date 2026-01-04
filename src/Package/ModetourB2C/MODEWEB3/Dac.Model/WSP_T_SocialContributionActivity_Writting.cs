namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_사회공헌활동_쓰기
/// </summary>
public class WSP_T_SocialContributionActivity_Writting
{
	public const string SP_NAME = "WSP_T_사회공헌활동_쓰기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 작업모드
		/// </summary>
		[Description("작업모드")]
		public string WorkingMode { get; set; }
		/// <summary>
		/// 리스트일련번호
		/// </summary>
		[Description("리스트일련번호")]
		public int ListSerialNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public int Classification { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Description("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Description("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Description("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 형식
		/// </summary>
		[Description("형식")]
		public string Format { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Description("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 대표영상
		/// </summary>
		[Description("대표영상")]
		public string RepresentativeVideo { get; set; }
		/// <summary>
		/// mloc
		/// </summary>
		[Description("mloc")]
		public int mloc { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Description("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 후원처
		/// </summary>
		[Description("후원처")]
		public string SupportPlace { get; set; }
		/// <summary>
		/// 후원내용
		/// </summary>
		[Description("후원내용")]
		public string SupportContent { get; set; }
		/// <summary>
		/// 후원일
		/// </summary>
		[Description("후원일")]
		public DateTime SupportDate { get; set; }
	}

	public class Result1 : IDbResult
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

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 결과코드
		/// </summary>
		[Column("결과코드")]
		public string ResultCode { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 결과코드
		/// </summary>
		[Column("결과코드")]
		public string ResultCode { get; set; }
	}
}