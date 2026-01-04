namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_여행후기_등록
/// </summary>
public class WSP_T_TravelReview_Registration
{
	public const string SP_NAME = "WSP_T_여행후기_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 작업구분
		/// </summary>
		[Description("작업구분")]
		public string WorkingClassification { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 글쓴이
		/// </summary>
		[Description("글쓴이")]
		public string Writer { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Description("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 일정타입
		/// </summary>
		[Description("일정타입")]
		public string ScheduleType { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Description("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// MLoc
		/// </summary>
		[Description("MLoc")]
		public string MLoc { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 만족도
		/// </summary>
		[Description("만족도")]
		public string SatisfactionRate { get; set; }
		/// <summary>
		/// 오픈
		/// </summary>
		[Description("오픈")]
		public string Open { get; set; }
		/// <summary>
		/// 추천
		/// </summary>
		[Description("추천")]
		public int Recommend { get; set; }
		/// <summary>
		/// 사진
		/// </summary>
		[Description("사진")]
		public string Picture { get; set; }
		/// <summary>
		/// 사이트
		/// </summary>
		[Description("사이트")]
		public string Site { get; set; }
		/// <summary>
		/// 핸드폰
		/// </summary>
		[Description("핸드폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이벤트
		/// </summary>
		[Description("이벤트")]
		public string Event { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

}