namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// WSP_S_업무요청게시판_이력_검색
/// </summary>
public class WSP_S_DutyRequestNoticeboard_History_Search
{
	public const string SP_NAME = "WSP_S_업무요청게시판_이력_검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 업무요청번호
		/// </summary>
		[Description("업무요청번호")]
		public int WorkRequestNumber { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 작업구분
		/// </summary>
		[Description("작업구분")]
		public string WorkingClassification { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// MSG
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 100)]
		[Description("MSG")]
		public string MSG { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 업무요청번호
		/// </summary>
		[Column("업무요청번호")]
		public int WorkRequestNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 간략이력
		/// </summary>
		[Column("간략이력")]
		public string BriefHistory { get; set; }
		/// <summary>
		/// 대분류
		/// </summary>
		[Column("대분류")]
		public int MajorClassification { get; set; }
		/// <summary>
		/// 중분류
		/// </summary>
		[Column("중분류")]
		public int MiddleClassification { get; set; }
		/// <summary>
		/// 소분류
		/// </summary>
		[Column("소분류")]
		public int SubClassification { get; set; }
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
		/// 작성자PTID
		/// </summary>
		[Column("작성자PTID")]
		public int WritterPTID { get; set; }
		/// <summary>
		/// 작성자부서
		/// </summary>
		[Column("작성자부서")]
		public string WritterDepartment { get; set; }
		/// <summary>
		/// 작성자부서PTID
		/// </summary>
		[Column("작성자부서PTID")]
		public int WritterDepartment_PTID { get; set; }
		/// <summary>
		/// 요청자
		/// </summary>
		[Column("요청자")]
		public string Requester { get; set; }
		/// <summary>
		/// 요청자PTID
		/// </summary>
		[Column("요청자PTID")]
		public int Requester_PTID { get; set; }
		/// <summary>
		/// 요청자부서
		/// </summary>
		[Column("요청자부서")]
		public string RequesterDepartment { get; set; }
		/// <summary>
		/// 요청자부서PTID
		/// </summary>
		[Column("요청자부서PTID")]
		public int RequesterDepartment_PTID { get; set; }
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
		/// 게시판구분
		/// </summary>
		[Column("게시판구분")]
		public int NoticeboardClassification { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 업무요청번호
		/// </summary>
		[Column("업무요청번호")]
		public int WorkRequestNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 간략이력
		/// </summary>
		[Column("간략이력")]
		public string BriefHistory { get; set; }
		/// <summary>
		/// 진행상황
		/// </summary>
		[Column("진행상황")]
		public int ProgressSituation { get; set; }
		/// <summary>
		/// 시작예정일
		/// </summary>
		[Column("시작예정일")]
		public DateTime StartExpectationDate { get; set; }
		/// <summary>
		/// 완료예정일
		/// </summary>
		[Column("완료예정일")]
		public DateTime FinishExpectationDate { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 작성자PTID
		/// </summary>
		[Column("작성자PTID")]
		public int WritterPTID { get; set; }
		/// <summary>
		/// 작성자부서
		/// </summary>
		[Column("작성자부서")]
		public string WritterDepartment { get; set; }
		/// <summary>
		/// 작성자부서PTID
		/// </summary>
		[Column("작성자부서PTID")]
		public int WritterDepartment_PTID { get; set; }
		/// <summary>
		/// 담당자
		/// </summary>
		[Column("담당자")]
		public string Manager { get; set; }
		/// <summary>
		/// 담당자PTID
		/// </summary>
		[Column("담당자PTID")]
		public int Manager_PTID { get; set; }
		/// <summary>
		/// 담당자부서
		/// </summary>
		[Column("담당자부서")]
		public string ManagerDepartment { get; set; }
		/// <summary>
		/// 담당자부서PTID
		/// </summary>
		[Column("담당자부서PTID")]
		public int ManagerDepartment_PTID { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 업무요청번호
		/// </summary>
		[Column("업무요청번호")]
		public int WorkRequestNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 간략이력
		/// </summary>
		[Column("간략이력")]
		public string BriefHistory { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 작성자PTID
		/// </summary>
		[Column("작성자PTID")]
		public int WritterPTID { get; set; }
		/// <summary>
		/// 작성자부서
		/// </summary>
		[Column("작성자부서")]
		public string WritterDepartment { get; set; }
		/// <summary>
		/// 작성자부서PTID
		/// </summary>
		[Column("작성자부서PTID")]
		public int WritterDepartment_PTID { get; set; }
	}
}