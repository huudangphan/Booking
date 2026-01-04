namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_모두웹진_고객만족도조사_등록
/// </summary>
public class WSP_S_MODEWebzine_CustomerSatisfactionRateSurvey_Registration
{
	public const string SP_NAME = "WSP_S_모두웹진_고객만족도조사_등록";

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