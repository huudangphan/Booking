namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_고객만족도조사
/// </summary>
public class WSP_T_CustomerSatisfactionSurvey
{
	public const string SP_NAME = "WSP_T_고객만족도조사";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Description("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Description("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 객관식질문1
		/// </summary>
		[Description("객관식질문1")]
		public string MultipleChoiceQuestion1 { get; set; }
		/// <summary>
		/// 객관식질문2
		/// </summary>
		[Description("객관식질문2")]
		public string MultipleChoiceQuestion2 { get; set; }
		/// <summary>
		/// 객관식질문3
		/// </summary>
		[Description("객관식질문3")]
		public string MultipleChoiceQuestion3 { get; set; }
		/// <summary>
		/// 객관식질문4
		/// </summary>
		[Description("객관식질문4")]
		public string MultipleChoiceQuestion4 { get; set; }
		/// <summary>
		/// 객관식질문5
		/// </summary>
		[Description("객관식질문5")]
		public string MultipleChoiceQuestion5 { get; set; }
		/// <summary>
		/// 객관식질문6
		/// </summary>
		[Description("객관식질문6")]
		public string MultipleChoiceQuestion6 { get; set; }
		/// <summary>
		/// 객관식질문7
		/// </summary>
		[Description("객관식질문7")]
		public string MultipleChoiceQuestion7 { get; set; }
		/// <summary>
		/// 객관식질문8
		/// </summary>
		[Description("객관식질문8")]
		public string MultipleChoiceQuestion8 { get; set; }
		/// <summary>
		/// 객관식질문9
		/// </summary>
		[Description("객관식질문9")]
		public string MultipleChoiceQuestion9 { get; set; }
		/// <summary>
		/// 주관식질문1
		/// </summary>
		[Description("주관식질문1")]
		public string ShortAnswerQuestion1 { get; set; }
		/// <summary>
		/// 등록IP
		/// </summary>
		[Description("등록IP")]
		public string RegisterIP { get; set; }
	}

}