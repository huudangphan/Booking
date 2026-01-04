namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_BTMS_문의
/// </summary>
public class WSP_S_CMN_BTMS_Inquiry
{
	public const string SP_NAME = "WSP_S_CMN_BTMS_문의";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 문의번호
		/// </summary>
		[Description("문의번호")]
		public int InquiryNumber { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Description("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 페이지당글개수
		/// </summary>
		[Description("페이지당글개수")]
		public int EachPageCharactersNumber { get; set; }
		/// <summary>
		/// 페이지
		/// </summary>
		[Description("페이지")]
		public int Page { get; set; }
		/// <summary>
		/// 총게시글수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("총게시글수")]
		public int TotalPostCharactersNumber { get; set; }
		/// <summary>
		/// 전체페이지수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체페이지수")]
		public int EntirePageNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 문의번호
		/// </summary>
		[Column("문의번호")]
		public int InquiryNumber { get; set; }
		/// <summary>
		/// 문의유형
		/// </summary>
		[Column("문의유형")]
		public string InquiryType { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처직원일련번호
		/// </summary>
		[Column("거래처직원일련번호")]
		public int CustomerEmployeeSerialNumber { get; set; }
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
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 문의건수
		/// </summary>
		[Column("문의건수")]
		public int InquiryNumberOfCase { get; set; }
		/// <summary>
		/// 상위일련번호
		/// </summary>
		[Column("상위일련번호")]
		public int HighRankSerialNumber { get; set; }
		/// <summary>
		/// 답변이메일
		/// </summary>
		[Column("답변이메일")]
		public string AnswerEmail { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 세부번호
		/// </summary>
		[Column("세부번호")]
		public int DetailNumber { get; set; }
		/// <summary>
		/// 답변상태
		/// </summary>
		[Column("답변상태")]
		public string AnswerState { get; set; }
		/// <summary>
		/// ROWNUMBER
		/// </summary>
		[Column("ROWNUMBER")]
		public long ROWNUMBER { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 문의번호
		/// </summary>
		[Column("문의번호")]
		public int InquiryNumber { get; set; }
		/// <summary>
		/// 문의유형
		/// </summary>
		[Column("문의유형")]
		public string InquiryType { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처직원일련번호
		/// </summary>
		[Column("거래처직원일련번호")]
		public int CustomerEmployeeSerialNumber { get; set; }
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
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 문의건수
		/// </summary>
		[Column("문의건수")]
		public int InquiryNumberOfCase { get; set; }
		/// <summary>
		/// 상위일련번호
		/// </summary>
		[Column("상위일련번호")]
		public int HighRankSerialNumber { get; set; }
		/// <summary>
		/// 답변상태
		/// </summary>
		[Column("답변상태")]
		public string AnswerState { get; set; }
		/// <summary>
		/// 답변이메일
		/// </summary>
		[Column("답변이메일")]
		public string AnswerEmail { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 세부번호
		/// </summary>
		[Column("세부번호")]
		public int DetailNumber { get; set; }
	}
}