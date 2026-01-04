namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_멘토링평가
/// </summary>
public class UP_MentoringEvaluate
{
	public const string SP_NAME = "UP_멘토링평가";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 평가리스트
		/// </summary>
		[Description("평가리스트")]
		public string EvaluationList { get; set; }
	}

}