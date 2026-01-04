namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_아이템_문의2
/// </summary>
public class WSP_S_Item_Inquiry2
{
	public const string SP_NAME = "WSP_S_아이템_문의2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
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
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
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
		/// 문의일련번호
		/// </summary>
		[Column("문의일련번호")]
		public int InquirySerialNumber { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// 등록자명
		/// </summary>
		[Column("등록자명")]
		public string RegistererName { get; set; }
		/// <summary>
		/// 공개여부
		/// </summary>
		[Column("공개여부")]
		public string ReleaseOrNot { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public string RegisterDate { get; set; }
		/// <summary>
		/// 답변여부
		/// </summary>
		[Column("답변여부")]
		public string AnswerOrNot { get; set; }
		/// <summary>
		/// 답변내용
		/// </summary>
		[Column("답변내용")]
		public string AnswerContent { get; set; }
		/// <summary>
		/// 답변자
		/// </summary>
		[Column("답변자")]
		public int Answerer { get; set; }
		/// <summary>
		/// 답변자명
		/// </summary>
		[Column("답변자명")]
		public string AnswererName { get; set; }
		/// <summary>
		/// 답변일
		/// </summary>
		[Column("답변일")]
		public string AnswerDate { get; set; }
		/// <summary>
		/// 등록자아이디
		/// </summary>
		[Column("등록자아이디")]
		public string RegistererID { get; set; }
	}
}