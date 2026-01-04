namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// WSP_S_업무요청게시판_분류_검색
/// </summary>
public class WSP_S_DutyRequestNoticeboard_Classification_Search
{
	public const string SP_NAME = "WSP_S_업무요청게시판_분류_검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 업무요청번호
		/// </summary>
		[Description("업무요청번호")]
		public int WorkRequestNumber { get; set; }
		/// <summary>
		/// 작업구분
		/// </summary>
		[Description("작업구분")]
		public string WorkingClassification { get; set; }
		/// <summary>
		/// 페이지
		/// </summary>
		[Description("페이지")]
		public int Page { get; set; }
		/// <summary>
		/// 게시글수
		/// </summary>
		[Description("게시글수")]
		public int PostNumber { get; set; }
		/// <summary>
		/// 게시판구분
		/// </summary>
		[Description("게시판구분")]
		public int NoticeboardClassification { get; set; }
		/// <summary>
		/// 소분류
		/// </summary>
		[Description("소분류")]
		public int SubClassification { get; set; }
		/// <summary>
		/// 검색구분
		/// </summary>
		[Description("검색구분")]
		public string SearchingClassification { get; set; }
		/// <summary>
		/// 검색값
		/// </summary>
		[Description("검색값")]
		public string SearchingValue { get; set; }
		/// <summary>
		/// 작성자PTID
		/// </summary>
		[Description("작성자PTID")]
		public int WritterPTID { get; set; }
		/// <summary>
		/// 검색시작일
		/// </summary>
		[Description("검색시작일")]
		public string SearchingStartDate { get; set; }
		/// <summary>
		/// 검색종료일
		/// </summary>
		[Description("검색종료일")]
		public string SearchingEndDate { get; set; }
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
		/// 검색건수
		/// </summary>
		[Column("검색건수")]
		public int SearchingNumberofcases { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// rownum
		/// </summary>
		[Column("rownum")]
		public long rownum { get; set; }
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
		/// 진행상황
		/// </summary>
		[Column("진행상황")]
		public int ProgressSituation { get; set; }
		/// <summary>
		/// 완료일
		/// </summary>
		[Column("완료일")]
		public DateTime FinishDate { get; set; }
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
		/// 담당자일련번호
		/// </summary>
		[Column("담당자일련번호")]
		public int ManagerSerialNumber { get; set; }
		/// <summary>
		/// 만족도
		/// </summary>
		[Column("만족도")]
		public int SatisfactionRate { get; set; }
		/// <summary>
		/// 메모수
		/// </summary>
		[Column("메모수")]
		public int MemoCount { get; set; }
		/// <summary>
		/// 업무파트
		/// </summary>
		[Column("업무파트")]
		public int WorkPart { get; set; }
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
		/// 진행상황
		/// </summary>
		[Column("진행상황")]
		public int ProgressSituation { get; set; }
		/// <summary>
		/// 완료일
		/// </summary>
		[Column("완료일")]
		public DateTime FinishDate { get; set; }
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
		/// 담당자일련번호
		/// </summary>
		[Column("담당자일련번호")]
		public int ManagerSerialNumber { get; set; }
		/// <summary>
		/// 만족도
		/// </summary>
		[Column("만족도")]
		public int SatisfactionRate { get; set; }
		/// <summary>
		/// 메모수
		/// </summary>
		[Column("메모수")]
		public int MemoCount { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// rownum
		/// </summary>
		[Column("rownum")]
		public long rownum { get; set; }
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
		/// 진행상황
		/// </summary>
		[Column("진행상황")]
		public int ProgressSituation { get; set; }
		/// <summary>
		/// 완료일
		/// </summary>
		[Column("완료일")]
		public DateTime FinishDate { get; set; }
		/// <summary>
		/// 담당자
		/// </summary>
		[Column("담당자")]
		public string Manager { get; set; }
		/// <summary>
		/// 담당자일련번호
		/// </summary>
		[Column("담당자일련번호")]
		public int ManagerSerialNumber { get; set; }
		/// <summary>
		/// 메모수
		/// </summary>
		[Column("메모수")]
		public int MemoCount { get; set; }
		/// <summary>
		/// 업무파트
		/// </summary>
		[Column("업무파트")]
		public int WorkPart { get; set; }
	}
}