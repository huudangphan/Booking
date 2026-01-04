namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_상품문의_질문유형저장
/// </summary>
public class WSP_S_ProductInquiry_QuestionTypeSaving
{
	public const string SP_NAME = "WSP_S_상품문의_질문유형저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 질문유형
		/// </summary>
		[Description("질문유형")]
		public string QuestionType { get; set; }
		/// <summary>
		/// 예약번호
		/// </summary>
		[Description("예약번호")]
		public string BookingNumber { get; set; }
	}

}