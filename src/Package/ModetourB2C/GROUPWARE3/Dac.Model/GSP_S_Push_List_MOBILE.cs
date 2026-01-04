namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// GSP_S_푸쉬_리스트_MOBILE
/// </summary>
public class GSP_S_Push_List_MOBILE
{
	public const string SP_NAME = "GSP_S_푸쉬_리스트_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 직원번호
		/// </summary>
		[Column("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
		/// <summary>
		/// 등록일자
		/// </summary>
		[Column("등록일자")]
		public string RegisterDate { get; set; }
		/// <summary>
		/// 등록일자포맷
		/// </summary>
		[Column("등록일자포맷")]
		public string RegisterDateFormat { get; set; }
		/// <summary>
		/// 대메뉴
		/// </summary>
		[Column("대메뉴")]
		public string MainMenu { get; set; }
		/// <summary>
		/// 중메뉴
		/// </summary>
		[Column("중메뉴")]
		public string MiddleMenu { get; set; }
		/// <summary>
		/// 소메뉴
		/// </summary>
		[Column("소메뉴")]
		public string SubMenu { get; set; }
		/// <summary>
		/// 게시판번호
		/// </summary>
		[Column("게시판번호")]
		public int NoticeboardNumber { get; set; }
		/// <summary>
		/// 휴가계번호
		/// </summary>
		[Column("휴가계번호")]
		public int VacationRequestDocumentNumber { get; set; }
		/// <summary>
		/// 전자결재번호
		/// </summary>
		[Column("전자결재번호")]
		public int DigitalApprovalNumber { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
	}
}