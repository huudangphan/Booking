namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_상품QA_쪽지전송
/// </summary>
public class WSP_T_CMN_Product_QA_NoteSending
{
	public const string SP_NAME = "WSP_T_CMN_상품QA_쪽지전송";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 발신자
		/// </summary>
		[Description("발신자")]
		public int MailSender { get; set; }
		/// <summary>
		/// 발신자정보
		/// </summary>
		[Description("발신자정보")]
		public string MailSenderInfo { get; set; }
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
		/// 수신
		/// </summary>
		[Description("수신")]
		public string Reception { get; set; }
		/// <summary>
		/// 답변쪽지번호
		/// </summary>
		[Description("답변쪽지번호")]
		public int AnswerNoteNumber { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

}