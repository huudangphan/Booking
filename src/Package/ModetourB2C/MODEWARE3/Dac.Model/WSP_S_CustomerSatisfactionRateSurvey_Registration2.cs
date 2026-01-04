namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_고객만족도조사_등록2
/// </summary>
public class WSP_S_CustomerSatisfactionRateSurvey_Registration2
{
	public const string SP_NAME = "WSP_S_고객만족도조사_등록2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 설문지번호
		/// </summary>
		[Description("설문지번호")]
		public int SurveyorNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 등록IP
		/// </summary>
		[Description("등록IP")]
		public string RegisterIP { get; set; }
		/// <summary>
		/// 설문데이터
		/// </summary>
		[Description("설문데이터")]
		public string SurveyData { get; set; }
	}

}