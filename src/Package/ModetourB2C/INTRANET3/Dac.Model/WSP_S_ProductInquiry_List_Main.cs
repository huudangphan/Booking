namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_상품문의_리스트_메인
/// </summary>
public class WSP_S_ProductInquiry_List_Main
{
	public const string SP_NAME = "WSP_S_상품문의_리스트_메인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 리스트갯수
		/// </summary>
		[Description("리스트갯수")]
		public int ListNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 질문유형
		/// </summary>
		[Column("질문유형")]
		public string QuestionType { get; set; }
		/// <summary>
		/// 사용자오픈
		/// </summary>
		[Column("사용자오픈")]
		public string UserOpen { get; set; }
		/// <summary>
		/// 답변
		/// </summary>
		[Column("답변")]
		public bool Answer { get; set; }
	}
}