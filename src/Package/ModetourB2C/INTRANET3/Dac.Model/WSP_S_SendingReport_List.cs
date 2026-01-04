namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_센딩보고_리스트
/// </summary>
public class WSP_S_SendingReport_List
{
	public const string SP_NAME = "WSP_S_센딩보고_리스트";

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
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 첨부파일
		/// </summary>
		[Column("첨부파일")]
		public string AttachFile { get; set; }
		/// <summary>
		/// 작성자명
		/// </summary>
		[Column("작성자명")]
		public string WritterName { get; set; }
		/// <summary>
		/// 수신자정보
		/// </summary>
		[Column("수신자정보")]
		public string ReceiverInfo { get; set; }
		/// <summary>
		/// 수신부서
		/// </summary>
		[Column("수신부서")]
		public string ReceptionDepartment { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 진행상황
		/// </summary>
		[Column("진행상황")]
		public string ProgressSituation { get; set; }
		/// <summary>
		/// 공지
		/// </summary>
		[Column("공지")]
		public bool Notification { get; set; }
		/// <summary>
		/// 메모수
		/// </summary>
		[Column("메모수")]
		public int MemoCount { get; set; }
		/// <summary>
		/// 예약번호
		/// </summary>
		[Column("예약번호")]
		public int BookingNumber { get; set; }
	}
}