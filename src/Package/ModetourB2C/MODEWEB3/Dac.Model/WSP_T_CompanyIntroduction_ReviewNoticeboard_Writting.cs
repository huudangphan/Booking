namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_회사소개_후기게시판_쓰기
/// </summary>
public class WSP_T_CompanyIntroduction_ReviewNoticeboard_Writting
{
	public const string SP_NAME = "WSP_T_회사소개_후기게시판_쓰기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사용자구분
		/// </summary>
		[Description("사용자구분")]
		public string UserClassification { get; set; }
		/// <summary>
		/// 작업모드
		/// </summary>
		[Description("작업모드")]
		public string WorkingMode { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
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
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Description("아이피")]
		public string IP { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 결과코드
		/// </summary>
		[Column("결과코드")]
		public string ResultCode { get; set; }
		/// <summary>
		/// 결과메세지
		/// </summary>
		[Column("결과메세지")]
		public string ResultMessage { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public decimal SerialNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 결과코드
		/// </summary>
		[Column("결과코드")]
		public string ResultCode { get; set; }
		/// <summary>
		/// 결과메세지
		/// </summary>
		[Column("결과메세지")]
		public string ResultMessage { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 결과코드
		/// </summary>
		[Column("결과코드")]
		public string ResultCode { get; set; }
		/// <summary>
		/// 결과메세지
		/// </summary>
		[Column("결과메세지")]
		public string ResultMessage { get; set; }
		/// <summary>
		/// 참조일련번호
		/// </summary>
		[Column("참조일련번호")]
		public int ReferenceSerialNumber { get; set; }
	}
}