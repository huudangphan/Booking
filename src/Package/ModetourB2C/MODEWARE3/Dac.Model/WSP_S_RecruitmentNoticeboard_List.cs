namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_채용게시판_리스트
/// </summary>
public class WSP_S_RecruitmentNoticeboard_List
{
	public const string SP_NAME = "WSP_S_채용게시판_리스트";

	public class Parameters : BaseDbParameters
	{
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
		/// 년도
		/// </summary>
		[Description("년도")]
		public string Year { get; set; }
		/// <summary>
		/// 채용구분번호
		/// </summary>
		[Description("채용구분번호")]
		public string RecruitmentClassificationNumber { get; set; }
		/// <summary>
		/// 전체게시물갯수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체게시물갯수")]
		public int EntirePostNumber { get; set; }
		/// <summary>
		/// 전체페이지번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체페이지번호")]
		public int EntirePageNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 고용형태
		/// </summary>
		[Column("고용형태")]
		public string EmploymentFormat { get; set; }
		/// <summary>
		/// 공고일련번호
		/// </summary>
		[Column("공고일련번호")]
		public int AnnounceSerialNumber { get; set; }
		/// <summary>
		/// 채용공고명
		/// </summary>
		[Column("채용공고명")]
		public string RecruitAnnouncementName { get; set; }
		/// <summary>
		/// 지원시작일
		/// </summary>
		[Column("지원시작일")]
		public DateTime SupportStartDate { get; set; }
		/// <summary>
		/// 지원종료일
		/// </summary>
		[Column("지원종료일")]
		public DateTime SupportEndDate { get; set; }
		/// <summary>
		/// 지원종료일1
		/// </summary>
		[Column("지원종료일1")]
		public DateTime SupportEndDate1 { get; set; }
		/// <summary>
		/// 채용구분번호
		/// </summary>
		[Column("채용구분번호")]
		public int RecruitmentClassificationNumber { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
	}
}