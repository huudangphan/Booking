namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_BTMS_문의
/// </summary>
public class WSP_T_CMN_BTMS_Inquiry
{
	public const string SP_NAME = "WSP_T_CMN_BTMS_문의";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 문의번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("문의번호")]
		public int InquiryNumber { get; set; }
		/// <summary>
		/// 문의유형
		/// </summary>
		[Description("문의유형")]
		public string InquiryType { get; set; }
		/// <summary>
		/// 문의구분
		/// </summary>
		[Description("문의구분")]
		public string InquiryClassification { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Description("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 견적번호
		/// </summary>
		[Description("견적번호")]
		public int EstimateNumber { get; set; }
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
		/// 답변상태
		/// </summary>
		[Description("답변상태")]
		public string AnswerState { get; set; }
		/// <summary>
		/// 답변이메일
		/// </summary>
		[Description("답변이메일")]
		public string AnswerEmail { get; set; }
	}

}