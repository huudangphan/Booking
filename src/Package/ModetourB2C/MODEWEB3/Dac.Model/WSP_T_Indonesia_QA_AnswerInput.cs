namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_인도네시아_QA답변입력
/// </summary>
public class WSP_T_Indonesia_QA_AnswerInput
{
	public const string SP_NAME = "WSP_T_인도네시아_QA답변입력";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
	}

}