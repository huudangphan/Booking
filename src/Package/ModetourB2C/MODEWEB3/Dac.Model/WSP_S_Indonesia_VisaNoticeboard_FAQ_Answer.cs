namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_인도네시아_비자게시판FAQ답변
/// </summary>
public class WSP_S_Indonesia_VisaNoticeboard_FAQ_Answer
{
	public const string SP_NAME = "WSP_S_인도네시아_비자게시판FAQ답변";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 언어구분
		/// </summary>
		[Description("언어구분")]
		public string LanguageClassification { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
	}
}