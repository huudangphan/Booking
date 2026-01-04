namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_상품QA_등록
/// </summary>
public class WSP_T_CMN_Product_QA_Registration
{
	public const string SP_NAME = "WSP_T_CMN_상품QA_등록";

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
		/// 답변
		/// </summary>
		[Description("답변")]
		public string Answer { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Description("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 오픈
		/// </summary>
		[Description("오픈")]
		public string Open { get; set; }
		/// <summary>
		/// 사용자오픈
		/// </summary>
		[Description("사용자오픈")]
		public string UserOpen { get; set; }
		/// <summary>
		/// 사이트
		/// </summary>
		[Description("사이트")]
		public string Site { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}
}